﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Cus.Erp.Reports.Naturisa.Compras
{
    public class XCOMP_Rpt001_Info
    {
        public int idEmpresa { get; set; }
        public int idSucursal { get; set; }
        public decimal idOrdenCompra { get; set; }
        public decimal idProveedor { get; set; }
        public string oc_NumDocumento { get; set; }
        public string Tipo { get; set; }
        public string idTerminoPago { get; set; }
        public int plazo { get; set; }
        public DateTime Fecha { get; set; }
        public Double Flete { get; set; }
        public string Observacion { get; set; }
        public string Estado { get; set; }
        public decimal IdPersona_Sol { get; set; }
        public decimal IdComprador { get; set; }
       // public decimal idPersona_Comprador { get; set; }
        public decimal IdDepartamento { get; set; }
        public string Nom_comprador { get; set; }
        public string Nom_solicitante { get; set; }
        public string departamento { get; set; }
        public int Secuencia { get; set; }
        public decimal IdProducto { get; set; }
        public double cantidad { get; set; }
        public double precio { get; set; }
        public double por_desc { get; set; }
        public double valor_descuento { get; set; }
        public double Subtotal { get; set; }
        public double iva { get; set; }
        public double total { get; set; }
        public double peso { get; set; }
        public string cod_producto { get; set; }
        public string nom_producto { get; set; }
        public string sucursal { get; set; }
        public string empresa { get; set; }
        public string ruc_empresa { get; set; }
        public Image logo_empresa { get; set; }
        public string nom_proveedor { get; set; }
        public string ced_ruc_provee { get; set; }
        public string direc_provee { get; set; }
        public string telef_provee { get; set; }
        public string NomUnidad { get; set; }
        public string Nom_TerminoPago { get; set; }
        public  string nom_centro_costo { get; set; }
        public string nom_sub_centro_costo { get; set; }
        public string Detalle_x_Items { get; set; }
        public string em_direccion { get; set; }
       
        public int? IdPunto_cargo { get; set; }
        public string nom_punto_cargo { get; set; }
        public string Descripcion { get; set; }
        public string nom_EstadoCierre { get; set; }
        public XCOMP_Rpt001_Info()

   {
    }
   }
}

