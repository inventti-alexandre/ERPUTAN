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
    
    public partial class vwro_marcaciones_x_empleado_x_incidentes_falt_Perm
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdPersona { get; set; }
        public int IdCargo { get; set; }
        public int IdDepartamento { get; set; }
        public string IdRegistro { get; set; }
        public string Id_catalogo_Cat { get; set; }
        public string IdTipoMarcaciones { get; set; }
        public Nullable<System.TimeSpan> es_Hora { get; set; }
        public Nullable<System.DateTime> es_fechaRegistro { get; set; }
        public Nullable<int> es_anio { get; set; }
        public Nullable<int> es_mes { get; set; }
        public Nullable<int> es_semana { get; set; }
        public Nullable<int> es_dia { get; set; }
        public string es_sdia { get; set; }
        public Nullable<int> es_idDia { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_apellido { get; set; }
        public string pe_nombre { get; set; }
        public string ca_descripcion { get; set; }
        public string de_descripcion { get; set; }
    }
}