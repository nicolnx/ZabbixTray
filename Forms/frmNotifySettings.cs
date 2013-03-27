
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using Zabbix;

namespace ZabbixTray
{
    public partial class frmNotifySettings : Form
    {
        frmMain parentForm;
        string wavFile = Config.getNotifyWavPath();

        public frmNotifySettings(frmMain parentForm)
        {
            InitializeComponent();
            this.tbWavFileName.Text = wavFile;
            this.parentForm = parentForm;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (dlgOpenWavFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Stream wavStream = dlgOpenWavFile.OpenFile();
                    if (wavStream != null)
                    {                        
                        this.tbWavFileName.Text = dlgOpenWavFile.FileName;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string wavFileName = tbWavFileName.Text;
            FileStream wavFile = null;
            try
            {
                wavFile = File.OpenRead(wavFileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                if (wavFile != null)
                {
                    wavFile.Close();
                    Config.updateNotificationPath(Path.GetFullPath(wavFileName));
                    this.parentForm.Reload();
                    this.Dispose();
                }
            }
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
