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
    
    public partial class vwRo_Rol_Rubros_Acumulados
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string CedulaRuc { get; set; }
        public string IdRubro { get; set; }
        public string RubroDescripcion { get; set; }
        public double Valor { get; set; }
        public string EstadoAcumulado { get; set; }
        public int IdPeriodo { get; set; }
        public string Cerrado { get; set; }
        public string Procesado { get; set; }
        public string Contabilizado { get; set; }
        public Nullable<int> pe_anio { get; set; }
        public Nullable<int> pe_mes { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
    }
}
