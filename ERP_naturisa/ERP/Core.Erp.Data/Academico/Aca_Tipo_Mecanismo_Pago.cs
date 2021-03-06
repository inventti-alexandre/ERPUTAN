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
    
    public partial class Aca_Tipo_Mecanismo_Pago
    {
        public Aca_Tipo_Mecanismo_Pago()
        {
            this.Aca_Documento_Bancario_x_Rep_Economico = new HashSet<Aca_Documento_Bancario_x_Rep_Economico>();
            this.Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula = new HashSet<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula>();
        }
    
        public int Id_tipo_meca_pago { get; set; }
        public int Id_tb_banco_x_mgbanco { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public string Tipo_cuenta { get; set; }
        public string Forma_pago { get; set; }
        public string Codigo { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public Nullable<System.DateTime> FechaCreacion { get; set; }
        public string IdUsuarioModificacion { get; set; }
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        public string Nom_pc { get; set; }
        public string ip { get; set; }
        public string IdUsuario_Responsable { get; set; }
        public string IdUsuarioAnulacion { get; set; }
        public Nullable<System.DateTime> FechaAnulacion { get; set; }
        public string MotivoAnulacion { get; set; }
        public string idProceso_Bancario_Tipo { get; set; }
    
        public virtual tb_banco_x_mg_banco tb_banco_x_mg_banco { get; set; }
        public virtual ICollection<Aca_Documento_Bancario_x_Rep_Economico> Aca_Documento_Bancario_x_Rep_Economico { get; set; }
        public virtual ICollection<Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula> Aca_Documento_Bancario_x_Rep_Economico_x_estudiante_x_Matricula { get; set; }
    }
}
