//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data.Academico
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aca_estudiante_x_Alergia
    {
        public int IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public string IdAlergia_catalogo { get; set; }
        public string descripcion { get; set; }
        public bool activo { get; set; }
    
        public virtual Aca_Catalogo Aca_Catalogo { get; set; }
        public virtual Aca_estudiante Aca_estudiante { get; set; }
    }
}
