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
    
    public partial class ro_parametro_x_pago_variable_tipo
    {
        public ro_parametro_x_pago_variable_tipo()
        {
            this.ro_fectividad_x_empleado_Adm_x_periodo_Det = new HashSet<ro_fectividad_x_empleado_Adm_x_periodo_Det>();
            this.ro_Grupo_empleado_det = new HashSet<ro_Grupo_empleado_det>();
            this.ro_parametro_x_pago_variable_Det = new HashSet<ro_parametro_x_pago_variable_Det>();
        }
    
        public int IdEmpresa { get; set; }
        public string cod_Pago_Variable { get; set; }
        public string nom_Pago_Variable { get; set; }
        public string IdRubro { get; set; }
    
        public virtual ICollection<ro_fectividad_x_empleado_Adm_x_periodo_Det> ro_fectividad_x_empleado_Adm_x_periodo_Det { get; set; }
        public virtual ICollection<ro_Grupo_empleado_det> ro_Grupo_empleado_det { get; set; }
        public virtual ICollection<ro_parametro_x_pago_variable_Det> ro_parametro_x_pago_variable_Det { get; set; }
    }
}
