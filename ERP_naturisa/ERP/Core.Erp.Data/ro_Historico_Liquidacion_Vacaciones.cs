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
    
    public partial class ro_Historico_Liquidacion_Vacaciones
    {
        public ro_Historico_Liquidacion_Vacaciones()
        {
            this.ro_Historico_Liquidacion_Vacaciones_Det = new HashSet<ro_Historico_Liquidacion_Vacaciones_Det>();
        }
    
        public int IdEmpresa { get; set; }
        public int IdNomina_Tipo { get; set; }
        public int IdSolicitud_Vacaciones { get; set; }
        public decimal IdEmpleado { get; set; }
        public decimal IdOrdenPago { get; set; }
        public int IdEmpresa_OP { get; set; }
        public double ValorCancelado { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string Observaciones { get; set; }
        public string IdUsuario { get; set; }
        public string Estado { get; set; }
        public Nullable<System.DateTime> Fecha_Transac { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> FechaHoraAnul { get; set; }
        public string MotiAnula { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public string EstadoContrato { get; set; }
        public Nullable<double> Iess { get; set; }
        public string IdTipo_op { get; set; }
        public string Gozadas_Pagadas { get; set; }
    
        public virtual ICollection<ro_Historico_Liquidacion_Vacaciones_Det> ro_Historico_Liquidacion_Vacaciones_Det { get; set; }
    }
}