﻿
CREATE PROCEDURE [Fj_servindustrias].[spROLES_Rpt005]  
	@IdEmpresa int,
	@IdNomina_tipo int,
	@Fecha_Inicio date,
	@Fecha_Fin date

	
AS
/*
declare
    @IdEmpresa int,
	@IdNomina_tipo int,
	@Fecha_Inicio date,
	@Fecha_Fin date

	set @IdEmpresa=1
	set @IdNomina_tipo=1
	set @Fecha_Inicio ='2016-09-01'
	set @Fecha_Fin ='2016-09-30'
	*/
BEGIN
	SELECT        Ma.IdEmpresa, Ma.IdNomina_Tipo, Ma.IdEmpleado, Ma.IdRegistro, P.pe_cedulaRuc, P.pe_nombre, P.pe_apellido, Ma.es_fecha_registro, 
                         Cat.ca_descripcion, C.ca_descripcion AS Cargo, Ma.IdTurno, Ma.es_jornada_desfasada,Dep.de_descripcion,
						 case when Ma.Id_catalogo_Cat='ASIST' THEN 'X'
						 WHEN Ma.Id_catalogo_Cat ='ATRA' THEN 'A'
						 WHEN Ma.Id_catalogo_Cat ='VACA' THEN 'V'
						 WHEN Ma.Id_catalogo_Cat ='PER' THEN 'P'
						 WHEN Ma.Id_catalogo_Cat ='FAL' THEN 'F'
						 WHEN Ma.es_jornada_desfasada =1 AND Ma.Id_catalogo_Cat='ASIST'  THEN 'JD'
						 ELSE 'N' END aS Id_catalogo_Cat,
						 planifica.zo_descripcion,
						  planifica.Disco,
						   planifica.ru_descripcion,
						    planifica.fu_descripcion,
							planifica.Placa,
							Em.em_status

						 
						-- ELSE END THEN  'N' AS Id_catalogo_Cat
FROM                      dbo.tb_persona AS P INNER JOIN
                         dbo.ro_empleado AS Em ON P.IdPersona = Em.IdPersona INNER JOIN
                         dbo.ro_empleado_x_ro_tipoNomina AS ExN ON Em.IdEmpleado = ExN.IdEmpleado INNER JOIN
                         Fj_servindustrias.ro_marcaciones_x_empleado_x_incidentes_falt_Perm AS Ma ON ExN.IdEmpresa = Ma.IdEmpresa AND 
                         ExN.IdTipoNomina = Ma.IdNomina_Tipo AND ExN.IdEmpleado = Ma.IdEmpleado INNER JOIN
                         dbo.ro_catalogo AS Cat ON Em.em_status = Cat.CodCatalogo INNER JOIN
                         dbo.ro_cargo AS C ON Em.IdEmpresa = C.IdEmpresa AND Em.IdCargo = C.IdCargo AND Em.IdEmpresa = C.IdEmpresa AND Em.IdCargo = C.IdCargo INNER JOIN
                         dbo.ro_turno AS Turn ON Ma.IdEmpresa = Turn.IdEmpresa AND Ma.IdTurno = Turn.IdTurno INNER JOIN
                         dbo.ro_Departamento AS Dep ON Em.IdDepartamento = Dep.IdDepartamento AND Dep.IdEmpresa = Em.IdEmpresa LEFT OUTER JOIN
                         Fj_servindustrias.vwro_planificacion_x_ruta_x_empleado_det_x_rut_x_fuer_x_zon_x_disc_x_pla AS planifica ON ExN.IdEmpresa = planifica.IdEmpresa AND 
                         ExN.IdTipoNomina = planifica.IdNomina_Tipo AND ExN.IdEmpleado = planifica.IdEmpleado
						 WHERE Ma.IdEmpresa=@IdEmpresa
						 AND Ma.IdNomina_Tipo=@IdNomina_tipo
						 AND Ma.es_fecha_registro between @Fecha_Inicio and @Fecha_Fin
						  
END