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
    
    public partial class vwcp_Conciliacion_Caja_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdConciliacion_Caja { get; set; }
        public int IdCaja { get; set; }
        public System.DateTime Fecha { get; set; }
        public string ca_Descripcion { get; set; }
        public string IdUsuario_Responsable { get; set; }
        public string IdOrden_giro_Tipo { get; set; }
        public decimal IdProveedor { get; set; }
        public System.DateTime co_fechaOg { get; set; }
        public string co_serie { get; set; }
        public string co_factura { get; set; }
        public System.DateTime co_FechaFactura { get; set; }
        public System.DateTime co_FechaFactura_vct { get; set; }
        public string co_observacion { get; set; }
        public double co_subtotal_iva { get; set; }
        public double co_subtotal_siniva { get; set; }
        public double co_baseImponible { get; set; }
        public double co_Por_iva { get; set; }
        public double co_valoriva { get; set; }
        public double co_total { get; set; }
        public double co_valorpagar { get; set; }
        public Nullable<int> IdIden_credito { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public string IdCtaCble_Gasto { get; set; }
        public string Estado { get; set; }
        public string IdCentroCosto { get; set; }
        public string Num_Autorizacion { get; set; }
        public double Total_Retencion { get; set; }
        public Nullable<decimal> IdRetencion { get; set; }
        public int IdEmpresa_OGiro { get; set; }
        public decimal IdCbteCble_Ogiro { get; set; }
        public int IdTipoCbte_Ogiro { get; set; }
        public string IdEstadoCierre { get; set; }
        public string Observacion { get; set; }
        public Nullable<int> IdEmpresa_op { get; set; }
        public Nullable<decimal> IdOrdenPago_op { get; set; }
        public int Secuencia { get; set; }
        public string IdCtaCble { get; set; }
        public string Expr1 { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdTipoMovi { get; set; }
        public double Dif_x_pagar_o_cobrar { get; set; }
        public double Total_fondo { get; set; }
        public double Total_fact_vale { get; set; }
        public double Total_Ing { get; set; }
        public double Ingresos { get; set; }
        public double Saldo_cont_al_periodo { get; set; }
        public int IdPeriodo { get; set; }
        public decimal Valor_a_aplicar { get; set; }
        public string Tipo_documento { get; set; }
        public Nullable<int> IdEmpresa_OP_conci { get; set; }
        public Nullable<decimal> IdOrdenPago_OP_Conci { get; set; }
        public string pe_cedulaRuc { get; set; }
    }
}
