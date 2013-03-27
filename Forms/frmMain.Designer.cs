namespace ZabbixTray
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsSystemTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.serversToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serversToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableSoundsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifySettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToProjectWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.cmsEventsLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clearEventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDebugLog = new System.Windows.Forms.GroupBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbAlertDetails = new System.Windows.Forms.GroupBox();
            this.dgvTriggers = new System.Windows.Forms.DataGridView();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cmsSystemTrayIcon.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.cmsEventsLog.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gbDebugLog.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.gbAlertDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriggers)).BeginInit();
            this.SuspendLayout();
            // 
            // systemTrayIcon
            // 
            this.systemTrayIcon.ContextMenuStrip = this.cmsSystemTrayIcon;
            this.systemTrayIcon.Text = "ZabbixTray";
            this.systemTrayIcon.Visible = true;
            this.systemTrayIcon.BalloonTipClicked += new System.EventHandler(this.SystemTrayIcon_BalloonTipClicked);
            this.systemTrayIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SystemTrayIcon_Click);
            // 
            // cmsSystemTrayIcon
            // 
            this.cmsSystemTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRestore,
            this.tsmiMinimize,
            this.toolStripSeparator2,
            this.serversToolStripMenuItem1,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.cmsSystemTrayIcon.Name = "contextMenuStrip1";
            this.cmsSystemTrayIcon.Size = new System.Drawing.Size(121, 104);
            this.cmsSystemTrayIcon.DoubleClick += new System.EventHandler(this.cmsSystemTrayIcon_DoubleClick);
            // 
            // tsmiRestore
            // 
            this.tsmiRestore.Name = "tsmiRestore";
            this.tsmiRestore.Size = new System.Drawing.Size(120, 22);
            this.tsmiRestore.Text = "&Show";
            this.tsmiRestore.Visible = false;
            this.tsmiRestore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // tsmiMinimize
            // 
            this.tsmiMinimize.Name = "tsmiMinimize";
            this.tsmiMinimize.Size = new System.Drawing.Size(120, 22);
            this.tsmiMinimize.Text = "&Hide";
            this.tsmiMinimize.Click += new System.EventHandler(this.tsmiMinimize_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(117, 6);
            // 
            // serversToolStripMenuItem1
            // 
            this.serversToolStripMenuItem1.Name = "serversToolStripMenuItem1";
            this.serversToolStripMenuItem1.Size = new System.Drawing.Size(120, 22);
            this.serversToolStripMenuItem1.Text = "Servers...";
            this.serversToolStripMenuItem1.Click += new System.EventHandler(this.tsmiServers_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(117, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(120, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.notificationsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(624, 24);
            this.mainMenuStrip.TabIndex = 7;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serversToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.toolsToolStripMenuItem.Text = "&Edit";
            // 
            // serversToolStripMenuItem
            // 
            this.serversToolStripMenuItem.Name = "serversToolStripMenuItem";
            this.serversToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.serversToolStripMenuItem.Text = "Zabbix Servers...";
            this.serversToolStripMenuItem.Click += new System.EventHandler(this.tsmiServers_Click);
            // 
            // notificationsToolStripMenuItem
            // 
            this.notificationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableSoundsToolStripMenuItem,
            this.notifySettingsToolStripMenuItem});
            this.notificationsToolStripMenuItem.Name = "notificationsToolStripMenuItem";
            this.notificationsToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.notificationsToolStripMenuItem.Text = "Notifications";
            // 
            // enableSoundsToolStripMenuItem
            // 
            this.enableSoundsToolStripMenuItem.Checked = true;
            this.enableSoundsToolStripMenuItem.CheckOnClick = true;
            this.enableSoundsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enableSoundsToolStripMenuItem.Name = "enableSoundsToolStripMenuItem";
            this.enableSoundsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.enableSoundsToolStripMenuItem.Text = "Enable sounds";
            // 
            // notifySettingsToolStripMenuItem
            // 
            this.notifySettingsToolStripMenuItem.Name = "notifySettingsToolStripMenuItem";
            this.notifySettingsToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.notifySettingsToolStripMenuItem.Text = "Settings...";
            this.notifySettingsToolStripMenuItem.Click += new System.EventHandler(this.notifySettingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToProjectWebsiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // goToProjectWebsiteToolStripMenuItem
            // 
            this.goToProjectWebsiteToolStripMenuItem.Name = "goToProjectWebsiteToolStripMenuItem";
            this.goToProjectWebsiteToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.goToProjectWebsiteToolStripMenuItem.Text = "Go to Project Website";
            this.goToProjectWebsiteToolStripMenuItem.Click += new System.EventHandler(this.goToProjectWebsiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.aboutToolStripMenuItem.Text = "&About Zabbix Tray...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbDebug
            // 
            this.tbDebug.ContextMenuStrip = this.cmsEventsLog;
            this.tbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDebug.Location = new System.Drawing.Point(3, 16);
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.ReadOnly = true;
            this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDebug.Size = new System.Drawing.Size(618, 79);
            this.tbDebug.TabIndex = 5;
            // 
            // cmsEventsLog
            // 
            this.cmsEventsLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.selectAllToolStripMenuItem,
            this.toolStripSeparator3,
            this.clearEventsToolStripMenuItem});
            this.cmsEventsLog.Name = "cmsEventsLog";
            this.cmsEventsLog.Size = new System.Drawing.Size(170, 76);
            // 
            // clearEventsToolStripMenuItem
            // 
            this.clearEventsToolStripMenuItem.Name = "clearEventsToolStripMenuItem";
            this.clearEventsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.clearEventsToolStripMenuItem.Text = "Clear Events";
            this.clearEventsToolStripMenuItem.Click += new System.EventHandler(this.clearEventsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 420);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(624, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tssMessage
            // 
            this.tssMessage.Name = "tssMessage";
            this.tssMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // gbDebugLog
            // 
            this.gbDebugLog.Controls.Add(this.tbDebug);
            this.gbDebugLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbDebugLog.Location = new System.Drawing.Point(0, 298);
            this.gbDebugLog.Name = "gbDebugLog";
            this.gbDebugLog.Size = new System.Drawing.Size(624, 98);
            this.gbDebugLog.TabIndex = 9;
            this.gbDebugLog.TabStop = false;
            this.gbDebugLog.Text = "Events Log";
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.gbAlertDetails);
            this.panelMain.Controls.Add(this.gbDebugLog);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(624, 396);
            this.panelMain.TabIndex = 10;
            // 
            // gbAlertDetails
            // 
            this.gbAlertDetails.AutoSize = true;
            this.gbAlertDetails.Controls.Add(this.dgvTriggers);
            this.gbAlertDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlertDetails.Location = new System.Drawing.Point(0, 0);
            this.gbAlertDetails.Name = "gbAlertDetails";
            this.gbAlertDetails.Size = new System.Drawing.Size(624, 298);
            this.gbAlertDetails.TabIndex = 11;
            this.gbAlertDetails.TabStop = false;
            this.gbAlertDetails.Text = "Alert Details";
            // 
            // dgvTriggers
            // 
            this.dgvTriggers.AllowUserToAddRows = false;
            this.dgvTriggers.AllowUserToDeleteRows = false;
            this.dgvTriggers.AllowUserToResizeRows = false;
            this.dgvTriggers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTriggers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTriggers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTriggers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTriggers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTriggers.Location = new System.Drawing.Point(3, 16);
            this.dgvTriggers.Name = "dgvTriggers";
            this.dgvTriggers.RowHeadersVisible = false;
            this.dgvTriggers.RowTemplate.Height = 24;
            this.dgvTriggers.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dgvTriggers.Size = new System.Drawing.Size(618, 279);
            this.dgvTriggers.TabIndex = 3;
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.copyToolStripMenuItem.Text = "Copy to clipboard";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(166, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.mainMenuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "frmMain";
            this.Text = "ZabbixTray";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.cmsSystemTrayIcon.ResumeLayout(false);
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.cmsEventsLog.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbDebugLog.ResumeLayout(false);
            this.gbDebugLog.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.gbAlertDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTriggers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon systemTrayIcon;
        private System.Windows.Forms.ContextMenuStrip cmsSystemTrayIcon;
        private System.Windows.Forms.ToolStripMenuItem tsmiRestore;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiMinimize;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox tbDebug;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssMessage;
        private System.Windows.Forms.GroupBox gbDebugLog;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbAlertDetails;
        private System.Windows.Forms.DataGridView dgvTriggers;
        private System.Windows.Forms.ContextMenuStrip cmsEventsLog;
        private System.Windows.Forms.ToolStripMenuItem clearEventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serversToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem goToProjectWebsiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableSoundsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notifySettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

