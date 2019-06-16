using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace backbone_wcf_client
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: agregue aquí sus operaciones de servicio
        [OperationContract]
        List<cliente> Get_Clients();

        [OperationContract]
        bool Delete_Client(int id);

        [OperationContract]
        int Get_Client_Id(string name);

        [OperationContract]
        bool Update_Client(int Id, string Name, string Email, long Telephone);


        //Transaction Contract
        [OperationContract]
        bool Create_Transaction(int cue_id, int cue_des_id, Service1.Tipo_Transaccion tip, long val);

        [OperationContract]
        [ServiceKnownType(typeof(transaccion))]
        transaccion Get_Transactions();
    }


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
