﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cus.Erp.Reports.FJ.Facturacion
{
    public class XFAC_FJ_Rpt014_Info
    {
        public int IdEmpresa { get; set; }
        public int IdSucursal { get; set; }
        public int IdBodega { get; set; }
        public decimal IdCbteVta { get; set; }
        public int Secuencia { get; set; }
        public string vt_tipoDoc { get; set; }
        public string vt_serie1 { get; set; }
        public string vt_serie2 { get; set; }
        public string vt_NumFactura { get; set; }
        public System.DateTime vt_fecha { get; set; }
        public string Estado { get; set; }
        public decimal IdProducto { get; set; }
        public string pr_descripcion { get; set; }
        public double vt_cantidad { get; set; }
        public double vt_PrecioFinal { get; set; }
        public double vt_Subtotal { get; set; }
        public string Atencion_a { get; set; }
        public string num_oc { get; set; }
        public Nullable<int> IdPunto_Cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string Observacion_x_item { get; set; }
        public decimal IdCliente { get; set; }
        public string pe_nombreCompleto { get; set; }
        public string pe_cedulaRuc { get; set; }
        public string pe_direccion { get; set; }
        public string pe_telefonoOfic { get; set; }
        public string Observacion_central { get; set; }
        public Nullable<int> dia { get; set; }
        public Nullable<int> mes { get; set; }
        public Nullable<int> anio { get; set; }
        public double vt_iva { get; set; }
        public double subtotal_0 { get; set; }
        public double subtotal_iva { get; set; }
        public double vt_total { get; set; }
        public string nom_producto { get; set; }
        public double forma_pago_EFECTIVO { get; set; }
        public double forma_pago_DINERO_ELECTRONICO { get; set; }
        public double forma_pago_TARJETA_CRE_DEB { get; set; }
        public double forma_pago_CHEQUE_TRANSFERENCIA { get; set; }
        public double descto { get; set; }
        public string vt_por_iva { get; set; }

        public string pr_descripcion_2 { get; set; }

    }
}
