namespace Win11ClockTogglerGUI
{
    partial class Win11ClockTogglerGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Win11ClockTogglerGUI));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnHideShow = new System.Windows.Forms.Button();
            this.pnlCheckBoxes = new System.Windows.Forms.Panel();
            this.pnlSecondary = new System.Windows.Forms.Panel();
            this.chkSecondary = new JCS.ToggleSwitch();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.chkDateTime = new JCS.ToggleSwitch();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNotifArea = new System.Windows.Forms.Panel();
            this.chkNotifArea = new JCS.ToggleSwitch();
            this.lblNotifArea = new System.Windows.Forms.Label();
            this.tmrShowMonitor = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lnkNewVersion = new System.Windows.Forms.LinkLabel();
            this.bgwCheckVersion = new System.ComponentModel.BackgroundWorker();
            this.toolTipSecondary = new System.Windows.Forms.ToolTip(this.components);
            this.cmdAbout = new System.Windows.Forms.Button();
            this.pnlCheckBoxes.SuspendLayout();
            this.pnlSecondary.SuspendLayout();
            this.pnlDateTime.SuspendLayout();
            this.pnlNotifArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(30, 144);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnHideShow
            // 
            this.btnHideShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHideShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHideShow.Location = new System.Drawing.Point(454, 144);
            this.btnHideShow.Name = "btnHideShow";
            this.btnHideShow.Size = new System.Drawing.Size(200, 37);
            this.btnHideShow.TabIndex = 4;
            this.btnHideShow.Text = "Toggle visibility";
            this.btnHideShow.UseVisualStyleBackColor = true;
            this.btnHideShow.Click += new System.EventHandler(this.btnHideShow_Click);
            // 
            // pnlCheckBoxes
            // 
            this.pnlCheckBoxes.Controls.Add(this.pnlSecondary);
            this.pnlCheckBoxes.Controls.Add(this.pnlDateTime);
            this.pnlCheckBoxes.Controls.Add(this.pnlNotifArea);
            this.pnlCheckBoxes.Location = new System.Drawing.Point(13, 13);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Size = new System.Drawing.Size(658, 77);
            this.pnlCheckBoxes.TabIndex = 5;
            // 
            // pnlSecondary
            // 
            this.pnlSecondary.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlSecondary.Controls.Add(this.chkSecondary);
            this.pnlSecondary.Controls.Add(this.label2);
            this.pnlSecondary.Location = new System.Drawing.Point(441, 3);
            this.pnlSecondary.Name = "pnlSecondary";
            this.pnlSecondary.Size = new System.Drawing.Size(200, 70);
            this.pnlSecondary.TabIndex = 9;
            this.toolTipSecondary.SetToolTip(this.pnlSecondary, "Shows or hides Date/Time in secondary toolbars\r\n(in secondary screens if they exi" +
        "st)");
            // 
            // chkSecondary
            // 
            this.chkSecondary.Checked = true;
            this.chkSecondary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkSecondary.Location = new System.Drawing.Point(54, 11);
            this.chkSecondary.Name = "chkSecondary";
            this.chkSecondary.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSecondary.OffText = "SHOW";
            this.chkSecondary.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSecondary.OnForeColor = System.Drawing.Color.White;
            this.chkSecondary.OnText = "HIDE";
            this.chkSecondary.Size = new System.Drawing.Size(94, 21);
            this.chkSecondary.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            this.chkSecondary.TabIndex = 6;
            this.toolTipSecondary.SetToolTip(this.chkSecondary, "Shows or hides Date/Time in secondary toolbars\r\n(in secondary screens if they exi" +
        "st)");
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Secondary";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTipSecondary.SetToolTip(this.label2, "Shows or hides Date/Time in secondary toolbars\r\n(in secondary screens if they exi" +
        "st)");
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlDateTime.Controls.Add(this.chkDateTime);
            this.pnlDateTime.Controls.Add(this.label1);
            this.pnlDateTime.Location = new System.Drawing.Point(17, 3);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(200, 70);
            this.pnlDateTime.TabIndex = 9;
            // 
            // chkDateTime
            // 
            this.chkDateTime.Checked = true;
            this.chkDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDateTime.Location = new System.Drawing.Point(54, 11);
            this.chkDateTime.Name = "chkDateTime";
            this.chkDateTime.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateTime.OffText = "SHOW";
            this.chkDateTime.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateTime.OnForeColor = System.Drawing.Color.White;
            this.chkDateTime.OnText = "HIDE";
            this.chkDateTime.Size = new System.Drawing.Size(94, 21);
            this.chkDateTime.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            this.chkDateTime.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date/Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlNotifArea
            // 
            this.pnlNotifArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlNotifArea.Controls.Add(this.chkNotifArea);
            this.pnlNotifArea.Controls.Add(this.lblNotifArea);
            this.pnlNotifArea.Location = new System.Drawing.Point(230, 3);
            this.pnlNotifArea.Name = "pnlNotifArea";
            this.pnlNotifArea.Size = new System.Drawing.Size(200, 70);
            this.pnlNotifArea.TabIndex = 8;
            // 
            // chkNotifArea
            // 
            this.chkNotifArea.Checked = true;
            this.chkNotifArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNotifArea.Location = new System.Drawing.Point(54, 11);
            this.chkNotifArea.Name = "chkNotifArea";
            this.chkNotifArea.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotifArea.OffText = "SHOW";
            this.chkNotifArea.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotifArea.OnForeColor = System.Drawing.Color.White;
            this.chkNotifArea.OnText = "HIDE";
            this.chkNotifArea.Size = new System.Drawing.Size(94, 21);
            this.chkNotifArea.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Iphone;
            this.chkNotifArea.TabIndex = 6;
            // 
            // lblNotifArea
            // 
            this.lblNotifArea.BackColor = System.Drawing.Color.Transparent;
            this.lblNotifArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotifArea.Location = new System.Drawing.Point(3, 38);
            this.lblNotifArea.Name = "lblNotifArea";
            this.lblNotifArea.Size = new System.Drawing.Size(194, 29);
            this.lblNotifArea.TabIndex = 8;
            this.lblNotifArea.Text = "Notification Area";
            this.lblNotifArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmrShowMonitor
            // 
            this.tmrShowMonitor.Interval = 10;
            this.tmrShowMonitor.Tick += new System.EventHandler(this.tmrShowMonitor_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Win11ClockTogglerCLI";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_Click);
            // 
            // lnkNewVersion
            // 
            this.lnkNewVersion.AutoEllipsis = true;
            this.lnkNewVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNewVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkNewVersion.LinkColor = System.Drawing.Color.Red;
            this.lnkNewVersion.Location = new System.Drawing.Point(13, 99);
            this.lnkNewVersion.Name = "lnkNewVersion";
            this.lnkNewVersion.Size = new System.Drawing.Size(658, 30);
            this.lnkNewVersion.TabIndex = 7;
            this.lnkNewVersion.TabStop = true;
            this.lnkNewVersion.Text = "⚠ New version 2.0.0 available! Click here to download...";
            this.lnkNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkNewVersion.Visible = false;
            this.lnkNewVersion.VisitedLinkColor = System.Drawing.Color.Red;
            this.lnkNewVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkNewVersion_LinkClicked);
            // 
            // bgwCheckVersion
            // 
            this.bgwCheckVersion.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwCheckVersion_DoWork);
            this.bgwCheckVersion.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwCheckVersion_RunWorkerCompleted);
            // 
            // toolTipSecondary
            // 
            this.toolTipSecondary.AutoPopDelay = 5000;
            this.toolTipSecondary.InitialDelay = 200;
            this.toolTipSecondary.IsBalloon = true;
            this.toolTipSecondary.ReshowDelay = 100;
            this.toolTipSecondary.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // cmdAbout
            // 
            this.cmdAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAbout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAbout.Location = new System.Drawing.Point(243, 144);
            this.cmdAbout.Name = "cmdAbout";
            this.cmdAbout.Size = new System.Drawing.Size(200, 37);
            this.cmdAbout.TabIndex = 8;
            this.cmdAbout.Text = "About";
            this.cmdAbout.UseVisualStyleBackColor = true;
            this.cmdAbout.Click += new System.EventHandler(this.cmdAbout_Click);
            // 
            // Win11ClockTogglerGUI
            // 
            this.AcceptButton = this.btnHideShow;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(683, 193);
            this.Controls.Add(this.cmdAbout);
            this.Controls.Add(this.lnkNewVersion);
            this.Controls.Add(this.btnHideShow);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pnlCheckBoxes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Win11ClockTogglerGUI";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 11 Date//Time & Notification Area Toggler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win11ClockTogglerGUI_FormClosing);
            this.Load += new System.EventHandler(this.Win11ClockTogglerGUI_Load);
            this.pnlCheckBoxes.ResumeLayout(false);
            this.pnlSecondary.ResumeLayout(false);
            this.pnlDateTime.ResumeLayout(false);
            this.pnlNotifArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHideShow;
        private System.Windows.Forms.Panel pnlCheckBoxes;
        private System.Windows.Forms.Timer tmrShowMonitor;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel lnkNewVersion;
        private System.ComponentModel.BackgroundWorker bgwCheckVersion;
        private JCS.ToggleSwitch chkNotifArea;
        private System.Windows.Forms.Panel pnlNotifArea;
        private System.Windows.Forms.Label lblNotifArea;
        private System.Windows.Forms.Panel pnlDateTime;
        private JCS.ToggleSwitch chkDateTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSecondary;
        private JCS.ToggleSwitch chkSecondary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTipSecondary;
        private System.Windows.Forms.Button cmdAbout;
    }
}

