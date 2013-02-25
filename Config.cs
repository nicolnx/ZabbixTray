
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Configuration;
using System.Linq;
using System.Text;
using System.IO;

namespace ZabbixTray
{
    class Config
    {
        #region Private
        private string configDirectory = (
            Environment.OSVersion.Platform == PlatformID.Unix ||
            Environment.OSVersion.Platform == PlatformID.MacOSX
        )
        ? Environment.GetEnvironmentVariable("HOME") + "/.ZabbixTray/"
        : Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%") + "/.ZabbixTray/";
        private string configFile = "ZabbixTray.xml";
        #endregion

        #region ZabbixServerConfig class
        public sealed class ZabbixServerConfig : ConfigurationSection
        {
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

            [ConfigurationProperty("pollInterval", DefaultValue=(int)10, IsRequired = true, IsKey = false)]
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

            [ConfigurationProperty("minPriority", IsRequired = true, IsKey = false)]
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

            [ConfigurationProperty("showAck", IsRequired = true, IsKey = false)]
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

            [ConfigurationProperty("showPopup", IsRequired = true, IsKey = false)]
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

        }
        #endregion

        #region Public
        public Configuration appConfig;
        #endregion

        public Config()
        {
            createConfigFileDir();
            ExeConfigurationFileMap configMap = new ExeConfigurationFileMap();
            configMap.ExeConfigFilename = configDirectory + configFile;
            appConfig = ConfigurationManager.OpenMappedExeConfiguration(configMap, ConfigurationUserLevel.None);
            saveConfig();
        }

        public void createConfigFileDir()
        {
            if (!Directory.Exists(configDirectory))
                Directory.CreateDirectory(configDirectory);
        }

        public void saveConfig()
        {
            appConfig.Save();
        }

        public ZabbixServerConfig getZabbixServerConfig()
        {
            ZabbixServerConfig zabbixServerConfig = (ZabbixServerConfig)appConfig.Sections.Get("ZabbixServer");
            return zabbixServerConfig;
        }

    }
}
