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
    
    public partial class vwaf_fa_tarifario_facturacion_x_cliente_det_x_ActivoFijo
    {
        public int IdEmpresa { get; set; }
        public decimal IdTarifario { get; set; }
        public int IdActivoFijo { get; set; }
        public Nullable<double> Valor_x_Unidad { get; set; }
        public Nullable<double> Unidades_minimas { get; set; }
        public string Af_Nombre { get; set; }
        public string CodActivoFijo { get; set; }
        public string IdUnidadFact_cat { get; set; }
        public string Descripcion { get; set; }
        public int IdCategoriaAF { get; set; }
        public string Categoria { get; set; }
        public string CodCategoriaAF { get; set; }
        public int IdActivoFijoTipo { get; set; }
        public Nullable<int> Num_empleado_relacionado { get; set; }
    }
}
