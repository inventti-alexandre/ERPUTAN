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
    
    public partial class vwProd_CompraChatarra
    {
        public string TipoChatarra { get; set; }
        public string Proveedor { get; set; }
        public string Presupuesto { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdLiquidacion { get; set; }
        public Nullable<decimal> IdProveedor_Presu { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Beneficiario { get; set; }
        public string Placa { get; set; }
        public Nullable<int> IdTipoChatarra { get; set; }
        public Nullable<double> PrecioChatarra { get; set; }
        public Nullable<double> TLlenoKg { get; set; }
        public Nullable<double> TVacionKg { get; set; }
        public Nullable<double> TMermaKg { get; set; }
        public Nullable<double> TNetokg { get; set; }
        public Nullable<double> Subtotal { get; set; }
        public Nullable<double> Descuento { get; set; }
        public Nullable<double> Total { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transa { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string MotiAnula { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public Nullable<decimal> IdProducto_Compra { get; set; }
        public Nullable<int> IdModeloProd { get; set; }
    }
}