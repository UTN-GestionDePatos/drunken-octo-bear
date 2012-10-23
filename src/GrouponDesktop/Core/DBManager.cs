using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace GrouponDesktop.Core
{
    class DBManager
    {
        SqlConnection sqlConnection = new SqlConnection();

        public DBManager(String connectionString)
        {
            Console.WriteLine(connectionString);
            sqlConnection.ConnectionString = connectionString;
        }

        public SqlConnection getConnection() {
            return this.sqlConnection;
        }
    }
}
