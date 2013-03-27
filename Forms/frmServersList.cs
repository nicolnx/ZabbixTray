
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Zabbix;

namespace ZabbixTray
{
    public partial class frmServersList : Form
    {

        private frmMain parentForm;
        private Config.ZabbixServerConfigCollection zabbixServerList;
        private static BindingSource bsZabbixServers = new BindingSource();
        private DataTable zabbixServersTable = new DataTable();

        public frmServersList(frmMain frm)
        {
            InitializeComponent();
            parentForm = frm;

            zabbixServersTable.Columns.Add("On", typeof(bool));
            zabbixServersTable.Columns.Add("Server Name", typeof(string));
            zabbixServersTable.Columns.Add("URL", typeof(string));

            initServersList();
        }

        public void initServersList()
        {
            zabbixServersTable.Clear();
            zabbixServerList = Config.getZabbixServersList();
            if (zabbixServerList != null)
            {
                foreach (Config.ZabbixServerConfig Z in zabbixServerList)
                {
                    DataRow row = zabbixServersTable.NewRow();
                    row["On"] = Z.Enabled;
                    row["Server Name"] = Z.Name;
                    row["URL"] = Z.Url;
                    zabbixServersTable.Rows.Add(row);
                }
                bsZabbixServers.DataSource = zabbixServersTable;
                dgvZabbixServers.DataSource = bsZabbixServers;
                dgvZabbixServers.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                dgvZabbixServers.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvZabbixServers.ClearSelection();
                if (zabbixServersTable.Rows.Count > 0)
                {
                    btn_Edit.Enabled = true;
                    btn_Remove.Enabled = true;
                }
            }
        }

        private void btnAddZabbixServer_Click(object sender, EventArgs e)
        {
            frmZabbixServer fo = new frmZabbixServer(this);
            fo.ShowDialog(this);
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            DataGridViewCellCollection selectedRowCells = dgvZabbixServers.SelectedRows[0].Cells;
            string serverName = selectedRowCells[1].Value.ToString();
            frmZabbixServer frmZabbixServer = new frmZabbixServer(this, serverName);
            frmZabbixServer.ShowDialog();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string name = dgvZabbixServers.CurrentRow.Cells[1].Value.ToString();
            if (MessageBox.Show(String.Format("Delete {0} server?", name), "Confirm delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Config.removeServerConfig(name);
                initServersList();
            }
        }

        private void btnZSClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            parentForm.Reload();            
        }

        private void frmServersList_Closing(object sender, EventArgs e)
        {
            this.Dispose();
            parentForm.Reload();
        }
    }
}
