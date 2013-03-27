namespace ZabbixTray
{
    partial class frmServersList
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
            this.gbZabbixServers = new System.Windows.Forms.GroupBox();
            this.dgvZabbixServers = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btnAddZabbixServer = new System.Windows.Forms.Button();
            this.gbZabbixServers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabbixServers)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbZabbixServers
            // 
            this.gbZabbixServers.Controls.Add(this.dgvZabbixServers);
            this.gbZabbixServers.Controls.Add(this.groupBox1);
            this.gbZabbixServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbZabbixServers.Location = new System.Drawing.Point(0, 0);
            this.gbZabbixServers.Name = "gbZabbixServers";
            this.gbZabbixServers.Size = new System.Drawing.Size(425, 273);
            this.gbZabbixServers.TabIndex = 0;
            this.gbZabbixServers.TabStop = false;
            // 
            // dgvZabbixServers
            // 
            this.dgvZabbixServers.AllowUserToAddRows = false;
            this.dgvZabbixServers.AllowUserToDeleteRows = false;
            this.dgvZabbixServers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvZabbixServers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvZabbixServers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvZabbixServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZabbixServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvZabbixServers.Location = new System.Drawing.Point(3, 16);
            this.dgvZabbixServers.MultiSelect = false;
            this.dgvZabbixServers.Name = "dgvZabbixServers";
            this.dgvZabbixServers.RowHeadersVisible = false;
            this.dgvZabbixServers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZabbixServers.Size = new System.Drawing.Size(419, 207);
            this.dgvZabbixServers.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Edit);
            this.groupBox1.Controls.Add(this.btn_Close);
            this.groupBox1.Controls.Add(this.btn_Remove);
            this.groupBox1.Controls.Add(this.btnAddZabbixServer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 47);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btn_Edit
            // 
            this.btn_Edit.AutoSize = true;
            this.btn_Edit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Edit.Enabled = false;
            this.btn_Edit.Location = new System.Drawing.Point(60, 15);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(44, 23);
            this.btn_Edit.TabIndex = 3;
            this.btn_Edit.Text = "Edit...";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.AutoSize = true;
            this.btn_Close.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Close.Location = new System.Drawing.Point(367, 15);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(43, 23);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.Text = "Close";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btnZSClose_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.AutoSize = true;
            this.btn_Remove.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_Remove.Enabled = false;
            this.btn_Remove.Location = new System.Drawing.Point(110, 15);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(57, 23);
            this.btn_Remove.TabIndex = 1;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btnAddZabbixServer
            // 
            this.btnAddZabbixServer.AutoSize = true;
            this.btnAddZabbixServer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddZabbixServer.Location = new System.Drawing.Point(9, 15);
            this.btnAddZabbixServer.Name = "btnAddZabbixServer";
            this.btnAddZabbixServer.Size = new System.Drawing.Size(45, 23);
            this.btnAddZabbixServer.TabIndex = 0;
            this.btnAddZabbixServer.Text = "Add...";
            this.btnAddZabbixServer.UseVisualStyleBackColor = true;
            this.btnAddZabbixServer.Click += new System.EventHandler(this.btnAddZabbixServer_Click);
            // 
            // frmServersList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 273);
            this.Controls.Add(this.gbZabbixServers);
            this.Name = "frmServersList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zabbix Servers";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServersList_Closing);
            this.gbZabbixServers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZabbixServers)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbZabbixServers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btnAddZabbixServer;
        private System.Windows.Forms.DataGridView dgvZabbixServers;
        private System.Windows.Forms.Button btn_Edit;

    }
}