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
            this.chkAllDisplays = new System.Windows.Forms.CheckBox();
            this.chkNotifArea = new System.Windows.Forms.CheckBox();
            this.chkDateTime = new System.Windows.Forms.CheckBox();
            this.tmrShowMonitor = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.lnkNewVersion = new System.Windows.Forms.LinkLabel();
            this.bgwCheckVersion = new System.ComponentModel.BackgroundWorker();
            this.pnlCheckBoxes.SuspendLayout();
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
            this.pnlCheckBoxes.Controls.Add(this.chkAllDisplays);
            this.pnlCheckBoxes.Controls.Add(this.chkNotifArea);
            this.pnlCheckBoxes.Controls.Add(this.chkDateTime);
            this.pnlCheckBoxes.Location = new System.Drawing.Point(13, 13);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Size = new System.Drawing.Size(658, 77);
            this.pnlCheckBoxes.TabIndex = 5;
            // 
            // chkAllDisplays
            // 
            this.chkAllDisplays.AutoEllipsis = true;
            this.chkAllDisplays.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkAllDisplays.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkAllDisplays.Checked = true;
            this.chkAllDisplays.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAllDisplays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkAllDisplays.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAllDisplays.Location = new System.Drawing.Point(441, 3);
            this.chkAllDisplays.Name = "chkAllDisplays";
            this.chkAllDisplays.Padding = new System.Windows.Forms.Padding(10);
            this.chkAllDisplays.Size = new System.Drawing.Size(200, 70);
            this.chkAllDisplays.TabIndex = 5;
            this.chkAllDisplays.Text = "In All Displays";
            this.chkAllDisplays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkAllDisplays.UseVisualStyleBackColor = false;
            // 
            // chkNotifArea
            // 
            this.chkNotifArea.AutoEllipsis = true;
            this.chkNotifArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkNotifArea.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkNotifArea.Checked = true;
            this.chkNotifArea.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotifArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkNotifArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkNotifArea.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkNotifArea.Location = new System.Drawing.Point(229, 3);
            this.chkNotifArea.Name = "chkNotifArea";
            this.chkNotifArea.Padding = new System.Windows.Forms.Padding(10);
            this.chkNotifArea.Size = new System.Drawing.Size(200, 70);
            this.chkNotifArea.TabIndex = 4;
            this.chkNotifArea.Text = "Notification Area";
            this.chkNotifArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkNotifArea.UseVisualStyleBackColor = false;
            // 
            // chkDateTime
            // 
            this.chkDateTime.AutoEllipsis = true;
            this.chkDateTime.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chkDateTime.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chkDateTime.Checked = true;
            this.chkDateTime.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkDateTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkDateTime.Enabled = false;
            this.chkDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDateTime.Location = new System.Drawing.Point(17, 3);
            this.chkDateTime.Name = "chkDateTime";
            this.chkDateTime.Padding = new System.Windows.Forms.Padding(10);
            this.chkDateTime.Size = new System.Drawing.Size(200, 70);
            this.chkDateTime.TabIndex = 3;
            this.chkDateTime.Text = "Date/Time";
            this.chkDateTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkDateTime.UseVisualStyleBackColor = false;
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
            this.notifyIcon.Visible = true;
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
            // Win11ClockTogglerGUI
            // 
            this.AcceptButton = this.btnHideShow;
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(683, 193);
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
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnHideShow;
        private System.Windows.Forms.Panel pnlCheckBoxes;
        private System.Windows.Forms.CheckBox chkAllDisplays;
        private System.Windows.Forms.CheckBox chkNotifArea;
        private System.Windows.Forms.CheckBox chkDateTime;
        private System.Windows.Forms.Timer tmrShowMonitor;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.LinkLabel lnkNewVersion;
        private System.ComponentModel.BackgroundWorker bgwCheckVersion;
    }
}

