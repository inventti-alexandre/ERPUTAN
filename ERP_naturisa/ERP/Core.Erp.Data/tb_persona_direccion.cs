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
    
    public partial class tb_persona_direccion
    {
        public decimal IdPersona { get; set; }
        public int IdDireccion { get; set; }
        public int prioridad { get; set; }
        public string Direccion { get; set; }
        public string referencia { get; set; }
        public string calle { get; set; }
        public string cod_postal { get; set; }
        public string IdPais { get; set; }
        public string Provincia { get; set; }
        public string Ciudad { get; set; }
        public bool estado { get; set; }
        public int IdTipoDireccion { get; set; }
    
        public virtual tb_persona tb_persona { get; set; }
        public virtual tb_persona_direccion_tipo tb_persona_direccion_tipo { get; set; }
    }
}
