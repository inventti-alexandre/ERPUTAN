﻿CREATE TABLE [dbo].[ro_archivos_bancos_generacion] (
    [IdEmpresa]          INT             NOT NULL,
    [IdArchivo]          NUMERIC (18)    NOT NULL,
    [IdNomina]           INT             NOT NULL,
    [IdNominaTipo]       INT             NOT NULL,
    [IdPeriodo]          INT             NOT NULL,
    [IdBanco]            VARCHAR (10)    NULL,
    [IdBanco_Acredita]   INT             NULL,
    [IdProceso_Bancario] VARCHAR (25)    NULL,
    [IdDivision]         INT             NULL,
    [Cod_Empresa]        VARCHAR (30)    NULL,
    [Nom_Archivo]        VARCHAR (200)   NULL,
    [archivo]            VARBINARY (MAX) NOT NULL,
    [estado]             CHAR (1)        NOT NULL,
    [IdUsuario]          VARCHAR (20)    NULL,
    [Fecha_Transac]      DATETIME        NULL,
    [IdUsuarioUltMod]    VARCHAR (20)    NULL,
    [Fecha_UltMod]       DATETIME        NULL,
    [IdUsuarioUltAnu]    VARCHAR (20)    NULL,
    [Fecha_UltAnu]       DATETIME        NULL,
    [nom_pc]             VARCHAR (50)    NULL,
    [ip]                 VARCHAR (25)    NULL,
    [MotiAnula]          VARCHAR (200)   NULL,
    CONSTRAINT [PK_ro_Archivos_Bancos_Generacion] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdArchivo] ASC, [IdNomina] ASC, [IdNominaTipo] ASC, [IdPeriodo] ASC)
);

