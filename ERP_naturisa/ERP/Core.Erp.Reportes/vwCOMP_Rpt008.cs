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
    
    public partial class vwCOMP_Rpt008
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdOrdenCompra { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_codigo { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<int> IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public System.DateTime oc_fecha { get; set; }
        public double do_Cantidad { get; set; }
        public double do_precioCompra { get; set; }
        public double ult_costo { get; set; }
        public double diferencia { get; set; }
    }
}
