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
    
    public partial class vwACTF_Rpt014
    {
        public int IdEmpresa { get; set; }
        public Nullable<int> IdPeriodo { get; set; }
        public string nom_tipo_depreciacion { get; set; }
        public double Af_costo_compra { get; set; }
        public Nullable<double> Valor_Depre_Acum { get; set; }
        public Nullable<double> Dep_Actual { get; set; }
        public Nullable<double> Porc_Depreciacion { get; set; }
        public int IdActijoFijoTipo { get; set; }
        public string nom_ActijoFijoTipo { get; set; }
        public int IdCategoriaAF { get; set; }
        public string nom_CategoriaAF { get; set; }
        public int IdSucursal { get; set; }
        public string Su_Descripcion { get; set; }
    }
}
