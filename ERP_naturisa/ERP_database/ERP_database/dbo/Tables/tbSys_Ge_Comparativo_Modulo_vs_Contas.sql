﻿CREATE TABLE [dbo].[tbSys_Ge_Comparativo_Modulo_vs_Contas] (
    [IdEmpresa]         INT           NOT NULL,
    [IdSucursal]        INT           NOT NULL,
    [cod_sucu]          VARCHAR (10)  NULL,
    [IdBodega]          INT           NULL,
    [IdCbteVta]         NUMERIC (18)  NULL,
    [vt_tipoDoc]        VARCHAR (20)  NULL,
    [vt_serie1]         VARCHAR (3)   NULL,
    [vt_serie2]         VARCHAR (3)   NULL,
    [vt_NumFactura]     VARCHAR (20)  NULL,
    [IdCliente]         NUMERIC (18)  NULL,
    [pe_nombreCompleto] VARCHAR (200) NULL,
    [vt_fecha]          DATETIME      NOT NULL,
    [vt_Observacion]    VARCHAR (MAX) NOT NULL,
    [Debito_Vta]        FLOAT (53)    NULL,
    [Credito_Vta]       FLOAT (53)    NULL,
    [cb_Fecha]          DATETIME      NULL,
    [cb_Observacion]    VARCHAR (MAX) NULL,
    [IdCtaCble]         VARCHAR (20)  NULL,
    [Debito_Conta]      FLOAT (53)    NULL,
    [Credito_Conta]     FLOAT (53)    NOT NULL,
    [pc_Cuenta]         VARCHAR (150) NULL,
    [IdEmpresa_ct]      INT           NULL,
    [IdTipoCbte_ct]     INT           NULL,
    [IdCbteCble_ct]     NUMERIC (18)  NULL,
    [secuencia]         INT           NULL,
    [TIPO]              VARCHAR (10)  NOT NULL,
    [referencia]        VARCHAR (143) NULL
);
