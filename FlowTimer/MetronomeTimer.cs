using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowTimer
{
    public class MetronomeTimer : BaseTimer
    {
        public Button ButtonAdd;
        public Button ButtonLoadTimers;
        public Button ButtonSaveTimers;

        public List<Timer> Timers;
        public Timer SelectedTimer;

        public MetronomeTimer(TabPage tab, params Control[] copyControls) : base(tab, (start) => Math.Max((FlowTimer.MaxOffset - (Win32.GetTime() - start)) / 1000.0, 0.0), copyControls)
        {
            ButtonAdd = FlowTimer.MainForm.ButtonAdd;
            ButtonLoadTimers = FlowTimer.MainForm.ButtonLoadTimers;
            ButtonSaveTimers = FlowTimer.MainForm.ButtonSaveTimers;

            Timers = new List<Timer>();
        }

        public override void OnBeepSoundChange()
        {
            Console.WriteLine("OnBeepSoundChange");
        }

        public override void OnBeepVolumeChange()
        {
            Console.WriteLine("OnBeepVolumeChange");
        }

        public override void OnInit()
        {
            Console.WriteLine("OnInit");
        }

        public override void OnKeyEvent(Keys key)
        {
            Console.WriteLine("OnKeyEvent");
        }

        public override void OnTimerStart()
        {
            Console.WriteLine("OnTimerStart");
        }

        public override void OnTimerStop()
        {
            Console.WriteLine("OnTimerStop");
        }

        public override void OnVisualTimerStart()
        {
            Console.WriteLine("OnVisualTimerStart");
        }
    }
}
