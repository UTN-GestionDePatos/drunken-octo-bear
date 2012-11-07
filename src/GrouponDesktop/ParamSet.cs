using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GrouponDesktop.Core;
using System.Data.SqlClient;
using System.Data;

namespace GrouponDesktop
{
    class ParamSet
    {
        
        String nombreSP;
        Dictionary<String, Object> parametros;
        
        public String NombreSP() { 
            return this.nombreSP;
        }

        public void NombreSP(String nombre){
            this.nombreSP = nombre;
        }

        public Dictionary<String,Object> Parametros(){
            return this.parametros;
        }

        public void Parametros(Dictionary<String,Object> parametros){
            this.parametros = parametros;
        }

        public SqlParameter execSP()
        {
            DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));

            SqlCommand query = new SqlCommand(nombreSP);
            query.CommandType = CommandType.StoredProcedure;

            foreach (String nombreP in parametros.Keys) {
                query.Parameters.Add(new SqlParameter(nombreP, parametros[nombreP]));

            }
        
            SqlParameter retval = query.Parameters.Add("@ret", SqlDbType.Int);
            retval.Direction = ParameterDirection.Output;
            query.Connection = db.getConnection();
            query.ExecuteNonQuery();

            return retval;
        }
    }
}
