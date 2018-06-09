﻿CREATE TABLE [dbo].[prod_GestionProductivaTechos_CusTalme_Detalle] (
    [IdEmpresa]             INT          NOT NULL,
    [IdGestionProductiva]   DECIMAL (18) NOT NULL,
    [Secuencia]             INT          NOT NULL,
    [Prod_IdProducto]       NUMERIC (18) NULL,
    [Prod_Largo]            FLOAT (53)   NULL,
    [Prod_Ancho]            FLOAT (53)   NULL,
    [Prod_PsoEsp]           FLOAT (53)   NULL,
    [Prod_Espesor]          FLOAT (53)   NULL,
    [Prod_PsoUnd]           FLOAT (53)   NULL,
    [Prducc_Unidades]       FLOAT (53)   NULL,
    [Prducc_Kg]             FLOAT (53)   NULL,
    [Segunda_IdProducto]    NUMERIC (18) NULL,
    [Segunda_Unidades]      FLOAT (53)   NULL,
    [Segunda_Kg]            FLOAT (53)   NULL,
    [Chatarra_Kg]           FLOAT (53)   NULL,
    [Peso]                  FLOAT (53)   NULL,
    [Kg_Desp]               FLOAT (53)   NULL,
    [Rend_Metalico]         FLOAT (53)   NULL,
    [KW]                    FLOAT (53)   NULL,
    [Tiempo_Preparacion]    TIME (0)     NULL,
    [Tiempo_Produccion]     TIME (0)     NULL,
    [Tiempo_Total]          TIME (0)     NULL,
    [Parada_Mecanica]       TIME (0)     NULL,
    [Parada_Electrico]      TIME (0)     NULL,
    [Parada_Logistica]      TIME (0)     NULL,
    [Parada_Otros]          TIME (0)     NULL,
    [TotalParos]            TIME (0)     NULL,
    [Indicadores_TnHrs]     FLOAT (53)   NULL,
    [Indicadores_TimeParda] FLOAT (53)   NULL,
    [Indicadores_UndsHrs]   FLOAT (53)   NULL,
    [Indicadores_Calidad]   FLOAT (53)   NULL,
    CONSTRAINT [PK_prod_GestionProductivaTechos_CusTalme] PRIMARY KEY CLUSTERED ([IdEmpresa] ASC, [IdGestionProductiva] ASC, [Secuencia] ASC)
);

