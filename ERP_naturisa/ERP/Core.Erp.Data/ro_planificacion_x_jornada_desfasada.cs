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
    
    public partial class ro_planificacion_x_jornada_desfasada
    {
        public ro_planificacion_x_jornada_desfasada()
        {
            this.ro_planificacion_x_jornada_desfasada_empleado = new HashSet<ro_planificacion_x_jornada_desfasada_empleado>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdPeriodo { get; set; }
        public int IdNomina_Tipo { get; set; }
        public string Observación { get; set; }
        public string Esta_Proceso { get; set; }
        public string IdUsuario { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string Estado { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ICollection<ro_planificacion_x_jornada_desfasada_empleado> ro_planificacion_x_jornada_desfasada_empleado { get; set; }
    }
}
