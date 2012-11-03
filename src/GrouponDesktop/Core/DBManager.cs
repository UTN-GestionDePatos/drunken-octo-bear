using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GrouponDesktop.Core
{
    class DBManager
    {
        SqlConnection sqlConnection = new SqlConnection();

        public DBManager(String connectionString)
        {
            Console.WriteLine(connectionString);
            sqlConnection.ConnectionString = connectionString;
            sqlConnection.Open();
        }

        public SqlConnection getConnection() {
            return this.sqlConnection;
        }

        public SQLResponse executeQuery(String query)
        {
            SQLResponse respuesta = new SQLResponse();
            SqlCommand comando = new SqlCommand(query, this.sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable resultado = new DataTable();
            respuesta.rowsAffected = adapter.Fill(resultado);
            respuesta.result = resultado;

            return respuesta;
        }

        public SQLResponse executeQuery(SqlCommand comando)
        {
            comando.Connection = this.sqlConnection;
            comando.CommandType = CommandType.Text;
            SQLResponse respuesta = new SQLResponse();
            SqlDataAdapter adapter = new SqlDataAdapter(comando);
            DataTable resultado = new DataTable();

            respuesta.rowsAffected = adapter.Fill(resultado);
            respuesta.result = resultado;

            return respuesta;
        }

        public void executeUpdate(String query) { 
        
        }
    }
}
