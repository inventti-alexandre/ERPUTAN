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
    
    public partial class vwImp_LiquidacionImportacion
    {
        public int IdEmpresa { get; set; }
        public decimal IdRegistroGasto { get; set; }
        public int IdSucusal { get; set; }
        public decimal IdOrdenCompraExt { get; set; }
        public string ga_decripcion { get; set; }
        public string pr_nombre { get; set; }
        public Nullable<int> IdTipoCbte { get; set; }
        public Nullable<decimal> IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public string Estado { get; set; }
        public string AfectaLiquidacion { get; set; }
        public Nullable<double> Valor { get; set; }
    }
}
