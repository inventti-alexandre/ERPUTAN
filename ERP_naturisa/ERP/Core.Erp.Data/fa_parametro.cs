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
    
    public partial class fa_parametro
    {
        public int IdEmpresa { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Factura { get; set; }
        public Nullable<double> pa_porc_max_total_item_x_despa_Guia { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Dev_Vta { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Factura_Anulacion { get; set; }
        public Nullable<int> IdMovi_inven_tipo_Dev_Vta_Anulacion { get; set; }
        public Nullable<int> Tipo_NC_x_DevVta { get; set; }
        public Nullable<int> IdDepartamento_x_DevVta { get; set; }
        public Nullable<int> IdTipoCbteCble_Factura { get; set; }
        public Nullable<int> IdTipoCbteCble_Factura_Reverso { get; set; }
        public Nullable<int> IdTipoCbteCble_Factura_Costo_VTA { get; set; }
        public Nullable<int> IdTipoCbteCble_Factura_Costo_VTA_Reverso { get; set; }
        public Nullable<int> IdTipoCbteCble_NC { get; set; }
        public Nullable<int> IdTipoCbteCble_NC_Reverso { get; set; }
        public Nullable<int> IdTipoCbteCble_ND { get; set; }
        public Nullable<int> IdTipoCbteCble_ND_Reverso { get; set; }
        public string SeImprimiGuiaRemiAuto { get; set; }
        public Nullable<int> NumeroDeItemFact { get; set; }
        public string TipoCobroDafaultFactu { get; set; }
        public Nullable<int> IdCaja_Default_Factura { get; set; }
        public string IdCtaCble_x_anticipo_cliente { get; set; }
        public Nullable<int> pa_IdTipoNota_NC_x_Anulacion { get; set; }
        public string IdEstadoAprobacion { get; set; }
        public string pa_ruta_descarga_xml_fac_elct { get; set; }
        public byte[] File_Reporte_FacturaDiseño { get; set; }
        public byte[] File_Reporte_Nota_CRED_DEB { get; set; }
        public string IdCtaCble_IVA { get; set; }
        public string IdCtaCble_SubTotal_Vtas_x_Default { get; set; }
        public string IdCtaCble_CXC_Vtas_x_Default { get; set; }
        public Nullable<bool> pa_X_Defecto_la_factura_es_cbte_elect { get; set; }
        public Nullable<bool> pa_X_Defecto_la_guia_es_cbte_elect { get; set; }
        public Nullable<bool> pa_X_Defecto_la_ND_es_cbte_elect { get; set; }
        public Nullable<bool> pa_X_Defecto_la_NC_es_cbte_elect { get; set; }
    
        public virtual fa_pedido_estadoAprobacion fa_pedido_estadoAprobacion { get; set; }
        public virtual fa_TipoNota fa_TipoNota { get; set; }
    }
}
