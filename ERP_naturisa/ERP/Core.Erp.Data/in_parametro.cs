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
    
    public partial class in_parametro
    {
        public int IdEmpresa { get; set; }
        public string IdCentroCosto_Padre_a_cargar { get; set; }
        public string LabelCentroCosto { get; set; }
        public Nullable<int> IdMovi_inven_tipo_egresoBodegaOrigen { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ingresoBodegaDestino { get; set; }
        public string Maneja_Stock_Negativo { get; set; }
        public string Usuario_Escoge_Motivo { get; set; }
        public Nullable<int> IdMovi_inven_tipo_egresoAjuste { get; set; }
        public Nullable<int> IdMovi_inven_tipo_ingresoAjuste { get; set; }
        public string Mostrar_CentroCosto_en_transacciones { get; set; }
        public Nullable<int> Rango_Busqueda_Transacciones { get; set; }
        public string pa_EstadoInicial_Pedido { get; set; }
        public string IdCtaCble_Inven { get; set; }
        public string IdCtaCble_CostoInven { get; set; }
        public Nullable<int> IdTipoCbte_CostoInven { get; set; }
        public Nullable<int> IdBodegaSuministro { get; set; }
        public string IdCentro_Costo_Inventario { get; set; }
        public string IdCentro_Costo_Costo { get; set; }
        public Nullable<int> IdTipoCbte_CostoInven_Reverso { get; set; }
        public Nullable<int> IdMovi_Inven_tipo_x_anu_Ing { get; set; }
        public Nullable<int> IdMovi_Inven_tipo_x_anu_Egr { get; set; }
        public Nullable<int> IdMovi_Inven_tipo_Ing_Ajust_fis_x_defa { get; set; }
        public Nullable<int> IdMovi_Inven_tipo_Egr_Ajust_fis_x_defa { get; set; }
        public string ApruebaAjusteFisicoAuto { get; set; }
        public Nullable<int> IdSucursal_Suministro { get; set; }
        public string IdEstadoAproba_x_Ing { get; set; }
        public string IdEstadoAproba_x_Egr { get; set; }
        public Nullable<int> IdMovi_Inven_tipo_x_Dev_Inv_x_Ing { get; set; }
        public Nullable<int> IdMovi_Inven_tipo_x_Dev_Inv_x_Erg { get; set; }
        public Nullable<bool> P_Grabar_Items_x_Cada_Movi_Inven { get; set; }
        public string P_Fecha_para_contabilizacion_ingr_egr { get; set; }
        public Nullable<bool> P_se_valida_parametrizacion_x_producto { get; set; }
        public string P_Al_Conta_CtaInven_Buscar_en { get; set; }
        public string P_Al_Conta_CtaCosto_Buscar_en { get; set; }
        public string P_IdCtaCble_transitoria_transf_inven { get; set; }
        public Nullable<int> IdMovi_inven_tipo_mobile_ing { get; set; }
        public Nullable<int> IdMovi_inven_tipo_mobile_egr { get; set; }
    
        public virtual in_Catalogo in_Catalogo { get; set; }
        public virtual in_Catalogo in_Catalogo1 { get; set; }
        public virtual in_Ing_Egr_Inven_estado_apro in_Ing_Egr_Inven_estado_apro { get; set; }
        public virtual in_Ing_Egr_Inven_estado_apro in_Ing_Egr_Inven_estado_apro1 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo1 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo2 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo3 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo4 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo5 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo6 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo7 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo8 { get; set; }
        public virtual in_movi_inven_tipo in_movi_inven_tipo9 { get; set; }
    }
}
