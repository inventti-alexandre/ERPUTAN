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
    
    public partial class ro_marcaciones_tipo
    {
        public ro_marcaciones_tipo()
        {
            this.ro_marcaciones_Equipo_x_TipoMarcacion = new HashSet<ro_marcaciones_Equipo_x_TipoMarcacion>();
            this.ro_marcaciones_x_empleado = new HashSet<ro_marcaciones_x_empleado>();
        }
    
        public string IdTipoMarcaciones { get; set; }
        public string ma_descripcion { get; set; }
    
        public virtual ICollection<ro_marcaciones_Equipo_x_TipoMarcacion> ro_marcaciones_Equipo_x_TipoMarcacion { get; set; }
        public virtual ICollection<ro_marcaciones_x_empleado> ro_marcaciones_x_empleado { get; set; }
    }
}