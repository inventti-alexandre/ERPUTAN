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
    
    public partial class ro_empleado_x_Proyeccion_Gastos_Personales
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public string IdTipoGasto { get; set; }
        public int AnioFiscal { get; set; }
        public double Valor { get; set; }
        public System.DateTime FechaIngresa { get; set; }
        public string UsuarioIngresa { get; set; }
        public Nullable<System.DateTime> FechaModifica { get; set; }
        public string UsuarioModifica { get; set; }
    
        public virtual ro_tipo_gastos_personales ro_tipo_gastos_personales { get; set; }
        public virtual ro_empleado ro_empleado { get; set; }
    }
}
