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
    
    public partial class cxc_cobro_x_EstadoCobro
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public string IdEstadoCobro { get; set; }
        public int Secuencia { get; set; }
        public string IdCobro_tipo { get; set; }
        public string observacion { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<int> nt_IdSucursal { get; set; }
        public Nullable<int> nt_IdBodega { get; set; }
        public Nullable<decimal> nt_IdNota { get; set; }
        public Nullable<int> IdBanco { get; set; }
        public Nullable<decimal> IdCbte_vta_nota { get; set; }
        public string IdUsuario { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
    
        public virtual cxc_cobro cxc_cobro { get; set; }
        public virtual cxc_EstadoCobro cxc_EstadoCobro { get; set; }
    }
}
