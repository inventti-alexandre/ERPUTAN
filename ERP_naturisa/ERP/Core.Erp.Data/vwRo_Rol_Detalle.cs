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
    
    public partial class vwRo_Rol_Detalle
    {
        public decimal IdEmpleado { get; set; }
        public string Ruc { get; set; }
        public string Empleado { get; set; }
        public string IdRubro { get; set; }
        public string Tag { get; set; }
        public string DescRubroLargo { get; set; }
        public string DescNombreRubroCorto { get; set; }
        public int Orden { get; set; }
        public double Valor { get; set; }
        public string NominaLiqui { get; set; }
        public string Nomina { get; set; }
        public string Empresa { get; set; }
        public int IdEmpresa { get; set; }
        public string Departamento { get; set; }
        public int IdNominaTipo { get; set; }
        public int IdNominaTipoLiqui { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public Nullable<bool> rub_visible_reporte { get; set; }
        public string Observacion { get; set; }
        public string TipoMovimiento { get; set; }
        public string EstadoRol { get; set; }
        public string IdCentroCosto { get; set; }
        public int IdPeriodo { get; set; }
        public Nullable<int> pe_anio { get; set; }
        public Nullable<int> pe_mes { get; set; }
        public System.DateTime FechaIni { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string Cerrado { get; set; }
        public string Procesado { get; set; }
        public string Contabilizado { get; set; }
        public Nullable<int> rub_grupo { get; set; }
        public int IdSucursal { get; set; }
        public int IdDepartamento { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public Nullable<int> IdArea { get; set; }
        public string StatusEmpleado { get; set; }
        public string EstadoEmpleado { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string ru_tipo { get; set; }
        public Nullable<bool> rub_aplica_IESS { get; set; }
        public Nullable<bool> rub_nocontab { get; set; }
        public Nullable<bool> rub_acumula { get; set; }
        public Nullable<bool> rub_provision { get; set; }
        public Nullable<bool> rub_antici { get; set; }
        public string rub_gencon { get; set; }
        public string rub_foract { get; set; }
        public Nullable<int> rub_tipcal { get; set; }
    }
}
