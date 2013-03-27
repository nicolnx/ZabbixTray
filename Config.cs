
using System;
using System.IO;
using System.Data;
using System.Linq;
using System.Text;
using System.Resources;
using System.Configuration;
using System.Security.Cryptography;
using System.Collections;
using System.Collections.Generic;

namespace ZabbixTray
{
    class Config
    {
        #region Private Properties

        private static string configDirectoryName = ".ZabbixTray";
        private static string configFileName = "zabbixtray.conf.xml";

        public static string[] iconResNames = {
            "ZabbixTray.Resources.Icons.icon_off.ico",
            "ZabbixTray.Resources.Icons.icon_information.ico",
            "ZabbixTray.Resources.Icons.icon_warning.ico",
            "ZabbixTray.Resources.Icons.icon_average.ico",
            "ZabbixTray.Resources.Icons.icon_high.ico",
            "ZabbixTray.Resources.Icons.icon_disaster.ico",
            "ZabbixTray.Resources.Icons.icon_normal.ico",
        };
        public static Hashtable priorityValues = new Hashtable() 
        { 
            {1, "Information"},
            {2, "Warning"},
            {3, "Average"},
            {4, "High"},
            {5, "Disaster"}
        };
        public static Hashtable priorityColors = new Hashtable() 
        { 
            {0,"cecece"},
            {1,"bbe2bb"},
            {2,"efefcc"},
            {3,"ddaaaa"},
            {4,"ff8888"},
            {5,"ff0000"},
            {6,"aaffaa"}
        };
        public static Hashtable statusIcons = new Hashtable() 
        { 
            {"OK", Properties.Resources.zabbix_icon_48_green},
            {"BAD", Properties.Resources.zabbix_icon_48_red},
            {"UNKN", Properties.Resources.zabbix_icon_48_grey},
        };

        public static int defaultPriorityKey = 0;
        public static string defaultPriorityValue = "Information";

        public static string defaultAlertSound = "Sounds/warning.wav";

        #endregion

        #region Configuration Classes

        public class ZabbixServerConfigSection : ConfigurationSection
        {
            [ConfigurationProperty("ServersList")]
            public ZabbixServerConfigCollection ServersList
            {
                get { return (ZabbixServerConfigCollection)this["ServersList"]; }
                set { this["ServersList"] = value; }
            }
        }

        public class ZabbixServerConfigCollection : ConfigurationElementCollection
        {

            public void Add(ZabbixServerConfig server)
            {
                BaseAdd(server);
            }

            public void Del(string name)
            {
                this.BaseRemove(name);
            }

            protected override ConfigurationElement CreateNewElement()
            {
                return new ZabbixServerConfig();
            }

            protected override object GetElementKey(ConfigurationElement element)
            {
                return ((ZabbixServerConfig)element).Name;
            }
        }

        public class ZabbixServerConfig : ConfigurationElement
        {
            [ConfigurationProperty("enabled", DefaultValue = true, IsRequired = false, IsKey = false)]
            public bool Enabled
            {
                get
                {
                    return (bool)this["enabled"];
                }
                set
                {
                    this["enabled"] = value;
                }
            }

            [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
            public string Name
            {
                get
                {
                    return (string)this["name"];
                }
                set
                {
                    this["name"] = value;
                }
            }

            [ConfigurationProperty("url", IsRequired = true, IsKey = false)]
            public string Url
            {
                get
                {
                    return (string)this["url"];
                }
                set
                {
                    this["url"] = value;
                }
            }

            [ConfigurationProperty("username", IsRequired = true, IsKey = false)]
            public string Username
            {
                get
                {
                    return (string)this["username"];
                }
                set
                {
                    this["username"] = value;
                }
            }

            [ConfigurationProperty("password", IsRequired = true, IsKey = false)]
            public string Password
            {
                get
                {
                    byte[] passwordEncrypted = Convert.FromBase64String((string)this["password"]);
                    byte[] passwordDecrypted = ProtectedData.Unprotect(passwordEncrypted, null, DataProtectionScope.CurrentUser);
                    return (string)System.Text.Encoding.UTF8.GetString(passwordDecrypted);
                }
                set
                {
                    byte[] plaintextPassword = Encoding.UTF8.GetBytes(value);
                    byte[] encryptedPassword = ProtectedData.Protect(plaintextPassword, null, DataProtectionScope.CurrentUser);
                    this["password"] = Convert.ToBase64String(encryptedPassword);
                }
            }

            [ConfigurationProperty("pollInterval", DefaultValue = 10, IsRequired = true, IsKey = false)]
            [IntegerValidator(MinValue = 5, MaxValue = 3600, ExcludeRange = false)]
            public int PollInterval
            {
                get
                {
                    return (int)this["pollInterval"];
                }
                set
                {
                    this["pollInterval"] = value;
                }
            }

            [ConfigurationProperty("minPriority", DefaultValue = 3, IsRequired = true, IsKey = false)]
            public int MinPriority
            {
                get
                {
                    return (int)this["minPriority"];
                }
                set
                {
                    this["minPriority"] = value;
                }
            }

            [ConfigurationProperty("showAck", DefaultValue = true, IsRequired = true, IsKey = false)]
            public bool ShowAck
            {
                get
                {
                    return (bool)this["showAck"];
                }
                set
                {
                    this["showAck"] = value;
                }
            }

            [ConfigurationProperty("showPopup", DefaultValue = true, IsRequired = true, IsKey = false)]
            public bool ShowPopup
            {
                get
                {
                    return (bool)this["showPopup"];
                }
                set
                {
                    this["showPopup"] = value;
                }
            }

            public ZabbixServerConfig(Hashtable Params = null)
            {
                if (Params != null)
                {
                    this.Name = Params["Name"].ToString();
                    this.Url = Params["Url"].ToString();
                    this.Username = Params["Username"].ToString();
                    this.Password = Params["Password"].ToString();
                    this.PollInterval = (int)Params["pollInterval"];
                    this.MinPriority = (int)Params["minPriority"];
                    this.ShowAck = (bool)Params["showAck"];
                    this.ShowPopup = (bool)Params["showPopup"];
                }
            }

        }

