﻿
CREATE VIEW [dbo].[vwCOMP_Rpt003]
AS

SELECT        dbo.in_Ing_Egr_Inven.IdEmpresa, dbo.in_Ing_Egr_Inven.IdSucursal, dbo.in_Ing_Egr_Inven.IdBodega, dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo, dbo.in_Ing_Egr_Inven.IdNumMovi, mov_inv.cm_tipo, 
                         dbo.in_Ing_Egr_Inven.cm_observacion, dbo.in_Ing_Egr_Inven.cm_fecha, dbo.in_Ing_Egr_Inven.Estado, suc.Su_Descripcion, bod.bo_Descripcion, minv_tip.tm_descripcion, prod.IdProducto, prod.pr_codigo, 
                         prod.pr_descripcion, dbo.in_Ing_Egr_Inven_det.dm_cantidad, dbo.in_Ing_Egr_Inven_det.mv_costo, dbo.in_Ing_Egr_Inven_det.dm_cantidad * dbo.in_Ing_Egr_Inven_det.mv_costo AS SubTotal, 
                         dbo.in_Ing_Egr_Inven_det.dm_precio, dbo.in_Ing_Egr_Inven_det.dm_observacion, dbo.in_Ing_Egr_Inven_det.dm_peso, dbo.tb_empresa.em_nombre, dbo.tb_empresa.em_ruc, dbo.tb_empresa.em_telefonos, 
                         dbo.tb_empresa.em_direccion, dbo.cp_proveedor.IdProveedor, dbo.cp_proveedor.pr_nombre, dbo.com_ordencompra_local_det.do_ManejaIva, dbo.com_ordencompra_local.IdOrdenCompra, 
                         dbo.in_Ing_Egr_Inven_det.IdUnidadMedida, uniMed.Descripcion AS nom_unidad, dbo.in_Motivo_Inven.IdMotivo_Inv, dbo.in_Motivo_Inven.Desc_mov_inv, dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion, 
                         dbo.in_Ing_Egr_Inven_det.IdUnidadMedida_sinConversion, uniSin.Descripcion AS nom_unidad_sinConversion, dbo.in_Ing_Egr_Inven_det.mv_costo_sinConversion, 
                         dbo.in_Ing_Egr_Inven_det.dm_cantidad_sinConversion * dbo.in_Ing_Egr_Inven_det.mv_costo_sinConversion AS SubTotal_sinConversion, dbo.in_Ing_Egr_Inven.CodMoviInven
