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
    
    public partial class in_Aprobacion_Ing_a_bod_x_OC
    {
        public in_Aprobacion_Ing_a_bod_x_OC()
        {
            this.in_Aprobacion_Ing_a_bod_x_OC_det = new HashSet<in_Aprobacion_Ing_a_bod_x_OC_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public System.DateTime Fecha { get; set; }
        public string Observacion { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string Serie { get; set; }
        public string AutoProveedor { get; set; }
        public string AutoImprenta { get; set; }
        public Nullable<System.DateTime> Fecha_factura { get; set; }
        public double Cargo_Adic_s_iva { get; set; }
        public double Base_Imp0 { get; set; }
        public double Cargo_Adic_iva { get; set; }
        public double Descuento { get; set; }
        public double Subtotal { get; set; }
        public double SubTotal_ant_iva { get; set; }
        public double Valor_iva { get; set; }
        public double Total_fact { get; set; }
        public Nullable<int> IdEmpresa_og { get; set; }
        public Nullable<decimal> IdCbteCble_Ogiro_og { get; set; }
        public Nullable<int> IdTipoCbte_Ogiro_og { get; set; }
    
        public virtual ICollection<in_Aprobacion_Ing_a_bod_x_OC_det> in_Aprobacion_Ing_a_bod_x_OC_det { get; set; }
    }
}