using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace DotNet_Utilities
{
    public class CustomConfigHelper
    {
        public static void SaveDefaultConfig(string key,string value)
        {
            //保存到配置文件
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (configuration.AppSettings.Settings[key] == null)
                configuration.AppSettings.Settings.Add(key, value);
            else
                configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }


        /// <summary>
        /// 打开默认的配置文件.exe.config 
        /// </summary>
        /// <returns></returns>
        public static Configuration GetConfiguration()
        {
            return ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        /// <summary>
        /// 获取指定的配置文件。
        /// </summary>
        /// <param name="configFullPath">配置文件的全名称</param>
        /// <returns></returns>
        public static Configuration GetConfiguration(string configFullPath)
        {
            ExeConfigurationFileMap configFile = new ExeConfigurationFileMap();
            configFile.ExeConfigFilename = configFullPath;
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(configFile, ConfigurationUserLevel.None);
            return config;
        }


    }
}
