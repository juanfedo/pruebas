﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace admin_olimpia.backbone_wcf {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/backbone_wcf_client")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="cliente", Namespace="http://schemas.datacontract.org/2004/07/backbone_wcf_client")]
    [System.SerializableAttribute()]
    public partial class cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string emailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string nameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> telephoneField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string email {
            get {
                return this.emailField;
            }
            set {
                if ((object.ReferenceEquals(this.emailField, value) != true)) {
                    this.emailField = value;
                    this.RaisePropertyChanged("email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                if ((object.ReferenceEquals(this.nameField, value) != true)) {
                    this.nameField = value;
                    this.RaisePropertyChanged("name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> telephone {
            get {
                return this.telephoneField;
            }
            set {
                if ((this.telephoneField.Equals(value) != true)) {
                    this.telephoneField = value;
                    this.RaisePropertyChanged("telephone");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Service1.Tipo_Transaccion", Namespace="http://schemas.datacontract.org/2004/07/backbone_wcf_client")]
    public enum Service1Tipo_Transaccion : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Transferencia = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Consignación = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Retiro = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Inicio = 3,
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="transaccion", Namespace="http://schemas.datacontract.org/2004/07/backbone_wcf_client")]
    [System.SerializableAttribute()]
    public partial class transaccion : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private admin_olimpia.backbone_wcf.Cuenta CuentaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private admin_olimpia.backbone_wcf.Cuenta Cuenta1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> cuenta_destino_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> cuenta_idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> fechaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> tipo_transaccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> valorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public admin_olimpia.backbone_wcf.Cuenta Cuenta {
            get {
                return this.CuentaField;
            }
            set {
                if ((object.ReferenceEquals(this.CuentaField, value) != true)) {
                    this.CuentaField = value;
                    this.RaisePropertyChanged("Cuenta");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public admin_olimpia.backbone_wcf.Cuenta Cuenta1 {
            get {
                return this.Cuenta1Field;
            }
            set {
                if ((object.ReferenceEquals(this.Cuenta1Field, value) != true)) {
                    this.Cuenta1Field = value;
                    this.RaisePropertyChanged("Cuenta1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> cuenta_destino_id {
            get {
                return this.cuenta_destino_idField;
            }
            set {
                if ((this.cuenta_destino_idField.Equals(value) != true)) {
                    this.cuenta_destino_idField = value;
                    this.RaisePropertyChanged("cuenta_destino_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> cuenta_id {
            get {
                return this.cuenta_idField;
            }
            set {
                if ((this.cuenta_idField.Equals(value) != true)) {
                    this.cuenta_idField = value;
                    this.RaisePropertyChanged("cuenta_id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> fecha {
            get {
                return this.fechaField;
            }
            set {
                if ((this.fechaField.Equals(value) != true)) {
                    this.fechaField = value;
                    this.RaisePropertyChanged("fecha");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> tipo_transaccion {
            get {
                return this.tipo_transaccionField;
            }
            set {
                if ((this.tipo_transaccionField.Equals(value) != true)) {
                    this.tipo_transaccionField = value;
                    this.RaisePropertyChanged("tipo_transaccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> valor {
            get {
                return this.valorField;
            }
            set {
                if ((this.valorField.Equals(value) != true)) {
                    this.valorField = value;
                    this.RaisePropertyChanged("valor");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cuenta", Namespace="http://schemas.datacontract.org/2004/07/backbone_wcf_client")]
    [System.SerializableAttribute()]
    public partial class Cuenta : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> balanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<decimal> numberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private admin_olimpia.backbone_wcf.transaccion[] transaccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private admin_olimpia.backbone_wcf.transaccion[] transaccion1Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<bool> typeField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> balance {
            get {
                return this.balanceField;
            }
            set {
                if ((this.balanceField.Equals(value) != true)) {
                    this.balanceField = value;
                    this.RaisePropertyChanged("balance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<decimal> number {
            get {
                return this.numberField;
            }
            set {
                if ((this.numberField.Equals(value) != true)) {
                    this.numberField = value;
                    this.RaisePropertyChanged("number");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public admin_olimpia.backbone_wcf.transaccion[] transaccion {
            get {
                return this.transaccionField;
            }
            set {
                if ((object.ReferenceEquals(this.transaccionField, value) != true)) {
                    this.transaccionField = value;
                    this.RaisePropertyChanged("transaccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public admin_olimpia.backbone_wcf.transaccion[] transaccion1 {
            get {
                return this.transaccion1Field;
            }
            set {
                if ((object.ReferenceEquals(this.transaccion1Field, value) != true)) {
                    this.transaccion1Field = value;
                    this.RaisePropertyChanged("transaccion1");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<bool> type {
            get {
                return this.typeField;
            }
            set {
                if ((this.typeField.Equals(value) != true)) {
                    this.typeField = value;
                    this.RaisePropertyChanged("type");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="backbone_wcf.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        admin_olimpia.backbone_wcf.CompositeType GetDataUsingDataContract(admin_olimpia.backbone_wcf.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<admin_olimpia.backbone_wcf.CompositeType> GetDataUsingDataContractAsync(admin_olimpia.backbone_wcf.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Clients", ReplyAction="http://tempuri.org/IService1/Get_ClientsResponse")]
        admin_olimpia.backbone_wcf.cliente[] Get_Clients();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Clients", ReplyAction="http://tempuri.org/IService1/Get_ClientsResponse")]
        System.Threading.Tasks.Task<admin_olimpia.backbone_wcf.cliente[]> Get_ClientsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Client", ReplyAction="http://tempuri.org/IService1/Delete_ClientResponse")]
        bool Delete_Client(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Delete_Client", ReplyAction="http://tempuri.org/IService1/Delete_ClientResponse")]
        System.Threading.Tasks.Task<bool> Delete_ClientAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Client_Id", ReplyAction="http://tempuri.org/IService1/Get_Client_IdResponse")]
        int Get_Client_Id(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Client_Id", ReplyAction="http://tempuri.org/IService1/Get_Client_IdResponse")]
        System.Threading.Tasks.Task<int> Get_Client_IdAsync(string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_Client", ReplyAction="http://tempuri.org/IService1/Update_ClientResponse")]
        bool Update_Client(int Id, string Name, string Email, long Telephone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Update_Client", ReplyAction="http://tempuri.org/IService1/Update_ClientResponse")]
        System.Threading.Tasks.Task<bool> Update_ClientAsync(int Id, string Name, string Email, long Telephone);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Create_Transaction", ReplyAction="http://tempuri.org/IService1/Create_TransactionResponse")]
        bool Create_Transaction(int cue_id, int cue_des_id, admin_olimpia.backbone_wcf.Service1Tipo_Transaccion tip, long val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Create_Transaction", ReplyAction="http://tempuri.org/IService1/Create_TransactionResponse")]
        System.Threading.Tasks.Task<bool> Create_TransactionAsync(int cue_id, int cue_des_id, admin_olimpia.backbone_wcf.Service1Tipo_Transaccion tip, long val);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Transactions", ReplyAction="http://tempuri.org/IService1/Get_TransactionsResponse")]
        admin_olimpia.backbone_wcf.transaccion Get_Transactions();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Get_Transactions", ReplyAction="http://tempuri.org/IService1/Get_TransactionsResponse")]
        System.Threading.Tasks.Task<admin_olimpia.backbone_wcf.transaccion> Get_TransactionsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : admin_olimpia.backbone_wcf.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<admin_olimpia.backbone_wcf.IService1>, admin_olimpia.backbone_wcf.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public admin_olimpia.backbone_wcf.CompositeType GetDataUsingDataContract(admin_olimpia.backbone_wcf.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<admin_olimpia.backbone_wcf.CompositeType> GetDataUsingDataContractAsync(admin_olimpia.backbone_wcf.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public admin_olimpia.backbone_wcf.cliente[] Get_Clients() {
            return base.Channel.Get_Clients();
        }
        
        public System.Threading.Tasks.Task<admin_olimpia.backbone_wcf.cliente[]> Get_ClientsAsync() {
            return base.Channel.Get_ClientsAsync();
        }
        
        public bool Delete_Client(int id) {
            return base.Channel.Delete_Client(id);
        }
        
        public System.Threading.Tasks.Task<bool> Delete_ClientAsync(int id) {
            return base.Channel.Delete_ClientAsync(id);
        }
        
        public int Get_Client_Id(string name) {
            return base.Channel.Get_Client_Id(name);
        }
        
        public System.Threading.Tasks.Task<int> Get_Client_IdAsync(string name) {
            return base.Channel.Get_Client_IdAsync(name);
        }
        
        public bool Update_Client(int Id, string Name, string Email, long Telephone) {
            return base.Channel.Update_Client(Id, Name, Email, Telephone);
        }
        
        public System.Threading.Tasks.Task<bool> Update_ClientAsync(int Id, string Name, string Email, long Telephone) {
            return base.Channel.Update_ClientAsync(Id, Name, Email, Telephone);
        }
        
        public bool Create_Transaction(int cue_id, int cue_des_id, admin_olimpia.backbone_wcf.Service1Tipo_Transaccion tip, long val) {
            return base.Channel.Create_Transaction(cue_id, cue_des_id, tip, val);
        }
        
        public System.Threading.Tasks.Task<bool> Create_TransactionAsync(int cue_id, int cue_des_id, admin_olimpia.backbone_wcf.Service1Tipo_Transaccion tip, long val) {
            return base.Channel.Create_TransactionAsync(cue_id, cue_des_id, tip, val);
        }
        
        public admin_olimpia.backbone_wcf.transaccion Get_Transactions() {
            return base.Channel.Get_Transactions();
        }
        
        public System.Threading.Tasks.Task<admin_olimpia.backbone_wcf.transaccion> Get_TransactionsAsync() {
            return base.Channel.Get_TransactionsAsync();
        }
    }
}