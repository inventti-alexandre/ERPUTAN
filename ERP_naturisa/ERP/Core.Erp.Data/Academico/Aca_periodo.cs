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
    
    public partial class Aca_periodo
    {
        public Aca_periodo()
        {
            this.Aca_Rubro_x_Aca_Periodo_Lectivo = new HashSet<Aca_Rubro_x_Aca_Periodo_Lectivo>();
        }
    
        public int IdInstitucion { get; set; }
        public int IdAnioLectivo { get; set; }
        public int IdPeriodo { get; set; }
        public int pe_anio { get; set; }
        public int pe_mes { get; set; }
        public System.DateTime pe_FechaIni { get; set; }
        public System.DateTime pe_FechaFin { get; set; }
        public string pe_estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string MotivoAnulacion { get; set; }
        public string est_apertura { get; set; }
    
        public virtual Aca_Anio_Lectivo Aca_Anio_Lectivo { get; set; }
        public virtual ICollection<Aca_Rubro_x_Aca_Periodo_Lectivo> Aca_Rubro_x_Aca_Periodo_Lectivo { get; set; }
    }
}