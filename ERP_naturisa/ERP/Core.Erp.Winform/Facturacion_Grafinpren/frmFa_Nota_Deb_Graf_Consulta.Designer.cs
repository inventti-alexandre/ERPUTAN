﻿namespace Core.Erp.Winform.Facturacion_Grafinpren
{
    partial class frmFa_Nota_Deb_Graf_Consulta
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
            this.ucGe_Menu_Mantenimiento_x_usuario = new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario();
            this.ucGe_BarraEstadoInferior_Forms1 = new Core.Erp.Winform.Controles.UCGe_BarraEstadoInferior_Forms();
            this.gridControlNota = new DevExpress.XtraGrid.GridControl();
            this.gridViewNota = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdNota = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSucursal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBodega = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colVendedor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Num_OP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Num_cotización = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Fecha_cotizacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colfecha = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNom_maquina = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEstado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CodGuiaRemision = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaIniTrasla = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaFinTrans = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_sc_observacion = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNota)).BeginInit();
            this.SuspendLayout();
            // 
            // ucGe_Menu_Mantenimiento_x_usuario
            // 
            this.ucGe_Menu_Mantenimiento_x_usuario.CargarTodasBodegas = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_anular = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CancelarCuotas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_CargaMarcaciónExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_consultar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_DiseñoChequeComprobante = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Duplicar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarPeriodos = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_GenerarXml = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Habilitar_Reg = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_Importar_XML = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_imprimir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_LoteCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_modificar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_nuevo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_NuevoCheque = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_periodo = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_boton_salir = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_btnImpExcel = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Enable_Descargar_Marca_Base_exter = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_desde = new System.DateTime(2016, 5, 7, 11, 27, 59, 491);
            this.ucGe_Menu_Mantenimiento_x_usuario.fecha_hasta = new System.DateTime(2016, 7, 7, 11, 27, 59, 492);
            this.ucGe_Menu_Mantenimiento_x_usuario.FormConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.FormMain = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.GridControlConsulta = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Location = new System.Drawing.Point(0, 0);
            this.ucGe_Menu_Mantenimiento_x_usuario.Name = "ucGe_Menu_Mantenimiento_x_usuario";
            this.ucGe_Menu_Mantenimiento_x_usuario.Perfil_x_usuario = null;
            this.ucGe_Menu_Mantenimiento_x_usuario.Size = new System.Drawing.Size(1009, 176);
            this.ucGe_Menu_Mantenimiento_x_usuario.TabIndex = 8;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_bodega = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_anular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CancelarCuotas = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_CargaMarcaciónExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_consular = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseñoChequeComprobante = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_DiseNoReport = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Duplicar = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarPeriodos = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_GenerarXml = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Habilitar_Reg = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_Importar_XML = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_imprimir = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_LoteCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_modificar = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_nuevo = DevExpress.XtraBars.BarItemVisibility.Always;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_boton_NuevoCheque = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_btnImpExcel = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Descargar_Marca_Base_exter = DevExpress.XtraBars.BarItemVisibility.Never;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_fechas = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Cancelaciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Diseño_Reporte = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_filtro = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Impresion = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Otras_Trans = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Grupo_Transacciones = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_Pie_fechas_Boton_buscar = true;
            this.ucGe_Menu_Mantenimiento_x_usuario.Visible_sucursal = false;
            this.ucGe_Menu_Mantenimiento_x_usuario.event_btnBuscar_Click += new Core.Erp.Winform.Controles.UCGe_Menu_Mantenimiento_x_usuario.delegate_btnBuscar_Click(this.ucGe_Menu_Mantenimiento_x_usuario_event_btnBuscar_Click);
            // 
            // ucGe_BarraEstadoInferior_Forms1
            // 
            this.ucGe_BarraEstadoInferior_Forms1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ucGe_BarraEstadoInferior_Forms1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucGe_BarraEstadoInferior_Forms1.Location = new System.Drawing.Point(0, 358);
            this.ucGe_BarraEstadoInferior_Forms1.Name = "ucGe_BarraEstadoInferior_Forms1";
            this.ucGe_BarraEstadoInferior_Forms1.Size = new System.Drawing.Size(1009, 32);
            this.ucGe_BarraEstadoInferior_Forms1.TabIndex = 33;
            // 
            // gridControlNota
            // 
            this.gridControlNota.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlNota.Location = new System.Drawing.Point(0, 176);
            this.gridControlNota.MainView = this.gridViewNota;
            this.gridControlNota.Name = "gridControlNota";
            this.gridControlNota.Size = new System.Drawing.Size(1009, 182);
            this.gridControlNota.TabIndex = 34;
            this.gridControlNota.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewNota});
            // 
            // gridViewNota
            // 
            this.gridViewNota.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdNota,
            this.colSucursal,
            this.colBodega,
            this.colCliente,
            this.colVendedor,
            this.Num_OP,
            this.Num_cotización,
            this.Fecha_cotizacion,
            this.colfecha,
            this.colNom_maquina,
            this.colEstado,
            this.CodGuiaRemision,
            this.colFechaIniTrasla,
            this.colFechaFinTrans,
            this.col_sc_observacion});
            this.gridViewNota.GridControl = this.gridControlNota;
            this.gridViewNota.Name = "gridViewNota";
            this.gridViewNota.OptionsBehavior.Editable = false;
            this.gridViewNota.OptionsView.ShowAutoFilterRow = true;
            this.gridViewNota.OptionsView.ShowGroupPanel = false;
            this.gridViewNota.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewNota_RowCellStyle);
            // 
            // colIdNota
            // 
            this.colIdNota.Caption = "Id Nota";
            this.colIdNota.FieldName = "IdNota";
            this.colIdNota.Name = "colIdNota";
            this.colIdNota.OptionsColumn.AllowEdit = false;
            this.colIdNota.Visible = true;
            this.colIdNota.VisibleIndex = 0;
            this.colIdNota.Width = 58;
            // 
            // colSucursal
            // 
            this.colSucursal.Caption = "Sucursal";
            this.colSucursal.FieldName = "IdSucursal";
            this.colSucursal.Name = "colSucursal";
            this.colSucursal.OptionsColumn.AllowEdit = false;
            this.colSucursal.Width = 50;
            // 
            // colBodega
            // 
            this.colBodega.Caption = "Bodega";
            this.colBodega.FieldName = "IdBodega";
            this.colBodega.Name = "colBodega";
            this.colBodega.OptionsColumn.AllowEdit = false;
            this.colBodega.Width = 54;
            // 
            // colCliente
            // 
            this.colCliente.Caption = "Cliente";
            this.colCliente.FieldName = "Cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.OptionsColumn.AllowEdit = false;
            this.colCliente.Visible = true;
            this.colCliente.VisibleIndex = 2;
            this.colCliente.Width = 221;
            // 
            // colVendedor
            // 
            this.colVendedor.Caption = "Vendedor";
            this.colVendedor.FieldName = "Vendedor";
            this.colVendedor.Name = "colVendedor";
            this.colVendedor.OptionsColumn.AllowEdit = false;
            this.colVendedor.Width = 127;
            // 
            // Num_OP
            // 
            this.Num_OP.Caption = "Numero OP";
            this.Num_OP.FieldName = "NotaCreDeb_Graf_Info.num_op";
            this.Num_OP.Name = "Num_OP";
            this.Num_OP.OptionsColumn.AllowEdit = false;
            this.Num_OP.Visible = true;
            this.Num_OP.VisibleIndex = 5;
            this.Num_OP.Width = 108;
            // 
            // Num_cotización
            // 
            this.Num_cotización.Caption = "Numero Cotización";
            this.Num_cotización.FieldName = "NotaCreDeb_Graf_Info.num_cotizacion";
            this.Num_cotización.Name = "Num_cotización";
            this.Num_cotización.OptionsColumn.AllowEdit = false;
            this.Num_cotización.Visible = true;
            this.Num_cotización.VisibleIndex = 4;
            this.Num_cotización.Width = 118;
            // 
            // Fecha_cotizacion
            // 
            this.Fecha_cotizacion.Caption = "Fecha Cotización";
            this.Fecha_cotizacion.FieldName = "NotaCreDeb_Graf_Info.fecha_cotizacion";
            this.Fecha_cotizacion.Name = "Fecha_cotizacion";
            this.Fecha_cotizacion.OptionsColumn.AllowEdit = false;
            this.Fecha_cotizacion.Visible = true;
            this.Fecha_cotizacion.VisibleIndex = 3;
            this.Fecha_cotizacion.Width = 91;
            // 
            // colfecha
            // 
            this.colfecha.Caption = "Fecha Nota";
            this.colfecha.FieldName = "no_fecha";
            this.colfecha.Name = "colfecha";
            this.colfecha.Visible = true;
            this.colfecha.VisibleIndex = 1;
            this.colfecha.Width = 79;
            // 
            // colNom_maquina
            // 
            this.colNom_maquina.Caption = "Equipo";
            this.colNom_maquina.FieldName = "NotaCreDeb_Graf_Info.nom_equipo";
            this.colNom_maquina.Name = "colNom_maquina";
            this.colNom_maquina.OptionsColumn.AllowEdit = false;
            this.colNom_maquina.Width = 193;
            // 
            // colEstado
            // 
            this.colEstado.Caption = "Estado";
            this.colEstado.FieldName = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.OptionsColumn.AllowEdit = false;
            this.colEstado.Visible = true;
            this.colEstado.VisibleIndex = 7;
            this.colEstado.Width = 55;
            // 
            // CodGuiaRemision
            // 
            this.CodGuiaRemision.Caption = "CodGuiaRemision";
            this.CodGuiaRemision.FieldName = "CodGuiaRemision";
            this.CodGuiaRemision.Name = "CodGuiaRemision";
            this.CodGuiaRemision.OptionsColumn.AllowEdit = false;
            // 
            // colFechaIniTrasla
            // 
            this.colFechaIniTrasla.Caption = "Fecha Inicio de Traslado";
            this.colFechaIniTrasla.FieldName = "gi_FechaIniTraslado";
            this.colFechaIniTrasla.Name = "colFechaIniTrasla";
            this.colFechaIniTrasla.OptionsColumn.AllowEdit = false;
            this.colFechaIniTrasla.Width = 74;
            // 
            // colFechaFinTrans
            // 
            this.colFechaFinTrans.Caption = "Fecha Fin de Traslado";
            this.colFechaFinTrans.FieldName = "gi_FechaFinTraslado";
            this.colFechaFinTrans.Name = "colFechaFinTrans";
            this.colFechaFinTrans.OptionsColumn.AllowEdit = false;
            this.colFechaFinTrans.Width = 51;
            // 
            // col_sc_observacion
            // 
            this.col_sc_observacion.Caption = "Observación";
            this.col_sc_observacion.FieldName = "sc_observacion";
            this.col_sc_observacion.Name = "col_sc_observacion";
            this.col_sc_observacion.Visible = true;
            this.col_sc_observacion.VisibleIndex = 6;
            this.col_sc_observacion.Width = 411;
            // 
            // frmFa_Nota_Deb_Graf_Consulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 390);
            this.Controls.Add(this.gridControlNota);
            this.Controls.Add(this.ucGe_BarraEstadoInferior_Forms1);
            this.Controls.Add(this.ucGe_Menu_Mantenimiento_x_usuario);
            this.Name = "frmFa_Nota_Deb_Graf_Consulta";
            this.Text = "frmFa_Nota_Cred_Consulta";
            this.Load += new System.EventHandler(this.frmFa_Nota_Cred_Consulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewNota)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Controles.UCGe_Menu_Mantenimiento_x_usuario ucGe_Menu_Mantenimiento_x_usuario;
        private Controles.UCGe_BarraEstadoInferior_Forms ucGe_BarraEstadoInferior_Forms1;
        private DevExpress.XtraGrid.GridControl gridControlNota;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewNota;
        private DevExpress.XtraGrid.Columns.GridColumn colIdNota;
        private DevExpress.XtraGrid.Columns.GridColumn colSucursal;
        private DevExpress.XtraGrid.Columns.GridColumn colBodega;
        private DevExpress.XtraGrid.Columns.GridColumn colCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colVendedor;
        private DevExpress.XtraGrid.Columns.GridColumn Num_OP;
        private DevExpress.XtraGrid.Columns.GridColumn Num_cotización;
        private DevExpress.XtraGrid.Columns.GridColumn Fecha_cotizacion;
        private DevExpress.XtraGrid.Columns.GridColumn colfecha;
        private DevExpress.XtraGrid.Columns.GridColumn colNom_maquina;
        private DevExpress.XtraGrid.Columns.GridColumn colEstado;
        private DevExpress.XtraGrid.Columns.GridColumn CodGuiaRemision;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaIniTrasla;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaFinTrans;
        private DevExpress.XtraGrid.Columns.GridColumn col_sc_observacion;
    }
}