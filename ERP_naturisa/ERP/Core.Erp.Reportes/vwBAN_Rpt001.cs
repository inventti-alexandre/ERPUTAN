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
    
    public partial class vwBAN_Rpt001
    {
        public int IdEmpresa { get; set; }
        public string Tipo_Cbte { get; set; }
        public decimal Num_Cbte { get; set; }
        public int IdBanco { get; set; }
        public string Banco { get; set; }
        public System.DateTime Fch_Cbte { get; set; }
        public string Observacion { get; set; }
        public double Valor { get; set; }
        public string Cheque { get; set; }
        public string Chq_Girado_A { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string Tipo_Flujo { get; set; }
        public Nullable<int> IdTipoNota { get; set; }
        public string Tipo_Nota { get; set; }
        public string Fch_PostFechado { get; set; }
        public string Es_Chq_Impreso { get; set; }
        public Nullable<System.DateTime> Fch_Chq { get; set; }
        public string Cta_Cble_Banco { get; set; }
        public int IdCalendario { get; set; }
        public Nullable<int> AnioFiscal { get; set; }
        public string NombreMes { get; set; }
        public string NombreCortoFecha { get; set; }
        public Nullable<int> IdMes { get; set; }
        public string pc_Cuenta { get; set; }
        public string Estado { get; set; }
    }
}
