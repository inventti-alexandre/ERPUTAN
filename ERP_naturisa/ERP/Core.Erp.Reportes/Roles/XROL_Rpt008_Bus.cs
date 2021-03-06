﻿/*CLASE: XROL_Rpt008_Bus
 *CREADO POR: ALBERTO MENA
 *FECHA: 25-06-2015
 *DERECHOS RESERVADOS - INNOVATECORP
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Core.Erp.Business.General;
using Core.Erp.Data.General;
using Core.Erp.Info.General;
using Core.Erp.Reportes.Roles;

namespace Core.Erp.Reportes.Roles
{
    public class XROL_Rpt008_Bus
    {

        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";

        private XROL_Rpt008_Data oData = new XROL_Rpt008_Data();

        public List<XROL_Rpt008_Info> GetListPorIdPeriodo(int idEmpresa, int idPeriodoFiscal, ref string msg)
        {
            try
            {
                return oData.GetListPorIdPeriodo(idEmpresa, idPeriodoFiscal, ref msg);
            }
            catch (Exception ex)
            {
                oLog.Log_Error(ex.ToString());
                mensaje = "Error.." + ex.Message;
                return new List<XROL_Rpt008_Info>();
            }
        }



    }
}
