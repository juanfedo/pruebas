using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web;


namespace backbone_service2.DAO
{
    public class Cuenta:IDAO_CRUD
    {
        long number;
        bool type;
        long balance;

        public long Number { get => number; set => number = value; }
        public bool Type { get => type; set => type = value; }
        public long Balance { get => balance; set => balance = value; }

        public Cuenta(long num, bool typ, long bal)
        {
            number = num;
            type = typ;
            balance = bal;
        }

        public bool Create()
        {
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@number",SqlDbType = SqlDbType.BigInt,Value = this.number },
                new SqlParameter() { ParameterName = "@type",SqlDbType = SqlDbType.Bit,Value = this.type},
                new SqlParameter() { ParameterName = "@balance",SqlDbType = SqlDbType.BigInt,Value = this.balance }
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Crear_Cuenta", parameters);
            return rows > 0;
        }

        public bool Delete()
        {
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@number",SqlDbType = SqlDbType.BigInt,Value = this.number }
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Eliminar_Cuenta", parameters);
            return rows > 0;
        }

        public bool Update()
        {
            List<SqlParameter> parameters = new List<SqlParameter>() {
                new SqlParameter() { ParameterName = "@number",SqlDbType = SqlDbType.BigInt,Value = this.number },
                new SqlParameter() { ParameterName = "@type",SqlDbType = SqlDbType.Bit,Value = this.type},
                new SqlParameter() { ParameterName = "@balance",SqlDbType = SqlDbType.BigInt,Value = this.balance }
            };
            int rows = new DataLayer.DataAccess().ExecuteStoreProcedure("Actualizar_Cuenta", parameters);
            return rows > 0;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}