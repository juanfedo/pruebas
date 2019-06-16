using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace backbone_service2.DataLayer
{
    public class DataAccess
    {
        //string cadenaConexion = "server=DESKTOP-EUMV4P4;database=olimpia;User Id=sa;Password=root";

        SqlConnection connection;

        SqlConnection get_connection()
        {
            if (connection == null)
                return connection = new SqlConnection(ConfigurationManager.ConnectionStrings["LocalSqlServer"].ConnectionString);
            else
                return connection;
        }

        public int ExecuteStoreProcedure(string sp_name,List<SqlParameter> parameters)
        {
            int rows = 0;
            try
            {
                SqlCommand comando = new SqlCommand(sp_name, get_connection())
                {
                    CommandType = CommandType.StoredProcedure
                };
                foreach (SqlParameter s in parameters)
                    comando.Parameters.Add(s);
                comando.Connection.Open();
                rows = comando.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                new Utils.Utilities().write_log("error.log", ex.Message);
            }
            return rows;
        }

        public int ExecuteNonQuery(string queryString)
        {
            int rows = 0;
            try
            {
                SqlCommand comando = new SqlCommand(queryString, get_connection());
                comando.Connection.Open();
                rows = comando.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                new Utils.Utilities().write_log("error.log",ex.Message);
            }
            return rows;
        }

        public object ExecuteScalar(string queryString)
        {
            object value = null;
            try
            { 
                SqlCommand comando = new SqlCommand(queryString, get_connection());
                comando.Connection.Open();
                value = comando.ExecuteScalar();
                connection.Close();
            }
            catch (Exception ex)
            {
                new Utils.Utilities().write_log("error.log", ex.Message);
            }            
            return value;
        }

        public DataTable ExecuteReader(string queryString)
        {
            DataTable tabla = new DataTable();
            try
            { 
                SqlCommand comando = new SqlCommand(queryString, get_connection());
                comando.Connection.Open();
                tabla = new DataTable();
                tabla.Load(comando.ExecuteReader());
                connection.Close();
            }
            catch (Exception ex)
            {
                new Utils.Utilities().write_log("error.log", ex.Message);
            }    
            return tabla;
        }
    }
}