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
    
    public partial class spROL_Nomina_a_Liquidar_Result
    {
        public string cargo { get; set; }
        public string departamento { get; set; }
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdPersona { get; set; }
        public Nullable<System.DateTime> em_fecha_ingreso { get; set; }
        public Nullable<System.DateTime> em_fechaSalida { get; set; }
        public Nullable<System.DateTime> em_fechaTerminoContra { get; set; }
        public Nullable<System.DateTime> em_fechaIngaRol { get; set; }
        public string em_SeAcreditaBanco { get; set; }
        public string em_tipoCta { get; set; }
        public string em_NumCta { get; set; }
        public string em_estado { get; set; }
        public int IdDepartamento { get; set; }
        public Nullable<int> IdCargo { get; set; }
        public string NomCompleto { get; set; }
        public string Apellido { get; set; }
        public string pe_razonSocial { get; set; }
        public string Nombre { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_estado { get; set; }
        public Nullable<System.DateTime> pe_fechaCreacion { get; set; }
        public Nullable<System.DateTime> pe_fechaModificacion { get; set; }
        public string Sucursal { get; set; }
        public int IdSucursal { get; set; }
        public Nullable<int> IdArea { get; set; }
        public Nullable<int> IdDivision { get; set; }
        public string em_status { get; set; }
        public Nullable<bool> es_TruncarDecimalAnticipo { get; set; }
        public int IdTipoNomina { get; set; }
        public Nullable<bool> Marca_Biometrico { get; set; }
        public string IdTipoAnticipo { get; set; }
        public Nullable<double> em_AnticipoSueldo { get; set; }
        public string Nomina { get; set; }
        public System.DateTime FechaInicio { get; set; }
        public System.DateTime FechaFin { get; set; }
        public string EstadoContrato { get; set; }
        public double Valor_Alimen { get; set; }
        public double Valor_Transp { get; set; }
        public double SueldoActual { get; set; }
        public double Valor_bono { get; set; }
        public int IdGrupo { get; set; }
        public Nullable<int> Dias_SyD { get; set; }
        public Nullable<int> Dias_Efectivos { get; set; }
        public Nullable<decimal> si_tiene_rubros_fijo { get; set; }
    }
}
