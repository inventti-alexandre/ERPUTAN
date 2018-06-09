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
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class EntitiesDBConta : DbContext
    {
        public EntitiesDBConta()
            : base("name=EntitiesDBConta")
        {
        }
        public void SetCommandTimeOut(int TimeOut)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = TimeOut;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<ct_cbtecble> ct_cbtecble { get; set; }
        public DbSet<ct_cbtecble_Plantilla> ct_cbtecble_Plantilla { get; set; }
        public DbSet<ct_cbtecble_Reversado> ct_cbtecble_Reversado { get; set; }
        public DbSet<ct_cbtecble_tipo> ct_cbtecble_tipo { get; set; }
        public DbSet<ct_centro_costo> ct_centro_costo { get; set; }
        public DbSet<ct_centro_costo_nivel> ct_centro_costo_nivel { get; set; }
        public DbSet<ct_centro_costo_sub_centro_costo> ct_centro_costo_sub_centro_costo { get; set; }
        public DbSet<ct_centro_costo_sub_centro_costo_x_Af_Activo_fijo> ct_centro_costo_sub_centro_costo_x_Af_Activo_fijo { get; set; }
        public DbSet<ct_GrupoEmpresarial> ct_GrupoEmpresarial { get; set; }
        public DbSet<ct_GrupoEmpresarial_grupocble> ct_GrupoEmpresarial_grupocble { get; set; }
        public DbSet<ct_GrupoEmpresarial_plancta> ct_GrupoEmpresarial_plancta { get; set; }
        public DbSet<ct_GrupoEmpresarial_plancta_nivel> ct_GrupoEmpresarial_plancta_nivel { get; set; }
        public DbSet<ct_GrupoEmpresarial_plancta_x_ct_plancta> ct_GrupoEmpresarial_plancta_x_ct_plancta { get; set; }
        public DbSet<ct_periodo> ct_periodo { get; set; }
        public DbSet<ct_plancta_nivel> ct_plancta_nivel { get; set; }
        public DbSet<ct_punto_cargo> ct_punto_cargo { get; set; }
        public DbSet<ct_rpt_Empresas_A_mostrar> ct_rpt_Empresas_A_mostrar { get; set; }
        public DbSet<ct_rpt_MovxCta> ct_rpt_MovxCta { get; set; }
        public DbSet<ct_rpt_SaldoxCta> ct_rpt_SaldoxCta { get; set; }
        public DbSet<ct_saldoxCuentas> ct_saldoxCuentas { get; set; }
        public DbSet<ct_saldoxCuentas_Movi> ct_saldoxCuentas_Movi { get; set; }
        public DbSet<ct_saldoxCuentas_Movi_tmp> ct_saldoxCuentas_Movi_tmp { get; set; }
        public DbSet<ct_saldoxCuentas_Movi_x_RangoFecha> ct_saldoxCuentas_Movi_x_RangoFecha { get; set; }
        public DbSet<ct_saldoxCuentas_TMP> ct_saldoxCuentas_TMP { get; set; }
        public DbSet<ct_tipo_ctacble> ct_tipo_ctacble { get; set; }
        public DbSet<vwct_cbtecble_con_ctacble_acreedora> vwct_cbtecble_con_ctacble_acreedora { get; set; }
        public DbSet<vwct_cbtecble_Con_Saldo> vwct_cbtecble_Con_Saldo { get; set; }
        public DbSet<vwct_cbtecble_con_saldo_cxp> vwct_cbtecble_con_saldo_cxp { get; set; }
        public DbSet<vwct_cbtecble_con_saldo_cxp_consulta> vwct_cbtecble_con_saldo_cxp_consulta { get; set; }
        public DbSet<vwct_cbtecble_det_TotalDiario> vwct_cbtecble_det_TotalDiario { get; set; }
        public DbSet<vwct_centro_costo> vwct_centro_costo { get; set; }
        public DbSet<vwct_ComprobanteContable> vwct_ComprobanteContable { get; set; }
        public DbSet<vwct_periodo> vwct_periodo { get; set; }
        public DbSet<vwct_plancta> vwct_plancta { get; set; }
        public DbSet<vwct_Plancta_UltimoNivel> vwct_Plancta_UltimoNivel { get; set; }
        public DbSet<vwct_SaldosxCuentas> vwct_SaldosxCuentas { get; set; }
        public DbSet<vwct_UtilidadxPeriodo> vwct_UtilidadxPeriodo { get; set; }
        public DbSet<vwct_UtilidadxPeriodo_Saldo_Acumulado> vwct_UtilidadxPeriodo_Saldo_Acumulado { get; set; }
        public DbSet<vwct_UtilidadxPeriodo_Saldo_Anterior> vwct_UtilidadxPeriodo_Saldo_Anterior { get; set; }
        public DbSet<vwct_UtilidadxPeriodo_Saldo_PeriodoActual> vwct_UtilidadxPeriodo_Saldo_PeriodoActual { get; set; }
        public DbSet<ct_punto_cargo_grupo> ct_punto_cargo_grupo { get; set; }
        public DbSet<ct_anio_fiscal> ct_anio_fiscal { get; set; }
        public DbSet<vwct_anio_fiscal_x_cuenta_utilidad> vwct_anio_fiscal_x_cuenta_utilidad { get; set; }
        public DbSet<ct_cbtecble_Plantilla_det> ct_cbtecble_Plantilla_det { get; set; }
        public DbSet<vwct_cbtecble_x_cp_Conciliacion_caja> vwct_cbtecble_x_cp_Conciliacion_caja { get; set; }
        public DbSet<ct_grupocble> ct_grupocble { get; set; }
        public DbSet<ct_grupocble_Mayor> ct_grupocble_Mayor { get; set; }
        public DbSet<ct_grupo_x_Tipo_Gasto> ct_grupo_x_Tipo_Gasto { get; set; }
        public DbSet<ct_periodo_x_tb_modulo> ct_periodo_x_tb_modulo { get; set; }
        public DbSet<vwct_grupo_x_Tipo_Gasto> vwct_grupo_x_Tipo_Gasto { get; set; }
        public DbSet<ct_parametro> ct_parametro { get; set; }
        public DbSet<vwct_centro_costo_sub_centro_costo> vwct_centro_costo_sub_centro_costo { get; set; }
        public DbSet<ct_cbtecble_det> ct_cbtecble_det { get; set; }
        public DbSet<vwct_cbtecble_det> vwct_cbtecble_det { get; set; }
        public DbSet<ct_anio_fiscal_x_cuenta_utilidad> ct_anio_fiscal_x_cuenta_utilidad { get; set; }
        public DbSet<vwct_plancta_nivel> vwct_plancta_nivel { get; set; }
        public DbSet<ct_plancta> ct_plancta { get; set; }
    
        public virtual int spCON_Saldo_Inicial_x_cta_cble(Nullable<int> i_IdEmpresa, Nullable<System.DateTime> i_FechaCorte, string i_IdCentroCosto)
        {
            var i_IdEmpresaParameter = i_IdEmpresa.HasValue ?
                new ObjectParameter("i_IdEmpresa", i_IdEmpresa) :
                new ObjectParameter("i_IdEmpresa", typeof(int));
    
            var i_FechaCorteParameter = i_FechaCorte.HasValue ?
                new ObjectParameter("i_FechaCorte", i_FechaCorte) :
                new ObjectParameter("i_FechaCorte", typeof(System.DateTime));
    
            var i_IdCentroCostoParameter = i_IdCentroCosto != null ?
                new ObjectParameter("i_IdCentroCosto", i_IdCentroCosto) :
                new ObjectParameter("i_IdCentroCosto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spCON_Saldo_Inicial_x_cta_cble", i_IdEmpresaParameter, i_FechaCorteParameter, i_IdCentroCostoParameter);
        }
    
        public virtual ObjectResult<spCON_Mayorizar_x_fecha_corte_Result> spCON_Mayorizar_x_fecha_corte(Nullable<int> i_IdEmpresa, Nullable<System.DateTime> i_Fecha_Ini, Nullable<System.DateTime> i_Fecha_Fin, string i_IdCentroCosto, Nullable<int> i_IdPunto_cargo_grupo, Nullable<int> i_IdPunto_cargo, Nullable<bool> i_Mostrar_reg_en_cero, Nullable<bool> i_Mostrar_reg_Centro_costo, Nullable<bool> i_Considerar_Asiento_cierre_anual, string i_IdUsuario)
        {
            var i_IdEmpresaParameter = i_IdEmpresa.HasValue ?
                new ObjectParameter("i_IdEmpresa", i_IdEmpresa) :
                new ObjectParameter("i_IdEmpresa", typeof(int));
    
            var i_Fecha_IniParameter = i_Fecha_Ini.HasValue ?
                new ObjectParameter("i_Fecha_Ini", i_Fecha_Ini) :
                new ObjectParameter("i_Fecha_Ini", typeof(System.DateTime));
    
            var i_Fecha_FinParameter = i_Fecha_Fin.HasValue ?
                new ObjectParameter("i_Fecha_Fin", i_Fecha_Fin) :
                new ObjectParameter("i_Fecha_Fin", typeof(System.DateTime));
    
            var i_IdCentroCostoParameter = i_IdCentroCosto != null ?
                new ObjectParameter("i_IdCentroCosto", i_IdCentroCosto) :
                new ObjectParameter("i_IdCentroCosto", typeof(string));
    
            var i_IdPunto_cargo_grupoParameter = i_IdPunto_cargo_grupo.HasValue ?
                new ObjectParameter("i_IdPunto_cargo_grupo", i_IdPunto_cargo_grupo) :
                new ObjectParameter("i_IdPunto_cargo_grupo", typeof(int));
    
            var i_IdPunto_cargoParameter = i_IdPunto_cargo.HasValue ?
                new ObjectParameter("i_IdPunto_cargo", i_IdPunto_cargo) :
                new ObjectParameter("i_IdPunto_cargo", typeof(int));
    
            var i_Mostrar_reg_en_ceroParameter = i_Mostrar_reg_en_cero.HasValue ?
                new ObjectParameter("i_Mostrar_reg_en_cero", i_Mostrar_reg_en_cero) :
                new ObjectParameter("i_Mostrar_reg_en_cero", typeof(bool));
    
            var i_Mostrar_reg_Centro_costoParameter = i_Mostrar_reg_Centro_costo.HasValue ?
                new ObjectParameter("i_Mostrar_reg_Centro_costo", i_Mostrar_reg_Centro_costo) :
                new ObjectParameter("i_Mostrar_reg_Centro_costo", typeof(bool));
    
            var i_Considerar_Asiento_cierre_anualParameter = i_Considerar_Asiento_cierre_anual.HasValue ?
                new ObjectParameter("i_Considerar_Asiento_cierre_anual", i_Considerar_Asiento_cierre_anual) :
                new ObjectParameter("i_Considerar_Asiento_cierre_anual", typeof(bool));
    
            var i_IdUsuarioParameter = i_IdUsuario != null ?
                new ObjectParameter("i_IdUsuario", i_IdUsuario) :
                new ObjectParameter("i_IdUsuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCON_Mayorizar_x_fecha_corte_Result>("spCON_Mayorizar_x_fecha_corte", i_IdEmpresaParameter, i_Fecha_IniParameter, i_Fecha_FinParameter, i_IdCentroCostoParameter, i_IdPunto_cargo_grupoParameter, i_IdPunto_cargoParameter, i_Mostrar_reg_en_ceroParameter, i_Mostrar_reg_Centro_costoParameter, i_Considerar_Asiento_cierre_anualParameter, i_IdUsuarioParameter);
        }
    
        public virtual ObjectResult<spCON_saldo_cuentas_x_anio_para_cierre_Result> spCON_saldo_cuentas_x_anio_para_cierre(Nullable<int> idEmpresa, Nullable<int> anio)
        {
            var idEmpresaParameter = idEmpresa.HasValue ?
                new ObjectParameter("IdEmpresa", idEmpresa) :
                new ObjectParameter("IdEmpresa", typeof(int));
    
            var anioParameter = anio.HasValue ?
                new ObjectParameter("Anio", anio) :
                new ObjectParameter("Anio", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spCON_saldo_cuentas_x_anio_para_cierre_Result>("spCON_saldo_cuentas_x_anio_para_cierre", idEmpresaParameter, anioParameter);
        }
    }
}
