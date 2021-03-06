﻿CREATE TABLE [dbo].[tbProd_Rpt_PRD_CUS_TAL_001] (
    [IdEmpresa]               INT            NOT NULL,
    [IdGestionProductiva]     NUMERIC (18)   NOT NULL,
    [IdTurno]                 INT            NULL,
    [IdEmpleado_JefeTurno]    NUMERIC (18)   NULL,
    [IdProducto_MateriaPrima] NUMERIC (18)   NULL,
    [Id_Bobina]               VARCHAR (200)  NULL,
    [Num_Orden]               VARCHAR (200)  NULL,
    [kg_Cargados]             FLOAT (53)     NULL,
    [kg_producidos]           FLOAT (53)     NULL,
    [IdProducto_Producido1]   NUMERIC (18)   NULL,
    [unidades_prd_1]          FLOAT (53)     NULL,
    [pesokg_prd_1]            FLOAT (53)     NULL,
    [IdProducto_Producido2]   NUMERIC (18)   NULL,
    [unidades_prd_2]          FLOAT (53)     NULL,
    [pesokg_prd_2]            FLOAT (53)     NULL,
    [kg_retazo_porcen]        FLOAT (53)     NULL,
    [kg_retazo_valor]         FLOAT (53)     NULL,
    [kg_chatarra_porcen]      FLOAT (53)     NULL,
    [kg_chatarra_valor]       FLOAT (53)     NULL,
    [kg_oxidacion_porcen]     FLOAT (53)     NULL,
    [kg_oxidacion_valor]      FLOAT (53)     NULL,
    [rendi_metal_historico]   FLOAT (53)     NULL,
    [rendi_metal_real]        FLOAT (53)     NULL,
    [rendi_metal_Diferencia]  FLOAT (53)     NULL,
    [consumo_kilowatios]      FLOAT (53)     NULL,
    [consumo_galones]         FLOAT (53)     NULL,
    [cambio_prue_programado]  FLOAT (53)     NULL,
    [cambio_prue_real]        FLOAT (53)     NULL,
    [cambio_prue_porcentaje]  FLOAT (53)     NULL,
    [hora_turno_ini]          VARCHAR (5)    NULL,
    [hora_turno_fin]          VARCHAR (5)    NULL,
    [hora_jornada]            FLOAT (53)     NULL,
    [hora_productiva]         FLOAT (53)     NULL,
    [hora_Paros]              FLOAT (53)     NULL,
    [hora_Neta]               FLOAT (53)     NULL,
    [hora_Hrs_Maquina]        FLOAT (53)     NULL,
    [Ton_Programada]          FLOAT (53)     NULL,
    [Ton_real]                FLOAT (53)     NULL,
    [Ton_Eficiencia]          FLOAT (53)     NULL,
    [Ton_TnHrNeta]            FLOAT (53)     NULL,
    [Ton_kwTon]               FLOAT (53)     NULL,
    [Ton_GlsTon]              FLOAT (53)     NULL,
    [EficienciaProduccion]    FLOAT (53)     NULL,
    [Estado]                  CHAR (1)       NULL,
    [Fecha]                   DATE           NULL,
    [Descripcion]             NVARCHAR (50)  NULL,
    [Nombre_JefeTurno]        NVARCHAR (201) NULL,
    [IdTipoParada]            VARCHAR (10)   NULL,
    [Secuencia]               INT            NULL,
    [HoraIni]                 VARCHAR (5)    NULL,
    [HoraFin]                 VARCHAR (5)    NULL,
    [Descripcion_Det]         VARCHAR (150)  NULL,
    [causa]                   VARCHAR (150)  NULL,
    [Materia_Prima]           NVARCHAR (500) NULL,
    [Producto_1]              NVARCHAR (500) NULL,
    [Producto_2]              NVARCHAR (500) NULL,
    [Descripcion_Turno]       NVARCHAR (50)  NULL,
    [DescripcionTipoParada]   VARCHAR (50)   NULL,
    [NomPc]                   VARCHAR (50)   NULL,
    [IdUsuario]               VARCHAR (50)   NULL
);

