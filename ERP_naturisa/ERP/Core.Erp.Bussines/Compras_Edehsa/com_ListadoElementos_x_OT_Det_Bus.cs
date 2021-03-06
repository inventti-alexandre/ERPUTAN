﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.Erp.Info.Compras_Edehsa;
using Core.Erp.Data.Compras_Edehsa;
using Core.Erp.Business.General;

namespace Core.Erp.Business.Compras_Edehsa
{
    public class com_ListadoElementos_x_OT_Det_Bus
    {
        tb_sis_Log_Error_Vzen_Bus oLog = new tb_sis_Log_Error_Vzen_Bus();
        string mensaje = "";
        com_ListadoElementos_x_OT_Det_Data Data = new com_ListadoElementos_x_OT_Det_Data();
        public Boolean GuardarDB(List<com_ListadoElementos_x_OT_Det_Info> LstInfo, string IdEstado)
        {
            try
            {
                return Data.GuardarDB(LstInfo, IdEstado);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "GuardarDB", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }

        public List<com_ListadoElementos_x_OT_Det_Info> Get_List_ListadoElementos_x_OT_Det(int IdEmpresa, decimal idLstMater)
        {
            try
            {
                return Data.Get_List_ListadoElementos_x_OT_Det(IdEmpresa, idLstMater);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoElementos_x_OT_Det", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }

        public Boolean EliminarDB(List<com_ListadoElementos_x_OT_Det_Info> LstInfo, ref string msg)
        {
            try
            {
                return Data.EliminarDB(LstInfo, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "EliminarDB", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }

        public Boolean ActualizarEstadoAprob(com_ListadoElementos_x_OT_Det_Info Info, ref string msg)
        {
            try
            {
                return Data.ActualizarEstadoAprob(Info, ref  msg);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "ActualizarEstadoAprob", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }

        public List<com_ListadoElementos_x_OT_Det_Info> TraerTodoDetalleLstMat(int IdEmpresa)
        {
            try
            {
                return Data.Get_List_ListadoElementos_x_OT_Det(IdEmpresa);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "TraerTodoDetalleLstMat", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }

        public com_ListadoElementos_x_OT_Det_Info Get_List_ListadoElementos_x_OT_Det(int IdEmpresa, decimal idlistadoMat, int IdDetalle)
        {
            try
            {
                return Data.Get_List_ListadoElementos_x_OT_Det(IdEmpresa, idlistadoMat, IdDetalle);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoElementos_x_OT_Det", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }

        public List<com_ListadoElementos_x_OT_Det_Info> Get_List_ListadoElementos_x_OT_Det(int IdEmpresa, string CodObra)
        {
            try
            {
                return Data.Get_List_ListadoElementos_x_OT_Det(IdEmpresa, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoElementos_x_OT_Det", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }
        public List<com_ListadoElementos_x_OT_Det_Info> Get_List_ListadoDespunteMateriales_Det(int IdEmpresa, string CodObra)
        {
            try
            {
                return Data.Get_List_ListadoDespunteMateriales_Det(IdEmpresa, CodObra);
            }
            catch (Exception ex)
            {
                Core.Erp.Info.Log_Exception.LoggingManager.Logger.Log(Core.Erp.Info.Log_Exception.LoggingCategory.Error, ex.Message);
                throw new Core.Erp.Info.Log_Exception.DalException(string.Format("", "Get_List_ListadoDespunteMateriales_Det", ex.Message), ex) { EntityType = typeof(com_ListadoElementos_x_OT_Det_Bus) };
            }
        }
    }
}
