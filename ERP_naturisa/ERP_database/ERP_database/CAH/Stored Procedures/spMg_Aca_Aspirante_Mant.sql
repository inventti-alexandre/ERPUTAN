﻿CREATE proc [CAH].[spMg_Aca_Aspirante_Mant]
(
 @i_Operacion	varchar(20)
,@i_id	decimal	
,@i_id_persona	int	
,@i_estado varchar(100)
,@i_estado_admision varchar(100)
,@i_fecha_ingreso	datetime	
,@i_fecha_transaccion	datetime	
,@i_fecha_modificacion	datetime	
--,@o_w_IdEstudiante varchar(250) output

)
as 
begin 

declare @w_IdInstitucion	int
--declare @w_IdEstudiante	int
--declare @w_IdEstudiante	int
declare @w_IdAspirante	int	
declare @w_cod_estudiante	varchar	(50)
declare @w_lugar	varchar	(50)
declare @w_IdPais_Nacionalidad	varchar	(10)
declare @w_barrio	nchar	(20)
declare @w_estado	varchar	(1)
declare @w_cod_alter varchar	(50)
declare @w_IdPersona	decimal	(9)
declare @w_FechaModificacion	datetime	
declare @w_FechaCreacion	datetime	
declare @w_UsuarioModificacion	varchar	(25)
declare @w_UsuarioCreacion	varchar	(25)

declare @w_MotivoAnulacion	varchar	(150)
declare @w_FechaAnulacion	datetime	
declare @w_UsuarioAnulacion	varchar	(25)
declare @w_IdPais_Nacionalidad2	varchar	(10)
declare @w_IdPais_Nacionalidad3	varchar	(10)


set @w_lugar	=''
set @w_barrio	=''
set @w_estado	='A'
set @w_cod_alter =@i_id
set @w_FechaModificacion	=@i_fecha_modificacion
set @w_FechaCreacion	=@i_fecha_transaccion
set @w_UsuarioModificacion	='sys_aca_mig'
set @w_UsuarioCreacion	='sys_aca_mig'
set @w_IdAspirante	=null
set @w_IdPais_Nacionalidad	=0
set @w_IdPais_Nacionalidad2	=null
set @w_IdPais_Nacionalidad3	=null
set @w_IdPersona =0


select @w_IdPais_Nacionalidad=IdPais from tb_pais where Nombre like '%ECUADOR%'

select @w_IdPersona = IdPersona_Erp from CAH.tb_persona_x_mg_persona where IdPersona_Academico=@i_id_persona


select @w_IdInstitucion=
Ins.IdInstitucion from Aca_Institucion Ins where Ins.IdEmpresa=1

	--set @o_w_IdEstudiante = @i_Operacion;
	if (@i_Operacion='INSERT')
	begin
		--set @o_w_IdEstudiante = 'HOLA';
		--return 'INSERT';
		--set @o_w_IdEstudiante = 'SELECT id_alumno_academico FROM CAH.mg_alumno_x_Aca_estudiante estu where estu.id_alumno_academico = ' + Convert(varchar(10),@i_id);
		
		if not exists( SELECT id_alumno_academico FROM [CAH].[mg_alumno_x_Aca_aspirante] aspi where aspi.id_alumno_academico =@i_id )
		--begin
		--	set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		--end
		--set @o_w_IdEstudiante = Convert(varchar(10),@i_id);
		begin


				select  @w_IdAspirante=ISNULL(MAX(asp.IdAspirante),0)+1 from [dbo].[Aca_Aspirante]  asp where asp.IdInstitucion=@w_IdInstitucion
				
				set @w_cod_estudiante=@w_IdAspirante
				--set @o_w_IdEstudiante = 10000;


					INSERT INTO [dbo].[Aca_Aspirante]
					(
					 [IdInstitucion]				,[IdAspirante]				,[cod_aspirante]			,[lugar]
					,[IdPais_Nacionalidad]			,[barrio]					,[foto]						,[estado]
					,[cod_alterno]					,[IdPersona]				,[FechaModificacion]		,[FechaCreacion]
					,[UsuarioModificacion]			,[UsuarioCreacion]			,[estado_alumno]
					,[estado_admision]							
								
					)
					values
					(
					 @w_IdInstitucion				,@w_IdAspirante				,@w_cod_estudiante			,@w_lugar	
					,@w_IdPais_Nacionalidad			,@w_barrio					,null						,@w_estado	
					,@w_cod_alter					,@w_IdPersona				,@w_FechaModificacion		,@w_FechaCreacion	
					,@w_UsuarioModificacion			,@w_UsuarioCreacion			,@i_estado
					,@i_estado_admision			
					)
		


					INSERT INTO [CAH].[mg_alumno_x_Aca_aspirante]
					   ([id_alumno_academico]				,[IdInstitucion]	,[IdAspirante]
					   ,[nota1]								,[nota2]
					   )
					 values
					 (@i_id									,@w_IdInstitucion	,@w_IdAspirante
					 ,'INSERT - if (@i_Operacion=INSERT)'	,null
					 )

					 
		end 

	end

	if (@i_Operacion='UPDATE')
	begin


		SELECT @w_IdInstitucion=IdInstitucion,@w_IdAspirante=[IdAspirante] 
		FROM [CAH].[mg_alumno_x_Aca_aspirante] 
		WHERE id_alumno_academico=@i_id


		UPDATE [dbo].[Aca_estudiante]
		SET 
			IdPais_Nacionalidad=@w_IdPais_Nacionalidad
			,FechaModificacion=@i_fecha_modificacion	
		WHERE 		
			IdInstitucion=@w_IdInstitucion
		AND IdEstudiante=@w_IdAspirante


		update [CAH].[mg_alumno_x_Aca_estudiante]
		set 
		   nota2='UDPATE - if (@i_Operacion=UPDATE)'
		where 
			id_alumno_academico=@i_id
		and IdInstitucion=@w_IdInstitucion
		and IdEstudiante=@w_IdAspirante
	end 
		
end