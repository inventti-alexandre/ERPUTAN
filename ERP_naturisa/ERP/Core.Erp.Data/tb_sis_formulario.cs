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
    
    public partial class tb_sis_formulario
    {
        public tb_sis_formulario()
        {
            this.tb_sis_reporte_x_formulario = new HashSet<tb_sis_reporte_x_formulario>();
        }
    
        public string IdFormulario { get; set; }
        public string cod_Formulario { get; set; }
        public string nom_Formulario { get; set; }
        public string CodModulo { get; set; }
        public string Text { get; set; }
        public string observacion { get; set; }
        public bool estado { get; set; }
        public string nom_Asembly { get; set; }
    
        public virtual tb_modulo tb_modulo { get; set; }
        public virtual ICollection<tb_sis_reporte_x_formulario> tb_sis_reporte_x_formulario { get; set; }
    }
}
