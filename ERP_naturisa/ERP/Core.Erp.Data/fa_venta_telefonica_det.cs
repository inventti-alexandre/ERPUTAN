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
    
    public partial class fa_venta_telefonica_det
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdVenta_tel { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string Observacion { get; set; }
        public double Cantidad { get; set; }
    
        public virtual fa_venta_telefonica fa_venta_telefonica { get; set; }
    }
}
