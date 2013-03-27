
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Resources;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using Zabbix;

namespace ZabbixTray
{
    delegate void anonymous();

    public partial class frmMain : Form
    {

        #region Private Properties

        private int numAlerts = 0;
        private int highestPriority = 0;
        private Config Configuration = new Config();
        private List<ZabbixServer> zabbixServersList = new List<ZabbixServer>();

        private DataTable dtTriggers = new DataTable();
        private static BindingSource bsTriggers = new BindingSource();
        private DataGridViewCellStyle[] cellStyles = new DataGridViewCellStyle[6];

        private int alertCheckInterval = 30;
        private static System.Windows.Forms.Timer alertsTimer = new System.Windows.Forms.Timer();
        private SoundPlayer player = new SoundPlayer();
        private bool nowPlaying = false;
        string notifyWavPath = Config.getNotifyWavPath();

        #endregion

        #region Public Properties


        #endregion

        #region Public Methods

        public frmMain()
        {
            InitializeComponent();
        }

        public void loadSettings()
        {
            Config.ZabbixServerConfigCollection zabbixServersList = Config.getZabbixServersList();

            if (zabbixServersList == null)
            {
                frmServersList fs = new frmServersList(this);
                System.Windows.Forms.DialogResult result = MessageBox.Show(this,
                    "You need to add at least one Zabbix Server",
                    "No Zabbix Server configured", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                if (result == DialogResult.OK)
                {
                    fs.ShowDialog(this);
                    return;
                }
                myExit();
                return;
            }

            foreach (Config.ZabbixServerConfig Z in zabbixServersList)
            {
                Hashtable options = new Hashtable()
                {
                    {"name", Z.Name}, {"apiURL", Z.Url},
                    {"username", Z.Username}, {"password", Z.Password},
                    {"minPrioirty", Z.MinPriority}, {"pollInterval", Z.PollInterval},
                    {"showAck", Z.ShowAck}
                };

                ZabbixServer ZS = new ZabbixServer(options);
                if (ZS != null)
                {
                    this.zabbixServersList.Add(ZS);
                }
            }

            this.notifyWavPath = Config.getNotifyWavPath();

        }

        public void Reload()
        {
            stopServersPolling();
            loadSettings();
            startServersPolling();
        }

        public Color priorityToColor(int p)
        {
            Int32 ir, ig, ib;
            String colorString = Config.priorityColors[p].ToString();
            ir = Int32.Parse(colorString.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
            ig = Int32.Parse(colorString.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
            ib = Int32.Parse(colorString.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);
            return Color.FromArgb(ir, ig, ib);
        }

        public void logEvent(string m)
        {
            string dateTime = DateTime.Now.ToString("dd-MM-yy h:mm:ss");
            string debugMsg = String.Format("{0} {1}\r\n", dateTime, m);
            tbDebug.AppendText(debugMsg);
            tbDebug.SelectionStart = tbDebug.Text.Length;
            tbDebug.ScrollToCaret();
        }

        #endregion

        #region Private Methods

        private void frmMain_Load(object sender, EventArgs e)
        {
            setIcons(0);
            setStyles();
            Reload();
        }

        private void startServersPolling()
        {
            if (this.zabbixServersList != null)
            {
                for (int i = 0; i < this.zabbixServersList.Count; i++)
                {
                    zabbixServersList[i].zApi.onUpdate += updateInfo;
                }
            }
            startAlertsPolling();
        }

        private void stopServersPolling()
        {
            if (this.zabbixServersList != null)
            {
                for (int i = 0; i < this.zabbixServersList.Count; i++)
                {
                    zabbixServersList[i].zApi.stop();
                }
            }
        }

        private void startAlertsPolling()
        {
            alertsTimer.Tick += new EventHandler(checkAlerts);
            alertsTimer.Interval = this.alertCheckInterval * 1000;
            alertsTimer.Start();
        }

        private void checkAlerts(Object state, EventArgs args)
        {
            if (!this.nowPlaying)
            {
                
                alertsTimer.Stop();
                if (numAlerts > 0)
                {
                    playAlert();
                    showBalloon();
                    setIcons(highestPriority);
                }
                else
                {
                    setIcons(6);
                }
                alertsTimer.Start();                
            }
        }

        private void setStyles()
        {
            if (dtTriggers.Columns.Count == 0)
            {
                dtTriggers.Columns.Add("Server", typeof(string));
                dtTriggers.Columns.Add("Host", typeof(string));
                dtTriggers.Columns.Add("ID", typeof(string));
                dtTriggers.Columns.Add("Issue", typeof(string));
                dtTriggers.Columns.Add("Priority", typeof(string));
                dtTriggers.Columns.Add("Last Change", typeof(DateTime));
            }
            for (int i = 1; i < 6; i++)
            {
                cellStyles[i] = new DataGridViewCellStyle();
                cellStyles[i].BackColor = priorityToColor(i);
            }
        }

        private void frmMain_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                minimizeMe();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                minimizeMe();
            }
        }

        private void restoreMe()
        {
            Show();
            WindowState = FormWindowState.Normal;
            tsmiRestore.Visible = false;
            tsmiMinimize.Visible = true;
        }

        private void minimizeMe()
        {
            Hide();
            WindowState = FormWindowState.Minimized;
            tsmiRestore.Visible = true;
            tsmiMinimize.Visible = false;
        }

        private void myExit()
        {
            stopServersPolling();
            Application.Exit();
        }

        private void setIcons(int p)
        {
            string strName = Config.iconResNames[p];
            System.Reflection.Assembly Assembly = System.Reflection.Assembly.GetExecutingAssembly();
            systemTrayIcon.Icon = new Icon(Assembly.GetManifestResourceStream(strName));
            this.Icon = systemTrayIcon.Icon;
        }

        private void updateAlerts(ZabbixAPI zApi)
        {
            if (zApi != null)
            {
                string serverName = zApi.getConnectionParams().serverName;

                // check if we have some triggers that aren't active anymore

                List<DataRow> itemsToRemove = new List<DataRow>();
                foreach (DataRow row in dtTriggers.Rows)
                {
                    string rowServerName = row[0].ToString();
                    string rowHostName = row[1].ToString();
                    if (rowServerName == serverName)
                    {
                        bool rowExpired = true;
                        string triggerId = row[2].ToString();
                        foreach (Trigger tr in zApi.triggers)
                        {
                            if (tr.triggerid == triggerId)
                            {
                                rowExpired = false;
                                break;
                            }
                        }
                        if (rowExpired)
                        {
                            logEvent(String.Format("Alert disappear on {0}", rowHostName));
                            itemsToRemove.Add(row);
                        }
                    }
                }
                foreach (DataRow removeItem in itemsToRemove)
                {
                    lock (dtTriggers)
                    {                        
                        dtTriggers.Rows.Remove(removeItem);
                    }
                }

                // check if we need to add some rows to table

                foreach (Trigger tr in zApi.triggers)
                {
                    bool triggerIsNew = true;
                    string triggerid = tr.triggerid;
                    foreach (DataRow row in dtTriggers.Rows)
                    {
                        string rowServerName = row[0].ToString();
                        string rowTriggerId = row[2].ToString();
                        if (rowServerName == serverName && rowTriggerId == triggerid)
                        {
                            triggerIsNew = false;
                            break;
                        }
                    }
                    if (triggerIsNew)
                    {
                        string host = "UNKN HOST";
                        if (tr.host != null)
                        {
                            host = tr.host.ToString();
                        }
                        string issue = tr.description;
                        string priority = Config.priorityValues[Int32.Parse(tr.priority)].ToString();
                        DateTime lastchange = tr.lastchangeDateTime;
                        string value = tr.value;
                        string id = tr.triggerid;
                        lock (dtTriggers)
                        {
                            logEvent(String.Format("Alert at {0}: {1}", host, issue));
                            dtTriggers.Rows.Add(serverName, host, id, issue, priority, lastchange);
                        }
                    }
                }
            }

            if (dtTriggers == null || dtTriggers.Rows.Count == 0)
            {
                setIcons(0);
                numAlerts = 0;
            }
            else
            {
                dgvTriggers.AutoSize = true;
                bsTriggers.DataSource = dtTriggers;
                dgvTriggers.DataSource = bsTriggers;
                for (int i = 0; i <= 5; i++)
                {
                    dgvTriggers.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvTriggers.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvTriggers.ClearSelection();

                lock (dgvTriggers)
                {
                    numAlerts = dgvTriggers.RowCount;
                }

                for (int i = 0; i < numAlerts; i++)
                {
                    try
                    {
                        int p = Config.getPriorityKey(dgvTriggers.Rows[i].Cells["Priority"].Value.ToString());
                        if (p > highestPriority) { highestPriority = p; }
                        dgvTriggers.Rows[i].DefaultCellStyle = cellStyles[p];
                    }
                    catch (Exception ex)
                    {
                        logEvent(ex.Message);
                    }

                }
            }
            checkAlerts(null, null);
        }

        private void updateInfo(UpdateInfoMessage info)
        {
            if (!this.IsDisposed)
            {
                switch (info.status)
                {
                    case "OK":
                        this.Invoke(new anonymous(() =>
                        {
                            tssMessage.Text = info.message;
                            this.Cursor = Cursors.Arrow;
                        }));
                        break;
                    case "DEBUG":
                        this.Invoke(new anonymous(() =>
                        {
                            logEvent(info.message);
                        }));
                        break;
                    case "TRIGGERS":
                        this.Invoke(new anonymous(() =>
                        {
                            long ticks = long.Parse(info.message);
                            double ms = ticks / 10000;
                            updateAlerts((ZabbixAPI)info.sender);
                        }));
                        break;
                    case "HOSTS":
                        this.Invoke(new anonymous(() =>
                        {
                            long ticks = long.Parse(info.message);
                            double ms = ticks / 10000;
                        }));
                        break;
                    case "REFRESH":
                        break;
                    default:
                        this.Invoke(new anonymous(() =>
                        {
                            if (info.message != null && info.message.Length > 0)
                            {
                                tssMessage.Text = info.message;
                                logEvent(info.message);
                            }
                        }));
                        break;
                }
            }
        }

        #endregion

        #region Interface Callbacks

        #region Application Menu

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            myExit();
        }

        private void goToProjectWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://github.com/nicolnx/ZabbixTray");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout fa = new frmAbout();
            fa.ShowDialog(this);
        }

