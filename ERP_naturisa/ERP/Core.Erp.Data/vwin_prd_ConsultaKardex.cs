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
    
    public partial class vwin_prd_ConsultaKardex
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public int IdTipoMovimiento { get; set; }
        public decimal IdMovimiento { get; set; }
        public int Secuencia { get; set; }
        public string mv_tipo_movi { get; set; }
        public decimal IdProducto { get; set; }
        public double dm_cantidad { get; set; }
        public double dm_stock_ante { get; set; }
        public double dm_stock_actu { get; set; }
        public string dm_observacion { get; set; }
        public Nullable<double> dm_peso { get; set; }
        public string CodigoBarra { get; set; }
        public string pr_descripcion { get; set; }
        public string bo_Descripcion { get; set; }
        public string Su_Descripcion { get; set; }
        public System.DateTime cm_fecha { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
    }
}
