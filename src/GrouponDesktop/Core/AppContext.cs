using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace GrouponDesktop.Core
{
    public sealed class AppContext
    {
        private static Hashtable appContext = new Hashtable();

        public AppContext()
        {
            this.loadConfig("Data\\Config.txt");
            this.createDBManager();
        }

        private void createDBManager()
        {
            DBManager m = new DBManager("user id=" + Properties.getProperty("dbuser") +
                                       ";password=" + Properties.getProperty("dbpasswd") + 
                                       ";server=" + Properties.getProperty("dburl") +
                                       ";Trusted_Connection=no;" +
                                       "database=" + Properties.getProperty("dbname") +
                                       ";connection timeout=60");
            appContext.Add(typeof(DBManager), m);
        }

        private void loadConfig(String path)
        {
            Properties p = new Properties(path);

            appContext.Add(typeof(DateTime),DateTime.Parse(Properties.getProperty("fecha")));
            appContext.Add(typeof(Properties),p);

            Console.WriteLine(DateTime.Parse(Properties.getProperty("fecha")).ToShortDateString());
        }

        public static Object getObject(Type t)
        {
            return appContext[t];
        }

        public static void setObject(Type key, Object t)
        {
            appContext[key] = t;
        }
    }
}
