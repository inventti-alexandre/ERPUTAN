//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ba_prestamo_detalle
    {
        public ba_prestamo_detalle()
        {
            this.ba_prestamo_detalle_cancelacion = new HashSet<ba_prestamo_detalle_cancelacion>();
        }
    
        public int IdEmpresa { get; set; }
        public decimal IdPrestamo { get; set; }
        public int NumCuota { get; set; }
        public double SaldoInicial { get; set; }
        public double Interes { get; set; }
        public double AbonoCapital { get; set; }
        public double TotalCuota { get; set; }
        public double Saldo { get; set; }
        public System.DateTime FechaPago { get; set; }
        public string EstadoPago { get; set; }
        public string Estado { get; set; }
        public string Observacion_det { get; set; }
        public string IdUsuario { get; set; }
        public System.DateTime Fecha_Transac { get; set; }
        public string IdUsuarioUltMod { get; set; }
        public Nullable<System.DateTime> Fecha_UltMod { get; set; }
        public string IdUsuarioUltAnu { get; set; }
        public Nullable<System.DateTime> Fecha_UltAnu { get; set; }
        public string nom_pc { get; set; }
        public string ip { get; set; }
        public string MotiAnula { get; set; }
    
        public virtual ba_Catalogo ba_Catalogo { get; set; }
        public virtual ICollection<ba_prestamo_detalle_cancelacion> ba_prestamo_detalle_cancelacion { get; set; }
        public virtual ba_prestamo ba_prestamo { get; set; }
    }
}
