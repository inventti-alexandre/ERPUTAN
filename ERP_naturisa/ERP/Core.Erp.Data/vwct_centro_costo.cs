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
    
    public partial class vwct_centro_costo
    {
        public int IdEmpresa { get; set; }
        public string IdCentroCosto { get; set; }
        public string CodCentroCosto { get; set; }
        public string Centro_costo { get; set; }
        public string Centro_costoPadre { get; set; }
        public string IdCentroCostoPadre { get; set; }
        public Nullable<decimal> IdCatalogo { get; set; }
        public string pc_EsMovimiento { get; set; }
        public int IdNivel { get; set; }
        public string pc_Estado { get; set; }
        public string IdCtaCble { get; set; }
    }
}
