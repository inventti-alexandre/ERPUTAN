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
    
    public partial class vwba_Archivo_Transferencia
    {
        public int IdEmpresa { get; set; }
        public string nom_empresa { get; set; }
        public decimal IdArchivo { get; set; }
        public int IdBanco { get; set; }
        public string nom_banco { get; set; }
        public string Origen_Archivo { get; set; }
        public string Cod_Empresa { get; set; }
        public string Nom_Archivo { get; set; }
        public System.DateTime Fecha { get; set; }
        public string IdEstadoArchivo_cat { get; set; }
        public string nom_EstadoArchivo { get; set; }
        public string Observacion { get; set; }
        public bool Estado { get; set; }
        public string CodigoLegal { get; set; }
        public string IdOrden_Bancaria { get; set; }
        public string cod_archivo { get; set; }
        public Nullable<decimal> Valor_Enviado { get; set; }
        public Nullable<decimal> Valor_cobrado { get; set; }
        public Nullable<decimal> Saldo_x_Cobrar { get; set; }
        public string IdMotivoArchivo_cat { get; set; }
        public string nom_MotivoArchivo { get; set; }
        public string nom_proceso_bancario { get; set; }
        public Nullable<System.DateTime> Fecha_Proceso { get; set; }
        public string IdProceso_bancario_tipo { get; set; }
        public Nullable<bool> Contabilizado { get; set; }
    }
}
