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
    
    public partial class vwCOMP_Rpt006
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdSolicitudCompra { get; set; }
        public int Secuencia_SC { get; set; }
        public Nullable<decimal> IdProducto_SC { get; set; }
        public string Su_Descripcion { get; set; }
        public string NomProducto_SC { get; set; }
        public double do_Cantidad { get; set; }
        public double Cantidad_aprobada { get; set; }
        public string IdUsuarioAprueba { get; set; }
        public Nullable<System.DateTime> FechaHoraAprobacion { get; set; }
        public string observacion { get; set; }
        public string IdUnidadMedida { get; set; }
        public string Descripcion { get; set; }
        public Nullable<double> do_precioCompra { get; set; }
        public Nullable<double> do_porc_des { get; set; }
        public Nullable<double> do_subtotal { get; set; }
        public Nullable<double> do_iva { get; set; }
        public Nullable<double> do_total { get; set; }
        public Nullable<bool> do_ManejaIva { get; set; }
        public decimal IdDepartamento { get; set; }
        public string de_descripcion { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string pr_nombre { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string IdEstadoPreAprobacion { get; set; }
        public string DescrpcionEstadoAprobacion { get; set; }
        public string DescrpcionEstadoPreAprobacion { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string codPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public decimal IdPersona { get; set; }
        public string nomSolicitante { get; set; }
    }
}
