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
    
    public partial class in_Aprobacion_Ing_a_bod_x_OC_det
    {
        public int IdEmpresa { get; set; }
        public decimal IdAprobacion { get; set; }
        public int Secuencia { get; set; }
        public Nullable<int> IdEmpresa_ing_bg_oc { get; set; }
        public Nullable<decimal> IdIngreso_x_oc_ing_bg_oc { get; set; }
        public Nullable<int> Secuencia_ing_bg_oc { get; set; }
        public Nullable<decimal> IdProducto { get; set; }
        public Nullable<double> Cantidad_Aprob { get; set; }
        public string Observacion { get; set; }
    
        public virtual in_Aprobacion_Ing_a_bod_x_OC in_Aprobacion_Ing_a_bod_x_OC { get; set; }
    }
}