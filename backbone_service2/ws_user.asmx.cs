using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Web.Services;

namespace backbone_service2
{
    /// <summary>
    /// Descripción breve de ws_user
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class ws_user : System.Web.Services.WebService
    {

        [WebMethod]
        public DataTable Get_users()
        {
            DataTable res;
            using (DAO.Usuario user = new DAO.Usuario("", ""))
                res = user.Get_Users();
            return res;
        }

        [WebMethod]
        public bool Is_Valid(string log, string pass)
        {
            bool isvalid = false;
            using (DAO.Usuario user = new DAO.Usuario(log, pass))
                isvalid = user.Is_Valid();
            return isvalid;
        }

        [WebMethod]
        public bool Create_User(string log, string pass)
        {
            bool iscreate = false;
            using (DAO.Usuario user = new DAO.Usuario(log, pass))
                iscreate = user.Create();
            return iscreate;
        }

        [WebMethod]
        public bool Update_User(string log, string pass)
        {
            bool isupdate = false;
            using (DAO.Usuario user = new DAO.Usuario(log, pass))
                isupdate = user.Update();
            return isupdate;
        }

        [WebMethod]
        public bool Delete_User(string log)
        {
            bool isdelete = false;
            using (DAO.Usuario user = new DAO.Usuario(log, ""))
                isdelete = user.Delete();
            return isdelete;
        }

        [WebMethod]
        public bool Create_Client(string nam, long tel, string ema)
        {
            bool iscreate = false;
            using (DAO.Cliente user = new DAO.Cliente(nam, tel, ema))
                iscreate = user.Create();
            return iscreate;
        }

        [WebMethod]
        public bool Update_Client(string nam, long tel, string ema)
        {
            bool isupdate = false;
            using (DAO.Cliente user = new DAO.Cliente(nam, tel, ema))
                isupdate = user.Update();
            return isupdate;
        }

        [WebMethod]
        public bool Delete_Client(string nam)
        {
            bool isdelete = false;
            using (DAO.Cliente user = new DAO.Cliente(nam, 0, ""))
                isdelete = user.Delete();
            return isdelete;
        }

        [WebMethod]
        public bool Create_Account(long num, bool typ, long bal)
        {
            bool iscreate = false;
            using (DAO.Cuenta accoun= new DAO.Cuenta(num, typ, bal))
                iscreate = accoun.Create();
            return iscreate;
        }

        [WebMethod]
        public bool Update_Account(long num, bool typ, long bal)
        {
            bool isupdate = false;
            using (DAO.Cuenta account = new DAO.Cuenta(num, typ, bal))
                isupdate = account.Update();
            return isupdate;
        }

        [WebMethod]
        public bool Delete_Account(long num)
        {
            bool isdelete = false;
            using (DAO.Cuenta account = new DAO.Cuenta(num, true, 0))
                isdelete = account.Delete();
            return isdelete;
        }

    }
}
