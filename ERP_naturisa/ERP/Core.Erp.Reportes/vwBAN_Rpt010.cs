//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwBAN_Rpt010
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public decimal IdTipocbte { get; set; }
        public string Descripcion { get; set; }
        public int IdPeriodo { get; set; }
        public int IdBanco { get; set; }
        public string nom_Banco { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_CtaCble { get; set; }
        public Nullable<double> Debito { get; set; }
        public Nullable<double> Haber { get; set; }
        public string referencia { get; set; }
        public string Concepto { get; set; }
        public string ruc_empresa { get; set; }
        public string nom_empresa { get; set; }
    }
}
