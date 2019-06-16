using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;

namespace backbone_service2.DAO
{
    public class Cliente: IDAO_CRUD
    {
        string name;
        long telephone;
        string email;
        
        public long Telephone { get => telephone; set => telephone = value; }
        public string Name { get => name; set => name = value; }
        public string Email { get => email; set => email = value; }

        public Cliente(string nam, long tel, string ema)
        {
            name = nam;
            telephone = tel;
            email = ema;
        }

        public bool Create()
        {
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@name",SqlDbType = SqlDbType.VarChar,Value = this.name },
                new SqlParameter() { ParameterName = "@telephone",SqlDbType = SqlDbType.BigInt,Value = this.telephone},
                new SqlParameter() { ParameterName = "@email",SqlDbType = SqlDbType.VarChar,Value = this.email }
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Crear_Cliente", parameters);
            return rows > 0;
        }

        public bool Update()
        {
            List<SqlParameter> parameters = new List<SqlParameter>() {                
                new SqlParameter() { ParameterName = "@telephone",SqlDbType = SqlDbType.BigInt,Value = this.telephone},
                new SqlParameter() { ParameterName = "@email",SqlDbType = SqlDbType.VarChar,Value = this.email }
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Actualizar_Cliente", parameters);
            return rows > 0;
        }

        public bool Delete()
        {
            List<SqlParameter> parameters = new List<SqlParameter>() {                
                new SqlParameter() { ParameterName = "@name",SqlDbType = SqlDbType.VarChar,Value = this.email }
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Eliminar_Cliente", parameters);
            return rows > 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}