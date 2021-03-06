﻿CREATE VIEW CAH.vw_Aca_Famliar_x_Estudiante_Comprobacion
AS
SELECT dbo.vwAca_Familiar_x_Estudiante.IdEstudiante, dbo.vwAca_Familiar_x_Estudiante.pe_nombre, dbo.vwAca_Familiar_x_Estudiante.pe_apellido, dbo.vwAca_Familiar_x_Estudiante.IdParentesco_cat, 
                  alumno.pe_nombre AS Expr1, alumno.pe_apellido AS Expr2, dbo.Aca_estudiante.IdPersona, alumno.IdPersona AS Expr3, dbo.Aca_estudiante.IdEstudiante AS Expr4
FROM     dbo.vwAca_Familiar_x_Estudiante INNER JOIN
                  dbo.Aca_estudiante ON dbo.vwAca_Familiar_x_Estudiante.IdInstitucion = dbo.Aca_estudiante.IdInstitucion AND dbo.vwAca_Familiar_x_Estudiante.IdEstudiante = dbo.Aca_estudiante.IdEstudiante INNER JOIN
                  dbo.tb_persona AS alumno ON dbo.Aca_estudiante.IdPersona = alumno.IdPersona
WHERE  (dbo.vwAca_Familiar_x_Estudiante.IdEstudiante = 7)
GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPaneCount', @value = 1, @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Famliar_x_Estudiante_Comprobacion';


GO
EXECUTE sp_addextendedproperty @name = N'MS_DiagramPane1', @value = N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[11] 3) )"
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
         Begin Table = "vwAca_Familiar_x_Estudiante"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 244
               Right = 359
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Aca_estudiante"
            Begin Extent = 
               Top = 8
               Left = 498
               Bottom = 249
               Right = 742
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "alumno"
            Begin Extent = 
               Top = 4
               Left = 853
               Bottom = 262
               Right = 1127
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
      Begin ColumnWidths = 9
         Width = 284
         Width = 2676
         Width = 2376
         Width = 3264
         Width = 2988
         Width = 1716
         Width = 2196
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
', @level0type = N'SCHEMA', @level0name = N'CAH', @level1type = N'VIEW', @level1name = N'vw_Aca_Famliar_x_Estudiante_Comprobacion';

