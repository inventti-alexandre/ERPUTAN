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
    
    public partial class ct_Sumatoria_x_Cuenta_x_Centro_Costo
    {
        public int IdEmpresa { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCtaCblePadre { get; set; }
        public double Saldo_Inicial { get; set; }
        public double dc_Saldo_deudor { get; set; }
        public double dc_Saldo_Acreedor { get; set; }
        public double dc_Saldo { get; set; }
        public string idusuario { get; set; }
        public string pc { get; set; }
        public string es_movimento { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<double> Saldo_Inicial_deudor { get; set; }
        public Nullable<double> Saldo_Inicial_acreedor { get; set; }
        public Nullable<double> Saldo_fin_deudor { get; set; }
        public Nullable<double> Saldo_fin_acreedor { get; set; }
    }
}
