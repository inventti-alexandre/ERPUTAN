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
    
    public partial class vwcp_retencion_x_RET_FT
    {
        public int IdEmpresa { get; set; }
        public decimal IdRetencion { get; set; }
        public string serie { get; set; }
        public string NumRetencion { get; set; }
        public string NAutorizacion { get; set; }
        public string re_tipoRet_RF { get; set; }
        public Nullable<double> re_baseRetencion_RF { get; set; }
        public Nullable<double> re_Porcen_retencion_RF { get; set; }
        public Nullable<double> re_valor_retencion_RF { get; set; }
        public Nullable<int> IdEmpresa_Ogiro { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro { get; set; }
    }
}