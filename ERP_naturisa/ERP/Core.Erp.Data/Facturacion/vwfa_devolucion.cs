//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Facturacion
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwfa_devolucion
    {
        public string pe_nombreCompleto { get; set; }
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdDevolucion { get; set; }
        public string CodDevolucion { get; set; }
        public decimal IdNota { get; set; }
        public decimal IdCliente { get; set; }
        public int IdVendedor { get; set; }
        public decimal IdCbteVta { get; set; }
        public System.DateTime dv_fecha { get; set; }
        public string Estado { get; set; }
        public string dv_Observacion { get; set; }
        public string IdUsuario { get; set; }
        public string Su_Descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public double dv_total { get; set; }
        public double dv_iva { get; set; }
        public double dv_subtotal { get; set; }
        public string Ve_Vendedor { get; set; }
        public Nullable<double> dv_OtroValor2 { get; set; }
        public Nullable<double> dv_OtroValor1 { get; set; }
        public Nullable<double> dv_interes { get; set; }
        public Nullable<double> dv_flete { get; set; }
        public Nullable<double> dv_seguro { get; set; }
        public string vt_NumFactura { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_serie1 { get; set; }
    }
}
