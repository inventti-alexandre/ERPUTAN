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
    
    public partial class vwFa_Ventas_x_cliente_x_periodo_BI
    {
        public int IdEmpresa { get; set; }
        public string Empresa { get; set; }
        public int IdSucursal { get; set; }
        public string Sucursal { get; set; }
        public int IdBodega { get; set; }
        public string Bodega { get; set; }
        public decimal IdCliente { get; set; }
        public string Cliente { get; set; }
        public int IdVendedor { get; set; }
        public string Vendedor { get; set; }
        public decimal IdProducto { get; set; }
        public string CodProducto { get; set; }
        public string Producto { get; set; }
        public string IdCategoria { get; set; }
        public string Categoria { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public int IdCalendario { get; set; }
        public Nullable<int> AnioFiscal { get; set; }
        public string NombreMes { get; set; }
        public string NombreFecha { get; set; }
        public Nullable<int> Mes_x_anio { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_Subtotal { get; set; }
    }
}
