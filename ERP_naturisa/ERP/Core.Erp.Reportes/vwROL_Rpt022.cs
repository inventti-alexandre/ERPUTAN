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
    
    public partial class vwROL_Rpt022
    {
        public int IdEmpresa { get; set; }
        public int IdTipoNomina { get; set; }
        public int IdDepartamento { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdPrestamo { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string EstadoPago { get; set; }
        public string Descripcion { get; set; }
        public string de_descripcion { get; set; }
        public double Total_Prestamo { get; set; }
        public double Total_Cancelado { get; set; }
        public double Total_Pendiente_pago { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string Observacion { get; set; }
    }
}
