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
    
    public partial class vwACTF_Rpt013
    {
        public string Tipo_Registro { get; set; }
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
        public Nullable<System.DateTime> Fecha { get; set; }
        public Nullable<double> Valor { get; set; }
        public int IdSucursal { get; set; }
        public string nom_Sucursal { get; set; }
    }
}
