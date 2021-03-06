﻿CREATE TABLE [dbo].[tbCXP_Rpt001] (
    [secuencia]           NUMERIC (18)  IDENTITY (1, 1) NOT NULL,
    [IdEmpresa]           INT           NOT NULL,
    [N]                   INT           NOT NULL,
    [IdOrden_giro_Tipo]   VARCHAR (150) NOT NULL,
    [IdCbteCble_Ogiro]    NUMERIC (18)  NOT NULL,
    [co_serie]            VARCHAR (10)  NOT NULL,
    [co_factura]          VARCHAR (15)  NOT NULL,
    [co_FechaFactura]     DATETIME      NULL,
    [co_plazo]            INT           NOT NULL,
    [co_FechaFactura_vct] DATETIME      NULL,
    [co_observacion]      VARCHAR (500) NOT NULL,
    [tipPag]              VARCHAR (6)   NOT NULL,
    [IdCbte]              VARCHAR (20)  NULL,
    [NCheq]               VARCHAR (25)  NULL,
    [Banco]               VARCHAR (150) NULL,
    [Haber]               MONEY         NOT NULL,
    [Debe]                FLOAT (53)    NULL,
    [SaldoOG]             FLOAT (53)    NULL,
    [IdUsuario]           VARCHAR (20)  NULL,
    [Fecha_Transac]       DATETIME      NULL,
    [nom_pc]              VARCHAR (50)  NULL,
    [IdEmpresaOP]         INT           NULL,
    [IdOrdenPago]         NUMERIC (18)  NULL,
    [SecuenciaOP]         INT           NULL,
    CONSTRAINT [PK_tbCXP_Rpt001_1] PRIMARY KEY CLUSTERED ([secuencia] ASC)
);

