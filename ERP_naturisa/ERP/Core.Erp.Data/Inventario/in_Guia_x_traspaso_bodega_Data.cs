﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Core.Erp.Info.Inventario;

using Core.Erp.Data.General;
using Core.Erp.Info.General;
using System.Data.Entity.Validation;

namespace Core.Erp.Data.Inventario
{
  public  class in_Guia_x_traspaso_bodega_Data
    {
      string mensaje = "";

      

      public Boolean GuardarDB(in_Guia_x_traspaso_bodega_Info info,ref decimal IdGuia, ref string mensaje)
      {
          try
          {
              try
              {
                  using (EntitiesInventario Context = new EntitiesInventario())
                  {
                      in_Guia_x_traspaso_bodega_x_in_transferencia_det_Data Data_transferencia = new in_Guia_x_traspaso_bodega_x_in_transferencia_det_Data();
                      var Address = new in_Guia_x_traspaso_bodega();

                      Address.IdEmpresa = info.IdEmpresa;
                      Address.IdGuia = info.IdGuia = GetIdGuia(info.IdEmpresa);
                      IdGuia = info.IdGuia;

                      if (info.NumGuia == "")
                      {
                          info.NumGuia = info.IdGuia.ToString();
                      }

                      Address.NumGuia = info.NumGuia;

                      if (info.IdSucursal_Partida == 0)
                      {
                          info.IdSucursal_Partida = null;
                      }

                      Address.IdSucursal_Partida = info.IdSucursal_Partida;

                      if (info.IdSucursal_Llegada == 0)
                      {
                          info.IdSucursal_Llegada = null;
                      }

                      Address.IdSucursal_Llegada = info.IdSucursal_Llegada;

                      if (info.Direc_sucu_Partida == "")
                      {
                          info.Direc_sucu_Partida = null;
                      }

                      Address.Direc_sucu_Partida = info.Direc_sucu_Partida;

                      if (info.Direc_sucu_Llegada == "")
                      {
                          info.Direc_sucu_Llegada = null;
                      }

                      Address.Direc_sucu_Llegada = info.Direc_sucu_Llegada;

                      if (info.IdTransportista == 0)
                      {
                          info.IdTransportista = null;
                      }

                      if (info.IdMotivo_Traslado == "")
                      {
                          info.IdMotivo_Traslado = null;
                      }

                      Address.IdMotivo_Traslado = info.IdMotivo_Traslado;
                      Address.IdTransportista = info.IdTransportista;

                      Address.Fecha = Convert.ToDateTime(info.Fecha).Date;
                      Address.Fecha_Traslado = Convert.ToDateTime(info.Fecha_Traslado).Date;
                      Address.Fecha_llegada = Convert.ToDateTime(info.Fecha_llegada).Date;
                      Address.Estado = "A";

                      Address.IdUsuario = info.IdUsuario;
                      Address.Fecha_Transac = info.Fecha_Transac;
                      Address.nom_pc = info.nom_pc;
                      Address.ip = info.ip;
                      Address.Hora_Llegada = info.Hora_Llegada;
                      Address.Hora_Traslado = info.Hora_Traslado;

                      Address.CodDocumentoTipo = info.CodDocumentoTipo;
                      Address.IdEstablecimiento = info.IdEstablecimiento;
                      Address.IdPuntoEmision = info.IdPuntoEmision;
                      Address.NumDocumento_Guia = info.NumDocumento_Guia;

                      Address.IdentificacionDestinatario = info.IdentificacionDestinatario;
                      Address.NombreDestinatario = info.NombreDestinatario;
                      Address.Direc_sucu_Llegada = info.Direc_sucu_Llegada;
                      Address.Placa = info.Placa;
                      Context.in_Guia_x_traspaso_bodega.Add(Address);
                      Context.SaveChanges();


                      //Grabar Detalles

                      //Graba tabla in_Guia_x_traspaso_bodega_det
                      if (info.list_detalle_Guia != null)
                      {
                          if (info.list_detalle_Guia.Count() != 0)
                          {
                              foreach (var item in info.list_detalle_Guia)
                              {
                                  item.IdEmpresa = info.IdEmpresa;
                                  item.IdGuia = IdGuia;
                              }

                              in_Guia_x_traspaso_bodega_det_Data odata = new in_Guia_x_traspaso_bodega_det_Data();
                              odata.GuardarDB(info.list_detalle_Guia);
                          }
                      }
                      //Graba tabla in_Guia_x_traspaso_bodega_det_sin_oc
                      if (info.list_detalle_Guia_Sin_OC != null)
                      {
                          if (info.list_detalle_Guia_Sin_OC.Count() != 0)
                          {
                              foreach (var item in info.list_detalle_Guia_Sin_OC)
                              {
                                  item.IdEmpresa = info.IdEmpresa;
                                  item.IdGuia = IdGuia;
                              }

                              in_Guia_x_traspaso_bodega_det_sin_oc_Data odata = new in_Guia_x_traspaso_bodega_det_sin_oc_Data();
                              odata.GuardarDB(info.list_detalle_Guia_Sin_OC);
                          }

                      }


                      if (info.Lista_Detalle_Transferencia != null)
                      {
                          foreach (var item in info.Lista_Detalle_Transferencia)
                          {
                              item.IdGuia = Convert.ToInt32(IdGuia);

                          }

                          Data_transferencia.Guardar(info.Lista_Detalle_Transferencia);
                      }
                      mensaje = "Grabación ok..";
                  }
                  return true;
              }
              catch (DbEntityValidationException ex)
              {
                  string arreglo = ToString();
                  tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                  tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                  oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                  mensaje = ex.ToString() + " " + ex.Message;
                  mensaje = "Error al Grabar" + ex.Message;
                  throw new Exception(ex.ToString());
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "",
                                  "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public Boolean ModificarDB(in_Guia_x_traspaso_bodega_Info info, ref string mensaje)
      {
          try
          {
              try
              {
                  using (EntitiesInventario context = new EntitiesInventario())
                  {
                      var contact = context.in_Guia_x_traspaso_bodega.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdGuia == info.IdGuia);
                      if (contact != null)
                      {
                          contact.NumGuia = info.NumGuia;
                          contact.IdSucursal_Partida = info.IdSucursal_Partida;
                          contact.IdSucursal_Llegada = info.IdSucursal_Llegada;

                          contact.Direc_sucu_Partida = info.Direc_sucu_Partida;
                          contact.Direc_sucu_Llegada = info.Direc_sucu_Llegada;
                          contact.IdTransportista = info.IdTransportista;
                          contact.Fecha = Convert.ToDateTime(info.Fecha).Date;
                          contact.Fecha_Traslado = Convert.ToDateTime(info.Fecha_Traslado).Date;
                          contact.Fecha_llegada = Convert.ToDateTime(info.Fecha_llegada).Date;
                          contact.IdMotivo_Traslado = info.IdMotivo_Traslado;

                          contact.Hora_Llegada = info.Hora_Llegada;
                          contact.Hora_Traslado = info.Hora_Traslado;

                          contact.Fecha_UltMod = info.Fecha_UltMod;
                          contact.IdUsuarioUltMod = info.IdUsuarioUltMod;


                          contact.CodDocumentoTipo = info.CodDocumentoTipo;
                          contact.IdEstablecimiento = info.IdEstablecimiento;
                          contact.IdPuntoEmision = info.IdPuntoEmision;
                          contact.NumDocumento_Guia = info.NumDocumento_Guia;
                          contact.Placa = info.Placa;
                          contact.IdentificacionDestinatario = info.IdentificacionDestinatario;
                          contact.NombreDestinatario = info.NombreDestinatario;
                          contact.Direc_sucu_Llegada = info.Direc_sucu_Llegada;

                          context.SaveChanges();

                          in_Guia_x_traspaso_bodega_det_Data odataDet = new in_Guia_x_traspaso_bodega_det_Data();
                          odataDet.EliminarDB(info.IdEmpresa, info.IdGuia);

                          //Graba tabla in_Guia_x_traspaso_bodega_det                
                          foreach (var item in info.list_detalle_Guia)
                          {
                              item.IdEmpresa = info.IdEmpresa;
                              item.IdGuia = info.IdGuia;
                          }

                          in_Guia_x_traspaso_bodega_det_Data oData_con_OC = new in_Guia_x_traspaso_bodega_det_Data();
                          oData_con_OC.GuardarDB(info.list_detalle_Guia);


                          in_Guia_x_traspaso_bodega_det_sin_oc_Data odataDetsinOC = new in_Guia_x_traspaso_bodega_det_sin_oc_Data();
                          odataDetsinOC.EliminarDB(info.IdEmpresa, info.IdGuia);

                          //Graba tabla in_Guia_x_traspaso_bodega_det_sin_oc                                    
                          foreach (var item in info.list_detalle_Guia_Sin_OC)
                          {
                              item.IdEmpresa = info.IdEmpresa;
                              item.IdGuia = info.IdGuia;
                          }

                          in_Guia_x_traspaso_bodega_det_sin_oc_Data oData_sin_oc = new in_Guia_x_traspaso_bodega_det_sin_oc_Data();
                          oData_sin_oc.GuardarDB(info.list_detalle_Guia_Sin_OC);


                          if (info.Lista_Detalle_Transferencia.Count != 0)
                          {
                              in_Guia_x_traspaso_bodega_x_in_transferencia_det_Data Data_transf = new in_Guia_x_traspaso_bodega_x_in_transferencia_det_Data();
                              if (Data_transf.Eliminar(info.Lista_Detalle_Transferencia.FirstOrDefault()))
                              {
                                  Data_transf.Guardar(info.Lista_Detalle_Transferencia);
                              }

                          }

                          mensaje = "Actualización ok..";
                      }
                  }
                  return true;
              }
              catch (DbEntityValidationException ex)
              {
                  string arreglo = ToString();
                  tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
                  tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
                  oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
                  mensaje = ex.ToString() + " " + ex.Message;
                  mensaje = "Error al Grabar" + ex.Message;
                  throw new Exception(ex.ToString());
              }
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
      
      public Boolean AnularDB(in_Guia_x_traspaso_bodega_Info info, ref string mensaje)
      {
          try
          {
              using (EntitiesInventario context = new EntitiesInventario())
              {
                  var contact = context.in_Guia_x_traspaso_bodega.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdGuia == info.IdGuia);
                  if (contact != null)
                  {
                      contact.Estado = "I";

                      contact.Fecha_UltAnu = info.Fecha_UltAnu;
                      contact.IdUsuarioUltAnu = info.IdUsuarioUltAnu;
                      context.SaveChanges();
                  }
              }

              if (info.list_detalle_Guia.Count > 0)
              {
                  using (EntitiesInventario context_ = new EntitiesInventario())
                  {
                      var Query = from q in context_.in_Guia_x_traspaso_bodega_det
                                  where q.IdEmpresa == info.IdEmpresa
                                    && q.IdGuia == info.IdGuia
                                  select q;
                      foreach (var item in Query)
                      {
                          var contact_ = context_.in_Guia_x_traspaso_bodega_det.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdGuia == info.IdGuia && var.secuencia == item.secuencia);
                          if (contact_ != null)
                              contact_.Cantidad_enviar = 0;
                      }
                      context_.SaveChanges();
                  }

              }


              if (info.Lista_Detalle_Transferencia.Count > 0)
              {
                  using (EntitiesInventario context_ = new EntitiesInventario())
                  {
                      var Query = from q in context_.in_Guia_x_traspaso_bodega_x_in_transferencia_det
                                  where q.IdEmpresa == info.IdEmpresa
                                    && q.IdGuia == info.IdGuia
                                  select q;
                      foreach (var item in Query)
                      {
                          var contact_ = context_.in_Guia_x_traspaso_bodega_x_in_transferencia_det.FirstOrDefault(var => var.IdEmpresa == info.IdEmpresa && var.IdGuia == info.IdGuia && var.dt_secuencia == item.dt_secuencia);
                          if (contact_ != null)
                              contact_.cantidad = 0;
                          context_.SaveChanges();
                      }
                     
                  }

              }





              mensaje = "Anulación ok..";


              return true;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
      
      public List<in_Guia_x_traspaso_bodega_Info> Get_List_Guia_x_traspaso_bodega(int IdEmpresa, DateTime FechaIni, DateTime FechaFin)
     {
         List<in_Guia_x_traspaso_bodega_Info> Lst = new List<in_Guia_x_traspaso_bodega_Info>();
         try
         {
             FechaIni = Convert.ToDateTime(FechaIni.ToShortDateString());
             FechaFin = Convert.ToDateTime(FechaFin.ToShortDateString());
             
             EntitiesInventario oEnti = new EntitiesInventario();
             Lst = (from q in oEnti.vwin_guia_x_traspaso_bodega
                          where q.IdEmpresa == IdEmpresa
                            && q.Fecha >= FechaIni
                            && q.Fecha <= FechaFin
                          select new in_Guia_x_traspaso_bodega_Info
                          {
                              IdEmpresa = q.IdEmpresa,
                              IdGuia = q.IdGuia,
                              NumGuia = q.NumGuia,
                              IdSucursal_Partida = q.IdSucursal_Partida,
                              IdSucursal_Llegada = q.IdSucursal_Llegada,
                              Direc_sucu_Partida = q.Direc_sucu_Partida,
                              Direc_sucu_Llegada = q.Direc_sucu_Llegada,
                              IdTransportista = q.IdTransportista,
                              Fecha = q.Fecha,
                              Fecha_Traslado = q.Fecha_Traslado,
                              Fecha_llegada = q.Fecha_llegada,
                              IdMotivo_Traslado = q.IdMotivo_Traslado,
                              Estado = q.Estado,
                              Su_Descripcion = q.Su_Descripcion,
                              Su_Descripcion_Llegada = q.Su_Descripcion_Llegada,
                              Hora_Llegada = q.Hora_Llegada,
                              Hora_Traslado = q.Hora_Traslado,
                              CodDocumentoTipo = q.CodDocumentoTipo,
                              IdEstablecimiento = q.IdEstablecimiento,
                              IdPuntoEmision = q.IdPuntoEmision,
                              NumDocumento_Guia = q.NumDocumento_Guia,
                              NombreDestinatario = q.NombreDestinatario,
                              IdentificacionDestinatario = q.IdentificacionDestinatario,
                              Placa = q.Placa
                          }).ToList();

             return Lst;
         }
         catch (Exception ex)
         {
             string arreglo = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
             oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
             mensaje = ex.ToString() + " " + ex.Message;
             throw new Exception(ex.ToString());
         }
     }

      public List<in_Guia_x_traspaso_bodega_Info> Get_List_OC_x_in_Guia(int IdEmpresa, int IdSucursal, decimal IdOrdenCompra)
      {
          try
          {
              List<in_Guia_x_traspaso_bodega_Info> Lista = new List<in_Guia_x_traspaso_bodega_Info>();

              using (EntitiesCompras Context = new EntitiesCompras())
              {
                  var lst = from q in Context.vwcom_ordencompra_local_x_in_guia_x_traspaso_bodega
                            where q.IdEmpresa_OC == IdEmpresa
                            && q.IdSucursal_OC == IdSucursal
                            && q.IdOrdenCompra_OC == IdOrdenCompra
                            select q;

                  foreach (var item in lst)
                  {
                      in_Guia_x_traspaso_bodega_Info info = new in_Guia_x_traspaso_bodega_Info();

                      info.IdEmpresa = item.IdEmpresa;
                      info.IdGuia = item.IdGuia;
                      info.IdSucursal_Partida = item.IdSucursal_Partida;
                      info.IdSucursal_Llegada = item.IdSucursal_Llegada;
                      info.Su_Descripcion = item.Su_Descripcion;
                      info.Su_Descripcion_Llegada = item.Su_Descripcion_Llegada;
                      info.Fecha = Convert.ToDateTime(item.Fecha);
                      
                      Lista.Add(info);
                  }
              }

              return Lista;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }

      public in_Guia_x_traspaso_bodega_Info Get_Info_x_in_Guia(int IdEmpresa, decimal IdGuia)
     {
         try
         {
             
             EntitiesInventario oEnti = new EntitiesInventario();
             var item = oEnti.vwin_guia_x_traspaso_bodega.Where(q =>
                         q.IdEmpresa == IdEmpresa
                           && q.IdGuia == IdGuia).FirstOrDefault();

             in_Guia_x_traspaso_bodega_Info Info_Guia = new in_Guia_x_traspaso_bodega_Info
             {
                 IdEmpresa = item.IdEmpresa,
                 IdGuia = item.IdGuia,
                 NumGuia = item.NumGuia,
                 IdSucursal_Partida = item.IdSucursal_Partida,
                 IdSucursal_Llegada = item.IdSucursal_Llegada,
                 Direc_sucu_Partida = item.Direc_sucu_Partida,
                 Direc_sucu_Llegada = item.Direc_sucu_Llegada,
                 IdTransportista = item.IdTransportista,
                 Fecha = item.Fecha,
                 Fecha_Traslado = item.Fecha_Traslado,
                 Fecha_llegada = item.Fecha_llegada,
                 IdMotivo_Traslado = item.IdMotivo_Traslado,
                 Estado = item.Estado.TrimEnd(),
                 Su_Descripcion = item.Su_Descripcion,
                 Su_Descripcion_Llegada = item.Su_Descripcion_Llegada,
                 Hora_Llegada = item.Hora_Llegada,
                 Hora_Traslado = item.Hora_Traslado,
                 CodDocumentoTipo = item.CodDocumentoTipo,
                 IdEstablecimiento = item.IdEstablecimiento,
                 IdPuntoEmision = item.IdPuntoEmision,
                 NumDocumento_Guia = item.NumDocumento_Guia,

                 ced_transportista = item.ced_transportista,
                 nom_transportista = item.nom_transportista,
                 nom_Motivo_Traslado = item.nom_Motivo_Traslado,
                 cod_estable_llegada = item.cod_estable_llegada,
                 cod_estable_partida = item.cod_estable_partida,
                 razon_social_empresa = item.razon_social_empresa,
                 nom_comercial_empresa = item.nom_comercial_empresa,
                 contrib_especial_empresa = item.contrib_especial_empresa,
                 obligado_conta_empresa = item.obligado_conta_empresa,
                 ruc_empresa = item.ruc_empresa,
                 nom_empresa = item.nom_empresa,
                 direc_empresa = item.direc_empresa,
                 Placa = item.Placa,
                 NombreDestinatario = item.NombreDestinatario,
                 IdentificacionDestinatario = item.IdentificacionDestinatario
             };
             return Info_Guia;
         }
         catch (Exception ex)
         {
             string arreglo = ToString();
             tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
             tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
             oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
             mensaje = ex.ToString() + " " + ex.Message;
             throw new Exception(ex.ToString());
         }
     }

      

      public decimal GetIdGuia(int IdEmpresa)
      {
          decimal Id = 0;
          try
          {
              EntitiesInventario contex = new EntitiesInventario();
              var selecte = contex.in_Guia_x_traspaso_bodega.Count(q => q.IdEmpresa == IdEmpresa);

              if (selecte == 0)
              {
                  Id = 1;
              }
              else
              {
                  var select_em = (from q in contex.in_Guia_x_traspaso_bodega
                                   where q.IdEmpresa == IdEmpresa
                                   select q.IdGuia).Max();
                  Id = Convert.ToDecimal(select_em.ToString()) + 1;
              }

              return Id;
          }
          catch (Exception ex)
          {
              string arreglo = ToString();
              tb_sis_Log_Error_Vzen_Data oDataLog = new tb_sis_Log_Error_Vzen_Data();
              tb_sis_Log_Error_Vzen_Info Log_Error_sis = new tb_sis_Log_Error_Vzen_Info(ex.ToString(), "", arreglo, "", "", "", "", "", DateTime.Now);
              oDataLog.Guardar_Log_Error(Log_Error_sis, ref mensaje);
              mensaje = ex.ToString() + " " + ex.Message;
              throw new Exception(ex.ToString());
          }
      }
  
  }
}
