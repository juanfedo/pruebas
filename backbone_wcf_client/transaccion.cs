//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace backbone_wcf_client
{
    using System;
    using System.Collections.Generic;
    
    public partial class transaccion
    {
        public int id { get; set; }
        public Nullable<int> cuenta_id { get; set; }
        public Nullable<int> cuenta_destino_id { get; set; }
        public Nullable<int> tipo_transaccion { get; set; }
        public Nullable<decimal> valor { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
    
        public virtual Cuenta Cuenta { get; set; }
        public virtual Cuenta Cuenta1 { get; set; }
    }
}