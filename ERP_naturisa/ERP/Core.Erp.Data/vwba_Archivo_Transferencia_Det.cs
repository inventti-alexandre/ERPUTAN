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
    
    public partial class vwba_Archivo_Transferencia_Det
    {
        public int IdEmpresa { get; set; }
        public decimal IdArchivo { get; set; }
        public int Secuencia { get; set; }
        public string IdProceso_bancario { get; set; }
        public string Origen_Archivo { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string num_cta_acreditacion { get; set; }
        public string pe_nombreCompleto { get; set; }
        public decimal Valor { get; set; }
        public decimal Valor_cobrado { get; set; }
        public decimal Saldo { get; set; }
        public string IdEstadoRegistro_cat { get; set; }
        public string nom_EstadoRegistro_cat { get; set; }
        public string Id_Item { get; set; }
        public string IdOrden_Bancaria { get; set; }
        public System.DateTime Fecha { get; set; }
        public int IdBanco { get; set; }
        public Nullable<decimal> Secuencial_reg_x_proceso { get; set; }
        public Nullable<int> IdEmpresa_pago { get; set; }
        public Nullable<int> IdTipoCbte_pago { get; set; }
        public Nullable<decimal> IdCbteCble_pago { get; set; }
        public string cb_Estado { get; set; }
        public Nullable<int> IdEmpresa_fac { get; set; }
        public Nullable<int> IdSucursal_fac { get; set; }
        public Nullable<int> IdBodega_fac { get; set; }
        public Nullable<decimal> IdCbteVta_fac { get; set; }
    }
}
