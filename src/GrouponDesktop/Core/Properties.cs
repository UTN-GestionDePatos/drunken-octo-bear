using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;

namespace GrouponDesktop.Core
{
    class Properties
    {
        private static Dictionary<String, String> properties = new Dictionary<String, String>();

        public Properties(String filePath)
        {
            this.loadProperties(filePath);
        }
        
        public void loadProperties(String path)
        {
            foreach(String line in File.ReadAllLines(path)){
                if(line.StartsWith("#")) continue;
                properties.Add(line.Substring(0, line.IndexOf("=")).Trim(), line.Substring(line.IndexOf("=")+1).Trim());
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
