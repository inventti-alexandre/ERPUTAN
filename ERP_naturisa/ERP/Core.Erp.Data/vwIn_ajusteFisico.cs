//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwin_ajusteFisico
    {
        public decimal IdAjusteFisico { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Ing { get; set; }
        public Nullable<decimal> IdNumMovi_Ing { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Egr { get; set; }
        public Nullable<decimal> IdNumMovi_Egr { get; set; }
        public string Observacion { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Estado { get; set; }
        public string tm_descripcion_ing { get; set; }
        public string tm_descripcion_Egr { get; set; }
        public string bo_Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public int IdEmpresa { get; set; }
        public int IdBodega { get; set; }
        public int IdSucursal { get; set; }
        public string Nombre_Estado { get; set; }
        public string IdEstadoAprobacion { get; set; }
    }
}
