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
    
    public partial class EntitiesCXP_General : DbContext
    {
        public EntitiesCXP_General()
            : base("name=EntitiesCXP_General")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwCXP_Rpt001> vwCXP_Rpt001 { get; set; }
        public DbSet<vwCXP_Rpt002> vwCXP_Rpt002 { get; set; }
        public DbSet<vwCXP_Rpt003> vwCXP_Rpt003 { get; set; }
        public DbSet<vwCXP_Rpt004> vwCXP_Rpt004 { get; set; }
        public DbSet<vwCXP_Rpt005> vwCXP_Rpt005 { get; set; }
        public DbSet<vwCXP_Rpt006> vwCXP_Rpt006 { get; set; }
        public DbSet<vwCXP_Rpt007> vwCXP_Rpt007 { get; set; }
        public DbSet<vwCXP_Rpt010> vwCXP_Rpt010 { get; set; }
        public DbSet<vwCXP_Rpt011> vwCXP_Rpt011 { get; set; }
        public DbSet<vwCXP_Rpt012> vwCXP_Rpt012 { get; set; }
        public DbSet<vwCXP_Rpt015> vwCXP_Rpt015 { get; set; }
        public DbSet<vwCXP_Rpt016> vwCXP_Rpt016 { get; set; }
        public DbSet<vwCXP_Rpt018> vwCXP_Rpt018 { get; set; }
        public DbSet<vwCXP_Rpt019> vwCXP_Rpt019 { get; set; }
        public DbSet<vwCXP_Rpt021> vwCXP_Rpt021 { get; set; }
        public DbSet<vwCXP_Rpt022> vwCXP_Rpt022 { get; set; }
        public DbSet<vwCXP_Rpt023> vwCXP_Rpt023 { get; set; }
        public DbSet<vwCXP_Rpt024> vwCXP_Rpt024 { get; set; }
        public DbSet<vwCXP_Rpt025> vwCXP_Rpt025 { get; set; }
        public DbSet<vwCXP_Rpt026> vwCXP_Rpt026 { get; set; }
        public DbSet<vwCXP_Rpt027> vwCXP_Rpt027 { get; set; }
        public DbSet<vwCXP_Rpt028> vwCXP_Rpt028 { get; set; }
        public DbSet<vwCXP_Rpt029> vwCXP_Rpt029 { get; set; }
        public DbSet<vwCXP_Rpt030> vwCXP_Rpt030 { get; set; }
        public DbSet<vwCXP_Rpt031> vwCXP_Rpt031 { get; set; }
        public DbSet<vwCXP_Rpt032> vwCXP_Rpt032 { get; set; }
        public DbSet<vwCXP_Rpt033> vwCXP_Rpt033 { get; set; }
        public DbSet<vwCXP_Rpt034> vwCXP_Rpt034 { get; set; }
    
        public virtual ObjectResult<spCXP_Rpt008_Result> spCXP_Rpt008(Nullable<int> idEmpresa, Nullable<int> idClase_ini, Nullable<int> idClase_fin, Nullable<decimal> idProveedor_ini, Nullable<decimal> idProveedor_fin, Nullable<System.DateTime> fecha_corte)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idClase_iniParameter = idClase_ini.HasValue ?
                new ObjectParameter("IdClase_ini", idClase_ini) :
                new ObjectParameter("IdClase_ini", typeof(int));
    
            var idClase_finParameter = idClase_fin.HasValue ?
                new ObjectParameter("IdClase_fin", idClase_fin) :
                new ObjectParameter("IdClase_fin", typeof(int));
    
            var idProveedor_iniParameter = idProveedor_ini.HasValue ?
                new ObjectParameter("IdProveedor_ini", idProveedor_ini) :
                new ObjectParameter("IdProveedor_ini", typeof(decimal));
    
            var idProveedor_finParameter = idProveedor_fin.HasValue ?
                new ObjectParameter("IdProveedor_fin", idProveedor_fin) :
                new ObjectParameter("IdProveedor_fin", typeof(decimal));
    
            var fecha_corteParameter = fecha_corte.HasValue ?
                new ObjectParameter("Fecha_corte", fecha_corte) :
                new ObjectParameter("Fecha_corte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXP_Rpt008_Result>("spCXP_Rpt008", idEmpresaParameter, idClase_iniParameter, idClase_finParameter, idProveedor_iniParameter, idProveedor_finParameter, fecha_corteParameter);
        }
    
        public virtual ObjectResult<spCXP_Rpt013_Result> spCXP_Rpt013(Nullable<int> idempresa, Nullable<System.DateTime> fecha, Nullable<decimal> idProveedorIni, Nullable<decimal> idProveedorFIn)
        {
            var idempresaParameter = idempresa.HasValue ?
                new ObjectParameter("idempresa", idempresa) :
                new ObjectParameter("idempresa", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var idProveedorIniParameter = idProveedorIni.HasValue ?
                new ObjectParameter("idProveedorIni", idProveedorIni) :
                new ObjectParameter("idProveedorIni", typeof(decimal));
    
            var idProveedorFInParameter = idProveedorFIn.HasValue ?
                new ObjectParameter("idProveedorFIn", idProveedorFIn) :
                new ObjectParameter("idProveedorFIn", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXP_Rpt013_Result>("spCXP_Rpt013", idempresaParameter, fechaParameter, idProveedorIniParameter, idProveedorFInParameter);
        }
    
        public virtual ObjectResult<spCXP_Rpt014_Result> spCXP_Rpt014(Nullable<int> idempresa, Nullable<System.DateTime> fecha, Nullable<decimal> idProveedorIni, Nullable<decimal> idProveedorFIn)
        {
            var idempresaParameter = idempresa.HasValue ?
                new ObjectParameter("idempresa", idempresa) :
                new ObjectParameter("idempresa", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var idProveedorIniParameter = idProveedorIni.HasValue ?
                new ObjectParameter("idProveedorIni", idProveedorIni) :
                new ObjectParameter("idProveedorIni", typeof(decimal));
    
            var idProveedorFInParameter = idProveedorFIn.HasValue ?
                new ObjectParameter("idProveedorFIn", idProveedorFIn) :
                new ObjectParameter("idProveedorFIn", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXP_Rpt014_Result>("spCXP_Rpt014", idempresaParameter, fechaParameter, idProveedorIniParameter, idProveedorFInParameter);
        }
    
        public virtual ObjectResult<spCXP_Rpt017_Result> spCXP_Rpt017(Nullable<int> idempresa, Nullable<System.DateTime> fecha, Nullable<decimal> idProveedorIni, Nullable<decimal> idProveedorFIn)
        {
            var idempresaParameter = idempresa.HasValue ?
                new ObjectParameter("idempresa", idempresa) :
                new ObjectParameter("idempresa", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var idProveedorIniParameter = idProveedorIni.HasValue ?
                new ObjectParameter("idProveedorIni", idProveedorIni) :
                new ObjectParameter("idProveedorIni", typeof(decimal));
    
            var idProveedorFInParameter = idProveedorFIn.HasValue ?
                new ObjectParameter("idProveedorFIn", idProveedorFIn) :
                new ObjectParameter("idProveedorFIn", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXP_Rpt017_Result>("spCXP_Rpt017", idempresaParameter, fechaParameter, idProveedorIniParameter, idProveedorFInParameter);
        }
    
        public virtual ObjectResult<spCXP_Rpt035_Result> spCXP_Rpt035(Nullable<int> idempresa, Nullable<System.DateTime> fecha, Nullable<decimal> idProveedorIni, Nullable<decimal> idProveedorFIn)
        {
            var idempresaParameter = idempresa.HasValue ?
                new ObjectParameter("idempresa", idempresa) :
                new ObjectParameter("idempresa", typeof(int));
    
            var fechaParameter = fecha.HasValue ?
                new ObjectParameter("fecha", fecha) :
                new ObjectParameter("fecha", typeof(System.DateTime));
    
            var idProveedorIniParameter = idProveedorIni.HasValue ?
                new ObjectParameter("idProveedorIni", idProveedorIni) :
                new ObjectParameter("idProveedorIni", typeof(decimal));
    
            var idProveedorFInParameter = idProveedorFIn.HasValue ?
                new ObjectParameter("idProveedorFIn", idProveedorFIn) :
                new ObjectParameter("idProveedorFIn", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXP_Rpt035_Result>("spCXP_Rpt035", idempresaParameter, fechaParameter, idProveedorIniParameter, idProveedorFInParameter);
        }
    }
}
