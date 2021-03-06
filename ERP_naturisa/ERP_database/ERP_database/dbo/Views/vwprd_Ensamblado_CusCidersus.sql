﻿







CREATE view [dbo].[vwprd_Ensamblado_CusCidersus] as
SELECT                  dbo.prd_Ensamblado_CusCider.IdEmpresa, dbo.prd_Ensamblado_CusCider.IdSucursal, 
                         dbo.prd_Ensamblado_CusCider.IdEnsamblado, dbo.prd_Ensamblado_CusCider.IdBodega, dbo.prd_Ensamblado_CusCider.IdGrupoTrabajo, 
                         dbo.prd_Ensamblado_CusCider.IdProducto, dbo.prd_Ensamblado_CusCider.CodigoBarra, dbo.prd_Ensamblado_CusCider.CodObra, 
                         dbo.prd_Ensamblado_CusCider.IdOrdenTaller, dbo.prd_Ensamblado_CusCider.IdUsuario, dbo.prd_Ensamblado_CusCider.IdUsuarioAnu, 
                         dbo.prd_Ensamblado_CusCider.MotivoAnu, dbo.prd_Ensamblado_CusCider.IdUsuarioUltModi, dbo.prd_Ensamblado_CusCider.FechaAnu, 
                         dbo.prd_Ensamblado_CusCider.FechaTransac, dbo.prd_Ensamblado_CusCider.FechaUltModi, dbo.prd_Ensamblado_CusCider.Estado, 
                         dbo.prd_Ensamblado_CusCider.Observacion, dbo.prd_GrupoTrabajo.IdProcesoProductivo, dbo.prd_GrupoTrabajo.IdEtapa, dbo.prd_Orden_Taller.Codigo, dbo.prd_Obra.Descripcion AS ob_descripcion, dbo.tb_bodega.bo_Descripcion, dbo.prd_GrupoTrabajo.Descripcion AS gt_descripcion, 
                         dbo.in_Producto.pr_descripcion, dbo.tb_sucursal.Su_Descripcion
FROM            dbo.prd_Ensamblado_CusCider INNER JOIN
                         dbo.prd_Obra ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Obra.IdEmpresa AND 
                         dbo.prd_Ensamblado_CusCider.CodObra = dbo.prd_Obra.CodObra INNER JOIN
                         dbo.prd_Orden_Taller ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_Orden_Taller.IdEmpresa AND 
                         dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_Orden_Taller.IdSucursal AND 
                         dbo.prd_Ensamblado_CusCider.IdOrdenTaller = dbo.prd_Orden_Taller.IdOrdenTaller AND 
                         dbo.prd_Ensamblado_CusCider.CodObra = dbo.prd_Orden_Taller.CodObra AND 
                         dbo.prd_Ensamblado_CusCider.IdProducto = dbo.prd_Orden_Taller.IdProducto INNER JOIN
                         dbo.prd_GrupoTrabajo ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.prd_GrupoTrabajo.IdEmpresa AND 
                         dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.prd_GrupoTrabajo.IdSucursal AND 
                         dbo.prd_Ensamblado_CusCider.IdGrupoTrabajo = dbo.prd_GrupoTrabajo.IdGrupoTrabajo INNER JOIN
                         dbo.tb_sucursal ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.tb_sucursal.IdEmpresa AND 
                         dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.tb_sucursal.IdSucursal INNER JOIN
                         dbo.tb_bodega ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.tb_bodega.IdEmpresa AND 
                         dbo.prd_Ensamblado_CusCider.IdSucursal = dbo.tb_bodega.IdSucursal AND dbo.prd_Ensamblado_CusCider.IdBodega = dbo.tb_bodega.IdBodega INNER JOIN
                         dbo.in_Producto ON dbo.prd_Ensamblado_CusCider.IdEmpresa = dbo.in_Producto.IdEmpresa AND 
                         dbo.prd_Ensamblado_CusCider.IdProducto = dbo.in_Producto.IdProducto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 2, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Ensamblado_CusCidersus';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane2', @value = N'
            End
            DisplayFlags = 280
            TopColumn = 5
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 28
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
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Ensamblado_CusCidersus';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[38] 4[4] 2[53] 3) )"
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
         Top = 0
         Left = -52
      End
      Begin Tables = 
         Begin Table = "prd_Ensamblado_CusCider"
            Begin Extent = 
               Top = 87
               Left = 90
               Bottom = 418
               Right = 260
            End
            DisplayFlags = 280
            TopColumn = 14
         End
         Begin Table = "prd_Obra"
            Begin Extent = 
               Top = 0
               Left = 437
               Bottom = 119
               Right = 597
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "prd_Orden_Taller"
            Begin Extent = 
               Top = 138
               Left = 658
               Bottom = 257
               Right = 818
            End
            DisplayFlags = 280
            TopColumn = 3
         End
         Begin Table = "prd_GrupoTrabajo"
            Begin Extent = 
               Top = 42
               Left = 984
               Bottom = 250
               Right = 1172
            End
            DisplayFlags = 280
            TopColumn = 4
         End
         Begin Table = "tb_sucursal"
            Begin Extent = 
               Top = 307
               Left = 354
               Bottom = 426
               Right = 568
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "tb_bodega"
            Begin Extent = 
               Top = 11
               Left = 409
               Bottom = 130
               Right = 607
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "in_Producto"
            Begin Extent = 
               Top = 206
               Left = 626
               Bottom = 325
               Right = 826', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwprd_Ensamblado_CusCidersus';

