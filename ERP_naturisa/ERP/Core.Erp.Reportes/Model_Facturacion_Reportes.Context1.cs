﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Core.Erp.Reportes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EntitiesFacturacion_Reportes : DbContext
    {
        public EntitiesFacturacion_Reportes()
            : base("name=EntitiesFacturacion_Reportes")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwFAC_Rpt003> vwFAC_Rpt003 { get; set; }
        public DbSet<vwFAC_Rpt005> vwFAC_Rpt005 { get; set; }
        public DbSet<vwFAC_Rpt006> vwFAC_Rpt006 { get; set; }
        public DbSet<vwFAC_Rpt007> vwFAC_Rpt007 { get; set; }
        public DbSet<vwFAC_Rpt009> vwFAC_Rpt009 { get; set; }
        public DbSet<vwFAC_Rpt010> vwFAC_Rpt010 { get; set; }
        public DbSet<vwFAC_Rpt011> vwFAC_Rpt011 { get; set; }
        public DbSet<vwFAC_Rpt012> vwFAC_Rpt012 { get; set; }
        public DbSet<vwFAC_Rpt013> vwFAC_Rpt013 { get; set; }
        public DbSet<vwFAC_Rpt001> vwFAC_Rpt001 { get; set; }
        public DbSet<vwFAC_Rpt004> vwFAC_Rpt004 { get; set; }
        public DbSet<vwFAC_Rpt002> vwFAC_Rpt002 { get; set; }
        public DbSet<vwFAC_Rpt004_Detalle> vwFAC_Rpt004_Detalle { get; set; }
        public DbSet<vwFAC_Rpt008> vwFAC_Rpt008 { get; set; }
    
        public virtual ObjectResult<spFAC_Rpt013_Result> spFAC_Rpt013(Nullable<int> idEmpresa, Nullable<decimal> idCliente, Nullable<System.DateTime> fechaIni, Nullable<System.DateTime> fechaFin)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(decimal));
    
            var fechaIniParameter = fechaIni.HasValue ?
                new ObjectParameter("FechaIni", fechaIni) :
                new ObjectParameter("FechaIni", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spFAC_Rpt013_Result>("spFAC_Rpt013", idEmpresaParameter, idClienteParameter, fechaIniParameter, fechaFinParameter);
        }
    }
}
