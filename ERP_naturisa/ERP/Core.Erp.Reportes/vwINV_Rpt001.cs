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
    
    public partial class vwINV_Rpt001
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdBodega { get; set; }
        public int IdMovi_inven_tipo { get; set; }
        public decimal IdNumMovi { get; set; }
        public string CodMoviInven { get; set; }
        public string Tipo_Movimiento { get; set; }
        public string Empresa { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string nom_sucursal { get; set; }
        public string nom_bodega { get; set; }
        public string UnidadMedida { get; set; }
        public decimal IdProducto { get; set; }
        public double Cantidad { get; set; }
        public double Stock_Ant { get; set; }
        public double Stock_Act { get; set; }
        public string Observacion_det { get; set; }
        public string IdCentroCosto { get; set; }
        public string IdCentroCosto_sub_centro_costo { get; set; }
        public string IdEstadoAproba { get; set; }
        public string IdUnidadMedida { get; set; }
        public string Observacion { get; set; }
        public System.DateTime Fecha { get; set; }
        public double dm_cantidad_sinConversion { get; set; }
        public string IdUnidadMedida_sinConversion { get; set; }
        public Nullable<double> mv_costo_sinConversion { get; set; }
        public string UnidadMedida_sinConversion { get; set; }
        public string signo { get; set; }
    }
}