﻿CREATE TABLE [dbo].[cp_orden_pago_con_Transferencia_data] (
    [IdEmpresa]                  INT           NOT NULL,
    [IdUsuario]                  VARCHAR (20)  NOT NULL,
    [IdOrdenPago]                NUMERIC (9)   NOT NULL,
    [Secuencia_OP]               INT           NOT NULL,
    [IdTipo_op]                  VARCHAR (20)  NOT NULL,
    [Referencia]                 VARCHAR (523) NULL,
    [Referencia2]                VARCHAR (34)  NULL,
    [IdTipoPersona]              VARCHAR (20)  NOT NULL,
    [IdPersona]                  NUMERIC (18)  NOT NULL,
    [IdEntidad]                  NUMERIC (18)  NOT NULL,
    [Fecha_OP]                   DATETIME      NULL,
    [Fecha_Fa_Prov]              DATETIME      NULL,
    [Fecha_Venc_Fac_Prov]        DATETIME      NULL,
    [Observacion]                VARCHAR (500) NOT NULL,
    [Nom_Beneficiario]           VARCHAR (200) NULL,
    [Girar_Cheque_a]             VARCHAR (200) NULL,
    [Valor_a_pagar]              FLOAT (53)    NOT NULL,
    [Valor_estimado_a_pagar_OP]  FLOAT (53)    NOT NULL,
    [Total_cancelado_OP]         FLOAT (53)    NOT NULL,
    [Saldo_x_Pagar_OP]           FLOAT (53)    NOT NULL,
    [IdEstadoAprobacion]         VARCHAR (10)  NOT NULL,
    [IdFormaPago]                VARCHAR (20)  NULL,
    [Fecha_Pago]                 DATE          NULL,
    [IdCtaCble]                  VARCHAR (20)  NULL,
    [IdCentroCosto]              VARCHAR (20)  NULL,
    [IdSubCentro_Costo]          VARCHAR (20)  NULL,
    [Cbte_cxp]                   NUMERIC (18)  NOT NULL,
    [Estado]                     VARCHAR (2)   NOT NULL,
    [Nom_Beneficiario_2]         VARCHAR (266) NULL,
    [IdEmpresa_cxp]              INT           NOT NULL,
    [IdTipoCbte_cxp]             INT           NOT NULL,
    [IdCbteCble_cxp]             NUMERIC (18)  NOT NULL,
    [IdTipoCta_acreditacion_cat] VARCHAR (25)  NULL,
    [num_cta_acreditacion]       VARCHAR (50)  NULL,
    [IdBanco_acreditacion]       INT           NULL,
    [ba_descripcion]             VARCHAR (100) NULL,
    [CodigoLegal]                VARCHAR (10)  NULL,
    [Checked]                    BIT           NOT NULL,
    [IdEmpresa_pago]             INT           NULL,
    [IdTipoCbte_pago]            INT           NULL,
    [IdCbteCble_pago]            NUMERIC (18)  NULL,
    [tipo_cbte_pago]             VARCHAR (50)  NULL,
    [Secuencial_reg_x_proceso]   DECIMAL (18)  NULL,
    [Secuencia_ar]               INT           NOT NULL,
    CONSTRAINT [PK_cp_orden_pago_con_Transferencia_data] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdUsuario] ASC, [IdOrdenPago] ASC, [Secuencia_OP] ASC)
);

