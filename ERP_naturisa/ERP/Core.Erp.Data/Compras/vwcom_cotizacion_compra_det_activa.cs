//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Compras
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwcom_cotizacion_compra_det_activa
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<decimal> Idproducto { get; set; }
        public Nullable<double> Cant_soli { get; set; }
        public Nullable<double> Cant_a_cotizar { get; set; }
        public Nullable<decimal> IdListadoMateriales_lq { get; set; }
        public string nom_sucursal { get; set; }
        public Nullable<System.DateTime> FechaReg { get; set; }
        public Nullable<int> IdDetalle_lq { get; set; }
        public string pr_descripcion { get; set; }
        public Nullable<double> saldo { get; set; }
    }
}