        private void tsmiServers_Click(object sender, EventArgs e)
        {
            frmServersList fs = new frmServersList(this);
            fs.ShowDialog(this);
        }

        private void tsmiMinimize_Click(object sender, EventArgs e)
        {
            minimizeMe();
        }

        private void ExitApplication_Click(object sender, EventArgs e)
        {
            myExit();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            restoreMe();
        }

        #endregion

        #region Context Menus

        private void clearEventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbDebug.Clear();
        }

        #endregion

        #region System Tray

        private void SystemTrayIcon_Click(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                if (this.WindowState == FormWindowState.Minimized)
                {
                    restoreMe();
                }
                else
                {
                    minimizeMe();
                }
            }
        }

        private void cmsSystemTrayIcon_DoubleClick(object sender, EventArgs e)
        {
            restoreMe();
        }

        private void SystemTrayIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            restoreMe();
        }

        private void showBalloon()
        {
            string title = String.Format("Zabbix Notification");
            string message = String.Format("Attention needed on {0} alerts", numAlerts);
            systemTrayIcon.BalloonTipIcon = ToolTipIcon.Warning;
            systemTrayIcon.BalloonTipTitle = title;
            systemTrayIcon.BalloonTipText = message;
            systemTrayIcon.ShowBalloonTip(30000);
        }

        private void playAlert()
        {
            if (nowPlaying == false && this.enableSoundsToolStripMenuItem.Checked)
            {
                nowPlaying = true;
                try
                {
                    nowPlaying = true;
                    ThreadPool.QueueUserWorkItem(ignoredState =>
                    {
                        player.SoundLocation = this.notifyWavPath;
                        player.PlaySync();
                        nowPlaying = false;                        
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        this,
                        ex.Message, "Alert playback problem",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation,
                        MessageBoxDefaultButton.Button1
                    );
                    nowPlaying = false;
                }
            }
        }

        #endregion

        private void notifySettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNotifySettings ns = new frmNotifySettings(this);
            ns.ShowDialog();
        }

        #endregion

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbDebug.SelectAll();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbDebug.Copy();
        }

    }
}