        public class NotificationsSettingsSection : ConfigurationSection
        {
            [ConfigurationProperty("Sounds")]
            public NotificationSoundsSettings Sounds
            {
                get { return (NotificationSoundsSettings)this["Sounds"]; }
                set { this["Sounds"] = value; }
            }
        }

        public class NotificationSoundsSettings : ConfigurationElement
        {
            [ConfigurationProperty("WavFile", DefaultValue="Sounds/warning.wav")]
            public string WavFile
            {
                get { return (string)this["WavFile"]; }
                set { this["WavFile"] = value; }
            }
        }

        #endregion

        #region Private Methods

        private static string _getConfigDirectory()
        {
            string homeDirectory;
            PlatformID platform = Environment.OSVersion.Platform;
            if (platform == PlatformID.Unix || platform == PlatformID.MacOSX)
            {
                homeDirectory = Environment.GetEnvironmentVariable("HOME");
            }
            else
            {
                homeDirectory = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            }
            return (String.Format("{0}/{1}/", homeDirectory, configDirectoryName));
        }

        private static Configuration _getAppConfig()
        {
            string configDirectory = _getConfigDirectory();
            if (!Directory.Exists(configDirectory))
            {
                Directory.CreateDirectory(configDirectory);
            }
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = _getConfigDirectory() + configFileName;
            Configuration appConfig = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            return appConfig;
        }

        #endregion

        #region Public Methods

        public static int getPriorityKey(string val)
        {
            if (priorityValues.ContainsValue(val))
            {
                IDictionaryEnumerator ide = priorityValues.GetEnumerator();
                while (ide.MoveNext())
                {
                    if (ide.Value.Equals(val))
                    {
                        return Int32.Parse(ide.Key.ToString());
                    }
                }
            }
            return defaultPriorityKey;
        }

        public static string getPriorityValue(int key)
        {
            if (priorityValues.ContainsKey(key))
            {
                return priorityValues[key].ToString();
            }
            else
            {
                return defaultPriorityValue;
            }
        }

        public static ZabbixServerConfigCollection getZabbixServersList()
        {
            Configuration appConfig = _getAppConfig();
            ZabbixServerConfigCollection zabbixServersList = null;
            ZabbixServerConfigSection ZabbixServers = (ZabbixServerConfigSection)appConfig.Sections.Get("ZabbixServers");
            if (ZabbixServers != null)
            {
                zabbixServersList = ZabbixServers.ServersList;
                
            }
            return zabbixServersList;
        }

        public static ZabbixServerConfig getServerSettings(string name)
        {
            if (name != null)
            {
                ZabbixServerConfigCollection serversList = getZabbixServersList();
                foreach (ZabbixServerConfig z in serversList)
                {
                    if (z.Name == name)
                    {
                        return z;
                    }
                }
            }
            return null;
        }

        private static NotificationsSettingsSection getNotificationSettings()
        {
            Configuration appConfig = _getAppConfig();
            NotificationsSettingsSection notificationSettings = null;
            notificationSettings = (NotificationsSettingsSection)appConfig.Sections.Get("NotificationSettings");
            if (notificationSettings == null)
            {
                notificationSettings = new NotificationsSettingsSection();
                NotificationSoundsSettings settings = new NotificationSoundsSettings();
                notificationSettings.Sounds = settings;
            }
            return notificationSettings;
        }

        public static string getNotifyWavPath()
        {
            string path = null;
            NotificationsSettingsSection notifySection = getNotificationSettings();
            path = notifySection.Sounds.WavFile;
            if (!System.IO.Path.IsPathRooted(path))
            {
#if DEBUG
                path = Path.GetFullPath("../../Resources/" + path);
#else
            path = Path.GetFullPath(path);
#endif
            }
            return path;
        }

        public static void updateServerConfigs(ZabbixServerConfigCollection zabbixServersList)
        {
            Configuration appConfig = _getAppConfig();
            ZabbixServerConfigSection newSection = new ZabbixServerConfigSection();
            newSection.ServersList = zabbixServersList;
            appConfig.Sections.Remove("ZabbixServers");
            appConfig.Sections.Add("ZabbixServers", newSection);
            appConfig.Save();
        }

        public static void updateNotificationPath(string newpath)
        {
            NotificationsSettingsSection newSection = new NotificationsSettingsSection();
            newSection.Sounds.WavFile = newpath;
            Configuration appConfig = _getAppConfig();
            appConfig.Sections.Remove("NotificationSettings");
            appConfig.Sections.Add("NotificationSettings", newSection);
            appConfig.Save();
        }

        public static void addNewServerConfig(Hashtable Params)
        {
            ZabbixServerConfigCollection zabbixServersList = getZabbixServersList();
            if (zabbixServersList == null)
            {
                zabbixServersList = new ZabbixServerConfigCollection();
            }
            zabbixServersList.Add(new ZabbixServerConfig(Params));
            updateServerConfigs(zabbixServersList);
        }

        public static void removeServerConfig(string name)
        {
            ZabbixServerConfigCollection zabbixServersList = getZabbixServersList();
            zabbixServersList.Del(name);
            updateServerConfigs(zabbixServersList);
        }

        public static void editServerConfig(string name, Hashtable Params)
        {
            removeServerConfig(name);
            addNewServerConfig(Params);
        }

        #endregion

    }
}
