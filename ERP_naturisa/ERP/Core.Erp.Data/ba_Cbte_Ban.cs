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
    
    public partial class ba_Cbte_Ban
    {
        public ba_Cbte_Ban()
        {
            this.ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito = new HashSet<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito>();
            this.ba_transferencia = new HashSet<ba_transferencia>();
            this.ba_transferencia1 = new HashSet<ba_transferencia>();
            this.ba_Archivo_Transferencia_x_PreAviso_Cheq_det = new HashSet<ba_Archivo_Transferencia_x_PreAviso_Cheq_det>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdCbteCble { get; set; }
        public int IdTipocbte { get; set; }
        public string Cod_Cbtecble { get; set; }
        public int IdPeriodo { get; set; }
        public int IdBanco { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public System.DateTime cb_Fecha { get; set; }
        public string cb_Observacion { get; set; }
        public decimal cb_secuencia { get; set; }
        public double cb_Valor { get; set; }
        public string cb_Cheque { get; set; }
        public string cb_ChequeImpreso { get; set; }
        public Nullable<System.DateTime> cb_FechaCheque { get; set; }
        public string IdUsuario { get; set; }
        public string IdUsuario_Anu { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public string Estado { get; set; }
        public string MotivoAnulacion { get; set; }
        public string ip { get; set; }
        public string nom_pc { get; set; }
        public Nullable<decimal> IdPersona_Girado_a { get; set; }
        public string cb_giradoA { get; set; }
        public string cb_ciudadChq { get; set; }
        public Nullable<decimal> IdCbteCble_Anulacion { get; set; }
        public Nullable<int> IdTipoCbte_Anulacion { get; set; }
        public Nullable<decimal> IdTipoFlujo { get; set; }
        public Nullable<int> IdTipoNota { get; set; }
        public string IdTransaccion { get; set; }
        public string Por_Anticipo { get; set; }
        public string PosFechado { get; set; }
        public string ValorEnLetras { get; set; }
        public Nullable<int> IdSucursal { get; set; }
        public string IdEstado_Cbte_Ban_cat { get; set; }
        public string IdEstado_Preaviso_ch_cat { get; set; }
        public string IdEstado_cheque_cat { get; set; }
    
        public virtual ba_Banco_Cuenta ba_Banco_Cuenta { get; set; }
        public virtual ICollection<ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito> ba_Caja_Movimiento_x_Cbte_Ban_x_Deposito { get; set; }
        public virtual ba_Catalogo ba_Catalogo { get; set; }
        public virtual ba_tipo_nota ba_tipo_nota { get; set; }
        public virtual ba_TipoFlujo ba_TipoFlujo { get; set; }
        public virtual ICollection<ba_transferencia> ba_transferencia { get; set; }
        public virtual ICollection<ba_transferencia> ba_transferencia1 { get; set; }
        public virtual ICollection<ba_Archivo_Transferencia_x_PreAviso_Cheq_det> ba_Archivo_Transferencia_x_PreAviso_Cheq_det { get; set; }
        public virtual ba_Catalogo ba_Catalogo1 { get; set; }
        public virtual ba_Cbte_Ban_Datos_Entrega_cheq ba_Cbte_Ban_Datos_Entrega_cheq { get; set; }
    }
}
