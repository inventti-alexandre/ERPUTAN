﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Reportes.CuentasxPagar
{
  public  class XCXP_Rpt028_Bus
    {
        XCXP_Rpt028_Data odata = new XCXP_Rpt028_Data();

        public List<XCXP_Rpt028_Info> consultar_data(int idempresa, decimal IdConciliacion_Caja, ref string mensaje)
        {

            try
            {
                return odata.consultar_data(idempresa, IdConciliacion_Caja, ref mensaje);
            }
            catch (Exception ex)
            {
                return new List<XCXP_Rpt028_Info>();

            }


        }
    }
}
