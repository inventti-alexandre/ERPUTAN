﻿namespace Core.Erp.Winform.Inventario
{
    partial class FrmIn_Producto_Mant
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.colPrEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tabControl_Producto = new System.Windows.Forms.TabControl();
            this.tab_descripcion = new System.Windows.Forms.TabPage();
            this.chkActivo = new DevExpress.XtraEditors.CheckEdit();
            this.ucIn_Presentacion = new Core.Erp.Winform.Controles.UCIn_Presentacion();
            this.label6 = new System.Windows.Forms.Label();
            this.ucFa_Motivo_venta = new Core.Erp.Winform.Controles.UCFa_Motivo_venta();
            this.label48 = new System.Windows.Forms.Label();
            this.cmbUnidadMedida_Consumo = new Core.Erp.Winform.Controles.UCIn_UnidadMedidaCmb();
            this.ucIn_Linea_Grup_SubGr = new Core.Erp.Winform.Controles.ucIn_Linea_Grup_SubGr();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbCodImpt_ICE = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView7 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCod_Impuesto_Ice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_impuesto_ice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_ice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCodigo_SRI_ice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbCodImp_IVA = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCod_Impuesto_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colnom_impuesto_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colporcentaje_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdCodigo_SRI_iva = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cmbUnidadMedida = new Core.Erp.Winform.Controles.UCIn_UnidadMedidaCmb();
            this.cmbMarca = new Core.Erp.Winform.Controles.UCIn_MarcaCmb();
            this.btn_imgGrande = new DevExpress.XtraEditors.SimpleButton();
            this.chkManejaKardex = new DevExpress.XtraEditors.CheckEdit();
            this.txeStockminimo = new DevExpress.XtraEditors.TextEdit();
            this.txeStockMaximo = new DevExpress.XtraEditors.TextEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txePesoEspecifico = new DevExpress.XtraEditors.TextEdit();
            this.txeAnchoEspecifico = new DevExpress.XtraEditors.TextEdit();
            this.txeAlto = new DevExpress.XtraEditors.TextEdit();
            this.txeProfundidad = new DevExpress.XtraEditors.TextEdit();
            this.txeLargo = new DevExpress.XtraEditors.TextEdit();
            this.txePeso = new DevExpress.XtraEditors.TextEdit();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.grImgGrande = new System.Windows.Forms.GroupBox();
            this.pibx_imagenPequeña = new System.Windows.Forms.PictureBox();
            this.codigoBarraProducto = new DevExpress.XtraEditors.BarCodeControl();
            this.txtCodigoBarra = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txePrecioMinimo = new DevExpress.XtraEditors.TextEdit();
            this.txePrecioMayor = new DevExpress.XtraEditors.TextEdit();
            this.txePrecioPublico = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tab_Costos = new System.Windows.Forms.TabPage();
            this.txeCostoPromedio = new DevExpress.XtraEditors.TextEdit();
            this.txeCostoFOB = new DevExpress.XtraEditors.TextEdit();
            this.txeCostoCIF = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tab_DatosImportacion = new System.Windows.Forms.TabPage();
            this.txtDiasTerrestre = new System.Windows.Forms.NumericUpDown();
            this.txtDiasAereo = new System.Windows.Forms.NumericUpDown();
            this.txtDiasMaritimo = new System.Windows.Forms.NumericUpDown();
            this.txtPorPartidaArancelaria = new System.Windows.Forms.NumericUpDown();
            this.txtPartidaArancelaria = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tab_proveedores = new System.Windows.Forms.TabPage();
            this.gridControlProveedor = new DevExpress.XtraGrid.GridControl();
            this.gridViewProveedor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProveedor_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProveedor_grid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colpr_nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNomProducto_en_Proveedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tab_productosxPuntoVta = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.treeList_Bodega_x_Sucursal = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn4 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn5 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn6 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn7 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridControlComposicion = new DevExpress.XtraGrid.GridControl();
            this.gridViewComposicion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProductoHijo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbProductoHijo_grid = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colpr_descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tab_DatosContables = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkModulo_AF = new System.Windows.Forms.CheckBox();
            this.chkModulo_Inven = new System.Windows.Forms.CheckBox();
            this.chkModulo_Compras = new System.Windows.Forms.CheckBox();
            this.chkModulo_Venta = new System.Windows.Forms.CheckBox();
            this.cmb_tipoProducto = new Core.Erp.Winform.Controles.UCIn_TipoProductoCmb();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion2 = new System.Windows.Forms.TextBox();
            this.lblAnulado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblIdProducto = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.inproductoxtbbodegaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctPlanctaInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctCentrocostoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ctCentrocostoInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ctPlanctaInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbCatalogoInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialogImagenGrande = new System.Windows.Forms.OpenFileDialog();
            this.ucGe_Menu = new Core.Erp.Winform.Controles.UCGe_Menu_Superior_Mant();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tabControl_Producto.SuspendLayout();
            this.tab_descripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodImpt_ICE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodImp_IVA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManejaKardex.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeStockminimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeStockMaximo.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txePesoEspecifico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAnchoEspecifico.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAlto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeProfundidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeLargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePeso.Properties)).BeginInit();
            this.grImgGrande.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pibx_imagenPequeña)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txePrecioMinimo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrecioMayor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrecioPublico.Properties)).BeginInit();
            this.tab_Costos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeCostoPromedio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeCostoFOB.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeCostoCIF.Properties)).BeginInit();
            this.tab_DatosImportacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasTerrestre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasAereo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasMaritimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorPartidaArancelaria)).BeginInit();
            this.tab_proveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.tab_productosxPuntoVta.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treeList_Bodega_x_Sucursal)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComposicion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoHijo_grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.panel4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inproductoxtbbodegaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // colPrEstado
            // 
            this.colPrEstado.Caption = "Estado";
            this.colPrEstado.FieldName = "pr_estado";
            this.colPrEstado.Name = "colPrEstado";
            this.colPrEstado.Visible = true;
            this.colPrEstado.VisibleIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 626);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(903, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(899, 593);
            this.panel1.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tabControl_Producto);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 97);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(899, 496);
            this.panel5.TabIndex = 47;
            // 
            // tabControl_Producto
            // 
            this.tabControl_Producto.Controls.Add(this.tab_descripcion);
            this.tabControl_Producto.Controls.Add(this.tab_Costos);
            this.tabControl_Producto.Controls.Add(this.tab_DatosImportacion);
            this.tabControl_Producto.Controls.Add(this.tab_proveedores);
            this.tabControl_Producto.Controls.Add(this.tab_productosxPuntoVta);
            this.tabControl_Producto.Controls.Add(this.tabPage1);
            this.tabControl_Producto.Controls.Add(this.tab_DatosContables);
            this.tabControl_Producto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl_Producto.Location = new System.Drawing.Point(0, 0);
            this.tabControl_Producto.Name = "tabControl_Producto";
            this.tabControl_Producto.SelectedIndex = 0;
            this.tabControl_Producto.Size = new System.Drawing.Size(899, 496);
            this.tabControl_Producto.TabIndex = 9;
            // 
            // tab_descripcion
            // 
            this.tab_descripcion.Controls.Add(this.chkActivo);
            this.tab_descripcion.Controls.Add(this.ucIn_Presentacion);
            this.tab_descripcion.Controls.Add(this.label6);
            this.tab_descripcion.Controls.Add(this.ucFa_Motivo_venta);
            this.tab_descripcion.Controls.Add(this.label48);
            this.tab_descripcion.Controls.Add(this.cmbUnidadMedida_Consumo);
            this.tab_descripcion.Controls.Add(this.ucIn_Linea_Grup_SubGr);
            this.tab_descripcion.Controls.Add(this.groupBox4);
            this.tab_descripcion.Controls.Add(this.cmbUnidadMedida);
            this.tab_descripcion.Controls.Add(this.cmbMarca);
            this.tab_descripcion.Controls.Add(this.btn_imgGrande);
            this.tab_descripcion.Controls.Add(this.chkManejaKardex);
            this.tab_descripcion.Controls.Add(this.txeStockminimo);
            this.tab_descripcion.Controls.Add(this.txeStockMaximo);
            this.tab_descripcion.Controls.Add(this.groupBox3);
            this.tab_descripcion.Controls.Add(this.grImgGrande);
            this.tab_descripcion.Controls.Add(this.codigoBarraProducto);
            this.tab_descripcion.Controls.Add(this.txtCodigoBarra);
            this.tab_descripcion.Controls.Add(this.label3);
            this.tab_descripcion.Controls.Add(this.txtObservacion);
            this.tab_descripcion.Controls.Add(this.label33);
            this.tab_descripcion.Controls.Add(this.groupBox1);
            this.tab_descripcion.Controls.Add(this.label31);
            this.tab_descripcion.Controls.Add(this.label30);
            this.tab_descripcion.Controls.Add(this.label19);
            this.tab_descripcion.Controls.Add(this.label39);
            this.tab_descripcion.Controls.Add(this.label7);
            this.tab_descripcion.Location = new System.Drawing.Point(4, 22);
            this.tab_descripcion.Name = "tab_descripcion";
            this.tab_descripcion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_descripcion.Size = new System.Drawing.Size(891, 470);
            this.tab_descripcion.TabIndex = 6;
            this.tab_descripcion.Text = "Descripcion de Producto";
            this.tab_descripcion.UseVisualStyleBackColor = true;
            // 
            // chkActivo
            // 
            this.chkActivo.Location = new System.Drawing.Point(19, 415);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Properties.Caption = "Activo";
            this.chkActivo.Size = new System.Drawing.Size(75, 19);
            this.chkActivo.TabIndex = 55;
            // 
            // ucIn_Presentacion
            // 
            this.ucIn_Presentacion.Location = new System.Drawing.Point(110, 121);
            this.ucIn_Presentacion.Name = "ucIn_Presentacion";
            this.ucIn_Presentacion.Size = new System.Drawing.Size(362, 30);
            this.ucIn_Presentacion.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Presentacion:";
            // 
            // ucFa_Motivo_venta
            // 
            this.ucFa_Motivo_venta.Location = new System.Drawing.Point(575, 151);
            this.ucFa_Motivo_venta.Name = "ucFa_Motivo_venta";
            this.ucFa_Motivo_venta.Size = new System.Drawing.Size(310, 28);
            this.ucFa_Motivo_venta.TabIndex = 70;
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(493, 157);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(64, 13);
            this.label48.TabIndex = 69;
            this.label48.Text = "Motivo Vta.:";
            // 
            // cmbUnidadMedida_Consumo
            // 
            this.cmbUnidadMedida_Consumo.Location = new System.Drawing.Point(110, 93);
            this.cmbUnidadMedida_Consumo.Name = "cmbUnidadMedida_Consumo";
            this.cmbUnidadMedida_Consumo.Size = new System.Drawing.Size(362, 29);
            this.cmbUnidadMedida_Consumo.TabIndex = 68;
            // 
            // ucIn_Linea_Grup_SubGr
            // 
            this.ucIn_Linea_Grup_SubGr.Location = new System.Drawing.Point(541, 23);
            this.ucIn_Linea_Grup_SubGr.Name = "ucIn_Linea_Grup_SubGr";
            this.ucIn_Linea_Grup_SubGr.Size = new System.Drawing.Size(337, 122);
            this.ucIn_Linea_Grup_SubGr.SubGrupoInfo = null;
            this.ucIn_Linea_Grup_SubGr.TabIndex = 67;
            this.ucIn_Linea_Grup_SubGr.Visible_Todos_cmb_Categoria = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbCodImpt_ICE);
            this.groupBox4.Controls.Add(this.cmbCodImp_IVA);
            this.groupBox4.Controls.Add(this.labelControl3);
            this.groupBox4.Controls.Add(this.labelControl2);
            this.groupBox4.Location = new System.Drawing.Point(6, 186);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(466, 60);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Códigos de Impuestos Aplicables";
            // 
            // cmbCodImpt_ICE
            // 
            this.cmbCodImpt_ICE.Location = new System.Drawing.Point(264, 25);
            this.cmbCodImpt_ICE.Name = "cmbCodImpt_ICE";
            this.cmbCodImpt_ICE.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCodImpt_ICE.Properties.DisplayMember = "nom_impuesto";
            this.cmbCodImpt_ICE.Properties.ValueMember = "IdCod_Impuesto";
            this.cmbCodImpt_ICE.Properties.View = this.gridView7;
            this.cmbCodImpt_ICE.Size = new System.Drawing.Size(195, 20);
            this.cmbCodImpt_ICE.TabIndex = 3;
            // 
            // gridView7
            // 
            this.gridView7.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCod_Impuesto_Ice,
            this.colnom_impuesto_ice,
            this.colporcentaje_ice,
            this.colIdCodigo_SRI_ice});
            this.gridView7.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView7.Name = "gridView7";
            this.gridView7.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView7.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCod_Impuesto_Ice
            // 
            this.colIdCod_Impuesto_Ice.Caption = "IdCod_Impuesto";
            this.colIdCod_Impuesto_Ice.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto_Ice.Name = "colIdCod_Impuesto_Ice";
            this.colIdCod_Impuesto_Ice.Visible = true;
            this.colIdCod_Impuesto_Ice.VisibleIndex = 2;
            this.colIdCod_Impuesto_Ice.Width = 135;
            // 
            // colnom_impuesto_ice
            // 
            this.colnom_impuesto_ice.Caption = "nom_impuesto";
            this.colnom_impuesto_ice.FieldName = "nom_impuesto";
            this.colnom_impuesto_ice.Name = "colnom_impuesto_ice";
            this.colnom_impuesto_ice.Visible = true;
            this.colnom_impuesto_ice.VisibleIndex = 0;
            this.colnom_impuesto_ice.Width = 638;
            // 
            // colporcentaje_ice
            // 
            this.colporcentaje_ice.Caption = "porcentaje";
            this.colporcentaje_ice.FieldName = "porcentaje";
            this.colporcentaje_ice.Name = "colporcentaje_ice";
            this.colporcentaje_ice.Visible = true;
            this.colporcentaje_ice.VisibleIndex = 1;
            this.colporcentaje_ice.Width = 228;
            // 
            // colIdCodigo_SRI_ice
            // 
            this.colIdCodigo_SRI_ice.Caption = "IdCodigo_SRI";
            this.colIdCodigo_SRI_ice.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI_ice.Name = "colIdCodigo_SRI_ice";
            this.colIdCodigo_SRI_ice.Visible = true;
            this.colIdCodigo_SRI_ice.VisibleIndex = 3;
            this.colIdCodigo_SRI_ice.Width = 140;
            // 
            // cmbCodImp_IVA
            // 
            this.cmbCodImp_IVA.Location = new System.Drawing.Point(36, 25);
            this.cmbCodImp_IVA.Name = "cmbCodImp_IVA";
            this.cmbCodImp_IVA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCodImp_IVA.Properties.DisplayMember = "nom_impuesto";
            this.cmbCodImp_IVA.Properties.ValueMember = "IdCod_Impuesto";
            this.cmbCodImp_IVA.Properties.View = this.gridView6;
            this.cmbCodImp_IVA.Size = new System.Drawing.Size(195, 20);
            this.cmbCodImp_IVA.TabIndex = 2;
            // 
            // gridView6
            // 
            this.gridView6.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCod_Impuesto_iva,
            this.colnom_impuesto_iva,
            this.colporcentaje_iva,
            this.colIdCodigo_SRI_iva});
            this.gridView6.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView6.Name = "gridView6";
            this.gridView6.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView6.OptionsView.ShowGroupPanel = false;
            // 
            // colIdCod_Impuesto_iva
            // 
            this.colIdCod_Impuesto_iva.Caption = "IdCod_Impuesto";
            this.colIdCod_Impuesto_iva.FieldName = "IdCod_Impuesto";
            this.colIdCod_Impuesto_iva.Name = "colIdCod_Impuesto_iva";
            this.colIdCod_Impuesto_iva.Visible = true;
            this.colIdCod_Impuesto_iva.VisibleIndex = 2;
            this.colIdCod_Impuesto_iva.Width = 76;
            // 
            // colnom_impuesto_iva
            // 
            this.colnom_impuesto_iva.Caption = "Impuesto";
            this.colnom_impuesto_iva.FieldName = "nom_impuesto";
            this.colnom_impuesto_iva.Name = "colnom_impuesto_iva";
            this.colnom_impuesto_iva.Visible = true;
            this.colnom_impuesto_iva.VisibleIndex = 0;
            this.colnom_impuesto_iva.Width = 591;
            // 
            // colporcentaje_iva
            // 
            this.colporcentaje_iva.Caption = "porcentaje";
            this.colporcentaje_iva.FieldName = "porcentaje";
            this.colporcentaje_iva.Name = "colporcentaje_iva";
            this.colporcentaje_iva.Visible = true;
            this.colporcentaje_iva.VisibleIndex = 1;
            this.colporcentaje_iva.Width = 235;
            // 
            // colIdCodigo_SRI_iva
            // 
            this.colIdCodigo_SRI_iva.Caption = "IdCodigo_SRI";
            this.colIdCodigo_SRI_iva.FieldName = "IdCodigo_SRI";
            this.colIdCodigo_SRI_iva.Name = "colIdCodigo_SRI_iva";
            this.colIdCodigo_SRI_iva.Visible = true;
            this.colIdCodigo_SRI_iva.VisibleIndex = 3;
            this.colIdCodigo_SRI_iva.Width = 239;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(237, 28);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(21, 13);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "ICE:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(9, 28);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(21, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "IVA:";
            // 
            // cmbUnidadMedida
            // 
            this.cmbUnidadMedida.Location = new System.Drawing.Point(106, 65);
            this.cmbUnidadMedida.Name = "cmbUnidadMedida";
            this.cmbUnidadMedida.Size = new System.Drawing.Size(366, 29);
            this.cmbUnidadMedida.TabIndex = 63;
            this.cmbUnidadMedida.event_cmbUnidadMedida_EditValueChanged += new Core.Erp.Winform.Controles.UCIn_UnidadMedidaCmb.delegate_cmbUnidadMedida_EditValueChanged(this.cmbUnidadMedida_event_cmbUnidadMedida_EditValueChanged);
            // 
            // cmbMarca
            // 
            this.cmbMarca.Location = new System.Drawing.Point(106, 32);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(419, 26);
            this.cmbMarca.TabIndex = 62;
            // 
            // btn_imgGrande
            // 
            this.btn_imgGrande.Location = new System.Drawing.Point(843, 349);
            this.btn_imgGrande.Name = "btn_imgGrande";
            this.btn_imgGrande.Size = new System.Drawing.Size(35, 22);
            this.btn_imgGrande.TabIndex = 61;
            this.btn_imgGrande.Text = "......";
            this.btn_imgGrande.Click += new System.EventHandler(this.btn_imgGrande_Click_1);
            // 
            // chkManejaKardex
            // 
            this.chkManejaKardex.Location = new System.Drawing.Point(352, 415);
            this.chkManejaKardex.Name = "chkManejaKardex";
            this.chkManejaKardex.Properties.Caption = "Maneja Kardex";
            this.chkManejaKardex.Size = new System.Drawing.Size(103, 19);
            this.chkManejaKardex.TabIndex = 60;
            // 
            // txeStockminimo
            // 
            this.txeStockminimo.Location = new System.Drawing.Point(333, 157);
            this.txeStockminimo.Name = "txeStockminimo";
            this.txeStockminimo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txeStockminimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txeStockminimo.Size = new System.Drawing.Size(116, 20);
            this.txeStockminimo.TabIndex = 56;
            // 
            // txeStockMaximo
            // 
            this.txeStockMaximo.Location = new System.Drawing.Point(109, 157);
            this.txeStockMaximo.Name = "txeStockMaximo";
            this.txeStockMaximo.Properties.Mask.EditMask = "\\d{0,9}";
            this.txeStockMaximo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.txeStockMaximo.Size = new System.Drawing.Size(115, 20);
            this.txeStockMaximo.TabIndex = 55;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txePesoEspecifico);
            this.groupBox3.Controls.Add(this.txeAnchoEspecifico);
            this.groupBox3.Controls.Add(this.txeAlto);
            this.groupBox3.Controls.Add(this.txeProfundidad);
            this.groupBox3.Controls.Add(this.txeLargo);
            this.groupBox3.Controls.Add(this.txePeso);
            this.groupBox3.Controls.Add(this.label38);
            this.groupBox3.Controls.Add(this.label37);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(257, 252);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(198, 157);
            this.groupBox3.TabIndex = 52;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dimensiones/Peso";
            // 
            // txePesoEspecifico
            // 
            this.txePesoEspecifico.Location = new System.Drawing.Point(90, 134);
            this.txePesoEspecifico.Name = "txePesoEspecifico";
            this.txePesoEspecifico.Properties.Mask.EditMask = "#,##0.00;#,##0.00";
            this.txePesoEspecifico.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txePesoEspecifico.Size = new System.Drawing.Size(104, 20);
            this.txePesoEspecifico.TabIndex = 62;
            // 
            // txeAnchoEspecifico
            // 
            this.txeAnchoEspecifico.Location = new System.Drawing.Point(90, 112);
            this.txeAnchoEspecifico.Name = "txeAnchoEspecifico";
            this.txeAnchoEspecifico.Properties.Mask.EditMask = "#,##0.00;#,##0.00";
            this.txeAnchoEspecifico.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeAnchoEspecifico.Size = new System.Drawing.Size(104, 20);
            this.txeAnchoEspecifico.TabIndex = 61;
            // 
            // txeAlto
            // 
            this.txeAlto.Location = new System.Drawing.Point(90, 89);
            this.txeAlto.Name = "txeAlto";
            this.txeAlto.Properties.Mask.EditMask = "#,##0.00;#,##0.00";
            this.txeAlto.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeAlto.Size = new System.Drawing.Size(104, 20);
            this.txeAlto.TabIndex = 60;
            // 
            // txeProfundidad
            // 
            this.txeProfundidad.Location = new System.Drawing.Point(90, 68);
            this.txeProfundidad.Name = "txeProfundidad";
            this.txeProfundidad.Properties.Mask.EditMask = "#,##0.00;#,##0.00";
            this.txeProfundidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeProfundidad.Size = new System.Drawing.Size(104, 20);
            this.txeProfundidad.TabIndex = 59;
            // 
            // txeLargo
            // 
            this.txeLargo.Location = new System.Drawing.Point(90, 42);
            this.txeLargo.Name = "txeLargo";
            this.txeLargo.Properties.Mask.EditMask = "#,##0.00;#,##0.00";
            this.txeLargo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeLargo.Size = new System.Drawing.Size(104, 20);
            this.txeLargo.TabIndex = 58;
            // 
            // txePeso
            // 
            this.txePeso.Location = new System.Drawing.Point(90, 16);
            this.txePeso.Name = "txePeso";
            this.txePeso.Properties.Mask.EditMask = "#,##0.0000;#,##0.0000";
            this.txePeso.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txePeso.Size = new System.Drawing.Size(104, 20);
            this.txePeso.TabIndex = 57;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(-3, 115);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(92, 13);
            this.label38.TabIndex = 34;
            this.label38.Text = "Ancho Específico";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(0, 137);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(88, 13);
            this.label37.TabIndex = 33;
            this.label37.Text = "Peso Específico:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(0, 72);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(67, 13);
            this.label26.TabIndex = 34;
            this.label26.Text = "Profundidad:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(0, 92);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(28, 13);
            this.label25.TabIndex = 33;
            this.label25.Text = "Alto:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(0, 46);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(37, 13);
            this.label24.TabIndex = 32;
            this.label24.Text = "Largo:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(0, 23);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(34, 13);
            this.label23.TabIndex = 31;
            this.label23.Text = "Peso:";
            // 
            // grImgGrande
            // 
            this.grImgGrande.Controls.Add(this.pibx_imagenPequeña);
            this.grImgGrande.Location = new System.Drawing.Point(496, 186);
            this.grImgGrande.Name = "grImgGrande";
            this.grImgGrande.Size = new System.Drawing.Size(341, 185);
            this.grImgGrande.TabIndex = 50;
            this.grImgGrande.TabStop = false;
            this.grImgGrande.Text = "Imagen ";
            // 
            // pibx_imagenPequeña
            // 
            this.pibx_imagenPequeña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pibx_imagenPequeña.Location = new System.Drawing.Point(3, 16);
            this.pibx_imagenPequeña.Name = "pibx_imagenPequeña";
            this.pibx_imagenPequeña.Size = new System.Drawing.Size(335, 166);
            this.pibx_imagenPequeña.TabIndex = 0;
            this.pibx_imagenPequeña.TabStop = false;
            // 
            // codigoBarraProducto
            // 
            this.codigoBarraProducto.Location = new System.Drawing.Point(455, 3);
            this.codigoBarraProducto.Name = "codigoBarraProducto";
            this.codigoBarraProducto.Padding = new System.Windows.Forms.Padding(10, 2, 10, 0);
            this.codigoBarraProducto.Size = new System.Drawing.Size(340, 23);
            this.codigoBarraProducto.Symbology = code128Generator1;
            this.codigoBarraProducto.TabIndex = 38;
            // 
            // txtCodigoBarra
            // 
            this.txtCodigoBarra.Location = new System.Drawing.Point(110, 6);
            this.txtCodigoBarra.Name = "txtCodigoBarra";
            this.txtCodigoBarra.Size = new System.Drawing.Size(341, 20);
            this.txtCodigoBarra.TabIndex = 27;
            this.txtCodigoBarra.TextChanged += new System.EventHandler(this.txtCodigoBarra_TextChanged);
            this.txtCodigoBarra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarra_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Código Barra:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(458, 390);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(396, 71);
            this.txtObservacion.TabIndex = 38;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(455, 374);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(33, 13);
            this.label33.TabIndex = 37;
            this.label33.Text = "Nota:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txePrecioMinimo);
            this.groupBox1.Controls.Add(this.txePrecioMayor);
            this.groupBox1.Controls.Add(this.txePrecioPublico);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(4, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 158);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precios:";
            // 
            // txePrecioMinimo
            // 
            this.txePrecioMinimo.Location = new System.Drawing.Point(114, 97);
            this.txePrecioMinimo.Name = "txePrecioMinimo";
            this.txePrecioMinimo.Properties.Mask.EditMask = "$ #,#######0.0000;$ #,#######0.0000";
            this.txePrecioMinimo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txePrecioMinimo.Size = new System.Drawing.Size(127, 20);
            this.txePrecioMinimo.TabIndex = 59;
            // 
            // txePrecioMayor
            // 
            this.txePrecioMayor.Location = new System.Drawing.Point(114, 56);
            this.txePrecioMayor.Name = "txePrecioMayor";
            this.txePrecioMayor.Properties.Mask.EditMask = "$ #,#######0.0000;$ #,#######0.0000";
            this.txePrecioMayor.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txePrecioMayor.Size = new System.Drawing.Size(127, 20);
            this.txePrecioMayor.TabIndex = 58;
            // 
            // txePrecioPublico
            // 
            this.txePrecioPublico.Location = new System.Drawing.Point(114, 13);
            this.txePrecioPublico.Name = "txePrecioPublico";
            this.txePrecioPublico.Properties.Mask.EditMask = "$ #,#######0.0000;$ #,#######0.0000";
            this.txePrecioPublico.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txePrecioPublico.Size = new System.Drawing.Size(127, 20);
            this.txePrecioPublico.TabIndex = 57;
            this.txePrecioPublico.EditValueChanged += new System.EventHandler(this.txePrecioPublico_EditValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Precio Mínimo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Precio al por Mayor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Precio al Público:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(234, 164);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(73, 13);
            this.label31.TabIndex = 32;
            this.label31.Text = "Stock Mínimo";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(9, 164);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(77, 13);
            this.label30.TabIndex = 30;
            this.label30.Text = "Stock Máximo:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(12, 38);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 13);
            this.label19.TabIndex = 28;
            this.label19.Text = "Marca:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(12, 102);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(103, 13);
            this.label39.TabIndex = 26;
            this.label39.Text = "Unidad de Consumo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Unidad de Medida";
            // 
            // tab_Costos
            // 
            this.tab_Costos.Controls.Add(this.txeCostoPromedio);
            this.tab_Costos.Controls.Add(this.txeCostoFOB);
            this.tab_Costos.Controls.Add(this.txeCostoCIF);
            this.tab_Costos.Controls.Add(this.label11);
            this.tab_Costos.Controls.Add(this.label12);
            this.tab_Costos.Controls.Add(this.label13);
            this.tab_Costos.Location = new System.Drawing.Point(4, 22);
            this.tab_Costos.Name = "tab_Costos";
            this.tab_Costos.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Costos.Size = new System.Drawing.Size(891, 470);
            this.tab_Costos.TabIndex = 1;
            this.tab_Costos.Text = "Costos";
            this.tab_Costos.UseVisualStyleBackColor = true;
            // 
            // txeCostoPromedio
            // 
            this.txeCostoPromedio.Location = new System.Drawing.Point(155, 68);
            this.txeCostoPromedio.Name = "txeCostoPromedio";
            this.txeCostoPromedio.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeCostoPromedio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeCostoPromedio.Size = new System.Drawing.Size(127, 20);
            this.txeCostoPromedio.TabIndex = 60;
            // 
            // txeCostoFOB
            // 
            this.txeCostoFOB.Location = new System.Drawing.Point(155, 41);
            this.txeCostoFOB.Name = "txeCostoFOB";
            this.txeCostoFOB.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeCostoFOB.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeCostoFOB.Size = new System.Drawing.Size(127, 20);
            this.txeCostoFOB.TabIndex = 59;
            // 
            // txeCostoCIF
            // 
            this.txeCostoCIF.Location = new System.Drawing.Point(155, 15);
            this.txeCostoCIF.Name = "txeCostoCIF";
            this.txeCostoCIF.Properties.Mask.EditMask = "$ #,#######0.00;$ #,#######0.00";
            this.txeCostoCIF.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txeCostoCIF.Size = new System.Drawing.Size(127, 20);
            this.txeCostoCIF.TabIndex = 58;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "Costo Promedio Actual:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(19, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 10;
            this.label12.Text = "Costo FOB.:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 18);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(59, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Costo CIF.:";
            // 
            // tab_DatosImportacion
            // 
            this.tab_DatosImportacion.Controls.Add(this.txtDiasTerrestre);
            this.tab_DatosImportacion.Controls.Add(this.txtDiasAereo);
            this.tab_DatosImportacion.Controls.Add(this.txtDiasMaritimo);
            this.tab_DatosImportacion.Controls.Add(this.txtPorPartidaArancelaria);
            this.tab_DatosImportacion.Controls.Add(this.txtPartidaArancelaria);
            this.tab_DatosImportacion.Controls.Add(this.label29);
            this.tab_DatosImportacion.Controls.Add(this.label28);
            this.tab_DatosImportacion.Controls.Add(this.label22);
            this.tab_DatosImportacion.Controls.Add(this.label21);
            this.tab_DatosImportacion.Controls.Add(this.label20);
            this.tab_DatosImportacion.Location = new System.Drawing.Point(4, 22);
            this.tab_DatosImportacion.Name = "tab_DatosImportacion";
            this.tab_DatosImportacion.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DatosImportacion.Size = new System.Drawing.Size(891, 470);
            this.tab_DatosImportacion.TabIndex = 3;
            this.tab_DatosImportacion.Text = "Datos de Importacion";
            this.tab_DatosImportacion.UseVisualStyleBackColor = true;
            // 
            // txtDiasTerrestre
            // 
            this.txtDiasTerrestre.Location = new System.Drawing.Point(253, 78);
            this.txtDiasTerrestre.Name = "txtDiasTerrestre";
            this.txtDiasTerrestre.Size = new System.Drawing.Size(110, 20);
            this.txtDiasTerrestre.TabIndex = 39;
            // 
            // txtDiasAereo
            // 
            this.txtDiasAereo.Location = new System.Drawing.Point(253, 50);
            this.txtDiasAereo.Name = "txtDiasAereo";
            this.txtDiasAereo.Size = new System.Drawing.Size(110, 20);
            this.txtDiasAereo.TabIndex = 38;
            // 
            // txtDiasMaritimo
            // 
            this.txtDiasMaritimo.Location = new System.Drawing.Point(253, 22);
            this.txtDiasMaritimo.Name = "txtDiasMaritimo";
            this.txtDiasMaritimo.Size = new System.Drawing.Size(110, 20);
            this.txtDiasMaritimo.TabIndex = 37;
            // 
            // txtPorPartidaArancelaria
            // 
            this.txtPorPartidaArancelaria.Location = new System.Drawing.Point(250, 142);
            this.txtPorPartidaArancelaria.Name = "txtPorPartidaArancelaria";
            this.txtPorPartidaArancelaria.Size = new System.Drawing.Size(270, 20);
            this.txtPorPartidaArancelaria.TabIndex = 36;
            // 
            // txtPartidaArancelaria
            // 
            this.txtPartidaArancelaria.Location = new System.Drawing.Point(250, 110);
            this.txtPartidaArancelaria.Name = "txtPartidaArancelaria";
            this.txtPartidaArancelaria.Size = new System.Drawing.Size(270, 20);
            this.txtPartidaArancelaria.TabIndex = 35;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(19, 142);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 13);
            this.label29.TabIndex = 23;
            this.label29.Text = "% Partida Arancelaria";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(18, 111);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 13);
            this.label28.TabIndex = 22;
            this.label28.Text = "Partida Arancelaria";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(19, 78);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(177, 13);
            this.label22.TabIndex = 21;
            this.label22.Text = "Días Aproximado de Viaje Terrestre:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(19, 50);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(163, 13);
            this.label21.TabIndex = 20;
            this.label21.Text = "Días Aproximado de Viaje Aereo:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(19, 22);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(179, 13);
            this.label20.TabIndex = 19;
            this.label20.Text = "Días Aproximado de Viaje Maritimos:";
            // 
            // tab_proveedores
            // 
            this.tab_proveedores.Controls.Add(this.gridControlProveedor);
            this.tab_proveedores.Location = new System.Drawing.Point(4, 22);
            this.tab_proveedores.Name = "tab_proveedores";
            this.tab_proveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tab_proveedores.Size = new System.Drawing.Size(891, 470);
            this.tab_proveedores.TabIndex = 8;
            this.tab_proveedores.Text = "Proveedores";
            this.tab_proveedores.UseVisualStyleBackColor = true;
            // 
            // gridControlProveedor
            // 
            this.gridControlProveedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProveedor.Location = new System.Drawing.Point(3, 3);
            this.gridControlProveedor.MainView = this.gridViewProveedor;
            this.gridControlProveedor.Name = "gridControlProveedor";
            this.gridControlProveedor.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProveedor_grid});
            this.gridControlProveedor.Size = new System.Drawing.Size(885, 464);
            this.gridControlProveedor.TabIndex = 6;
            this.gridControlProveedor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProveedor});
            // 
            // gridViewProveedor
            // 
            this.gridViewProveedor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedor,
            this.colNomProducto_en_Proveedor,
            this.gridColumn13});
            this.gridViewProveedor.GridControl = this.gridControlProveedor;
            this.gridViewProveedor.Name = "gridViewProveedor";
            this.gridViewProveedor.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewProveedor.OptionsView.ShowGroupPanel = false;
            this.gridViewProveedor.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewProveedor_RowCellStyle);
            // 
            // colIdProveedor
            // 
            this.colIdProveedor.Caption = "Proveedor";
            this.colIdProveedor.ColumnEdit = this.cmbProveedor_grid;
            this.colIdProveedor.FieldName = "IdProveedor";
            this.colIdProveedor.Name = "colIdProveedor";
            this.colIdProveedor.Visible = true;
            this.colIdProveedor.VisibleIndex = 0;
            this.colIdProveedor.Width = 414;
            // 
            // cmbProveedor_grid
            // 
            this.cmbProveedor_grid.AutoHeight = false;
            this.cmbProveedor_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProveedor_grid.Name = "cmbProveedor_grid";
            this.cmbProveedor_grid.View = this.gridView1;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProveedor_grid,
            this.colpr_nombre,
            this.colPrEstado});
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.Red;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.colPrEstado;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "I";
            this.gridView1.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridView1_RowCellStyle);
            // 
            // colIdProveedor_grid
            // 
            this.colIdProveedor_grid.Caption = "IdProveedor";
            this.colIdProveedor_grid.FieldName = "IdProveedor";
            this.colIdProveedor_grid.Name = "colIdProveedor_grid";
            this.colIdProveedor_grid.Visible = true;
            this.colIdProveedor_grid.VisibleIndex = 1;
            this.colIdProveedor_grid.Width = 223;
            // 
            // colpr_nombre
            // 
            this.colpr_nombre.Caption = "Proveedor";
            this.colpr_nombre.FieldName = "pr_nombre";
            this.colpr_nombre.Name = "colpr_nombre";
            this.colpr_nombre.Visible = true;
            this.colpr_nombre.VisibleIndex = 0;
            this.colpr_nombre.Width = 957;
            // 
            // colNomProducto_en_Proveedor
            // 
            this.colNomProducto_en_Proveedor.Caption = "Descripción según Proveedor";
            this.colNomProducto_en_Proveedor.FieldName = "NomProducto_en_Proveedor";
            this.colNomProducto_en_Proveedor.Name = "colNomProducto_en_Proveedor";
            this.colNomProducto_en_Proveedor.Visible = true;
            this.colNomProducto_en_Proveedor.VisibleIndex = 1;
            this.colNomProducto_en_Proveedor.Width = 766;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "pr_estado";
            this.gridColumn13.FieldName = "pr_estado";
            this.gridColumn13.Name = "gridColumn13";
            // 
            // tab_productosxPuntoVta
            // 
            this.tab_productosxPuntoVta.Controls.Add(this.groupBox2);
            this.tab_productosxPuntoVta.Location = new System.Drawing.Point(4, 22);
            this.tab_productosxPuntoVta.Name = "tab_productosxPuntoVta";
            this.tab_productosxPuntoVta.Padding = new System.Windows.Forms.Padding(3);
            this.tab_productosxPuntoVta.Size = new System.Drawing.Size(891, 470);
            this.tab_productosxPuntoVta.TabIndex = 9;
            this.tab_productosxPuntoVta.Text = "Sucursal Bodega y Ctas. Contables";
            this.tab_productosxPuntoVta.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.treeList_Bodega_x_Sucursal);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(885, 464);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            // 
            // treeList_Bodega_x_Sucursal
            // 
            this.treeList_Bodega_x_Sucursal.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3,
            this.treeListColumn4,
            this.treeListColumn5,
            this.treeListColumn6,
            this.treeListColumn7});
            this.treeList_Bodega_x_Sucursal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeList_Bodega_x_Sucursal.Location = new System.Drawing.Point(3, 16);
            this.treeList_Bodega_x_Sucursal.Name = "treeList_Bodega_x_Sucursal";
            this.treeList_Bodega_x_Sucursal.OptionsBehavior.PopulateServiceColumns = true;
            this.treeList_Bodega_x_Sucursal.OptionsPrint.UsePrintStyles = true;
            this.treeList_Bodega_x_Sucursal.OptionsView.ShowIndicator = false;
            this.treeList_Bodega_x_Sucursal.ParentFieldName = "IdPadre";
            this.treeList_Bodega_x_Sucursal.Size = new System.Drawing.Size(879, 445);
            this.treeList_Bodega_x_Sucursal.TabIndex = 1;
            this.treeList_Bodega_x_Sucursal.BeforeFocusNode += new DevExpress.XtraTreeList.BeforeFocusNodeEventHandler(this.treeList_Bodega_x_Sucursal_BeforeFocusNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "IdEmpresa";
            this.treeListColumn1.FieldName = "IdEmpresa";
            this.treeListColumn1.Name = "treeListColumn1";
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "Descripcion";
            this.treeListColumn2.FieldName = "Nombre";
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.OptionsColumn.AllowEdit = false;
            this.treeListColumn2.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 1;
            this.treeListColumn2.Width = 1122;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "Estado";
            this.treeListColumn3.FieldName = "Estado";
            this.treeListColumn3.Name = "treeListColumn3";
            // 
            // treeListColumn4
            // 
            this.treeListColumn4.Caption = "Nivel";
            this.treeListColumn4.FieldName = "Nivel";
            this.treeListColumn4.Name = "treeListColumn4";
            // 
            // treeListColumn5
            // 
            this.treeListColumn5.Caption = "IdSucursal";
            this.treeListColumn5.FieldName = "IdSucursal";
            this.treeListColumn5.Name = "treeListColumn5";
            // 
            // treeListColumn6
            // 
            this.treeListColumn6.Caption = "IdBodega";
            this.treeListColumn6.FieldName = "IdBodega";
            this.treeListColumn6.Name = "treeListColumn6";
            // 
            // treeListColumn7
            // 
            this.treeListColumn7.Caption = "*";
            this.treeListColumn7.FieldName = "Checked";
            this.treeListColumn7.Name = "treeListColumn7";
            this.treeListColumn7.Visible = true;
            this.treeListColumn7.VisibleIndex = 0;
            this.treeListColumn7.Width = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridControlComposicion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(891, 470);
            this.tabPage1.TabIndex = 10;
            this.tabPage1.Text = "Composición";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridControlComposicion
            // 
            this.gridControlComposicion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlComposicion.Location = new System.Drawing.Point(3, 3);
            this.gridControlComposicion.MainView = this.gridViewComposicion;
            this.gridControlComposicion.Name = "gridControlComposicion";
            this.gridControlComposicion.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cmbProductoHijo_grid});
            this.gridControlComposicion.Size = new System.Drawing.Size(885, 464);
            this.gridControlComposicion.TabIndex = 9;
            this.gridControlComposicion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewComposicion});
            // 
            // gridViewComposicion
            // 
            this.gridViewComposicion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProductoHijo,
            this.colCantidad});
            this.gridViewComposicion.GridControl = this.gridControlComposicion;
            this.gridViewComposicion.Name = "gridViewComposicion";
            this.gridViewComposicion.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridViewComposicion.OptionsView.ShowGroupPanel = false;
            // 
            // colIdProductoHijo
            // 
            this.colIdProductoHijo.Caption = "Descripción";
            this.colIdProductoHijo.ColumnEdit = this.cmbProductoHijo_grid;
            this.colIdProductoHijo.FieldName = "IdProductoHijo";
            this.colIdProductoHijo.Name = "colIdProductoHijo";
            this.colIdProductoHijo.Visible = true;
            this.colIdProductoHijo.VisibleIndex = 0;
            this.colIdProductoHijo.Width = 878;
            // 
            // cmbProductoHijo_grid
            // 
            this.cmbProductoHijo_grid.AutoHeight = false;
            this.cmbProductoHijo_grid.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbProductoHijo_grid.Name = "cmbProductoHijo_grid";
            this.cmbProductoHijo_grid.View = this.gridView5;
            // 
            // gridView5
            // 
            this.gridView5.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colpr_descripcion,
            this.colIdProducto});
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            // 
            // colpr_descripcion
            // 
            this.colpr_descripcion.Caption = "Descripción";
            this.colpr_descripcion.FieldName = "pr_descripcion";
            this.colpr_descripcion.Name = "colpr_descripcion";
            this.colpr_descripcion.Visible = true;
            this.colpr_descripcion.VisibleIndex = 0;
            this.colpr_descripcion.Width = 892;
            // 
            // colIdProducto
            // 
            this.colIdProducto.Caption = "IdProducto";
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 1;
            this.colIdProducto.Width = 288;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 1;
            this.colCantidad.Width = 302;
            // 
            // tab_DatosContables
            // 
            this.tab_DatosContables.Location = new System.Drawing.Point(4, 22);
            this.tab_DatosContables.Name = "tab_DatosContables";
            this.tab_DatosContables.Padding = new System.Windows.Forms.Padding(3);
            this.tab_DatosContables.Size = new System.Drawing.Size(891, 470);
            this.tab_DatosContables.TabIndex = 11;
            this.tab_DatosContables.Text = "Datos Contables";
            this.tab_DatosContables.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.groupBox5);
            this.panel4.Controls.Add(this.cmb_tipoProducto);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.txtDescripcion2);
            this.panel4.Controls.Add(this.lblAnulado);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtNombre);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.lblIdProducto);
            this.panel4.Controls.Add(this.txtCodigo);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(899, 97);
            this.panel4.TabIndex = 46;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkModulo_AF);
            this.groupBox5.Controls.Add(this.chkModulo_Inven);
            this.groupBox5.Controls.Add(this.chkModulo_Compras);
            this.groupBox5.Controls.Add(this.chkModulo_Venta);
            this.groupBox5.Location = new System.Drawing.Point(710, 13);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(185, 78);
            this.groupBox5.TabIndex = 73;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Modulos donde se muestra";
            // 
            // chkModulo_AF
            // 
            this.chkModulo_AF.AutoSize = true;
            this.chkModulo_AF.Location = new System.Drawing.Point(100, 47);
            this.chkModulo_AF.Name = "chkModulo_AF";
            this.chkModulo_AF.Size = new System.Drawing.Size(75, 17);
            this.chkModulo_AF.TabIndex = 3;
            this.chkModulo_AF.Text = "Activo Fijo";
            this.chkModulo_AF.UseVisualStyleBackColor = true;
            // 
            // chkModulo_Inven
            // 
            this.chkModulo_Inven.AutoSize = true;
            this.chkModulo_Inven.Location = new System.Drawing.Point(11, 49);
            this.chkModulo_Inven.Name = "chkModulo_Inven";
            this.chkModulo_Inven.Size = new System.Drawing.Size(73, 17);
            this.chkModulo_Inven.TabIndex = 2;
            this.chkModulo_Inven.Text = "Inventario";
            this.chkModulo_Inven.UseVisualStyleBackColor = true;
            // 
            // chkModulo_Compras
            // 
            this.chkModulo_Compras.AutoSize = true;
            this.chkModulo_Compras.Location = new System.Drawing.Point(100, 24);
            this.chkModulo_Compras.Name = "chkModulo_Compras";
            this.chkModulo_Compras.Size = new System.Drawing.Size(67, 17);
            this.chkModulo_Compras.TabIndex = 1;
            this.chkModulo_Compras.Text = "Compras";
            this.chkModulo_Compras.UseVisualStyleBackColor = true;
            // 
            // chkModulo_Venta
            // 
            this.chkModulo_Venta.AutoSize = true;
            this.chkModulo_Venta.Location = new System.Drawing.Point(12, 23);
            this.chkModulo_Venta.Name = "chkModulo_Venta";
            this.chkModulo_Venta.Size = new System.Drawing.Size(59, 17);
            this.chkModulo_Venta.TabIndex = 0;
            this.chkModulo_Venta.Text = "Ventas";
            this.chkModulo_Venta.UseVisualStyleBackColor = true;
            // 
            // cmb_tipoProducto
            // 
            this.cmb_tipoProducto.Location = new System.Drawing.Point(542, 3);
            this.cmb_tipoProducto.Name = "cmb_tipoProducto";
            this.cmb_tipoProducto.Size = new System.Drawing.Size(162, 26);
            this.cmb_tipoProducto.TabIndex = 56;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Nombre 2:";
            // 
            // txtDescripcion2
            // 
            this.txtDescripcion2.Location = new System.Drawing.Point(65, 64);
            this.txtDescripcion2.Multiline = true;
            this.txtDescripcion2.Name = "txtDescripcion2";
            this.txtDescripcion2.Size = new System.Drawing.Size(639, 29);
            this.txtDescripcion2.TabIndex = 29;
            // 
            // lblAnulado
            // 
            this.lblAnulado.AutoSize = true;
            this.lblAnulado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnulado.ForeColor = System.Drawing.Color.Red;
            this.lblAnulado.Location = new System.Drawing.Point(317, 9);
            this.lblAnulado.Name = "lblAnulado";
            this.lblAnulado.Size = new System.Drawing.Size(146, 20);
            this.lblAnulado.TabIndex = 53;
            this.lblAnulado.Text = "*** ANULADO ***";
            this.lblAnulado.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Código:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 33);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(639, 28);
            this.txtNombre.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(459, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Tipo Producto:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Nombre:";
            // 
            // lblIdProducto
            // 
            this.lblIdProducto.BackColor = System.Drawing.SystemColors.Control;
            this.lblIdProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIdProducto.Enabled = false;
            this.lblIdProducto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblIdProducto.Location = new System.Drawing.Point(251, 8);
            this.lblIdProducto.Name = "lblIdProducto";
            this.lblIdProducto.Size = new System.Drawing.Size(60, 20);
            this.lblIdProducto.TabIndex = 23;
            this.lblIdProducto.Text = "0";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(65, 6);
            this.txtCodigo.MaxLength = 30;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(176, 20);
            this.txtCodigo.TabIndex = 25;
            // 
            // inproductoxtbbodegaInfoBindingSource
            // 
            this.inproductoxtbbodegaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Inventario.in_producto_x_tb_bodega_Info);
            // 
            // ctPlanctaInfoBindingSource
            // 
            this.ctPlanctaInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // ctCentrocostoInfoBindingSource
            // 
            this.ctCentrocostoInfoBindingSource.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Centro_costo_Info);
            // 
            // ctCentrocostoInfoBindingSource1
            // 
            this.ctCentrocostoInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Centro_costo_Info);
            // 
            // ctPlanctaInfoBindingSource1
            // 
            this.ctPlanctaInfoBindingSource1.DataSource = typeof(Core.Erp.Info.Contabilidad.ct_Plancta_Info);
            // 
            // tbCatalogoInfoBindingSource
            // 
            this.tbCatalogoInfoBindingSource.DataSource = typeof(Core.Erp.Info.General.tb_Catalogo_Info);
            // 
            // ucGe_Menu
            // 
            this.ucGe_Menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu.Enabled_bnRetImprimir = true;
            this.ucGe_Menu.Enabled_bntAnular = true;
            this.ucGe_Menu.Enabled_bntAprobar = true;
            this.ucGe_Menu.Enabled_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Enabled_bntImprimir = true;
            this.ucGe_Menu.Enabled_bntImprimir_Guia = true;
            this.ucGe_Menu.Enabled_bntLimpiar = true;
            this.ucGe_Menu.Enabled_bntSalir = true;
            this.ucGe_Menu.Enabled_btn_conciliacion_Auto = true;
            this.ucGe_Menu.Enabled_btn_DiseñoReporte = true;
            this.ucGe_Menu.Enabled_btn_Generar_XML = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cbte = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Cheq = true;
            this.ucGe_Menu.Enabled_btn_Imprimir_Reten = true;
            this.ucGe_Menu.Enabled_btnAceptar = true;
            this.ucGe_Menu.Enabled_btnAprobarGuardarSalir = true;
            this.ucGe_Menu.Enabled_btnEstadosOC = true;
            this.ucGe_Menu.Enabled_btnGuardar = true;
            this.ucGe_Menu.Enabled_btnImpFrm = true;
            this.ucGe_Menu.Enabled_btnImpLote = true;
            this.ucGe_Menu.Enabled_btnImpRep = true;
            this.ucGe_Menu.Enabled_btnImprimirSoporte = true;
            this.ucGe_Menu.Enabled_btnproductos = true;
            this.ucGe_Menu.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu.Name = "ucGe_Menu";
            this.ucGe_Menu.Size = new System.Drawing.Size(903, 29);
            this.ucGe_Menu.TabIndex = 6;
            this.ucGe_Menu.Visible_bntAnular = true;
            this.ucGe_Menu.Visible_bntAprobar = false;
            this.ucGe_Menu.Visible_bntDiseñoReporte = false;
            this.ucGe_Menu.Visible_bntGuardar_y_Salir = true;
            this.ucGe_Menu.Visible_bntImprimir = false;
            this.ucGe_Menu.Visible_bntImprimir_Guia = false;
            this.ucGe_Menu.Visible_bntLimpiar = true;
            this.ucGe_Menu.Visible_bntReImprimir = false;
            this.ucGe_Menu.Visible_bntSalir = true;
            this.ucGe_Menu.Visible_btn_Actualizar = false;
            this.ucGe_Menu.Visible_btn_conciliacion_Auto = false;
            this.ucGe_Menu.Visible_btn_Generar_XML = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cbte = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Cheq = false;
            this.ucGe_Menu.Visible_btn_Imprimir_Reten = false;
            this.ucGe_Menu.Visible_btnAceptar = false;
            this.ucGe_Menu.Visible_btnAprobarGuardarSalir = false;
            this.ucGe_Menu.Visible_btnContabilizar = false;
            this.ucGe_Menu.Visible_btnEstadosOC = false;
            this.ucGe_Menu.Visible_btnGuardar = true;
            this.ucGe_Menu.Visible_btnImpFrm = false;
            this.ucGe_Menu.Visible_btnImpLote = false;
            this.ucGe_Menu.Visible_btnImpRep = false;
            this.ucGe_Menu.Visible_btnImprimirSoporte = false;
            this.ucGe_Menu.Visible_btnModificar = false;
            this.ucGe_Menu.Visible_btnproductos = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panel1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(903, 597);
            this.panelControl1.TabIndex = 7;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 29);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(903, 597);
            this.xtraScrollableControl1.TabIndex = 8;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "pr_estado";
            this.gridColumn12.FieldName = "pr_estado";
            this.gridColumn12.Name = "gridColumn12";
            // 
            // FrmIn_Producto_Mant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 648);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Controls.Add(this.ucGe_Menu);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmIn_Producto_Mant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Productos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmIn_Producto_Mant_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIn_Producto_Mant_FormClosed);
            this.Load += new System.EventHandler(this.FrmIn_ProductoMantenimiento_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.tabControl_Producto.ResumeLayout(false);
            this.tab_descripcion.ResumeLayout(false);
            this.tab_descripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chkActivo.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodImpt_ICE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCodImp_IVA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkManejaKardex.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeStockminimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeStockMaximo.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txePesoEspecifico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAnchoEspecifico.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeAlto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeProfundidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeLargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePeso.Properties)).EndInit();
            this.grImgGrande.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pibx_imagenPequeña)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txePrecioMinimo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrecioMayor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txePrecioPublico.Properties)).EndInit();
            this.tab_Costos.ResumeLayout(false);
            this.tab_Costos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txeCostoPromedio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeCostoFOB.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txeCostoCIF.Properties)).EndInit();
            this.tab_DatosImportacion.ResumeLayout(false);
            this.tab_DatosImportacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasTerrestre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasAereo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiasMaritimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorPartidaArancelaria)).EndInit();
            this.tab_proveedores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProveedor_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.tab_productosxPuntoVta.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treeList_Bodega_x_Sucursal)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlComposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewComposicion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbProductoHijo_grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inproductoxtbbodegaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctCentrocostoInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctPlanctaInfoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCatalogoInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl_Producto;
        private System.Windows.Forms.TabPage tab_Costos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabPage tab_DatosImportacion;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigoBarra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblIdProducto;
        private System.Windows.Forms.TabPage tab_descripcion;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtObservacion;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtPartidaArancelaria;
        private System.Windows.Forms.NumericUpDown txtPorPartidaArancelaria;
        private System.Windows.Forms.NumericUpDown txtDiasTerrestre;
        private System.Windows.Forms.NumericUpDown txtDiasAereo;
        private System.Windows.Forms.NumericUpDown txtDiasMaritimo;
        private System.Windows.Forms.TabPage tab_proveedores;
        private DevExpress.XtraEditors.BarCodeControl codigoBarraProducto;
        private System.Windows.Forms.OpenFileDialog openFileDialogImagenGrande;
        private System.Windows.Forms.TabPage tab_productosxPuntoVta;
        private System.Windows.Forms.GroupBox grImgGrande;
        private System.Windows.Forms.PictureBox pibx_imagenPequeña;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtDescripcion2;
        private System.Windows.Forms.TabPage tab_DatosContables;
        private System.Windows.Forms.BindingSource inproductoxtbbodegaInfoBindingSource;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource;
        private System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource;
        private System.Windows.Forms.BindingSource ctCentrocostoInfoBindingSource1;
        private System.Windows.Forms.BindingSource ctPlanctaInfoBindingSource1;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.BindingSource tbCatalogoInfoBindingSource;
        private System.Windows.Forms.Label lblAnulado;
        private System.Windows.Forms.Label label1;
        private Controles.UCGe_Menu_Superior_Mant ucGe_Menu;
        private DevExpress.XtraGrid.GridControl gridControlProveedor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProveedor;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProveedor_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProveedor_grid;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_nombre;
        private DevExpress.XtraGrid.Columns.GridColumn colNomProducto_en_Proveedor;
        private DevExpress.XtraGrid.GridControl gridControlComposicion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewComposicion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProductoHijo;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cmbProductoHijo_grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraGrid.Columns.GridColumn colpr_descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraEditors.TextEdit txeStockMaximo;
        private DevExpress.XtraEditors.TextEdit txeStockminimo;
        private DevExpress.XtraEditors.TextEdit txePrecioPublico;
        private DevExpress.XtraEditors.TextEdit txePrecioMayor;
        private DevExpress.XtraEditors.TextEdit txePrecioMinimo;
        private DevExpress.XtraEditors.TextEdit txePeso;
        private DevExpress.XtraEditors.TextEdit txeLargo;
        private DevExpress.XtraEditors.TextEdit txeProfundidad;
        private DevExpress.XtraEditors.TextEdit txeAlto;
        private DevExpress.XtraEditors.TextEdit txeAnchoEspecifico;
        private DevExpress.XtraEditors.TextEdit txePesoEspecifico;
        private DevExpress.XtraEditors.TextEdit txeCostoCIF;
        private DevExpress.XtraEditors.TextEdit txeCostoFOB;
        private DevExpress.XtraEditors.TextEdit txeCostoPromedio;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private DevExpress.XtraEditors.SimpleButton btn_imgGrande;
        private DevExpress.XtraEditors.CheckEdit chkManejaKardex;
        private DevExpress.XtraEditors.CheckEdit chkActivo;
        private Controles.UCIn_MarcaCmb cmbMarca;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private Controles.UCIn_TipoProductoCmb cmb_tipoProducto;
        private Controles.UCIn_UnidadMedidaCmb cmbUnidadMedida;
        private System.Windows.Forms.GroupBox groupBox4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private Controles.ucIn_Linea_Grup_SubGr ucIn_Linea_Grup_SubGr;
        private DevExpress.XtraTreeList.TreeList treeList_Bodega_x_Sucursal;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn4;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn5;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn6;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn colPrEstado;
        private Controles.UCIn_UnidadMedidaCmb cmbUnidadMedida_Consumo;
        private Controles.UCFa_Motivo_venta ucFa_Motivo_venta;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label6;
        private Controles.UCIn_Presentacion ucIn_Presentacion;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCodImp_IVA;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraEditors.SearchLookUpEdit cmbCodImpt_ICE;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkModulo_Compras;
        private System.Windows.Forms.CheckBox chkModulo_Venta;
        private System.Windows.Forms.CheckBox chkModulo_AF;
        private System.Windows.Forms.CheckBox chkModulo_Inven;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto_Ice;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_impuesto_ice;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_ice;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI_ice;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCod_Impuesto_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colnom_impuesto_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colporcentaje_iva;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCodigo_SRI_iva;

    }
}