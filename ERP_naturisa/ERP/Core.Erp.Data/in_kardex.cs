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
    
    public partial class in_kardex
    {
        public in_kardex()
        {
            this.in_kardex_det = new HashSet<in_kardex_det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdProducto { get; set; }
        public double kr_saldoInicial { get; set; }
        public double kr_saldoFinal { get; set; }
        public double kr_TotalIngresos { get; set; }
        public double kr_TotalEgresos { get; set; }
        public double kr_TotalMovimientos { get; set; }
        public double kr_costoInicial { get; set; }
        public double kr_costoFinal { get; set; }
        public double kr_stockActual { get; set; }
    
        public virtual ICollection<in_kardex_det> in_kardex_det { get; set; }
    }
}
