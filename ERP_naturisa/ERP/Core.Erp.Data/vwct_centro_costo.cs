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