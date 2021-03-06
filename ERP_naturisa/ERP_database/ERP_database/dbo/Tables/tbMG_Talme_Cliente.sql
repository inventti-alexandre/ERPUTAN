﻿CREATE TABLE [dbo].[tbMG_Talme_Cliente] (
    [Cl_codigo]                    NVARCHAR (255) NULL,
    [Cl_cuenta_contable]           NVARCHAR (255) NULL,
    [Cl_ruc]                       NVARCHAR (255) NULL,
    [Cl_nombre]                    NVARCHAR (255) NULL,
    [Cl_representante]             NVARCHAR (255) NULL,
    [Cl_direccion]                 NVARCHAR (255) NULL,
    [Cl_casilla]                   NVARCHAR (255) NULL,
    [Cl_telefono]                  NVARCHAR (255) NULL,
    [Cl_fax]                       NVARCHAR (255) NULL,
    [Cl_pais]                      NVARCHAR (255) NULL,
    [Cl_region]                    NVARCHAR (255) NULL,
    [Cl_provincia]                 NVARCHAR (255) NULL,
    [Cl_ciudad]                    NVARCHAR (255) NULL,
    [Cl_zona]                      NVARCHAR (255) NULL,
    [Cl_tipo]                      NVARCHAR (255) NULL,
    [Cl_precio]                    FLOAT (53)     NULL,
    [Cl_iva]                       NVARCHAR (255) NULL,
    [Cl_porcentaje_descuento]      FLOAT (53)     NULL,
    [Cl_dias_plazo]                FLOAT (53)     NULL,
    [Cl_vendedor]                  NVARCHAR (255) NULL,
    [Cl_limite]                    FLOAT (53)     NULL,
    [Cl_ultima_compra]             NVARCHAR (255) NULL,
    [Cl_ultimo_pago]               NVARCHAR (255) NULL,
    [Cl_bloqueo]                   NVARCHAR (255) NULL,
    [Cl_debitos]                   FLOAT (53)     NULL,
    [Cl_creditos]                  FLOAT (53)     NULL,
    [Cl_chq_postfechados_valor]    FLOAT (53)     NULL,
    [Cl_chq_protestados_valor]     FLOAT (53)     NULL,
    [Cl_chq_justificados_valor]    FLOAT (53)     NULL,
    [Cl_chq_anulados_valor]        FLOAT (53)     NULL,
    [Cl_chq_postfechados_cantidad] FLOAT (53)     NULL,
    [Cl_chq_protestados_cantidad]  FLOAT (53)     NULL,
    [Cl_chq_justificados_cantidad] FLOAT (53)     NULL,
    [Cl_chq_anulados_cantidad]     FLOAT (53)     NULL,
    [Cl_Generico]                  BIT            NOT NULL,
    [Cl_Especial]                  NVARCHAR (255) NULL,
    [Cl_Calificacion]              NVARCHAR (255) NULL,
    [Cl_Calificacion_Anterior]     NVARCHAR (255) NULL,
    [Cl_Ultimo_Protesto]           NVARCHAR (255) NULL,
    [Cl_FechaIngreso]              DATETIME       NULL,
    [Cl_comentario]                NVARCHAR (255) NULL,
    [Cl_dias_plazo_2]              FLOAT (53)     NULL,
    [Cl_dias_plazo_3]              FLOAT (53)     NULL,
    [Cl_Matriz]                    NVARCHAR (255) NULL,
    [cl_DespachoLibre]             BIT            NOT NULL,
    [Cl_diaGracia1]                FLOAT (53)     NULL,
    [Cl_diaGracia2]                FLOAT (53)     NULL,
    [Cl_diaGracia3]                FLOAT (53)     NULL,
    [Cl_DespachoLibreSodimet]      BIT            NOT NULL,
    [Cl_Grupo]                     NVARCHAR (255) NULL,
    [Cl_VtaTelefonica]             BIT            NOT NULL,
    [Cl_NoContactar]               BIT            NOT NULL,
    [sri_IdTipoIdentificacion]     NVARCHAR (255) NULL,
    [Cl_Activo]                    BIT            NOT NULL,
    [Cl_ConsiderarFlujo]           BIT            NOT NULL,
    [Cl_TendenciaPago]             BIT            NOT NULL,
    [IdEmpresa]                    INT            NULL
);

