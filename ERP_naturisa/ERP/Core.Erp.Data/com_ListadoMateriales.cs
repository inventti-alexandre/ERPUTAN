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
    
    public partial class com_ListadoMateriales
    {
        public int IdEmpresa { get; set; }
        public decimal IdListadoMateriales { get; set; }
        public string CodObra { get; set; }
        public int ot_IdSucursal { get; set; }
        public Nullable<decimal> IdOrdenTaller { get; set; }
        public System.DateTime FechaReg { get; set; }
        public string Estado { get; set; }
        public string Usuario { get; set; }
        public string Motivo { get; set; }
        public string lm_Observacion { get; set; }
    
        public virtual com_ListadoMateriales com_ListadoMateriales1 { get; set; }
        public virtual com_ListadoMateriales com_ListadoMateriales2 { get; set; }
        public virtual com_ListadoMateriales com_ListadoMateriales11 { get; set; }
        public virtual com_ListadoMateriales com_ListadoMateriales3 { get; set; }
    }
}