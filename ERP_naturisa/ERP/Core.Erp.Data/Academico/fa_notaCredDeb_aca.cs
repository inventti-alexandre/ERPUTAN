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
    
    public partial class fa_notaCredDeb_aca
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNotaCredDeb { get; set; }
        public Nullable<int> IdInstitucion { get; set; }
        public decimal IdEstudiante { get; set; }
        public string Observaciones { get; set; }
    
        public virtual Aca_estudiante Aca_estudiante { get; set; }
    }
}
