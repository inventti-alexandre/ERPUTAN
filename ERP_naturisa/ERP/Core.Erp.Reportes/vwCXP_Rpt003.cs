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
    
    public partial class vwCXP_Rpt003
    {
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public System.DateTime Fecha { get; set; }
        public string num_comprobante { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public Nullable<System.DateTime> co_FechaContabilizacion { get; set; }
        public System.DateTime co_FechaFactura_vct { get; set; }
        public string Detalle { get; set; }
        public Nullable<int> secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<double> dc_Valor { get; set; }
        public double valor_debe { get; set; }
        public double valor_haber { get; set; }
        public string dc_Observacion { get; set; }
        public string nom_cuenta { get; set; }
        public string clave_cuenta { get; set; }
        public string nom_proveedor { get; set; }
        public string Codigo { get; set; }
        public string nom_comprobante { get; set; }
        public string CodTipoCbte { get; set; }
        public string tc_TipoCbte { get; set; }
        public string em_nombre { get; set; }
    }
}
