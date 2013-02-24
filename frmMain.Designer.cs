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
            this.systemTrayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsSystemTrayIcon = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMinimize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbDebug = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tssMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbDebugLog = new System.Windows.Forms.GroupBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.gbAlertDetails = new System.Windows.Forms.GroupBox();
            this.dgvTriggers = new System.Windows.Forms.DataGridView();
            this.cmsSystemTrayIcon.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.systemTrayIcon.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // cmsSystemTrayIcon
            // 
            this.cmsSystemTrayIcon.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiRestore,
            this.tsmiMinimize,
            this.toolStripSeparator2,
            this.tsmiOptions,
            this.toolStripSeparator1,
            this.tsmiExit});
            this.cmsSystemTrayIcon.Name = "contextMenuStrip1";
            this.cmsSystemTrayIcon.Size = new System.Drawing.Size(124, 104);
            this.cmsSystemTrayIcon.DoubleClick += new System.EventHandler(this.cmsSystemTrayIcon_DoubleClick);
            // 
            // tsmiRestore
            // 
            this.tsmiRestore.Name = "tsmiRestore";
            this.tsmiRestore.Size = new System.Drawing.Size(123, 22);
            this.tsmiRestore.Text = "&Restore";
            this.tsmiRestore.Visible = false;
            this.tsmiRestore.Click += new System.EventHandler(this.Restore_Click);
            // 
            // tsmiMinimize
            // 
            this.tsmiMinimize.Name = "tsmiMinimize";
            this.tsmiMinimize.Size = new System.Drawing.Size(123, 22);
            this.tsmiMinimize.Text = "&Minimize";
            this.tsmiMinimize.Click += new System.EventHandler(this.tsmiMinimize_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(120, 6);
            // 
            // tsmiOptions
            // 
            this.tsmiOptions.Name = "tsmiOptions";
            this.tsmiOptions.Size = new System.Drawing.Size(123, 22);
            this.tsmiOptions.Text = "Options";
            this.tsmiOptions.Click += new System.EventHandler(this.tsmiOptions_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(120, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(123, 22);
            this.tsmiExit.Text = "E&xit";
            this.tsmiExit.Click += new System.EventHandler(this.ExitApplication_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(562, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Settings";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tbDebug
            // 
            this.tbDebug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDebug.Location = new System.Drawing.Point(3, 16);
            this.tbDebug.Multiline = true;
            this.tbDebug.Name = "tbDebug";
            this.tbDebug.ReadOnly = true;
            this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDebug.Size = new System.Drawing.Size(556, 79);
            this.tbDebug.TabIndex = 5;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssMessage});
            this.statusStrip1.Location = new System.Drawing.Point(0, 321);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(562, 22);
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
            this.gbDebugLog.Location = new System.Drawing.Point(0, 199);
            this.gbDebugLog.Name = "gbDebugLog";
            this.gbDebugLog.Size = new System.Drawing.Size(562, 98);
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
            this.panelMain.Size = new System.Drawing.Size(562, 297);
            this.panelMain.TabIndex = 10;
            // 
            // gbAlertDetails
            // 
            this.gbAlertDetails.Controls.Add(this.dgvTriggers);
            this.gbAlertDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbAlertDetails.Location = new System.Drawing.Point(0, 0);
            this.gbAlertDetails.Name = "gbAlertDetails";
            this.gbAlertDetails.Size = new System.Drawing.Size(562, 199);
            this.gbAlertDetails.TabIndex = 11;
            this.gbAlertDetails.TabStop = false;
            this.gbAlertDetails.Text = "Alert Details";
            // 
            // dgvTriggers
            // 
            this.dgvTriggers.AllowUserToAddRows = false;
            this.dgvTriggers.AllowUserToDeleteRows = false;
            this.dgvTriggers.AllowUserToResizeRows = false;
            this.dgvTriggers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTriggers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTriggers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvTriggers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTriggers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTriggers.Location = new System.Drawing.Point(3, 16);
            this.dgvTriggers.Name = "dgvTriggers";
            this.dgvTriggers.RowTemplate.Height = 24;
            this.dgvTriggers.Size = new System.Drawing.Size(556, 180);
            this.dgvTriggers.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 343);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "ZabbixTray - NOT CONNECTED";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Resize += new System.EventHandler(this.frmMain_Resize);
            this.cmsSystemTrayIcon.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gbDebugLog.ResumeLayout(false);
            this.gbDebugLog.PerformLayout();
            this.panelMain.ResumeLayout(false);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptions;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TextBox tbDebug;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tssMessage;
        private System.Windows.Forms.GroupBox gbDebugLog;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.GroupBox gbAlertDetails;
        private System.Windows.Forms.DataGridView dgvTriggers;
    }
}

