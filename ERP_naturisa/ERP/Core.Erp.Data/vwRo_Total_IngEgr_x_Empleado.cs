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
    
    public partial class vwRo_Total_IngEgr_x_Empleado
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdNomina_TipoLiqui { get; set; }
        public int IdPeriodo { get; set; }
        public Nullable<double> totIng { get; set; }
        public Nullable<double> totEgr { get; set; }
        public Nullable<double> totNeto { get; set; }
        public string NomCompleto { get; set; }
        public string cargo { get; set; }
        public string departamento { get; set; }
        public string em_codigo { get; set; }
        public string pe_cedulaRuc { get; set; }
    }
}
