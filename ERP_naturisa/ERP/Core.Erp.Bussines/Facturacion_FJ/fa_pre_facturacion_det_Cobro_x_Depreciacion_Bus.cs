﻿using Core.Erp.Data.Facturacion_Fj;
using Core.Erp.Info.Facturacion_FJ;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Erp.Business.Facturacion_FJ
{
    public class fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus
    {
        fa_pre_facturacion_det_Cobro_x_Depreciacion_Data oData = new fa_pre_facturacion_det_Cobro_x_Depreciacion_Data();

        public List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info> Get_List(int IdEmpresa, decimal IdPrefacturacion)
        {
            try
            {
                return oData.Get_List(IdEmpresa, IdPrefacturacion);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus) };
            }
        }

        public Boolean GuardarDB(List<fa_pre_facturacion_det_Cobro_x_Depreciacion_Info> Lista)
        {
            try
            {
                return oData.GuardarDB(Lista);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus) };
            }
        }

        public Boolean EliminarDB(fa_pre_facturacion_Info info)
        {
            try
            {
                return oData.EliminarDB(info);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(fa_pre_facturacion_det_Cobro_x_Depreciacion_Bus) };
            }
        }
    }
}
