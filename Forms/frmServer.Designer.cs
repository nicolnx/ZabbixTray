namespace ZabbixTray
{
    partial class frmZabbixServer
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
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbShowAck = new System.Windows.Forms.CheckBox();
            this.cbPriority = new System.Windows.Forms.ComboBox();
            this.cbShowPopup = new System.Windows.Forms.CheckBox();
            this.gbNotifyOptions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbAuth = new System.Windows.Forms.GroupBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.gbAPIOptions = new System.Windows.Forms.GroupBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblURLHint = new System.Windows.Forms.Label();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.lblURL = new System.Windows.Forms.Label();
            this.cbInterval = new System.Windows.Forms.ComboBox();
            this.lblInterval = new System.Windows.Forms.Label();
            this.gbNotifyOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbAuth.SuspendLayout();
            this.gbAPIOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(54, 373);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 180;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(185, 373);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 190;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbShowAck
            // 
            this.cbShowAck.AutoSize = true;
            this.cbShowAck.Location = new System.Drawing.Point(10, 42);
            this.cbShowAck.Name = "cbShowAck";
            this.cbShowAck.Size = new System.Drawing.Size(156, 17);
            this.cbShowAck.TabIndex = 160;
            this.cbShowAck.Text = "Show Acknowledged Alerts";
            this.cbShowAck.UseVisualStyleBackColor = true;
            // 
            // cbPriority
            // 
            this.cbPriority.BackColor = System.Drawing.SystemColors.Window;
            this.cbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPriority.FormattingEnabled = true;
            this.cbPriority.Items.AddRange(new object[] {
            "Information",
            "Warning",
            "Average",
            "High",
            "Disaster"});
            this.cbPriority.Location = new System.Drawing.Point(96, 67);
            this.cbPriority.Name = "cbPriority";
            this.cbPriority.Size = new System.Drawing.Size(101, 21);
            this.cbPriority.TabIndex = 170;
            // 
            // cbShowPopup
            // 
            this.cbShowPopup.AutoSize = true;
            this.cbShowPopup.Location = new System.Drawing.Point(10, 19);
            this.cbShowPopup.Name = "cbShowPopup";
            this.cbShowPopup.Size = new System.Drawing.Size(131, 17);
            this.cbShowPopup.TabIndex = 150;
            this.cbShowPopup.Text = "Show Popup for Alerts";
            this.cbShowPopup.UseVisualStyleBackColor = true;
            // 
            // gbNotifyOptions
            // 
            this.gbNotifyOptions.Controls.Add(this.label1);
            this.gbNotifyOptions.Controls.Add(this.cbPriority);
            this.gbNotifyOptions.Controls.Add(this.cbShowAck);
            this.gbNotifyOptions.Controls.Add(this.cbShowPopup);
            this.gbNotifyOptions.Location = new System.Drawing.Point(6, 269);
            this.gbNotifyOptions.Name = "gbNotifyOptions";
            this.gbNotifyOptions.Size = new System.Drawing.Size(304, 98);
            this.gbNotifyOptions.TabIndex = 0;
            this.gbNotifyOptions.TabStop = false;
            this.gbNotifyOptions.Text = "Notifications";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Minimal Severity";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancel);
            this.groupBox1.Controls.Add(this.btnOK);
            this.groupBox1.Controls.Add(this.gbAuth);
            this.groupBox1.Controls.Add(this.gbAPIOptions);
            this.groupBox1.Controls.Add(this.gbNotifyOptions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 406);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // gbAuth
            // 
            this.gbAuth.Controls.Add(this.tbPassword);
            this.gbAuth.Controls.Add(this.lblPassword);
            this.gbAuth.Controls.Add(this.tbUsername);
            this.gbAuth.Controls.Add(this.lblUsername);
            this.gbAuth.Location = new System.Drawing.Point(6, 163);
            this.gbAuth.Name = "gbAuth";
            this.gbAuth.Size = new System.Drawing.Size(304, 100);
            this.gbAuth.TabIndex = 0;
            this.gbAuth.TabStop = false;
            this.gbAuth.Text = "Authentication";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(68, 61);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(201, 20);
            this.tbPassword.TabIndex = 140;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 64);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 23;
            this.lblPassword.Text = "Password";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(68, 32);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(201, 20);
            this.tbUsername.TabIndex = 130;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(7, 35);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(55, 13);
            this.lblUsername.TabIndex = 21;
            this.lblUsername.Text = "Username";
            // 
            // gbAPIOptions
            // 
            this.gbAPIOptions.Controls.Add(this.tbName);
            this.gbAPIOptions.Controls.Add(this.lblName);
            this.gbAPIOptions.Controls.Add(this.lblURLHint);
            this.gbAPIOptions.Controls.Add(this.tbURL);
            this.gbAPIOptions.Controls.Add(this.lblURL);
            this.gbAPIOptions.Controls.Add(this.cbInterval);
            this.gbAPIOptions.Controls.Add(this.lblInterval);
            this.gbAPIOptions.Location = new System.Drawing.Point(6, 12);
            this.gbAPIOptions.Name = "gbAPIOptions";
            this.gbAPIOptions.Size = new System.Drawing.Size(304, 145);
            this.gbAPIOptions.TabIndex = 0;
            this.gbAPIOptions.TabStop = false;
            this.gbAPIOptions.Text = "Server Settings";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(49, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(220, 20);
            this.tbName.TabIndex = 100;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 27);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 27;
            this.lblName.Text = "Name";
            // 
            // lblURLHint
            // 
            this.lblURLHint.AutoSize = true;
            this.lblURLHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblURLHint.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblURLHint.Location = new System.Drawing.Point(45, 81);
            this.lblURLHint.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblURLHint.Name = "lblURLHint";
            this.lblURLHint.Size = new System.Drawing.Size(224, 13);
            this.lblURLHint.TabIndex = 26;
            this.lblURLHint.Text = "example: http://HOSTNAME/api_jsonrpc.php";
            // 
            // tbURL
            // 
            this.tbURL.Location = new System.Drawing.Point(48, 58);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(221, 20);
            this.tbURL.TabIndex = 110;
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(7, 61);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(29, 13);
            this.lblURL.TabIndex = 13;
            this.lblURL.Text = "URL";
            // 
            // cbInterval
            // 
            this.cbInterval.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbInterval.FormattingEnabled = true;
            this.cbInterval.Items.AddRange(new object[] {
            "5",
            "10",
            "30",
            "60",
            "90",
            "120",
            "300",
            "600"});
            this.cbInterval.Location = new System.Drawing.Point(89, 106);
            this.cbInterval.Name = "cbInterval";
            this.cbInterval.Size = new System.Drawing.Size(73, 21);
            this.cbInterval.TabIndex = 120;
            // 
            // lblInterval
            // 
            this.lblInterval.AutoSize = true;
            this.lblInterval.Location = new System.Drawing.Point(7, 109);
            this.lblInterval.Name = "lblInterval";
            this.lblInterval.Size = new System.Drawing.Size(76, 13);
            this.lblInterval.TabIndex = 8;
            this.lblInterval.Text = "Poll Interval (s)";
            // 
            // frmZabbixServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 406);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmZabbixServer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zabbix Server Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.gbNotifyOptions.ResumeLayout(false);
            this.gbNotifyOptions.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.gbAuth.ResumeLayout(false);
            this.gbAuth.PerformLayout();
            this.gbAPIOptions.ResumeLayout(false);
            this.gbAPIOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.CheckBox cbShowAck;
        private System.Windows.Forms.ComboBox cbPriority;
        private System.Windows.Forms.CheckBox cbShowPopup;
        private System.Windows.Forms.GroupBox gbNotifyOptions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbAuth;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.GroupBox gbAPIOptions;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblURLHint;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.ComboBox cbInterval;
        private System.Windows.Forms.Label lblInterval;
    }
}