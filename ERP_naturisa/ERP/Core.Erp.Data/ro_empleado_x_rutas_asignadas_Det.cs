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
    
    public partial class ro_empleado_x_rutas_asignadas_Det
    {
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public decimal IdEmpleado { get; set; }
        public int IdRuta { get; set; }
        public int secuencia { get; set; }
    
        public virtual ro_empleado_x_rutas_asignadas ro_empleado_x_rutas_asignadas { get; set; }
        public virtual ro_ruta ro_ruta { get; set; }
    }
}