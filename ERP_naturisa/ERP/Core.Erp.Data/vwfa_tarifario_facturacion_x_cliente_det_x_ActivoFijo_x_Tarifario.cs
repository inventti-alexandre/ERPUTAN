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
    
    public partial class vwfa_tarifario_facturacion_x_cliente_det_x_ActivoFijo_x_Tarifario
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public Nullable<int> IdDepartamento { get; set; }
        public string de_descripcion { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Af_NumSerie { get; set; }
        public System.DateTime Af_fecha_compra { get; set; }
        public System.DateTime Af_fecha_ini_depre { get; set; }
        public System.DateTime Af_fecha_fin_depre { get; set; }
        public double Af_Costo_historico { get; set; }
        public double Af_costo_compra { get; set; }
        public int Af_Vida_Util { get; set; }
        public int Af_Meses_depreciar { get; set; }
        public double Af_porcentaje_deprec { get; set; }
        public string Af_NumSerie_Motor { get; set; }
        public string Af_NumSerie_Chasis { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string nom_Sucursal { get; set; }
        public string nom_Categoria { get; set; }
        public string Estado { get; set; }
        public string nom_encargado { get; set; }
        public Nullable<double> Af_ValorUnidad_Actu { get; set; }
        public string nom_Color { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public string nom_Cliente { get; set; }
        public string nom_punto_cargo { get; set; }
        public string nom_Centro_costo { get; set; }
        public string nom_UnidadFact { get; set; }
        public Nullable<int> IdCategoriaAF { get; set; }
        public string IdCentroCosto { get; set; }
        public Nullable<double> Af_ValorSalvamento { get; set; }
        public Nullable<double> Af_ValorResidual { get; set; }
        public string nom_Centro_costo_sub_centro_costo { get; set; }
        public Nullable<bool> Es_carroceria { get; set; }
        public Nullable<decimal> IdTarifario { get; set; }
        public Nullable<int> Num_empleado_relacionado { get; set; }
        public Nullable<double> Valor_x_Unidad { get; set; }
        public Nullable<double> Unidades_minimas { get; set; }
    }
}
