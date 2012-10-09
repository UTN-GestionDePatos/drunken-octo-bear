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
            this.createDBManager();
        }

        private void createDBManager()
        {
            DBManager m = new DBManager("user id=gd;" +
                                       "password=gd2012;server=localhost\\SQLSERVER2008;" +
                                       "Trusted_Connection=yes;" +
                                       "database=GD2C2012; " +
                                       "connection timeout=60");
            appContext.Add(typeof(DBManager), m);
        }

        public static Object getObject(Type t)
        {
            return appContext[t];
        }
    }
}
