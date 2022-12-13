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
            this.pnlCheckBoxes = new System.Windows.Forms.Panel();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.ExitText = new System.Windows.Forms.Label();
            this.VisibilityPanel = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.AboutPanel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.UpdatePanel = new System.Windows.Forms.Panel();
            this.lnkNewVersion = new System.Windows.Forms.LinkLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ShowOnHoverPanel = new System.Windows.Forms.Panel();
            this.AutoHideLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.AutoHideToggle = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.AutoHideImage = new System.Windows.Forms.PictureBox();
            this.pnlSecondary = new System.Windows.Forms.Panel();
            this.SecondaryLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SecondaryImage = new System.Windows.Forms.PictureBox();
            this.SecondaryToggle = new System.Windows.Forms.CheckBox();
            this.pnlDateTime = new System.Windows.Forms.Panel();
            this.DateTimeLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DateTimeImage = new System.Windows.Forms.PictureBox();
            this.DateTimeToggle = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlNotifArea = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.NotificationAreaLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NotificationAreaImage = new System.Windows.Forms.PictureBox();
            this.NotificationAreaToggle = new System.Windows.Forms.CheckBox();
            this.tmrShowMonitor = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bgwCheckVersion = new System.ComponentModel.BackgroundWorker();
            this.toolTipSecondary = new System.Windows.Forms.ToolTip(this.components);
            this.ToggleOnSource = new System.Windows.Forms.PictureBox();
            this.ToggleOffSource = new System.Windows.Forms.PictureBox();
            this.pnlCheckBoxes.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            this.VisibilityPanel.SuspendLayout();
            this.AboutPanel.SuspendLayout();
            this.UpdatePanel.SuspendLayout();
            this.ShowOnHoverPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoHideImage)).BeginInit();
            this.pnlSecondary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryImage)).BeginInit();
            this.pnlDateTime.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeImage)).BeginInit();
            this.pnlNotifArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationAreaImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOnSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOffSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCheckBoxes
            // 
            this.pnlCheckBoxes.AutoScroll = true;
            this.pnlCheckBoxes.Controls.Add(this.ExitPanel);
            this.pnlCheckBoxes.Controls.Add(this.VisibilityPanel);
            this.pnlCheckBoxes.Controls.Add(this.AboutPanel);
            this.pnlCheckBoxes.Controls.Add(this.UpdatePanel);
            this.pnlCheckBoxes.Controls.Add(this.ShowOnHoverPanel);
            this.pnlCheckBoxes.Controls.Add(this.pnlNotifArea);
            this.pnlCheckBoxes.Controls.Add(this.pnlDateTime);
            this.pnlCheckBoxes.Controls.Add(this.pnlSecondary);
            this.pnlCheckBoxes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCheckBoxes.Location = new System.Drawing.Point(0, 0);
            this.pnlCheckBoxes.Name = "pnlCheckBoxes";
            this.pnlCheckBoxes.Size = new System.Drawing.Size(923, 734);
            this.pnlCheckBoxes.TabIndex = 5;
            // 
            // ExitPanel
            // 
            this.ExitPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ExitPanel.Controls.Add(this.label21);
            this.ExitPanel.Controls.Add(this.label22);
            this.ExitPanel.Controls.Add(this.ExitText);
            this.ExitPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ExitPanel.Location = new System.Drawing.Point(10, 640);
            this.ExitPanel.Margin = new System.Windows.Forms.Padding(10);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(901, 84);
            this.ExitPanel.TabIndex = 20;
            this.ExitPanel.Click += new System.EventHandler(this.panel3_Click);
            this.ExitPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ExitPanel_Paint);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(53, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(180, 17);
            this.label21.TabIndex = 19;
            this.label21.Text = "Leave the joy that is this app?";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(9, 21);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(44, 32);
            this.label22.TabIndex = 17;
            this.label22.Text = "";
            // 
            // ExitText
            // 
            this.ExitText.BackColor = System.Drawing.Color.Transparent;
            this.ExitText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitText.Location = new System.Drawing.Point(49, 19);
            this.ExitText.Name = "ExitText";
            this.ExitText.Size = new System.Drawing.Size(194, 29);
            this.ExitText.TabIndex = 16;
            this.ExitText.Text = "Exit";
            this.ExitText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // VisibilityPanel
            // 
            this.VisibilityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VisibilityPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.VisibilityPanel.Controls.Add(this.label20);
            this.VisibilityPanel.Controls.Add(this.label18);
            this.VisibilityPanel.Controls.Add(this.label19);
            this.VisibilityPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VisibilityPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.VisibilityPanel.Location = new System.Drawing.Point(10, 550);
            this.VisibilityPanel.Margin = new System.Windows.Forms.Padding(10);
            this.VisibilityPanel.Name = "VisibilityPanel";
            this.VisibilityPanel.Size = new System.Drawing.Size(901, 84);
            this.VisibilityPanel.TabIndex = 13;
            this.VisibilityPanel.Click += new System.EventHandler(this.panel2_Click);
            this.VisibilityPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(49, 19);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(194, 29);
            this.label20.TabIndex = 16;
            this.label20.Text = "Toggle Visibility";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(53, 50);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(88, 17);
            this.label18.TabIndex = 19;
            this.label18.Text = "Instant toggle";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(9, 21);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(50, 37);
            this.label19.TabIndex = 17;
            this.label19.Text = "";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // AboutPanel
            // 
            this.AboutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.AboutPanel.Controls.Add(this.label17);
            this.AboutPanel.Controls.Add(this.label2);
            this.AboutPanel.Controls.Add(this.label14);
            this.AboutPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.AboutPanel.Location = new System.Drawing.Point(10, 460);
            this.AboutPanel.Margin = new System.Windows.Forms.Padding(10);
            this.AboutPanel.Name = "AboutPanel";
            this.AboutPanel.Size = new System.Drawing.Size(901, 84);
            this.AboutPanel.TabIndex = 12;
            this.AboutPanel.Click += new System.EventHandler(this.panel1_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(53, 50);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(147, 17);
            this.label17.TabIndex = 19;
            this.label17.Text = "Find out about this app.";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 32);
            this.label2.TabIndex = 17;
            this.label2.Text = "";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(49, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(194, 29);
            this.label14.TabIndex = 16;
            this.label14.Text = "About";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // UpdatePanel
            // 
            this.UpdatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdatePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.UpdatePanel.Controls.Add(this.lnkNewVersion);
            this.UpdatePanel.Controls.Add(this.label15);
            this.UpdatePanel.Controls.Add(this.label16);
            this.UpdatePanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.UpdatePanel.Location = new System.Drawing.Point(10, 370);
            this.UpdatePanel.Margin = new System.Windows.Forms.Padding(10);
            this.UpdatePanel.Name = "UpdatePanel";
            this.UpdatePanel.Size = new System.Drawing.Size(901, 84);
            this.UpdatePanel.TabIndex = 11;
            // 
            // lnkNewVersion
            // 
            this.lnkNewVersion.ActiveLinkColor = System.Drawing.SystemColors.ControlDark;
            this.lnkNewVersion.AutoEllipsis = true;
            this.lnkNewVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkNewVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lnkNewVersion.LinkColor = System.Drawing.SystemColors.ControlLight;
            this.lnkNewVersion.Location = new System.Drawing.Point(53, 48);
            this.lnkNewVersion.Name = "lnkNewVersion";
            this.lnkNewVersion.Size = new System.Drawing.Size(452, 25);
            this.lnkNewVersion.TabIndex = 19;
            this.lnkNewVersion.TabStop = true;
            this.lnkNewVersion.Text = "⚠ New version 2.0.0 available! Click here to download...";
            this.lnkNewVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkNewVersion.Visible = false;
            this.lnkNewVersion.VisitedLinkColor = System.Drawing.Color.Red;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 32);
            this.label15.TabIndex = 17;
            this.label15.Text = "";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(49, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(194, 29);
            this.label16.TabIndex = 16;
            this.label16.Text = "Update this app";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ShowOnHoverPanel
            // 
            this.ShowOnHoverPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowOnHoverPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.ShowOnHoverPanel.Controls.Add(this.AutoHideLabel);
            this.ShowOnHoverPanel.Controls.Add(this.label11);
            this.ShowOnHoverPanel.Controls.Add(this.AutoHideToggle);
            this.ShowOnHoverPanel.Controls.Add(this.label12);
            this.ShowOnHoverPanel.Controls.Add(this.label13);
            this.ShowOnHoverPanel.Controls.Add(this.AutoHideImage);
            this.ShowOnHoverPanel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.ShowOnHoverPanel.Location = new System.Drawing.Point(10, 100);
            this.ShowOnHoverPanel.Margin = new System.Windows.Forms.Padding(10);
            this.ShowOnHoverPanel.Name = "ShowOnHoverPanel";
            this.ShowOnHoverPanel.Size = new System.Drawing.Size(901, 84);
            this.ShowOnHoverPanel.TabIndex = 10;
            // 
            // AutoHideLabel
            // 
            this.AutoHideLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoHideLabel.AutoSize = true;
            this.AutoHideLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoHideLabel.Location = new System.Drawing.Point(790, 43);
            this.AutoHideLabel.Name = "AutoHideLabel";
            this.AutoHideLabel.Size = new System.Drawing.Size(26, 17);
            this.AutoHideLabel.TabIndex = 19;
            this.AutoHideLabel.Text = "Off";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(52, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(355, 17);
            this.label11.TabIndex = 18;
            this.label11.Text = "Show the Clock when hovering in its area, hiding otherwise?";
            // 
            // AutoHideToggle
            // 
            this.AutoHideToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoHideToggle.AutoSize = true;
            this.AutoHideToggle.Location = new System.Drawing.Point(798, 12);
            this.AutoHideToggle.Name = "AutoHideToggle";
            this.AutoHideToggle.Size = new System.Drawing.Size(15, 14);
            this.AutoHideToggle.TabIndex = 9;
            this.AutoHideToggle.UseVisualStyleBackColor = true;
            this.AutoHideToggle.CheckedChanged += new System.EventHandler(this.AutoHideToggle_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 32);
            this.label12.TabIndex = 17;
            this.label12.Text = "";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(49, 19);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 29);
            this.label13.TabIndex = 16;
            this.label13.Text = "Show On Hover";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AutoHideImage
            // 
            this.AutoHideImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AutoHideImage.Location = new System.Drawing.Point(821, 36);
            this.AutoHideImage.Name = "AutoHideImage";
            this.AutoHideImage.Size = new System.Drawing.Size(77, 32);
            this.AutoHideImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AutoHideImage.TabIndex = 12;
            this.AutoHideImage.TabStop = false;
            this.AutoHideImage.Click += new System.EventHandler(this.AutoHideImage_Click);
            // 
            // pnlSecondary
            // 
            this.pnlSecondary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSecondary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlSecondary.Controls.Add(this.SecondaryLabel);
            this.pnlSecondary.Controls.Add(this.label8);
            this.pnlSecondary.Controls.Add(this.label9);
            this.pnlSecondary.Controls.Add(this.label10);
            this.pnlSecondary.Controls.Add(this.SecondaryImage);
            this.pnlSecondary.Controls.Add(this.SecondaryToggle);
            this.pnlSecondary.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlSecondary.Location = new System.Drawing.Point(10, 280);
            this.pnlSecondary.Margin = new System.Windows.Forms.Padding(10);
            this.pnlSecondary.Name = "pnlSecondary";
            this.pnlSecondary.Size = new System.Drawing.Size(901, 84);
            this.pnlSecondary.TabIndex = 9;
            // 
            // SecondaryLabel
            // 
            this.SecondaryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryLabel.AutoSize = true;
            this.SecondaryLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SecondaryLabel.Location = new System.Drawing.Point(790, 33);
            this.SecondaryLabel.Name = "SecondaryLabel";
            this.SecondaryLabel.Size = new System.Drawing.Size(26, 17);
            this.SecondaryLabel.TabIndex = 19;
            this.SecondaryLabel.Text = "Off";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(52, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Hide on other screens?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 37);
            this.label9.TabIndex = 17;
            this.label9.Text = "";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(49, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 29);
            this.label10.TabIndex = 16;
            this.label10.Text = "Secondary Screens";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // SecondaryImage
            // 
            this.SecondaryImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryImage.Location = new System.Drawing.Point(821, 26);
            this.SecondaryImage.Name = "SecondaryImage";
            this.SecondaryImage.Size = new System.Drawing.Size(77, 32);
            this.SecondaryImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SecondaryImage.TabIndex = 12;
            this.SecondaryImage.TabStop = false;
            this.SecondaryImage.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.SecondaryImage_LoadCompleted);
            this.SecondaryImage.Click += new System.EventHandler(this.SecondaryImage_Click);
            // 
            // SecondaryToggle
            // 
            this.SecondaryToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SecondaryToggle.AutoSize = true;
            this.SecondaryToggle.Location = new System.Drawing.Point(798, 10);
            this.SecondaryToggle.Name = "SecondaryToggle";
            this.SecondaryToggle.Size = new System.Drawing.Size(15, 14);
            this.SecondaryToggle.TabIndex = 11;
            this.SecondaryToggle.UseVisualStyleBackColor = true;
            this.SecondaryToggle.CheckedChanged += new System.EventHandler(this.SecondaryToggle_CheckedChanged);
            // 
            // pnlDateTime
            // 
            this.pnlDateTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDateTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlDateTime.Controls.Add(this.DateTimeLabel);
            this.pnlDateTime.Controls.Add(this.label4);
            this.pnlDateTime.Controls.Add(this.label3);
            this.pnlDateTime.Controls.Add(this.DateTimeImage);
            this.pnlDateTime.Controls.Add(this.DateTimeToggle);
            this.pnlDateTime.Controls.Add(this.label1);
            this.pnlDateTime.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlDateTime.Location = new System.Drawing.Point(10, 10);
            this.pnlDateTime.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDateTime.Name = "pnlDateTime";
            this.pnlDateTime.Size = new System.Drawing.Size(901, 83);
            this.pnlDateTime.TabIndex = 9;
            // 
            // DateTimeLabel
            // 
            this.DateTimeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeLabel.AutoSize = true;
            this.DateTimeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeLabel.Location = new System.Drawing.Point(790, 33);
            this.DateTimeLabel.Name = "DateTimeLabel";
            this.DateTimeLabel.Size = new System.Drawing.Size(26, 17);
            this.DateTimeLabel.TabIndex = 17;
            this.DateTimeLabel.Text = "Off";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(320, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Should the date and time be hidden (Always enabled)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 37);
            this.label3.TabIndex = 11;
            this.label3.Text = "🕙";
            // 
            // DateTimeImage
            // 
            this.DateTimeImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeImage.Location = new System.Drawing.Point(821, 26);
            this.DateTimeImage.Name = "DateTimeImage";
            this.DateTimeImage.Size = new System.Drawing.Size(77, 32);
            this.DateTimeImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.DateTimeImage.TabIndex = 10;
            this.DateTimeImage.TabStop = false;
            this.DateTimeImage.Click += new System.EventHandler(this.DateTimeImage_Click);
            // 
            // DateTimeToggle
            // 
            this.DateTimeToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimeToggle.AutoSize = true;
            this.DateTimeToggle.Location = new System.Drawing.Point(798, 7);
            this.DateTimeToggle.Name = "DateTimeToggle";
            this.DateTimeToggle.Size = new System.Drawing.Size(15, 14);
            this.DateTimeToggle.TabIndex = 9;
            this.DateTimeToggle.UseVisualStyleBackColor = true;
            this.DateTimeToggle.CheckedChanged += new System.EventHandler(this.DateTimeToggle_CheckedChanged);
            this.DateTimeToggle.Layout += new System.Windows.Forms.LayoutEventHandler(this.DateTimeToggle_Layout);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date/Time";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlNotifArea
            // 
            this.pnlNotifArea.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNotifArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.pnlNotifArea.Controls.Add(this.label23);
            this.pnlNotifArea.Controls.Add(this.NotificationAreaLabel);
            this.pnlNotifArea.Controls.Add(this.label5);
            this.pnlNotifArea.Controls.Add(this.label6);
            this.pnlNotifArea.Controls.Add(this.label7);
            this.pnlNotifArea.Controls.Add(this.NotificationAreaImage);
            this.pnlNotifArea.Controls.Add(this.NotificationAreaToggle);
            this.pnlNotifArea.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.pnlNotifArea.Location = new System.Drawing.Point(10, 190);
            this.pnlNotifArea.Margin = new System.Windows.Forms.Padding(10);
            this.pnlNotifArea.Name = "pnlNotifArea";
            this.pnlNotifArea.Size = new System.Drawing.Size(901, 84);
            this.pnlNotifArea.TabIndex = 8;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(10, 29);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(44, 32);
            this.label23.TabIndex = 18;
            this.label23.Text = "";
            // 
            // NotificationAreaLabel
            // 
            this.NotificationAreaLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationAreaLabel.AutoSize = true;
            this.NotificationAreaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotificationAreaLabel.Location = new System.Drawing.Point(790, 36);
            this.NotificationAreaLabel.Name = "NotificationAreaLabel";
            this.NotificationAreaLabel.Size = new System.Drawing.Size(26, 17);
            this.NotificationAreaLabel.TabIndex = 16;
            this.NotificationAreaLabel.Text = "Off";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(52, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Show That notification Area?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Notification Area";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // NotificationAreaImage
            // 
            this.NotificationAreaImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationAreaImage.Location = new System.Drawing.Point(821, 29);
            this.NotificationAreaImage.Name = "NotificationAreaImage";
            this.NotificationAreaImage.Size = new System.Drawing.Size(77, 32);
            this.NotificationAreaImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.NotificationAreaImage.TabIndex = 11;
            this.NotificationAreaImage.TabStop = false;
            this.NotificationAreaImage.Click += new System.EventHandler(this.NotificationAreaImage_Click);
            // 
            // NotificationAreaToggle
            // 
            this.NotificationAreaToggle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NotificationAreaToggle.AutoSize = true;
            this.NotificationAreaToggle.Location = new System.Drawing.Point(798, 12);
            this.NotificationAreaToggle.Name = "NotificationAreaToggle";
            this.NotificationAreaToggle.Size = new System.Drawing.Size(15, 14);
            this.NotificationAreaToggle.TabIndex = 10;
            this.NotificationAreaToggle.UseVisualStyleBackColor = true;
            this.NotificationAreaToggle.CheckedChanged += new System.EventHandler(this.NotificationAreaToggle_CheckedChanged);
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
            // ToggleOnSource
            // 
            this.ToggleOnSource.Image = global::Win11ClockTogglerGUI.Properties.Resources.toggle_on;
            this.ToggleOnSource.Location = new System.Drawing.Point(694, 19);
            this.ToggleOnSource.Name = "ToggleOnSource";
            this.ToggleOnSource.Size = new System.Drawing.Size(100, 50);
            this.ToggleOnSource.TabIndex = 10;
            this.ToggleOnSource.TabStop = false;
            this.ToggleOnSource.Visible = false;
            // 
            // ToggleOffSource
            // 
            this.ToggleOffSource.Image = global::Win11ClockTogglerGUI.Properties.Resources.toggle_off;
            this.ToggleOffSource.Location = new System.Drawing.Point(800, 19);
            this.ToggleOffSource.Name = "ToggleOffSource";
            this.ToggleOffSource.Size = new System.Drawing.Size(100, 50);
            this.ToggleOffSource.TabIndex = 11;
            this.ToggleOffSource.TabStop = false;
            this.ToggleOffSource.Visible = false;
            // 
            // Win11ClockTogglerGUI
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(923, 734);
            this.Controls.Add(this.pnlCheckBoxes);
            this.Controls.Add(this.ToggleOnSource);
            this.Controls.Add(this.ToggleOffSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(608, 587);
            this.Name = "Win11ClockTogglerGUI";
            this.Opacity = 0.99D;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows 11 Date//Time & Notification Area Toggler";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Win11ClockTogglerGUI_FormClosing);
            this.Load += new System.EventHandler(this.Win11ClockTogglerGUI_Load);
            this.pnlCheckBoxes.ResumeLayout(false);
            this.ExitPanel.ResumeLayout(false);
            this.ExitPanel.PerformLayout();
            this.VisibilityPanel.ResumeLayout(false);
            this.VisibilityPanel.PerformLayout();
            this.AboutPanel.ResumeLayout(false);
            this.AboutPanel.PerformLayout();
            this.UpdatePanel.ResumeLayout(false);
            this.UpdatePanel.PerformLayout();
            this.ShowOnHoverPanel.ResumeLayout(false);
            this.ShowOnHoverPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutoHideImage)).EndInit();
            this.pnlSecondary.ResumeLayout(false);
            this.pnlSecondary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SecondaryImage)).EndInit();
            this.pnlDateTime.ResumeLayout(false);
            this.pnlDateTime.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateTimeImage)).EndInit();
            this.pnlNotifArea.ResumeLayout(false);
            this.pnlNotifArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NotificationAreaImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOnSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ToggleOffSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlCheckBoxes;
        private System.Windows.Forms.Timer tmrShowMonitor;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.ComponentModel.BackgroundWorker bgwCheckVersion;
        
        private System.Windows.Forms.Panel pnlNotifArea;
        private System.Windows.Forms.Panel pnlDateTime;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSecondary;
        private System.Windows.Forms.ToolTip toolTipSecondary;
        private System.Windows.Forms.CheckBox AutoHideToggle;
        private System.Windows.Forms.CheckBox SecondaryToggle;
        private System.Windows.Forms.CheckBox DateTimeToggle;
        private System.Windows.Forms.CheckBox NotificationAreaToggle;
        private System.Windows.Forms.PictureBox DateTimeImage;
        private System.Windows.Forms.PictureBox SecondaryImage;
        private System.Windows.Forms.PictureBox NotificationAreaImage;
        private System.Windows.Forms.PictureBox ToggleOnSource;
        private System.Windows.Forms.PictureBox ToggleOffSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label DateTimeLabel;
        private System.Windows.Forms.Label NotificationAreaLabel;
        private System.Windows.Forms.Label SecondaryLabel;
        private System.Windows.Forms.Panel ShowOnHoverPanel;
        private System.Windows.Forms.Label AutoHideLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox AutoHideImage;
        private System.Windows.Forms.Panel UpdatePanel;
        private System.Windows.Forms.LinkLabel lnkNewVersion;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel AboutPanel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel VisibilityPanel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel ExitPanel;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label ExitText;
        private System.Windows.Forms.Label label23;
    }
}