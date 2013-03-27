
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZabbixTray
{
    public partial class frmZabbixServer : Form
    {
        private frmServersList parentForm;
        private Config.ZabbixServerConfig serverConfig;
        private string serverName;

        public frmZabbixServer(frmServersList frm, string serverName = null)
        {
            parentForm = frm;
            this.serverName = serverName;
            this.serverConfig = Config.getServerSettings(serverName);
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            if (this.serverConfig != null)
            {
                tbName.Text = serverConfig.Name;
                tbURL.Text = serverConfig.Url;
                tbUsername.Text = serverConfig.Username;
                tbPassword.Text = serverConfig.Password;

                cbInterval.SelectedIndex = cbInterval.Items.IndexOf(serverConfig.PollInterval.ToString());
                cbPriority.SelectedIndex = cbPriority.Items.IndexOf(Config.getPriorityValue(serverConfig.MinPriority).ToString());

                cbShowAck.Checked = serverConfig.ShowAck;
                cbShowPopup.Checked = serverConfig.ShowPopup;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Hashtable serverParams = new Hashtable() 
                {                     
                    {"Name", tbName.Text}, {"Url", tbURL.Text},
                    {"Username", tbUsername.Text}, {"Password", tbPassword.Text},
                    {"pollInterval", Int32.Parse(cbInterval.SelectedItem.ToString())},
                    {"minPriority", Config.getPriorityKey(cbPriority.SelectedItem.ToString())},
                    {"showAck", cbShowAck.Checked}, {"showPopup", cbShowPopup.Checked}
                };
            if (serverConfig == null)
            {
                Config.addNewServerConfig(serverParams);                
            }
            else
            {
                Config.editServerConfig(serverName, serverParams);
            }
            parentForm.initServersList();
            this.Dispose();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
