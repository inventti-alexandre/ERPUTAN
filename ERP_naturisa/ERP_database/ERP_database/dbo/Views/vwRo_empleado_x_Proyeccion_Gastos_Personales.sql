﻿CREATE VIEW [dbo].[vwRo_empleado_x_Proyeccion_Gastos_Personales]
AS
SELECT        a.IdEmpresa, a.IdEmpleado, a.IdTipoGasto, a.AnioFiscal, a.Valor, a.FechaIngresa, a.UsuarioIngresa, a.FechaModifica, a.UsuarioModifica, 
                         dbo.ro_tipo_gastos_personales_tabla_valores_x_anio.observacion, dbo.ro_tipo_gastos_personales_tabla_valores_x_anio.Monto_max, 
                         dbo.ro_tipo_gastos_personales.nom_tipo_gasto
FROM            dbo.ro_empleado_x_Proyeccion_Gastos_Personales AS a INNER JOIN
                         dbo.ro_tipo_gastos_personales_tabla_valores_x_anio ON a.IdTipoGasto = dbo.ro_tipo_gastos_personales_tabla_valores_x_anio.IdTipoGasto AND 
                         a.AnioFiscal = dbo.ro_tipo_gastos_personales_tabla_valores_x_anio.AnioFiscal INNER JOIN
                         dbo.ro_tipo_gastos_personales ON dbo.ro_tipo_gastos_personales_tabla_valores_x_anio.IdTipoGasto = dbo.ro_tipo_gastos_personales.IdTipoGasto
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_empleado_x_Proyeccion_Gastos_Personales';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[48] 4[4] 2[4] 3) )"
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
         Left = 0
      End
      Begin Tables = 
         Begin Table = "a"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 239
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 1
         End
         Begin Table = "ro_tipo_gastos_personales_tabla_valores_x_anio"
            Begin Extent = 
               Top = 60
               Left = 314
               Bottom = 231
               Right = 523
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "ro_tipo_gastos_personales"
            Begin Extent = 
               Top = 6
               Left = 667
               Bottom = 276
               Right = 876
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
      Begin ColumnWidths = 13
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
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2670
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
', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'VIEW', @level1name = N'vwRo_empleado_x_Proyeccion_Gastos_Personales';

