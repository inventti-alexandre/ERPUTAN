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
    
    public partial class vwBa_ChequexCbteCtble
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Cod_Cbtecble { get; set; }
        public string cb_Observacion { get; set; }
        public decimal cb_secuencia { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Cheque { get; set; }
        public string cb_ChequeImpreso { get; set; }
        public Nullable<System.DateTime> cb_FechaCheque { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string Estado { get; set; }
        public string cb_giradoA { get; set; }
        public string cb_ciudadChq { get; set; }
        public string CodTipoCbteBan { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public System.DateTime con_Fecha { get; set; }
        public double con_Valor { get; set; }
        public string con_Observacion { get; set; }
        public decimal con_IdCbteCble { get; set; }
        public string IdCtaCble { get; set; }
        public string pc_Cuenta { get; set; }
        public double dc_Valor { get; set; }
        public string ValorEnLetras { get; set; }
        public int IdBanco { get; set; }
        public string ba_descripcion { get; set; }
    }
}