FROM            dbo.com_ordencompra_local INNER JOIN
                         dbo.com_ordencompra_local_det ON dbo.com_ordencompra_local.IdEmpresa = dbo.com_ordencompra_local_det.IdEmpresa AND 
                         dbo.com_ordencompra_local.IdSucursal = dbo.com_ordencompra_local_det.IdSucursal AND dbo.com_ordencompra_local.IdOrdenCompra = dbo.com_ordencompra_local_det.IdOrdenCompra INNER JOIN
                         dbo.cp_proveedor ON dbo.com_ordencompra_local.IdEmpresa = dbo.cp_proveedor.IdEmpresa AND dbo.com_ordencompra_local.IdProveedor = dbo.cp_proveedor.IdProveedor INNER JOIN
                         dbo.in_Ing_Egr_Inven_det ON dbo.com_ordencompra_local_det.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_oc AND 
                         dbo.com_ordencompra_local_det.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_oc AND dbo.com_ordencompra_local_det.IdOrdenCompra = dbo.in_Ing_Egr_Inven_det.IdOrdenCompra AND 
                         dbo.com_ordencompra_local_det.Secuencia = dbo.in_Ing_Egr_Inven_det.Secuencia_oc INNER JOIN
                         dbo.in_Ing_Egr_Inven ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal AND 
                         dbo.in_Ing_Egr_Inven.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi INNER JOIN
                         dbo.tb_bodega AS bod ON dbo.in_Ing_Egr_Inven.IdEmpresa = bod.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdSucursal = bod.IdSucursal AND dbo.in_Ing_Egr_Inven.IdBodega = bod.IdBodega INNER JOIN
                         dbo.in_UnidadMedida AS uniMed ON dbo.in_Ing_Egr_Inven_det.IdUnidadMedida = uniMed.IdUnidadMedida INNER JOIN
                         dbo.in_UnidadMedida AS uniSin ON dbo.in_Ing_Egr_Inven_det.IdUnidadMedida_sinConversion = uniSin.IdUnidadMedida INNER JOIN
                         dbo.tb_sucursal AS suc ON bod.IdEmpresa = suc.IdEmpresa AND bod.IdSucursal = suc.IdSucursal INNER JOIN
                         dbo.tb_empresa ON dbo.in_Ing_Egr_Inven.IdEmpresa = dbo.tb_empresa.IdEmpresa INNER JOIN
                         dbo.in_Producto AS prod ON dbo.in_Ing_Egr_Inven_det.IdEmpresa = prod.IdEmpresa AND dbo.in_Ing_Egr_Inven_det.IdProducto = prod.IdProducto INNER JOIN
                         dbo.in_movi_inven_tipo AS minv_tip ON dbo.in_Ing_Egr_Inven.IdEmpresa = minv_tip.IdEmpresa AND dbo.in_Ing_Egr_Inven.IdMovi_inven_tipo = minv_tip.IdMovi_inven_tipo LEFT OUTER JOIN
                         dbo.in_movi_inve_detalle AS mov_inv_det ON mov_inv_det.IdEmpresa = dbo.in_Ing_Egr_Inven_det.IdEmpresa_inv AND mov_inv_det.IdSucursal = dbo.in_Ing_Egr_Inven_det.IdSucursal_inv AND 
                         mov_inv_det.IdBodega = dbo.in_Ing_Egr_Inven_det.IdBodega_inv AND mov_inv_det.IdMovi_inven_tipo = dbo.in_Ing_Egr_Inven_det.IdMovi_inven_tipo_inv AND 
                         mov_inv_det.IdNumMovi = dbo.in_Ing_Egr_Inven_det.IdNumMovi_inv AND mov_inv_det.Secuencia = dbo.in_Ing_Egr_Inven_det.secuencia_inv LEFT OUTER JOIN
                         dbo.in_movi_inve AS mov_inv ON mov_inv.IdEmpresa = mov_inv_det.IdEmpresa AND mov_inv.IdSucursal = mov_inv_det.IdSucursal AND mov_inv.IdBodega = mov_inv_det.IdBodega AND 
                         mov_inv.IdMovi_inven_tipo = mov_inv_det.IdMovi_inven_tipo AND mov_inv.IdNumMovi = mov_inv_det.IdNumMovi LEFT OUTER JOIN
                         dbo.in_Motivo_Inven ON dbo.in_Motivo_Inven.IdMotivo_Inv = dbo.in_Ing_Egr_Inven.IdMotivo_Inv AND dbo.in_Motivo_Inven.IdEmpresa = dbo.in_Ing_Egr_Inven.IdEmpresa
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCOMP_Rpt003';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'ight = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "uniSin"
            Begin Extent = 
               Top = 930
               Left = 38
               Bottom = 1060
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "suc"
            Begin Extent = 
               Top = 1062
               Left = 38
               Bottom = 1192
               Right = 268
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_empresa"
            Begin Extent = 
               Top = 1194
               Left = 38
               Bottom = 1456
               Right = 257
            End
            DisplayFlags = 280
            TopColumn = 11
         End
         Begin Table = "prod"
            Begin Extent = 
               Top = 1326
               Left = 38
               Bottom = 1456
               Right = 272
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "minv_tip"
            Begin Extent = 
               Top = 1458
               Left = 38
               Bottom = 1588
               Right = 253
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "mov_inv_det"
            Begin Extent = 
               Top = 1590
               Left = 38
               Bottom = 1720
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "mov_inv"
            Begin Extent = 
               Top = 1722
               Left = 38
               Bottom = 1940
               Right = 301
            End
            DisplayFlags = 280
            TopColumn = 28
         End
         Begin Table = "in_Motivo_Inven"
            Begin Extent = 
               Top = 1854
               Left = 38
               Bottom = 1984
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCOMP_Rpt003';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[51] 4[5] 2[36] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = -1220
         Left = 0
      End
      Begin Tables = 
         Begin Table = "com_ordencompra_local"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 339
               Right = 255
            End
            DisplayFlags = 280
            TopColumn = 18
         End
         Begin Table = "com_ordencompra_local_det"
            Begin Extent = 
               Top = 27
               Left = 415
               Bottom = 407
               Right = 678
            End
            DisplayFlags = 280
            TopColumn = 6
         End
         Begin Table = "cp_proveedor"
            Begin Extent = 
               Top = 270
               Left = 38
               Bottom = 400
               Right = 270
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Ing_Egr_Inven_det"
            Begin Extent = 
               Top = 52
               Left = 918
               Bottom = 182
               Right = 1181
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Ing_Egr_Inven"
            Begin Extent = 
               Top = 322
               Left = 905
               Bottom = 627
               Right = 1168
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "bod"
            Begin Extent = 
               Top = 574
               Left = 384
               Bottom = 704
               Right = 645
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "uniMed"
            Begin Extent = 
               Top = 798
               Left = 38
               Bottom = 928
               R', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwCOMP_Rpt003';

