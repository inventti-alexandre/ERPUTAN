﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.IO;
using System.Collections.Generic;

using Core.Erp.Business.General;
using Core.Erp.Info.General;

namespace Cus.Erp.Reports.Naturisa.CuentasxPagar
{
    public partial class XCXP_NATU_Rpt001_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        cl_parametrosGenerales_Bus param = cl_parametrosGenerales_Bus.Instance;
        tb_sis_Log_Error_Vzen_Bus Log_Error_bus = new tb_sis_Log_Error_Vzen_Bus();
        
        public XCXP_NATU_Rpt001_Rpt()
        {
            InitializeComponent();
        }

        private void XCXP_NATU_Rpt001_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                xrL_Empresa.Text = param.NombreEmpresa;
                xrPictureBox1.Image = param.InfoEmpresa.em_logo_Image;
                XCXP_NATU_Rpt001_Bus repbus = new XCXP_NATU_Rpt001_Bus();
                List<XCXP_NATU_Rpt001_Info> ListDataRpt = new List<XCXP_NATU_Rpt001_Info>();

                int IdEmpresa = 0;

                Decimal IdProveedorIni = 0;
                Decimal IdProveedorFin = 0;

                DateTime co_fechaOg_Ini = DateTime.Now;
                DateTime co_fechaOg_Fin = DateTime.Now;
                String mensaje = "";
                String TipoPersona = "";

                IdEmpresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdProveedorIni = Convert.ToDecimal(Parameters["IdProveedorIni"].Value);
                IdProveedorFin = Convert.ToDecimal(Parameters["IdProveedorFin"].Value);
                co_fechaOg_Ini = Convert.ToDateTime(Parameters["Fecha_Ini"].Value);
                co_fechaOg_Fin = Convert.ToDateTime(Parameters["Fecha_Fin"].Value);
                TipoPersona = Convert.ToString(Parameters["TipoPersona"].Value);
                ListDataRpt = repbus.consultar_data(IdEmpresa, TipoPersona, IdProveedorIni, IdProveedorFin, co_fechaOg_Ini, co_fechaOg_Fin, ref mensaje);
                this.DataSource = ListDataRpt.ToArray();
            }
            catch (Exception ex)
            {
                Log_Error_bus.Log_Error(ex.ToString());
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "XCXP_NATU_Rpt001_Rpt_BeforePrint", ex.Message), ex) { EntityType = typeof(XCXP_NATU_Rpt001_Rpt) };
                
            }

            
        }
    }
}
