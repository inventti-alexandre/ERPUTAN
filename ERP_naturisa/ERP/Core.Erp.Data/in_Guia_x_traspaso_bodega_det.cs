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
    
    public partial class in_Guia_x_traspaso_bodega_det
    {
        public in_Guia_x_traspaso_bodega_det()
        {
            this.in_transferencia_det_x_in_Guia_x_traspaso_bodega_det = new HashSet<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdGuia { get; set; }
        public int secuencia { get; set; }
        public Nullable<int> IdEmpresa_OC { get; set; }
        public Nullable<int> IdSucursal_OC { get; set; }
        public Nullable<decimal> IdOrdenCompra_OC { get; set; }
        public Nullable<int> Secuencia_OC { get; set; }
        public string observacion { get; set; }
        public Nullable<double> Cantidad_enviar { get; set; }
        public string Referencia { get; set; }
    
        public virtual ICollection<in_transferencia_det_x_in_Guia_x_traspaso_bodega_det> in_transferencia_det_x_in_Guia_x_traspaso_bodega_det { get; set; }
        public virtual in_Guia_x_traspaso_bodega in_Guia_x_traspaso_bodega { get; set; }
    }
}
