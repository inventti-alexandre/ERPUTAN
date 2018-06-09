﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Core.Erp.Info.General;
using Core.Erp.Business.General;
using Core.Erp.Info.MobileSCI;
using Core.Erp.Business.MobileSCI;
using System.Linq;

namespace Core.Erp.Winform.MobileSCI
{
    public partial class frmApp_configuracion : DevExpress.XtraEditors.XtraForm
    {
        BindingList<tbl_bodega_Info> blst_bodega;
        BindingList<tbl_subcentro_Info> blst_subcentro;
        BindingList<tbl_producto_Info> blst_producto;
        tbl_bodega_Bus bus_bodega;
        tbl_subcentro_Bus bus_subcentro;
        tbl_producto_Bus bus_producto;
        cl_parametrosGenerales_Bus param;
        public frmApp_configuracion()
        {
            InitializeComponent();
            bus_bodega = new tbl_bodega_Bus();
            param = cl_parametrosGenerales_Bus.Instance;
            bus_subcentro = new tbl_subcentro_Bus();
            bus_producto = new tbl_producto_Bus();
        }

        private void frmApp_configuracion_Load(object sender, EventArgs e)
        {
            tb_Empresa_Bus bus_empresa = new tb_Empresa_Bus();
            var lst_empresa = bus_empresa.Get_List_Empresa();
            cmb_empresa.Properties.DataSource = lst_empresa;
        }

        private void cmb_empresa_EditValueChanged(object sender, EventArgs e)
        {
            cargar_configuracion_x_empresa();
        }

        private void cargar_configuracion_x_empresa()
        {
            blst_bodega = new BindingList<tbl_bodega_Info>();
            blst_subcentro = new BindingList<tbl_subcentro_Info>();
            blst_producto = new BindingList<tbl_producto_Info>();
            if (cmb_empresa.EditValue != null)
            {
                blst_bodega = new BindingList<tbl_bodega_Info>(bus_bodega.get_list(Convert.ToInt32(cmb_empresa.EditValue), true));
                blst_subcentro = new BindingList<tbl_subcentro_Info>(bus_subcentro.get_list(Convert.ToInt32(cmb_empresa.EditValue), true));
                blst_producto = new BindingList<tbl_producto_Info>(bus_producto.get_list(Convert.ToInt32(cmb_empresa.EditValue), true));
            }
            gridControlBodegas.DataSource = blst_bodega;
            gridControlSubcentros.DataSource = blst_subcentro;
            gridControlProductos.DataSource = blst_producto;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private bool guardar()
        {
            chk_bodegas.Focus();
            chk_subcentros.Focus();

            #region Validar
            if (cmb_empresa.EditValue == null)
            {
                MessageBox.Show("Seleccione la empresa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            #endregion

            int IdEmpresa = Convert.ToInt32(cmb_empresa.EditValue);

            #region bodegas
            List<tbl_bodega_Info> lst_bodega = (from q in blst_bodega
                                                where q.seleccionado == true
                                                select new tbl_bodega_Info
                                                {
                                                    IdEmpresaSCI = IdEmpresa,
                                                    IdEmpresa = IdEmpresa,
                                                    IdSucursal = q.IdSucursal,
                                                    IdBodega = q.IdBodega
                                                }).ToList();

            bool result = bus_bodega.eliminarDB(IdEmpresa);
            if (!result)
                return false;

            result = bus_bodega.guardarDB(lst_bodega);
            if (!result)
                return false;
            #endregion

            #region subcentros
            List<tbl_subcentro_Info> lst_subcentro = (from q in blst_subcentro
                                                      where q.seleccionado == true
                                                      select new tbl_subcentro_Info
                                                      {
                                                          IdEmpresaSCI = IdEmpresa,
                                                          IdEmpresa = IdEmpresa,
                                                          IdCentroCosto = q.IdCentroCosto,
                                                          IdCentroCosto_sub_centro_costo = q.IdCentroCosto_sub_centro_costo
                                                      }).ToList();

            result = bus_subcentro.eliminarDB(IdEmpresa);
            if (!result)
                return false;

            result = bus_subcentro.guardarDB(lst_subcentro);
            if (!result)
                return false;
            #endregion

            #region productos
            List<tbl_producto_Info> lst_producto = (from q in blst_producto
                                                    where q.seleccionado == true
                                                    select new tbl_producto_Info
                                                    {
                                                        IdEmpresaSCI = IdEmpresa,
                                                        IdEmpresa = IdEmpresa,
                                                        IdProducto = q.IdProducto
                                                    }).ToList();

            result = bus_producto.eliminarDB(IdEmpresa);
            if (!result)
                return false;

            result = bus_producto.guardarDB(lst_producto);
            if (!result)
                return false;
            #endregion

            MessageBox.Show("Actualización exitosa", param.Nombre_sistema, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            cargar_configuracion_x_empresa();
            return true;
        }

        private void chk_bodegas_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewBodegas.RowCount; i++)
            {
                gridViewBodegas.SetRowCellValue(i, col_bodega, chk_bodegas.Checked);
            }
        }

        private void chk_subcentros_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewSubcentros.RowCount; i++)
            {
                gridViewSubcentros.SetRowCellValue(i, col_subcentro, chk_subcentros.Checked);
            }
        }

        private void chk_productos_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < gridViewProductos.RowCount; i++)
            {
                gridViewProductos.SetRowCellValue(i, col_producto, chk_productos.Checked);
            }
        }

        private void btn_guardar_salir_Click(object sender, EventArgs e)
        {
            if (guardar())
                this.Close();
        }
    }
}