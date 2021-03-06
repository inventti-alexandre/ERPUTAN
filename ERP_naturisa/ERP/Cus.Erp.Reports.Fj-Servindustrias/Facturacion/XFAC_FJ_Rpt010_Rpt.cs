﻿using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using Cus.Erp.Reports.FJ.Facturacion;
using System.Collections.Generic;
using System.Linq;
using Core.Erp.Info.Facturacion_FJ;
using Core.Erp.Business.Facturacion_FJ;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public partial class XFAC_FJ_Rpt010_Rpt : DevExpress.XtraReports.UI.XtraReport
    {
        public XFAC_FJ_Rpt010_Rpt()
        {
            InitializeComponent();
        }
        List<XFAC_FJ_Rpt010_Info> lista = new List<XFAC_FJ_Rpt010_Info>();
        XFAC_FJ_Rpt010_Bus bus = new XFAC_FJ_Rpt010_Bus();
        fa_tarifario_facturacion_x_cliente_Por_comision_Bus bus_parametro = new fa_tarifario_facturacion_x_cliente_Por_comision_Bus();

        fa_tarifario_facturacion_x_cliente_Por_comision_Info info_parametro = new fa_tarifario_facturacion_x_cliente_Por_comision_Info();

        private void XFAC_FJ_Rpt010_Rpt_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            try
            {
                int Idempresa = 0;
                int IdPeriod = 0;
                int Anio = 0;
                Decimal IdCliente = 0;
                double Porcentaje_fee = 0;
                double p_subtotal = 0;
                double p_fee = 0;
                double p_total = 0;


                Idempresa = Convert.ToInt32(Parameters["IdEmpresa"].Value);
                IdPeriod = Convert.ToInt32(Parameters["IdPeriodo"].Value);
                Anio = Convert.ToInt32(Parameters["Anio"].Value);
                IdCliente = Convert.ToInt32(Parameters["IdCliente"].Value);

                Porcentaje_fee = bus_parametro.Get_Fee(Idempresa, Anio, IdCliente);
                lista = bus.Get_List(Idempresa, IdPeriod);


                this.DataSource = lista;

            }
            catch (Exception)
            {

            }
        }

    }
}
