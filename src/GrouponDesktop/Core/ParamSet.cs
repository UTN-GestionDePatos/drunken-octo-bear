using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace GrouponDesktop.Core
{
    class ParamSet
    {
        
        String nombreSP;
        Dictionary<String, Object> parametros = new Dictionary<String, Object>();

        public ParamSet()
        {
            // Para compatibilidad con lo ya hecho.
        }

        public ParamSet(String nombre)
        {
            this.nombreSP = nombre;
        }

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

        public void AddParameter(String nombre, Object contenido) {
            this.parametros.Add(nombre, contenido);
        }

        public void RemoveParameters()
        {
            this.parametros.Clear();
        }

        public SqlParameter execSP()
        {
            DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));

            SqlCommand query = new SqlCommand(nombreSP);
            query.CommandType = CommandType.StoredProcedure;

            foreach (String nombreP in parametros.Keys)
                query.Parameters.Add(new SqlParameter(nombreP, parametros[nombreP]));
        
            SqlParameter retval = query.Parameters.Add("@ret", SqlDbType.Int);
            retval.Direction = ParameterDirection.Output;
            query.Connection = db.getConnection();
            query.ExecuteNonQuery();
            
            this.RemoveParameters();
            return retval;
        }

        public void executeNoReturn(){
            DBManager db = (DBManager)AppContext.getObject(typeof(DBManager));

            SqlCommand query = new SqlCommand(nombreSP);
            query.CommandType = CommandType.StoredProcedure;

            foreach (String nombreP in parametros.Keys)
                query.Parameters.Add(new SqlParameter(nombreP, parametros[nombreP]));
            query.Connection = db.getConnection();
            query.ExecuteNonQuery();
            this.RemoveParameters();
        }

    }
}
