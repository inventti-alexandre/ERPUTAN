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
    
    public partial class vwct_ComprobanteContable
    {
        public double debe { get; set; }
        public double Cred { get; set; }
        public int IdEmpresa { get; set; }
        public int IdTipoCbte { get; set; }
        public decimal IdCbteCble { get; set; }
        public string CodCbteCble { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Observacion { get; set; }
        public string cb_Estado { get; set; }
        public int cb_Anio { get; set; }
        public int cb_mes { get; set; }
        public int secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public double dc_Valor { get; set; }
        public string dc_Observacion { get; set; }
        public string pc_Cuenta { get; set; }
        public string tc_TipoCbte { get; set; }
    }
}
