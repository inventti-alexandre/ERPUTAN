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
    
    public partial class vw_WSProduccionCidersus_Trazabilidad
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodigoBarra { get; set; }
        public string tm_descripcion { get; set; }
        public string pr_descripcion { get; set; }
        public string dm_observacion { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
    }
}
