//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    
    public partial class spCONTA_Rpt006_Result
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipoCbte { get; set; }
        public string sTipocbte { get; set; }
        public int IdPeriodo { get; set; }
        public System.DateTime FechaCbte { get; set; }
        public string IdCtaCble { get; set; }
        public string nom_cuenta { get; set; }
        public string Concepto { get; set; }
        public string ruc_empresa { get; set; }
        public string nom_empresa { get; set; }
        public Nullable<double> SaldoInicial { get; set; }
        public Nullable<double> SaldoFinal { get; set; }
        public double Debito { get; set; }
        public Nullable<double> Credito { get; set; }
        public string nom_grupo_punto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string IdCentro_Costo { get; set; }
        public string nom_centro_costo { get; set; }
        public string pc_clave_corta { get; set; }
    }
}
