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
    
    public partial class ro_parametro_contable_x_Nomina_Tipoliqui_Sueldo_x_Pagar
    {
        public int IdEmpresa { get; set; }
        public int IdNomina { get; set; }
        public int IdNominaTipo { get; set; }
        public string IdCtaCble { get; set; }
        public string Observacion { get; set; }
    
        public virtual ro_Nomina_Tipoliqui ro_Nomina_Tipoliqui { get; set; }
    }
}