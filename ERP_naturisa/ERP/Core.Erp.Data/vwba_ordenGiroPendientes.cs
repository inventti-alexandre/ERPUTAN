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
    
    public partial class vwba_ordenGiroPendientes
    {
        public decimal IdProveedor { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public string co_observacion { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public Nullable<double> valorAPagar { get; set; }
        public double TotalPagado { get; set; }
        public Nullable<double> saldo { get; set; }
        public string Proveedor { get; set; }
        public string NFactura { get; set; }
        public string GiraCheque { get; set; }
        public string CtaProveedor { get; set; }
    }
}
