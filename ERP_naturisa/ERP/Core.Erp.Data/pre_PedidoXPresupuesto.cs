//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class pre_PedidoXPresupuesto
    {
        public int IdEmpresa { get; set; }
        public decimal IdPedidoXPre { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public Nullable<decimal> IdProveedor1 { get; set; }
        public Nullable<decimal> IdProveedor2 { get; set; }
        public Nullable<decimal> IdProveedor3 { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
    }
}
