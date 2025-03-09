using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace FlowTimer
{
    // TODO New shared base between Metronome and FixedInterval, tons of shared code that should be cut out. For now, quick solution.
    public class MetronomeTimer : BaseTimer
    {
        public Button ButtonAdd;
        public Button ButtonLoadTimers;
        public Button ButtonSaveTimers;

        public List<Metronome> Metronomes;
        public Metronome SelectedMetronome;

        public MetronomeTimer(TabPage tab, params Control[] copyControls) :
            base(tab, (start) => Math.Max((FlowTimer.MaxOffset - (Win32.GetTime() - start)) / 1000.0, 0.0), copyControls)
        {
            ButtonAdd = FlowTimer.MainForm.ButtonAdd;
            ButtonLoadTimers = FlowTimer.MainForm.ButtonLoadTimers;
            ButtonSaveTimers = FlowTimer.MainForm.ButtonSaveTimers;

            Metronomes = new List<Metronome>();
        }

        public override void OnInit()
        {
            if (FlowTimer.Settings.LastLoadedMetronomes != null)
            {
                LoadTimers(FlowTimer.Settings.LastLoadedMetronomes, false);
            }
            else
            {
                AddTimer();
            }
        }

        public override void OnLoad()
        {
            base.OnLoad();
            RepositionAddButton();
            SelectMetronome(SelectedMetronome);
        }

        public override void OnTimerStart()
        {
            FlowTimer.AudioContext.QueueAudio(FlowTimer.PCM);

            SelectedMetronome.GetTimerInfo(out MetronomeInfo timerInfo);
            FlowTimer.MaxOffset = timerInfo.MaxOffset;
        }

        public override void OnVisualTimerStart()
        {
            EnableControls(false);
        }

        public override void OnTimerStop()
        {
            SelectMetronome(SelectedMetronome);
            EnableControls(true);
        }

        public override void OnKeyEvent(Keys key)
        {
            if (FlowTimer.Settings.Up.IsPressed(key))
            {
                MoveSelectedTimerIndex(-1);
            }
            else if (FlowTimer.Settings.Down.IsPressed(key))
            {
                MoveSelectedTimerIndex(+1);
            }
        }

        public override void OnBeepSoundChange()
        {
            SelectMetronome(SelectedMetronome);
        }

        public override void OnBeepVolumeChange()
        {
            SelectMetronome(SelectedMetronome);
        }

        public void RepositionAddButton()
        {
            ButtonAdd.SetBounds(Metronome.X, Metronome.Y + Metronome.Size * Metronomes.Count - 2, ButtonAdd.Bounds.Width, ButtonAdd.Bounds.Height);
            FlowTimer.ResizeForm(FlowTimer.MainForm.Width, FlowTimer.MainFormBaseHeight + Math.Max(Metronomes.Count - 5, 0) * Metronome.Size);
        }

        public void EnableControls(bool enabled)
        {
            // TODO: Replace instances of Timer here with Metronome
            foreach (Metronome timer in Metronomes)
            {
                Control[] excluded = { timer.RadioButton };
                timer.Controls.Except(excluded).ToList().ForEach(control => control.Enabled = enabled);
            }

            ButtonAdd.Enabled = enabled;
            ButtonLoadTimers.Enabled = enabled;
            ButtonSaveTimers.Enabled = enabled;
        }

        // TODO Rename instances of Metronome called "timer" to "metronome" for consistency
        public void AddTimer()
        {
            AddTimer(new Metronome(Metronomes.Count));
        }

        public void AddTimer(Metronome timer)
        {
            Metronomes.Add(timer);

            foreach (Control control in timer.Controls)
            {
                Tab.Controls.Add(control);
                control.RemoveKeyControls();
            }

            Metronomes[0].RemoveButton.Visible = Metronomes.Count > 1;
            RepositionAddButton();
            SelectMetronome(timer);
        }

        public void RemoveTimer(Metronome timer)
        {
            int timerIndex = Metronomes.IndexOf(timer);
            timer.Controls.ForEach(Tab.Controls.Remove);
            Metronomes.Remove(timer);

            for (int i = timerIndex; i < Metronomes.Count; i++)
            {
                Metronomes[i].Index = Metronomes[i].Index - 1;
            }

            Metronomes[0].RemoveButton.Visible = Metronomes.Count > 1;
            RepositionAddButton();
            if (SelectedMetronome == timer) SelectMetronome(Metronomes[0]);
        }

        public void ClearAllTimers()
        {
            for (int i = 0; i < Metronomes.Count; i++)
            {
                Metronomes[i].Controls.ForEach(Tab.Controls.Remove);
            }

            Metronomes.Clear();
            RepositionAddButton();
        }

        public void SelectMetronome(Metronome timer)
        {
            if (!Selected || timer == null) return;

            SelectedMetronome = timer;
            timer.RadioButton.Checked = true;

            MetronomeInfo timerInfo;
            TimerError error = SelectedMetronome.GetTimerInfo(out timerInfo);

            List<Control> controls = new List<Control>() { FlowTimer.MainForm.ButtonStart, FlowTimer.MainForm.ButtonStop };

            if (error == TimerError.NoError)
            {
                // TODO Update PCM and AudioContext logic to allow for multiple beep types
                FlowTimer.UpdatePCM(Array.ConvertAll(timerInfo.Offsets, x => (double)x), timerInfo.Interval, timerInfo.NumBeeps);
                if (!FlowTimer.IsTimerRunning) FlowTimer.MainForm.LabelTimer.Text = (timerInfo.MaxOffset / 1000.0).ToFormattedString();
                controls.ForEach(control => control.Enabled = true);
            }
            else
            {
                FlowTimer.MainForm.LabelTimer.Text = "Error";
                controls.ForEach(control => control.Enabled = false);
            }
        }

        public void MoveSelectedTimerIndex(int amount)
        {
            if (SelectedMetronome == null || Metronomes.Count == 0 || !Selected)
            {
                return;
            }

            int selectedTimerIndex = Metronomes.IndexOf(SelectedMetronome);
            selectedTimerIndex = (((selectedTimerIndex + amount) % Metronomes.Count) + Metronomes.Count) % Metronomes.Count;
            SelectMetronome(Metronomes[selectedTimerIndex]);
        }

        public void OpenLoadTimersDialog()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = FlowTimer.TimerFileFilter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                LoadTimers(dialog.FileName, true);
            }
        }

        public JsonMetronomesFile ReadTimers(string filePath)
        {
            var json = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(filePath));
            return json.GetType() == typeof(JArray) ? ReadJsonTimersLegacy((JArray)json) : ReadJsonTimersModern((JObject)json);
        }

        private JsonMetronomesFile ReadJsonTimersLegacy(JArray json)
        {
            return new JsonMetronomesFile(new JsonMetronomesHeader(), json.ToObject<List<JsonMetronome>>());
        }

        private JsonMetronomesFile ReadJsonTimersModern(JObject json)
        {
            return json.ToObject<JsonMetronomesFile>();
        }

        public bool LoadTimers(string filePath, bool displayMessages = true)
        {
            JsonMetronomesFile file = ReadTimers(filePath);

            if (file.Timers.Count == 0)
            {
                if (displayMessages)
                {
                    MessageBox.Show("Timers could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }

            ClearAllTimers();

            for (int i = 0; i < file.Timers.Count; i++)
            {
                JsonMetronome timer = file[i];
                AddTimer(new Metronome(i, timer.Name, timer.Offsets, timer.BPM, timer.BeatsPerBar, timer.TotalFullBars));
            }

            if (displayMessages)
            {
                MessageBox.Show("Metronomes successfully loaded from '" + filePath + "'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FlowTimer.Settings.LastLoadedMetronomes = filePath;
            return true;
        }

        public void OpenSaveTimersDialog()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = FlowTimer.TimerFileFilter;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                SaveTimers(dialog.FileName, true);
            }
        }

        public JsonMetronomesFile BuildJsonMetronomeFile()
        {
            return new JsonMetronomesFile(new JsonMetronomesHeader(), Metronomes.ConvertAll(timer => new JsonMetronome()
            {
                Name = timer.TextBoxName.Text,
                Offsets = timer.TextBoxOffset.Text,
                BPM = timer.TextBoxBPM.Text,
                BeatsPerBar = timer.TextBoxBeatsPerBar.Text,
                TotalFullBars = timer.TextBoxTotalBars.Text
            }));
        }

        public bool SaveTimers(string filePath, bool displayMessages = true)
        {
            JsonMetronomesFile timerFile = BuildJsonMetronomeFile();

            try
            {
                File.WriteAllText(filePath, JsonConvert.SerializeObject(timerFile));

                if (displayMessages)
                {
                    MessageBox.Show("Timers successfully saved to '" + filePath + "'.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                FlowTimer.Settings.LastLoadedMetronomes = filePath;

                return true;
            }
            catch (Exception ex)
            {
                if (displayMessages)
                {
                    MessageBox.Show("Timers could not be saved. Exception: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                return false;
            }
        }

        public bool HaveTimersChanged()
        {
            if (FlowTimer.Settings.LastLoadedMetronomes == null)
            {
                return false;
            }

            if (!File.Exists(FlowTimer.Settings.LastLoadedMetronomes))
            {
                return false;
            }

            JsonMetronomesFile oldTimers = ReadTimers(FlowTimer.Settings.LastLoadedMetronomes);
            JsonMetronomesFile newTimers = BuildJsonMetronomeFile();

            if (oldTimers.Timers.Count != newTimers.Timers.Count)
            {
                return true;
            }

            for (int i = 0; i < oldTimers.Timers.Count; i++)
            {
                JsonMetronome timer1 = oldTimers[i];
                JsonMetronome timer2 = newTimers[i];
                if (timer1.Name != timer2.Name ||
                   timer1.Offsets != timer2.Offsets ||
                   timer1.BPM != timer2.BPM ||
                   timer1.BeatsPerBar != timer2.BeatsPerBar ||
                   timer1.TotalFullBars != timer2.TotalFullBars)
                {
                    return true;
                }
            }

            return false;
        }
    }

    // TODO Should be in own file, best practice = 1 class per file
    // TODO Move such models into a model folder, the added layer will help with separation
    // TODO Everything is public in this app. Sort it.
    public class MetronomeInfo
    {
        // TODO, this model can be shared, transformation of the relevant data (for now) can be done in the main model below, so move, rename, and share
        public uint[] Offsets;
        public uint MaxOffset;
        public uint Interval;
        public uint NumBeeps;
    }

    public class Metronome
    {
        public const int X = 165;
        public const int Y = 31;
        public const int Size = 28;

        public TextBox TextBoxName;
        public TextBox TextBoxOffset;
        public TextBox TextBoxBPM;
        // TODO Change to dropdown with 3/4 and 4/4 time signatures instead of free text field
        public TextBox TextBoxBeatsPerBar;
        public TextBox TextBoxTotalBars;

        public RadioButton RadioButton;
        public Button RemoveButton;
        public List<Control> Controls;

        public List<TextBox> TextBoxes
        {
            get { return Controls.FindAll(control => control.GetType() == typeof(TextBox)).ConvertAll(control => (TextBox)control); }
        }

        public int Index
        {
            get
            {
                return (TextBoxes[0].Location.Y - Y) / Size;
            }

            set
            {
                int yPosition = Y + value * Size;
                int xOffset = 0;

                for (int i = 0; i < TextBoxes.Count; i++)
                {
                    TextBoxes[i].SetBounds(X + xOffset, yPosition, 65, 21);
                    xOffset += TextBoxes[i].Width + 5;
                }

                RadioButton.SetBounds(X - 21, yPosition + 4, 14, 13);

                Rectangle lastBox = TextBoxes.Last().Bounds;
                RemoveButton.SetBounds(lastBox.X + lastBox.Width + 5, lastBox.Y, 38, 21);
            }
        }

        public Metronome(int index, string name = "Metronome", string offset = "5000", string bpm = "200", string beats = "4", string bars = "2")
        {
            Controls = new List<Control>();

            TextBoxName = new TextBox();
            TextBoxName.Text = name;
            Controls.Add(TextBoxName);

            TextBoxOffset = new TextBox();
            TextBoxOffset.Text = offset;
            Controls.Add(TextBoxOffset);

            TextBoxBPM = new TextBox();
            TextBoxBPM.Text = bpm;
            Controls.Add(TextBoxBPM);

            TextBoxBeatsPerBar = new TextBox();
            TextBoxBeatsPerBar.Text = beats;
            Controls.Add(TextBoxBeatsPerBar);

            TextBoxTotalBars = new TextBox();
            TextBoxTotalBars.Text = bars;
            Controls.Add(TextBoxTotalBars);

            foreach (TextBox textbox in TextBoxes) 
            {
                textbox.Font = new Font(textbox.Font.FontFamily, 9.0f);
                textbox.TextChanged += DataChanged;
                textbox.TabStop = false;
            }

            RadioButton = new RadioButton();
            RadioButton.Click += RadioButton_Click;
            Controls.Add(RadioButton);

            RemoveButton = new Button();
            RemoveButton.Text = "-";
            RemoveButton.Click += RemoveButton_Click;
            RemoveButton.TabStop = false;
            RemoveButton.DisableSelect();
            Controls.Add(RemoveButton);

            Index = index;
        }

        public TimerError GetTimerInfo(out MetronomeInfo metronomeInfo)
        {
            uint bpm;
            uint beats;
            uint bars;

            metronomeInfo = new MetronomeInfo();

            if (!uint.TryParse(TextBoxBPM.Text, out bpm))
            {
                // TODO: Add error for BPM
                return TimerError.InvalidInterval;
            }

            if (!uint.TryParse(TextBoxBeatsPerBar.Text, out beats))
            {
                // TODO: Add error for beats
                return TimerError.InvalidNumBeeps;
            }

            if (!uint.TryParse(TextBoxTotalBars.Text, out bars))
            {
                // TODO: Add error for total bars
                return TimerError.InvalidNumBeeps;
            }

            string[] offsetsStr = TextBoxOffset.Text.Split('/');
            uint[] offsets = new uint[offsetsStr.Length];

            for (int i = 0; i < offsetsStr.Length; i++)
            {
                if (!uint.TryParse(offsetsStr[i], out offsets[i]))
                {
                    return TimerError.InvalidOffset;
                }
            }

            Array.Sort(offsets);
            metronomeInfo.Offsets = offsets;
            metronomeInfo.MaxOffset = offsets.Last();

            // Calculate remaining values
            // number of beeps = (timsig * bars) + 1
            // interval = 60000 / bpm
            metronomeInfo.NumBeeps = (beats * bars) + 1;
            metronomeInfo.Interval = 60000 / bpm;

            if (metronomeInfo.Interval >= ushort.MaxValue << 9)
            {
                return TimerError.InvalidInterval;
            }

            if (metronomeInfo.NumBeeps >= ushort.MaxValue << 9)
            {
                return TimerError.InvalidNumBeeps;
            }

            foreach (uint offset in metronomeInfo.Offsets)
            {
                if (offset >= ushort.MaxValue << 9 || offset < metronomeInfo.Interval * (metronomeInfo.NumBeeps - 1))
                {
                    return TimerError.InvalidOffset;
                }
            }

            return TimerError.NoError;
        }

        private void RadioButton_Click(object sender, EventArgs e)
        {
            FlowTimer.Metronome.SelectMetronome(this);
        }

        private void DataChanged(object sender, EventArgs e)
        {
            FlowTimer.Metronome.SelectMetronome(this);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            FlowTimer.Metronome.RemoveTimer(this);
        }
    }
}
