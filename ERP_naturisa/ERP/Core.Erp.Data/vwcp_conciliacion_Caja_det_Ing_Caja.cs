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
    
    public partial class vwcp_conciliacion_Caja_det_Ing_Caja
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int secuencia { get; set; }
        public int IdEmpresa_movcaj { get; set; }
        public decimal IdCbteCble_movcaj { get; set; }
        public int IdTipocbte_movcaj { get; set; }
        public double valor_aplicado { get; set; }
        public string cm_observacion { get; set; }
        public double cm_valor { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public int IdPeriodo { get; set; }
    }
}
