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
    
    public partial class ro_empleado_estudios
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public int Secuencia { get; set; }
        public string IdInstitucion { get; set; }
        public string Carrera { get; set; }
        public string IdEstudios { get; set; }
        public string Observacion { get; set; }
    
        public virtual ro_empleado ro_empleado { get; set; }
    }
}
