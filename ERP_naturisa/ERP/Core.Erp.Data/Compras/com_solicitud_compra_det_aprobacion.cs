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
    
    public partial class com_solicitud_compra_det_aprobacion
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal_SC { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public int Secuencia_SC { get; set; }
        public Nullable<decimal> IdProducto_SC { get; set; }
        public string NomProducto_SC { get; set; }
        public double Cantidad_aprobada { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public Nullable<decimal> IdProveedor_SC { get; set; }
        public string IdUsuarioAprueba { get; set; }
        public Nullable<System.DateTime> FechaHoraAprobacion { get; set; }
        public string observacion { get; set; }
        public string IdUnidadMedida { get; set; }
        public Nullable<double> do_precioCompra { get; set; }
        public Nullable<double> do_porc_des { get; set; }
        public Nullable<double> do_descuento { get; set; }
        public Nullable<double> do_subtotal { get; set; }
        public Nullable<double> do_iva { get; set; }
        public Nullable<double> do_total { get; set; }
        public string do_ManejaIva { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string do_observacion { get; set; }
        public string IdEstadoPreAprobacion { get; set; }
    
        public virtual com_solicitud_compra_det com_solicitud_compra_det { get; set; }
    }
}
