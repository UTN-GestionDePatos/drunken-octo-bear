using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Configuration;

namespace GrouponDesktop.Core
{
    class Properties
    {
        private static Dictionary<String, String> properties = new Dictionary<String, String>();

        public Properties()
        {
            this.loadProperties();
        }
        
        public void loadProperties()
        {
           
            foreach (String key in System.Configuration.ConfigurationSettings.AppSettings.AllKeys) {
                properties.Add(key, System.Configuration.ConfigurationSettings.AppSettings[key]);
            }
        }

        public static String getProperty(String key) {
            return properties[key];
        }

        public void setProperty(String key, String value) {
            properties.Add(key, value);
        }
    }
}
