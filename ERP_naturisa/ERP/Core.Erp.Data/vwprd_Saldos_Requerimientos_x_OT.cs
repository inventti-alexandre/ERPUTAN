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
    
    public partial class vwprd_Saldos_Requerimientos_x_OT
    {
        public int IdEmpresa { get; set; }
        public decimal IdTransaccion { get; set; }
        public int IdDetTrans { get; set; }
        public Nullable<decimal> IdProveedor { get; set; }
        public string CodObra { get; set; }
        public decimal IdOrdenTaller { get; set; }
        public decimal IdProducto { get; set; }
        public double Cantidad { get; set; }
        public int IdSucursal { get; set; }
        public string Codigo { get; set; }
        public Nullable<decimal> IdListadoMateriales { get; set; }
        public Nullable<int> IdDetalle { get; set; }
        public Nullable<int> oc_IdEmpresa { get; set; }
        public Nullable<decimal> oc_IdOrdenCompra { get; set; }
        public string IdEstadoAprob { get; set; }
        public string oc_NumDocumento { get; set; }
        public string EstadoRecepcion { get; set; }
    }
}
