﻿
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZabbixTray
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
