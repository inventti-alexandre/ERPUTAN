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
    
    public partial class vwCXC_Rpt001
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public decimal IdCobro { get; set; }
        public Nullable<decimal> IdCobro_a_aplicar { get; set; }
        public string cr_Codigo { get; set; }
        public string IdCobro_tipo { get; set; }
        public decimal IdCliente { get; set; }
        public string nombreCliente { get; set; }
        public System.DateTime cr_fecha { get; set; }
        public int IdCalendario { get; set; }
        public Nullable<int> AnioFiscal { get; set; }
        public string NombreMes { get; set; }
        public string NombreCortoFecha { get; set; }
        public double cr_TotalCobro { get; set; }
        public System.DateTime cr_fechaDocu { get; set; }
        public System.DateTime cr_fechaCobro { get; set; }
        public string cr_observacion { get; set; }
        public string Referencia { get; set; }
        public string numDocumento { get; set; }
        public Nullable<int> IdTipoNotaCredito { get; set; }
    }
}
