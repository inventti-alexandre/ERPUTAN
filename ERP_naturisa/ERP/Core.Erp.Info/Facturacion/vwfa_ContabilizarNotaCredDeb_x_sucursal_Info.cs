﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Erp.Info.Facturacion
{
   public  class vwfa_ContabilizarNotaCredDeb_x_sucursal_Info
    {

        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdNota { get; set; }
        public string sc_pagaIva { get; set; }
        public Nullable<double> IVA { get; set; }
        public Nullable<double> SUBTOTAL { get; set; }
        public Nullable<double> tOTAL { get; set; }
        public Nullable<double> descuentototal { get; set; }

        public vwfa_ContabilizarNotaCredDeb_x_sucursal_Info()
        {

        }


    }
}
