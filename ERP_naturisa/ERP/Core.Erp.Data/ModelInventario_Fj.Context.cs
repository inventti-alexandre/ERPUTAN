﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EntitiesInventario_Fj : DbContext
    {
        public EntitiesInventario_Fj()
            : base("name=EntitiesInventario_Fj")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<in_Orden_servicio_x_Activo_fijo_det> in_Orden_servicio_x_Activo_fijo_det { get; set; }
        public DbSet<vwin_Orden_servicio_x_activo_fijo> vwin_Orden_servicio_x_activo_fijo { get; set; }
        public DbSet<in_Orden_servicio_x_Activo_fijo> in_Orden_servicio_x_Activo_fijo { get; set; }
    }
}