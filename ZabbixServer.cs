
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Zabbix;

namespace ZabbixTray
{
    public class ZabbixServer
    {
        #region Properties

        public string name;
        public string apiURL;
        public string apiUsername;
        public string apiPassword;

        public int checkInterval = 10;
        public int minPriority = 3;

        public bool showAck = true;
        public bool showPopup = true;
        public bool enabled = true;

        public ZabbixAPI zApi;

        #endregion

        #region Methods

        public ZabbixServer(Hashtable options)
        {
            this.name = options["name"].ToString();
            this.apiURL = options["apiURL"].ToString();
            this.apiUsername = options["username"].ToString();
            this.apiPassword = options["password"].ToString();
            this.zApi = new ZabbixAPI(this.apiURL, this.apiUsername, this.apiPassword, this.name);
            if (zApi != null)
            {
                if(options["minPriority"] != null)
                    zApi.setMinSeverity(options["minPriority"].ToString());
                if(options["pollInterval"] != null)
                    zApi.setInterval(Convert.ToInt16(options["pollInterval"]));
                if(options["showAck"] != null)
                    zApi.setHideAck(Convert.ToInt16(options["showAck"]));
                zApi.connect();
            }
        }

        public void Disconnect()
        {
            if (zApi != null)
            {
                zApi.stop();
            }
        }

        #endregion
    }
}
