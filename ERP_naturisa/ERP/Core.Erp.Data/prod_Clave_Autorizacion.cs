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
    
    public partial class prod_Clave_Autorizacion
    {
        public int IdEmpresa { get; set; }
        public decimal IdGeneracion { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> IdModeloProduccion { get; set; }
        public string Clave { get; set; }
        public string IdUsuarioUsoDeClave { get; set; }
        public Nullable<System.DateTime> FechaUsoDeClave { get; set; }
        public string IdUsuarioGeneracion { get; set; }
        public Nullable<System.DateTime> FechaGeneracion { get; set; }
        public Nullable<decimal> IdTransaccion { get; set; }
        public string Activo { get; set; }
    }
}
