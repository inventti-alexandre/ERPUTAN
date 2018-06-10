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
    
    public partial class Entities_CuentasxCobrar : DbContext
    {
        public Entities_CuentasxCobrar()
            : base("name=Entities_CuentasxCobrar")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<vwCXC_Rpt002> vwCXC_Rpt002 { get; set; }
        public DbSet<vwCXC_Rpt003> vwCXC_Rpt003 { get; set; }
        public DbSet<vwCXC_Rpt005> vwCXC_Rpt005 { get; set; }
        public DbSet<vwCXC_Rpt011> vwCXC_Rpt011 { get; set; }
        public DbSet<vwCXC_Rpt001> vwCXC_Rpt001 { get; set; }
        public DbSet<vwCXC_Rpt004> vwCXC_Rpt004 { get; set; }
        public DbSet<vwCXC_Rpt006> vwCXC_Rpt006 { get; set; }
        public DbSet<vwCXC_Rpt007> vwCXC_Rpt007 { get; set; }
        public DbSet<vwCXC_Rpt014> vwCXC_Rpt014 { get; set; }
        public DbSet<vwCXC_Rpt016> vwCXC_Rpt016 { get; set; }
        public DbSet<vwCXC_Rpt013> vwCXC_Rpt013 { get; set; }
    
        public virtual ObjectResult<spCXC_Rpt008_Result> spCXC_Rpt008(Nullable<int> idEmpresa, Nullable<int> sucursalIni, Nullable<int> sucursalFin, Nullable<System.DateTime> fechaCorte)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var sucursalIniParameter = sucursalIni.HasValue ?
                new ObjectParameter("SucursalIni", sucursalIni) :
                new ObjectParameter("SucursalIni", typeof(int));
    
            var sucursalFinParameter = sucursalFin.HasValue ?
                new ObjectParameter("SucursalFin", sucursalFin) :
                new ObjectParameter("SucursalFin", typeof(int));
    
            var fechaCorteParameter = fechaCorte.HasValue ?
                new ObjectParameter("fechaCorte", fechaCorte) :
                new ObjectParameter("fechaCorte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXC_Rpt008_Result>("spCXC_Rpt008", idEmpresaParameter, sucursalIniParameter, sucursalFinParameter, fechaCorteParameter);
        }
    
        public virtual ObjectResult<spCXC_Rpt010_Result> spCXC_Rpt010(Nullable<int> idEmpresa, Nullable<int> sucursalIni, Nullable<int> sucursalFin, Nullable<System.DateTime> fechaCorte)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var sucursalIniParameter = sucursalIni.HasValue ?
                new ObjectParameter("SucursalIni", sucursalIni) :
                new ObjectParameter("SucursalIni", typeof(int));
    
            var sucursalFinParameter = sucursalFin.HasValue ?
                new ObjectParameter("SucursalFin", sucursalFin) :
                new ObjectParameter("SucursalFin", typeof(int));
    
            var fechaCorteParameter = fechaCorte.HasValue ?
                new ObjectParameter("fechaCorte", fechaCorte) :
                new ObjectParameter("fechaCorte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXC_Rpt010_Result>("spCXC_Rpt010", idEmpresaParameter, sucursalIniParameter, sucursalFinParameter, fechaCorteParameter);
        }
    
        public virtual ObjectResult<spCXC_Rpt009_Result> spCXC_Rpt009(Nullable<int> idEmpresa, Nullable<int> sucursalIni, Nullable<int> sucursalFin, Nullable<System.DateTime> fechaCorte)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var sucursalIniParameter = sucursalIni.HasValue ?
                new ObjectParameter("SucursalIni", sucursalIni) :
                new ObjectParameter("SucursalIni", typeof(int));
    
            var sucursalFinParameter = sucursalFin.HasValue ?
                new ObjectParameter("SucursalFin", sucursalFin) :
                new ObjectParameter("SucursalFin", typeof(int));
    
            var fechaCorteParameter = fechaCorte.HasValue ?
                new ObjectParameter("fechaCorte", fechaCorte) :
                new ObjectParameter("fechaCorte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXC_Rpt009_Result>("spCXC_Rpt009", idEmpresaParameter, sucursalIniParameter, sucursalFinParameter, fechaCorteParameter);
        }
    
        public virtual ObjectResult<spCXC_Rpt007_Result> spCXC_Rpt007(Nullable<int> idEmpresa, Nullable<int> sucursalIni, Nullable<int> sucursalFin, Nullable<decimal> idCliente, Nullable<System.DateTime> fechaCorte, Nullable<bool> i_solo_cbtes_con_saldo)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var sucursalIniParameter = sucursalIni.HasValue ?
                new ObjectParameter("SucursalIni", sucursalIni) :
                new ObjectParameter("SucursalIni", typeof(int));
    
            var sucursalFinParameter = sucursalFin.HasValue ?
                new ObjectParameter("SucursalFin", sucursalFin) :
                new ObjectParameter("SucursalFin", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(decimal));
    
            var fechaCorteParameter = fechaCorte.HasValue ?
                new ObjectParameter("fechaCorte", fechaCorte) :
                new ObjectParameter("fechaCorte", typeof(System.DateTime));
    
            var i_solo_cbtes_con_saldoParameter = i_solo_cbtes_con_saldo.HasValue ?
                new ObjectParameter("i_solo_cbtes_con_saldo", i_solo_cbtes_con_saldo) :
                new ObjectParameter("i_solo_cbtes_con_saldo", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXC_Rpt007_Result>("spCXC_Rpt007", idEmpresaParameter, sucursalIniParameter, sucursalFinParameter, idClienteParameter, fechaCorteParameter, i_solo_cbtes_con_saldoParameter);
        }
    
        public virtual ObjectResult<spCXC_Rpt015_Result> spCXC_Rpt015(Nullable<int> idEmpresa, Nullable<int> sucursalIni, Nullable<int> sucursalFin, Nullable<System.DateTime> fechaIni, Nullable<System.DateTime> fechaFin)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var sucursalIniParameter = sucursalIni.HasValue ?
                new ObjectParameter("SucursalIni", sucursalIni) :
                new ObjectParameter("SucursalIni", typeof(int));
    
            var sucursalFinParameter = sucursalFin.HasValue ?
                new ObjectParameter("SucursalFin", sucursalFin) :
                new ObjectParameter("SucursalFin", typeof(int));
    
            var fechaIniParameter = fechaIni.HasValue ?
                new ObjectParameter("fechaIni", fechaIni) :
                new ObjectParameter("fechaIni", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("fechaFin", fechaFin) :
                new ObjectParameter("fechaFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXC_Rpt015_Result>("spCXC_Rpt015", idEmpresaParameter, sucursalIniParameter, sucursalFinParameter, fechaIniParameter, fechaFinParameter);
        }
    
        public virtual ObjectResult<spCXC_Rpt017_Result> spCXC_Rpt017(Nullable<int> idEmpresa, Nullable<System.DateTime> fechaIni, Nullable<System.DateTime> fechaFin)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var fechaIniParameter = fechaIni.HasValue ?
                new ObjectParameter("FechaIni", fechaIni) :
                new ObjectParameter("FechaIni", typeof(System.DateTime));
    
            var fechaFinParameter = fechaFin.HasValue ?
                new ObjectParameter("FechaFin", fechaFin) :
                new ObjectParameter("FechaFin", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXC_Rpt017_Result>("spCXC_Rpt017", idEmpresaParameter, fechaIniParameter, fechaFinParameter);
        }
    
        public virtual ObjectResult<spCXC_Rpt012_Result> spCXC_Rpt012(Nullable<int> idEmpresa, Nullable<decimal> idCliente, Nullable<System.DateTime> fechaCorte)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var idClienteParameter = idCliente.HasValue ?
                new ObjectParameter("IdCliente", idCliente) :
                new ObjectParameter("IdCliente", typeof(decimal));
    
            var fechaCorteParameter = fechaCorte.HasValue ?
                new ObjectParameter("fechaCorte", fechaCorte) :
                new ObjectParameter("fechaCorte", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCXC_Rpt012_Result>("spCXC_Rpt012", idEmpresaParameter, idClienteParameter, fechaCorteParameter);
        }
    }
}