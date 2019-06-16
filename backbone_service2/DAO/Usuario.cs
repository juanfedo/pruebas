using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace backbone_service2.DAO
{
    public class Usuario:IDAO_CRUD
    {
        string login;
        string password;

        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }

        public Usuario(string log, string pass)
        {
            login = log;
            password = pass;
        }

        public DataTable Get_Users()
        {
            return new DataLayer.DataAccess().ExecuteReader("select * from usuario");
        }

        public bool Is_Valid()
        {
            string pass_enc = new Utils.Utilities().Encrypt(this.password);
            int rows = Convert.ToInt16(new DataLayer.DataAccess().ExecuteScalar("select id from usuario where login = '" + this.login + "' and password = '" + pass_enc + "'"));
            return rows > 0;
        }

        public bool Create()
        {
            string pass_enc = new Utils.Utilities().Encrypt(this.password);
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@login",SqlDbType = SqlDbType.VarChar,Value = this.login },
                new SqlParameter() { ParameterName = "@password",SqlDbType = SqlDbType.VarChar,Value = pass_enc}
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Crear_Usuario", parameters);
            return rows > 0;
        }

        public bool Update()
        {
            string pass_enc = new Utils.Utilities().Encrypt(this.password);
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@login",SqlDbType = SqlDbType.VarChar,Value = this.login },
                new SqlParameter() { ParameterName = "@password",SqlDbType = SqlDbType.VarChar,Value = pass_enc}
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Actualizar_Usuario", parameters);
            return rows > 0;
        }

        public bool Delete()
        {
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@login",SqlDbType = SqlDbType.VarChar,Value = this.login }
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Eliminar_Usuario", parameters);
            return rows > 0;
        }

        public void Dispose()
        {
           
        }
    }
}