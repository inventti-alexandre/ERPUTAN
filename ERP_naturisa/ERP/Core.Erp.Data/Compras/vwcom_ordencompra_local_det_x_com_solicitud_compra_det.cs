//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcom_ordencompra_local_det_x_com_solicitud_compra_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public decimal IdProveedor { get; set; }
        public string oc_NumDocumento { get; set; }
        public string Tipo { get; set; }
        public string IdTerminoPago { get; set; }
        public int oc_plazo { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public double oc_flete { get; set; }
        public string oc_observacion { get; set; }
        public string Estado { get; set; }
        public string IdEstadoAprobacion_cat { get; set; }
        public Nullable<System.DateTime> co_fecha_aprobacion { get; set; }
        public string IdUsuario_Aprueba { get; set; }
        public string IdUsuario_Reprue { get; set; }
        public Nullable<System.DateTime> co_fechaReproba { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string IdEstadoRecepcion_cat { get; set; }
        public string AfectaCosto { get; set; }
        public string MotivoReprobacion { get; set; }
        public Nullable<double> subtotal { get; set; }
        public Nullable<double> iva { get; set; }
        public Nullable<double> total { get; set; }
        public Nullable<double> peso { get; set; }
        public string ap_descripcion { get; set; }
        public string tp_descripcion { get; set; }
        public string rec_descripcion { get; set; }
        public string pr_nombre { get; set; }
        public string Su_Descripcion { get; set; }
        public Nullable<decimal> IdDepartamento { get; set; }
        public string Solicitante { get; set; }
        public Nullable<decimal> IdSolicitante { get; set; }
        public decimal IdComprador { get; set; }
        public string MotivoAnulacion { get; set; }
        public string Nom_Solicita { get; set; }
        public string SDepartamento { get; set; }
        public Nullable<int> IdMotivo { get; set; }
        public Nullable<System.DateTime> oc_fechaVencimiento { get; set; }
        public string Nom_Comprador { get; set; }
        public string IdEstado_cierre { get; set; }
        public string nom_motivo_OC { get; set; }
        public int scd_IdEmpresa { get; set; }
        public int scd_IdSucursal { get; set; }
        public decimal scd_IdSolicitudCompra { get; set; }
    }
}