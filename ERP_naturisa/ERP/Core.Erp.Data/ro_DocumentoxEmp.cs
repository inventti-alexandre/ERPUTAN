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
    
    public partial class ro_DocumentoxEmp
    {
        public int IdEmpresa { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdDocumento { get; set; }
        public string Dc_Nombre { get; set; }
        public string Dc_Descripcion { get; set; }
        public byte[] Documento { get; set; }
        public string tipo { get; set; }
        public System.DateTime FechaReg { get; set; }
        public Nullable<System.DateTime> FechaElimin { get; set; }
        public string UsuarioElimin { get; set; }
        public string MotivoElimin { get; set; }
        public string Estado { get; set; }
    
        public virtual ro_empleado ro_empleado { get; set; }
    }
}