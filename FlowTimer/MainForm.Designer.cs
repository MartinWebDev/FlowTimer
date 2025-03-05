namespace FlowTimer {
    partial class MainForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LabelTimer = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSettings = new System.Windows.Forms.Button();
            this.ButtonLoadTimers = new System.Windows.Forms.Button();
            this.ButtonSaveTimers = new System.Windows.Forms.Button();
            this.PictureBoxPin = new System.Windows.Forms.PictureBox();
            this.LabelBeeps = new System.Windows.Forms.Label();
            this.LabelInterval = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LabelOffset = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabPageFixedOffset = new System.Windows.Forms.TabPage();
            this.TabPageVariableOffset = new System.Windows.Forms.TabPage();
            this.ButtonUndo = new System.Windows.Forms.Button();
            this.ButtonMinus = new System.Windows.Forms.Button();
            this.ButtonPlus = new System.Windows.Forms.Button();
            this.ComboBoxFPS = new System.Windows.Forms.ComboBox();
            this.ButtonSubmit = new System.Windows.Forms.Button();
            this.LabelBeeps2 = new System.Windows.Forms.Label();
            this.TextBoxBeeps = new System.Windows.Forms.TextBox();
            this.LabelInterval2 = new System.Windows.Forms.Label();
            this.TextBoxInterval = new System.Windows.Forms.TextBox();
            this.LabelOffset2 = new System.Windows.Forms.Label();
            this.TextBoxOffset = new System.Windows.Forms.TextBox();
            this.LabelFPS = new System.Windows.Forms.Label();
            this.LabelFrame = new System.Windows.Forms.Label();
            this.TextBoxFrame = new System.Windows.Forms.TextBox();
            this.TabPageIGTTracking = new System.Windows.Forms.TabPage();
            this.ButtonAdd3 = new System.Windows.Forms.Button();
            this.ButtonSaveTimers3 = new System.Windows.Forms.Button();
            this.ButtonLoadTimers3 = new System.Windows.Forms.Button();
            this.ButtonUndoPlay = new System.Windows.Forms.Button();
            this.ComboBoxGame = new System.Windows.Forms.ComboBox();
            this.ComboBoxFPS3 = new System.Windows.Forms.ComboBox();
            this.ButtonPlay = new System.Windows.Forms.Button();
            this.LabelBeeps3 = new System.Windows.Forms.Label();
            this.LabelInterval3 = new System.Windows.Forms.Label();
            this.LabelGame = new System.Windows.Forms.Label();
            this.LabelOffset3 = new System.Windows.Forms.Label();
            this.LabelFPS3 = new System.Windows.Forms.Label();
            this.LabelName3 = new System.Windows.Forms.Label();
            this.LabelFrame3 = new System.Windows.Forms.Label();
            this.tabMetronome = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPin)).BeginInit();
            this.TabControl.SuspendLayout();
            this.TabPageFixedOffset.SuspendLayout();
            this.TabPageVariableOffset.SuspendLayout();
            this.TabPageIGTTracking.SuspendLayout();
            this.SuspendLayout();
            // 
            // LabelTimer
            // 
            this.LabelTimer.AutoSize = true;
            this.LabelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTimer.Location = new System.Drawing.Point(10, 8);
            this.LabelTimer.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelTimer.Name = "LabelTimer";
            this.LabelTimer.Size = new System.Drawing.Size(227, 85);
            this.LabelTimer.TabIndex = 0;
            this.LabelTimer.Text = "0.000";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(24, 110);
            this.ButtonStart.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(242, 48);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.TabStop = false;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(24, 163);
            this.ButtonStop.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(242, 48);
            this.ButtonStop.TabIndex = 2;
            this.ButtonStop.TabStop = false;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(0, 0);
            this.ButtonAdd.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(134, 44);
            this.ButtonAdd.TabIndex = 28;
            this.ButtonAdd.TabStop = false;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Location = new System.Drawing.Point(24, 217);
            this.ButtonSettings.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(242, 48);
            this.ButtonSettings.TabIndex = 30;
            this.ButtonSettings.TabStop = false;
            this.ButtonSettings.Text = "Settings";
            this.ButtonSettings.UseVisualStyleBackColor = true;
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonLoadTimers
            // 
            this.ButtonLoadTimers.Location = new System.Drawing.Point(24, 271);
            this.ButtonLoadTimers.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonLoadTimers.Name = "ButtonLoadTimers";
            this.ButtonLoadTimers.Size = new System.Drawing.Size(242, 48);
            this.ButtonLoadTimers.TabIndex = 31;
            this.ButtonLoadTimers.TabStop = false;
            this.ButtonLoadTimers.Text = "Load Timers";
            this.ButtonLoadTimers.UseVisualStyleBackColor = true;
            this.ButtonLoadTimers.Click += new System.EventHandler(this.ButtonLoadTimers_Click);
            // 
            // ButtonSaveTimers
            // 
            this.ButtonSaveTimers.Location = new System.Drawing.Point(24, 325);
            this.ButtonSaveTimers.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSaveTimers.Name = "ButtonSaveTimers";
            this.ButtonSaveTimers.Size = new System.Drawing.Size(242, 48);
            this.ButtonSaveTimers.TabIndex = 32;
            this.ButtonSaveTimers.TabStop = false;
            this.ButtonSaveTimers.Text = "Save Timers";
            this.ButtonSaveTimers.UseVisualStyleBackColor = true;
            this.ButtonSaveTimers.Click += new System.EventHandler(this.ButtonSaveTimers_Click);
            // 
            // PictureBoxPin
            // 
            this.PictureBoxPin.Location = new System.Drawing.Point(956, 8);
            this.PictureBoxPin.Margin = new System.Windows.Forms.Padding(6);
            this.PictureBoxPin.Name = "PictureBoxPin";
            this.PictureBoxPin.Size = new System.Drawing.Size(32, 31);
            this.PictureBoxPin.TabIndex = 33;
            this.PictureBoxPin.TabStop = false;
            this.PictureBoxPin.Click += new System.EventHandler(this.PictureBoxPin_Click);
            // 
            // LabelBeeps
            // 
            this.LabelBeeps.AutoSize = true;
            this.LabelBeeps.Location = new System.Drawing.Point(748, 27);
            this.LabelBeeps.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelBeeps.Name = "LabelBeeps";
            this.LabelBeeps.Size = new System.Drawing.Size(73, 25);
            this.LabelBeeps.TabIndex = 16;
            this.LabelBeeps.Text = "Beeps";
            // 
            // LabelInterval
            // 
            this.LabelInterval.AutoSize = true;
            this.LabelInterval.Location = new System.Drawing.Point(606, 27);
            this.LabelInterval.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelInterval.Name = "LabelInterval";
            this.LabelInterval.Size = new System.Drawing.Size(82, 25);
            this.LabelInterval.TabIndex = 13;
            this.LabelInterval.Text = "Interval";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(322, 27);
            this.LabelName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(68, 25);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "Name";
            // 
            // LabelOffset
            // 
            this.LabelOffset.AutoSize = true;
            this.LabelOffset.Location = new System.Drawing.Point(464, 27);
            this.LabelOffset.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelOffset.Name = "LabelOffset";
            this.LabelOffset.Size = new System.Drawing.Size(69, 25);
            this.LabelOffset.TabIndex = 12;
            this.LabelOffset.Text = "Offset";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabPageFixedOffset);
            this.TabControl.Controls.Add(this.TabPageVariableOffset);
            this.TabControl.Controls.Add(this.TabPageIGTTracking);
            this.TabControl.Controls.Add(this.tabMetronome);
            this.TabControl.Location = new System.Drawing.Point(-6, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(6);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1072, 481);
            this.TabControl.TabIndex = 34;
            // 
            // TabPageFixedOffset
            // 
            this.TabPageFixedOffset.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageFixedOffset.Controls.Add(this.ButtonAdd);
            this.TabPageFixedOffset.Controls.Add(this.LabelTimer);
            this.TabPageFixedOffset.Controls.Add(this.PictureBoxPin);
            this.TabPageFixedOffset.Controls.Add(this.LabelBeeps);
            this.TabPageFixedOffset.Controls.Add(this.ButtonStart);
            this.TabPageFixedOffset.Controls.Add(this.LabelInterval);
            this.TabPageFixedOffset.Controls.Add(this.ButtonSaveTimers);
            this.TabPageFixedOffset.Controls.Add(this.LabelOffset);
            this.TabPageFixedOffset.Controls.Add(this.ButtonStop);
            this.TabPageFixedOffset.Controls.Add(this.LabelName);
            this.TabPageFixedOffset.Controls.Add(this.ButtonLoadTimers);
            this.TabPageFixedOffset.Controls.Add(this.ButtonSettings);
            this.TabPageFixedOffset.Location = new System.Drawing.Point(8, 39);
            this.TabPageFixedOffset.Margin = new System.Windows.Forms.Padding(6);
            this.TabPageFixedOffset.Name = "TabPageFixedOffset";
            this.TabPageFixedOffset.Padding = new System.Windows.Forms.Padding(6);
            this.TabPageFixedOffset.Size = new System.Drawing.Size(1056, 434);
            this.TabPageFixedOffset.TabIndex = 0;
            this.TabPageFixedOffset.Text = "Fixed Offset";
            // 
            // TabPageVariableOffset
            // 
            this.TabPageVariableOffset.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageVariableOffset.Controls.Add(this.ButtonUndo);
            this.TabPageVariableOffset.Controls.Add(this.ButtonMinus);
            this.TabPageVariableOffset.Controls.Add(this.ButtonPlus);
            this.TabPageVariableOffset.Controls.Add(this.ComboBoxFPS);
            this.TabPageVariableOffset.Controls.Add(this.ButtonSubmit);
            this.TabPageVariableOffset.Controls.Add(this.LabelBeeps2);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxBeeps);
            this.TabPageVariableOffset.Controls.Add(this.LabelInterval2);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxInterval);
            this.TabPageVariableOffset.Controls.Add(this.LabelOffset2);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxOffset);
            this.TabPageVariableOffset.Controls.Add(this.LabelFPS);
            this.TabPageVariableOffset.Controls.Add(this.LabelFrame);
            this.TabPageVariableOffset.Controls.Add(this.TextBoxFrame);
            this.TabPageVariableOffset.Location = new System.Drawing.Point(8, 39);
            this.TabPageVariableOffset.Margin = new System.Windows.Forms.Padding(6);
            this.TabPageVariableOffset.Name = "TabPageVariableOffset";
            this.TabPageVariableOffset.Padding = new System.Windows.Forms.Padding(6);
            this.TabPageVariableOffset.Size = new System.Drawing.Size(1056, 434);
            this.TabPageVariableOffset.TabIndex = 1;
            this.TabPageVariableOffset.Text = "Variable Offset";
            // 
            // ButtonUndo
            // 
            this.ButtonUndo.Location = new System.Drawing.Point(652, 73);
            this.ButtonUndo.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonUndo.Name = "ButtonUndo";
            this.ButtonUndo.Size = new System.Drawing.Size(160, 42);
            this.ButtonUndo.TabIndex = 14;
            this.ButtonUndo.Text = "Undo";
            this.ButtonUndo.UseVisualStyleBackColor = true;
            this.ButtonUndo.Click += new System.EventHandler(this.ButtonUndo_Click);
            // 
            // ButtonMinus
            // 
            this.ButtonMinus.Location = new System.Drawing.Point(826, 23);
            this.ButtonMinus.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonMinus.Name = "ButtonMinus";
            this.ButtonMinus.Size = new System.Drawing.Size(44, 42);
            this.ButtonMinus.TabIndex = 13;
            this.ButtonMinus.Text = "-";
            this.ButtonMinus.UseVisualStyleBackColor = true;
            this.ButtonMinus.Click += new System.EventHandler(this.ButtonMinus_Click);
            // 
            // ButtonPlus
            // 
            this.ButtonPlus.Location = new System.Drawing.Point(874, 23);
            this.ButtonPlus.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonPlus.Name = "ButtonPlus";
            this.ButtonPlus.Size = new System.Drawing.Size(44, 42);
            this.ButtonPlus.TabIndex = 12;
            this.ButtonPlus.Text = "+";
            this.ButtonPlus.UseVisualStyleBackColor = true;
            this.ButtonPlus.Click += new System.EventHandler(this.ButtonPlus_Click);
            // 
            // ComboBoxFPS
            // 
            this.ComboBoxFPS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFPS.FormattingEnabled = true;
            this.ComboBoxFPS.Items.AddRange(new object[] {
            "59.7275",
            "59.6555",
            "59.8261",
            "60.0",
            "30.0",
            "25.0",
            "15.0"});
            this.ComboBoxFPS.Location = new System.Drawing.Point(480, 75);
            this.ComboBoxFPS.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBoxFPS.Name = "ComboBoxFPS";
            this.ComboBoxFPS.Size = new System.Drawing.Size(156, 33);
            this.ComboBoxFPS.TabIndex = 11;
            this.ComboBoxFPS.SelectedIndexChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // ButtonSubmit
            // 
            this.ButtonSubmit.Location = new System.Drawing.Point(652, 23);
            this.ButtonSubmit.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSubmit.Name = "ButtonSubmit";
            this.ButtonSubmit.Size = new System.Drawing.Size(160, 42);
            this.ButtonSubmit.TabIndex = 10;
            this.ButtonSubmit.Text = "Submit";
            this.ButtonSubmit.UseVisualStyleBackColor = true;
            this.ButtonSubmit.Click += new System.EventHandler(this.ButtonSubmit_Click);
            // 
            // LabelBeeps2
            // 
            this.LabelBeeps2.AutoSize = true;
            this.LabelBeeps2.Location = new System.Drawing.Point(384, 231);
            this.LabelBeeps2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelBeeps2.Name = "LabelBeeps2";
            this.LabelBeeps2.Size = new System.Drawing.Size(79, 25);
            this.LabelBeeps2.TabIndex = 9;
            this.LabelBeeps2.Text = "Beeps:";
            // 
            // TextBoxBeeps
            // 
            this.TextBoxBeeps.Location = new System.Drawing.Point(480, 225);
            this.TextBoxBeeps.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxBeeps.Name = "TextBoxBeeps";
            this.TextBoxBeeps.Size = new System.Drawing.Size(156, 31);
            this.TextBoxBeeps.TabIndex = 8;
            this.TextBoxBeeps.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // LabelInterval2
            // 
            this.LabelInterval2.AutoSize = true;
            this.LabelInterval2.Location = new System.Drawing.Point(384, 181);
            this.LabelInterval2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelInterval2.Name = "LabelInterval2";
            this.LabelInterval2.Size = new System.Drawing.Size(88, 25);
            this.LabelInterval2.TabIndex = 7;
            this.LabelInterval2.Text = "Interval:";
            // 
            // TextBoxInterval
            // 
            this.TextBoxInterval.Location = new System.Drawing.Point(480, 175);
            this.TextBoxInterval.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxInterval.Name = "TextBoxInterval";
            this.TextBoxInterval.Size = new System.Drawing.Size(156, 31);
            this.TextBoxInterval.TabIndex = 6;
            this.TextBoxInterval.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // LabelOffset2
            // 
            this.LabelOffset2.AutoSize = true;
            this.LabelOffset2.Location = new System.Drawing.Point(384, 131);
            this.LabelOffset2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelOffset2.Name = "LabelOffset2";
            this.LabelOffset2.Size = new System.Drawing.Size(75, 25);
            this.LabelOffset2.TabIndex = 5;
            this.LabelOffset2.Text = "Offset:";
            // 
            // TextBoxOffset
            // 
            this.TextBoxOffset.Location = new System.Drawing.Point(480, 125);
            this.TextBoxOffset.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxOffset.Name = "TextBoxOffset";
            this.TextBoxOffset.Size = new System.Drawing.Size(156, 31);
            this.TextBoxOffset.TabIndex = 4;
            this.TextBoxOffset.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // LabelFPS
            // 
            this.LabelFPS.AutoSize = true;
            this.LabelFPS.Location = new System.Drawing.Point(384, 81);
            this.LabelFPS.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFPS.Name = "LabelFPS";
            this.LabelFPS.Size = new System.Drawing.Size(59, 25);
            this.LabelFPS.TabIndex = 3;
            this.LabelFPS.Text = "FPS:";
            // 
            // LabelFrame
            // 
            this.LabelFrame.AutoSize = true;
            this.LabelFrame.Location = new System.Drawing.Point(384, 31);
            this.LabelFrame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFrame.Name = "LabelFrame";
            this.LabelFrame.Size = new System.Drawing.Size(79, 25);
            this.LabelFrame.TabIndex = 1;
            this.LabelFrame.Text = "Frame:";
            // 
            // TextBoxFrame
            // 
            this.TextBoxFrame.Location = new System.Drawing.Point(480, 25);
            this.TextBoxFrame.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxFrame.Name = "TextBoxFrame";
            this.TextBoxFrame.Size = new System.Drawing.Size(156, 31);
            this.TextBoxFrame.TabIndex = 0;
            this.TextBoxFrame.TextChanged += new System.EventHandler(this.VariableTimer_DataChange);
            // 
            // TabPageIGTTracking
            // 
            this.TabPageIGTTracking.BackColor = System.Drawing.SystemColors.Control;
            this.TabPageIGTTracking.Controls.Add(this.ButtonAdd3);
            this.TabPageIGTTracking.Controls.Add(this.ButtonSaveTimers3);
            this.TabPageIGTTracking.Controls.Add(this.ButtonLoadTimers3);
            this.TabPageIGTTracking.Controls.Add(this.ButtonUndoPlay);
            this.TabPageIGTTracking.Controls.Add(this.ComboBoxGame);
            this.TabPageIGTTracking.Controls.Add(this.ComboBoxFPS3);
            this.TabPageIGTTracking.Controls.Add(this.ButtonPlay);
            this.TabPageIGTTracking.Controls.Add(this.LabelBeeps3);
            this.TabPageIGTTracking.Controls.Add(this.LabelInterval3);
            this.TabPageIGTTracking.Controls.Add(this.LabelGame);
            this.TabPageIGTTracking.Controls.Add(this.LabelOffset3);
            this.TabPageIGTTracking.Controls.Add(this.LabelFPS3);
            this.TabPageIGTTracking.Controls.Add(this.LabelName3);
            this.TabPageIGTTracking.Controls.Add(this.LabelFrame3);
            this.TabPageIGTTracking.Location = new System.Drawing.Point(8, 39);
            this.TabPageIGTTracking.Margin = new System.Windows.Forms.Padding(6);
            this.TabPageIGTTracking.Name = "TabPageIGTTracking";
            this.TabPageIGTTracking.Padding = new System.Windows.Forms.Padding(6);
            this.TabPageIGTTracking.Size = new System.Drawing.Size(1056, 434);
            this.TabPageIGTTracking.TabIndex = 2;
            this.TabPageIGTTracking.Text = "IGT Tracking";
            // 
            // ButtonAdd3
            // 
            this.ButtonAdd3.Location = new System.Drawing.Point(0, 0);
            this.ButtonAdd3.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonAdd3.Name = "ButtonAdd3";
            this.ButtonAdd3.Size = new System.Drawing.Size(134, 44);
            this.ButtonAdd3.TabIndex = 33;
            this.ButtonAdd3.TabStop = false;
            this.ButtonAdd3.Text = "Add";
            this.ButtonAdd3.UseVisualStyleBackColor = true;
            this.ButtonAdd3.Click += new System.EventHandler(this.ButtonAdd3_Click);
            // 
            // ButtonSaveTimers3
            // 
            this.ButtonSaveTimers3.Location = new System.Drawing.Point(24, 325);
            this.ButtonSaveTimers3.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonSaveTimers3.Name = "ButtonSaveTimers3";
            this.ButtonSaveTimers3.Size = new System.Drawing.Size(242, 48);
            this.ButtonSaveTimers3.TabIndex = 35;
            this.ButtonSaveTimers3.TabStop = false;
            this.ButtonSaveTimers3.Text = "Save Timers";
            this.ButtonSaveTimers3.UseVisualStyleBackColor = true;
            this.ButtonSaveTimers3.Click += new System.EventHandler(this.ButtonSaveTimers3_Click);
            // 
            // ButtonLoadTimers3
            // 
            this.ButtonLoadTimers3.Location = new System.Drawing.Point(24, 271);
            this.ButtonLoadTimers3.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonLoadTimers3.Name = "ButtonLoadTimers3";
            this.ButtonLoadTimers3.Size = new System.Drawing.Size(242, 48);
            this.ButtonLoadTimers3.TabIndex = 34;
            this.ButtonLoadTimers3.TabStop = false;
            this.ButtonLoadTimers3.Text = "Load Timers";
            this.ButtonLoadTimers3.UseVisualStyleBackColor = true;
            this.ButtonLoadTimers3.Click += new System.EventHandler(this.ButtonLoadTimers3_Click);
            // 
            // ButtonUndoPlay
            // 
            this.ButtonUndoPlay.Location = new System.Drawing.Point(814, 219);
            this.ButtonUndoPlay.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonUndoPlay.Name = "ButtonUndoPlay";
            this.ButtonUndoPlay.Size = new System.Drawing.Size(160, 42);
            this.ButtonUndoPlay.TabIndex = 14;
            this.ButtonUndoPlay.Text = "Undo";
            this.ButtonUndoPlay.UseVisualStyleBackColor = true;
            this.ButtonUndoPlay.Click += new System.EventHandler(this.ButtonUndoPlay_Click);
            // 
            // ComboBoxGame
            // 
            this.ComboBoxGame.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxGame.FormattingEnabled = true;
            this.ComboBoxGame.Location = new System.Drawing.Point(814, 67);
            this.ComboBoxGame.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBoxGame.Name = "ComboBoxGame";
            this.ComboBoxGame.Size = new System.Drawing.Size(156, 33);
            this.ComboBoxGame.TabIndex = 11;
            this.ComboBoxGame.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFPS3_DataChange);
            // 
            // ComboBoxFPS3
            // 
            this.ComboBoxFPS3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxFPS3.FormattingEnabled = true;
            this.ComboBoxFPS3.Items.AddRange(new object[] {
            "59.7275",
            "59.6555",
            "59.8261",
            "60.0",
            "30.0",
            "25.0",
            "15.0"});
            this.ComboBoxFPS3.Location = new System.Drawing.Point(814, 119);
            this.ComboBoxFPS3.Margin = new System.Windows.Forms.Padding(6);
            this.ComboBoxFPS3.Name = "ComboBoxFPS3";
            this.ComboBoxFPS3.Size = new System.Drawing.Size(156, 33);
            this.ComboBoxFPS3.TabIndex = 11;
            this.ComboBoxFPS3.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFPS3_DataChange);
            // 
            // ButtonPlay
            // 
            this.ButtonPlay.Location = new System.Drawing.Point(814, 169);
            this.ButtonPlay.Margin = new System.Windows.Forms.Padding(6);
            this.ButtonPlay.Name = "ButtonPlay";
            this.ButtonPlay.Size = new System.Drawing.Size(160, 42);
            this.ButtonPlay.TabIndex = 10;
            this.ButtonPlay.Text = "Play";
            this.ButtonPlay.UseVisualStyleBackColor = true;
            this.ButtonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            // 
            // LabelBeeps3
            // 
            this.LabelBeeps3.AutoSize = true;
            this.LabelBeeps3.Location = new System.Drawing.Point(802, 277);
            this.LabelBeeps3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelBeeps3.Name = "LabelBeeps3";
            this.LabelBeeps3.Size = new System.Drawing.Size(73, 25);
            this.LabelBeeps3.TabIndex = 9;
            this.LabelBeeps3.Text = "Beeps";
            // 
            // LabelInterval3
            // 
            this.LabelInterval3.AutoSize = true;
            this.LabelInterval3.Location = new System.Drawing.Point(692, 277);
            this.LabelInterval3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelInterval3.Name = "LabelInterval3";
            this.LabelInterval3.Size = new System.Drawing.Size(82, 25);
            this.LabelInterval3.TabIndex = 7;
            this.LabelInterval3.Text = "Interval";
            // 
            // LabelGame
            // 
            this.LabelGame.AutoSize = true;
            this.LabelGame.Location = new System.Drawing.Point(736, 73);
            this.LabelGame.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelGame.Name = "LabelGame";
            this.LabelGame.Size = new System.Drawing.Size(75, 25);
            this.LabelGame.TabIndex = 3;
            this.LabelGame.Text = "Game:";
            // 
            // LabelOffset3
            // 
            this.LabelOffset3.AutoSize = true;
            this.LabelOffset3.Location = new System.Drawing.Point(552, 277);
            this.LabelOffset3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelOffset3.Name = "LabelOffset3";
            this.LabelOffset3.Size = new System.Drawing.Size(69, 25);
            this.LabelOffset3.TabIndex = 5;
            this.LabelOffset3.Text = "Offset";
            // 
            // LabelFPS3
            // 
            this.LabelFPS3.AutoSize = true;
            this.LabelFPS3.Location = new System.Drawing.Point(736, 125);
            this.LabelFPS3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFPS3.Name = "LabelFPS3";
            this.LabelFPS3.Size = new System.Drawing.Size(59, 25);
            this.LabelFPS3.TabIndex = 3;
            this.LabelFPS3.Text = "FPS:";
            // 
            // LabelName3
            // 
            this.LabelName3.AutoSize = true;
            this.LabelName3.Location = new System.Drawing.Point(322, 277);
            this.LabelName3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelName3.Name = "LabelName3";
            this.LabelName3.Size = new System.Drawing.Size(68, 25);
            this.LabelName3.TabIndex = 1;
            this.LabelName3.Text = "Name";
            // 
            // LabelFrame3
            // 
            this.LabelFrame3.AutoSize = true;
            this.LabelFrame3.Location = new System.Drawing.Point(462, 277);
            this.LabelFrame3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.LabelFrame3.Name = "LabelFrame3";
            this.LabelFrame3.Size = new System.Drawing.Size(73, 25);
            this.LabelFrame3.TabIndex = 1;
            this.LabelFrame3.Text = "Frame";
            // 
            // tabMetronome
            // 
            this.tabMetronome.BackColor = System.Drawing.SystemColors.Control;
            this.tabMetronome.Location = new System.Drawing.Point(8, 39);
            this.tabMetronome.Name = "tabMetronome";
            this.tabMetronome.Size = new System.Drawing.Size(1056, 434);
            this.tabMetronome.TabIndex = 3;
            this.tabMetronome.Text = "Metronome Timer";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 438);
            this.Controls.Add(this.TabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "FlowTimer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxPin)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.TabPageFixedOffset.ResumeLayout(false);
            this.TabPageFixedOffset.PerformLayout();
            this.TabPageVariableOffset.ResumeLayout(false);
            this.TabPageVariableOffset.PerformLayout();
            this.TabPageIGTTracking.ResumeLayout(false);
            this.TabPageIGTTracking.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label LabelTimer;
        public System.Windows.Forms.Button ButtonStart;
        public System.Windows.Forms.Button ButtonStop;
        public System.Windows.Forms.Button ButtonAdd;
        public System.Windows.Forms.Button ButtonSettings;
        public System.Windows.Forms.Button ButtonLoadTimers;
        public System.Windows.Forms.Button ButtonSaveTimers;
        public System.Windows.Forms.PictureBox PictureBoxPin;
        public System.Windows.Forms.Label LabelBeeps;
        public System.Windows.Forms.Label LabelInterval;
        public System.Windows.Forms.Label LabelName;
        public System.Windows.Forms.Label LabelOffset;
        public System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabPageFixedOffset;
        private System.Windows.Forms.TabPage TabPageVariableOffset;
        private System.Windows.Forms.TabPage TabPageIGTTracking;
        public System.Windows.Forms.TextBox TextBoxFrame;
        public System.Windows.Forms.Label LabelFrame;
        public System.Windows.Forms.Label LabelFrame3;
        public System.Windows.Forms.Label LabelBeeps2;
        public System.Windows.Forms.Label LabelBeeps3;
        public System.Windows.Forms.TextBox TextBoxBeeps;
        public System.Windows.Forms.Label LabelInterval2;
        public System.Windows.Forms.Label LabelInterval3;
        public System.Windows.Forms.TextBox TextBoxInterval;
        public System.Windows.Forms.Label LabelOffset2;
        public System.Windows.Forms.Label LabelOffset3;
        public System.Windows.Forms.TextBox TextBoxOffset;
        public System.Windows.Forms.Label LabelFPS;
        public System.Windows.Forms.Label LabelFPS3;
        public System.Windows.Forms.Button ButtonSubmit;
        public System.Windows.Forms.Button ButtonPlay;
        public System.Windows.Forms.ComboBox ComboBoxFPS;
        public System.Windows.Forms.ComboBox ComboBoxFPS3;
        public System.Windows.Forms.Button ButtonMinus;
        public System.Windows.Forms.Button ButtonPlus;
        public System.Windows.Forms.Button ButtonUndo;
        public System.Windows.Forms.Button ButtonUndoPlay;
        public System.Windows.Forms.Label LabelName3;
        public System.Windows.Forms.Button ButtonAdd3;
        public System.Windows.Forms.Button ButtonSaveTimers3;
        public System.Windows.Forms.Button ButtonLoadTimers3;
        public System.Windows.Forms.ComboBox ComboBoxGame;
        public System.Windows.Forms.Label LabelGame;
        private System.Windows.Forms.TabPage tabMetronome;
    }
}
