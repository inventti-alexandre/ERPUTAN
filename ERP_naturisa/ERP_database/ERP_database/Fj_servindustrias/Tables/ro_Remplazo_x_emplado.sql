﻿CREATE TABLE [Fj_servindustrias].[ro_Remplazo_x_emplado] (
    [IdEmpresa]                 INT           NOT NULL,
    [IdEmpleado]                NUMERIC (18)  NOT NULL,
    [IdEmpleado_Remplazo]       NUMERIC (18)  NOT NULL,
    [Id_remplazo]               INT           NOT NULL,
    [IdNomina_Tipo]             INT           NULL,
    [IdNomina_TipoLiqui]        INT           NULL,
    [IdPeriodo]                 INT           NULL,
    [IdRubro]                   VARCHAR (10)  NULL,
    [IdNovedad]                 NUMERIC (9)   NULL,
    [Valor_descuento_empleado]  FLOAT (53)    NULL,
    [Fecha_descuenta_rol]       DATE          NULL,
    [valor_x_dia_remplazo]      FLOAT (53)    NOT NULL,
    [Total_pagar_remplazo]      FLOAT (53)    NOT NULL,
    [Descuenta_rol]             BIT           NOT NULL,
    [Fecha]                     DATE          NOT NULL,
    [Id_Motivo_Ausencia_Cat]    INT           NOT NULL,
    [Id_Tipo_tipo_Remplazo_Cat] INT           NOT NULL,
    [Fecha_Salida]              DATE          NOT NULL,
    [Fecha_Entrada]             DATE          NOT NULL,
    [Hora_salida]               TIME (7)      NULL,
    [Hora_regreso]              TIME (7)      NULL,
    [Observacion]               VARCHAR (300) NULL,
    [IdUsuario]                 VARCHAR (20)  NULL,
    [Fecha_Transac]             DATETIME      NULL,
    [IdUsuarioUltMod]           VARCHAR (20)  NULL,
    [Fecha_UltMod]              DATETIME      NULL,
    [IdUsuarioUltAnu]           VARCHAR (20)  NULL,
    [Fecha_UltAnu]              DATETIME      NULL,
    [nom_pc]                    VARCHAR (50)  NULL,
    [ip]                        VARCHAR (25)  NULL,
    [Estado]                    CHAR (1)      NULL,
    [MotiAnula]                 VARCHAR (200) NULL,
    [IdTipo_op]                 VARCHAR (20)  NULL,
    [IdOrdenPago]               NUMERIC (9)   NULL,
    CONSTRAINT [PK_ro_Remplazo_x_emplado] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdEmpleado] ASC, [Id_remplazo] ASC, [IdEmpleado_Remplazo] ASC)
);
