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
    
    public partial class spACTF_activos_a_depreciar_Result
    {
        public int IdEmpresa { get; set; }
        public int IdActivoFijo { get; set; }
        public string CodActivoFijo { get; set; }
        public string Af_Nombre { get; set; }
        public string IdUsuario { get; set; }
        public double Af_costo_compra { get; set; }
        public double Af_depreciacion_acum { get; set; }
        public double Af_valor_depreciacion { get; set; }
        public Nullable<int> IdActijoFijoTipo { get; set; }
        public string nom_tipo { get; set; }
        public Nullable<int> IdCategoriaAF { get; set; }
        public string nom_categoria { get; set; }
        public Nullable<double> Af_porcentaje_deprec { get; set; }
        public double Valor_importe { get; set; }
    }
}
