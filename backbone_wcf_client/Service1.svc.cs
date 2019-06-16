using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace backbone_wcf_client
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public enum Tipo_Transaccion {Transferencia, Consignación, Retiro, Inicio}

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public List<cliente> Get_Clients()
        {
            List<cliente> clients = new List<cliente>();
            using (olimpiaEntities tstDb = new olimpiaEntities())
                clients = tstDb.cliente.ToList();
            return clients;
        }

        public int Get_Client_Id(string name)
        {
            cliente client;
            using (olimpiaEntities tstDb = new olimpiaEntities())
                client = tstDb.cliente.FirstOrDefault(x => x.name == name);
            return client.id;
        }

        public bool Delete_Client(int Id)
        {
            bool isdelete = false;
            using (olimpiaEntities tstDb = new olimpiaEntities())
            {
                cliente temp = tstDb.cliente.SingleOrDefault(x => x.id == Id);
                tstDb.cliente.Remove(temp);
                isdelete = tstDb.SaveChanges() > 0;
            }
            return isdelete;
        }

        public bool Create_Client(string Name, string Email, long Telephone)
        {
            bool iscreate = false;
            using (olimpiaEntities tstDb = new olimpiaEntities())
            {
                cliente usrdtl = new cliente
                {
                    name = Name,
                    email = Email,
                    telephone = Telephone
                };
                tstDb.cliente.Add(usrdtl); 
                iscreate = tstDb.SaveChanges() > 0;
            }
            return iscreate;
        }

        public bool Update_Client(int Id, string Name, string Email, long Telephone)
        {
            bool isupdate = false;
            using (olimpiaEntities tstDb = new olimpiaEntities())
            {
                cliente temp = tstDb.cliente.FirstOrDefault(x => x.id == Id);
                temp.name = Name;
                temp.email = Email;
                temp.telephone = Telephone;
                isupdate = tstDb.SaveChanges() > 0;
            }
            return isupdate;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        ///Transaction Methods
        ///
        public bool Create_Transaction(int cue_id, int cue_des_id, Tipo_Transaccion tip,long val)
        {
            bool iscreate = false;
            using (olimpiaEntities tstDb = new olimpiaEntities())
            {
                transaccion usrdtl = new transaccion
                {
                    cuenta_id = cue_id,
                    cuenta_destino_id = cue_des_id,
                    tipo_transaccion = (int) tip,
                    valor = val,
                    fecha = DateTime.Now
                };
                tstDb.transaccion.Add(usrdtl);
                iscreate = tstDb.SaveChanges() > 0;
            }
            return iscreate;
        }

        public transaccion Get_Transactions()
        {
            List<transaccion> elements = new List<transaccion>();
            using (olimpiaEntities tstDb = new olimpiaEntities())
            {
                elements = tstDb.transaccion.ToList();
                return tstDb.transaccion.ToList()[0];
            }
        }

    }
}
