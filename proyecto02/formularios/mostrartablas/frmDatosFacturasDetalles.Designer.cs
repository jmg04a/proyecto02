namespace proyecto02.formularios.mostrartablas
{
    partial class frmDatosFacturasDetalles
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
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPC = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.tslAgregarForm = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtDescripcionPago = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtMedioPago = new System.Windows.Forms.TextBox();
            this.lblNroTel2 = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.lblNroTel = new System.Windows.Forms.Label();
            this.txtCostoAsociado = new System.Windows.Forms.TextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtDescripcionFactura = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtIdFactura = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            this.cmsDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(98, 44);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // tsmConexion
            // 
            this.tsmConexion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPC});
            this.tsmConexion.Name = "tsmConexion";
            this.tsmConexion.Size = new System.Drawing.Size(135, 44);
            this.tsmConexion.Text = "Conexion";
            // 
            // tsmPC
            // 
            this.tsmPC.Name = "tsmPC";
            this.tsmPC.Size = new System.Drawing.Size(320, 44);
            this.tsmPC.Text = "Probar conexion";
            // 
            // tsmReiniciar
            // 
            this.tsmReiniciar.Name = "tsmReiniciar";
            this.tsmReiniciar.Size = new System.Drawing.Size(123, 44);
            this.tsmReiniciar.Text = "Reiniciar";
            this.tsmReiniciar.Click += new System.EventHandler(this.tsmReiniciar_Click);
            // 
            // tslAgregarForm
            // 
            this.tslAgregarForm.Name = "tslAgregarForm";
            this.tslAgregarForm.Size = new System.Drawing.Size(226, 44);
            this.tslAgregarForm.Text = "Agregar Elemento";
            this.tslAgregarForm.Click += new System.EventHandler(this.tslAgregarForm_Click);
            // 
            // msMenu
            // 
            this.msMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.msMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslAgregarForm,
            this.tsmReiniciar,
            this.tsmConexion,
            this.cerrarToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msMenu.Size = new System.Drawing.Size(2391, 40);
            this.msMenu.TabIndex = 61;
            this.msMenu.Text = "menuStrip1";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(-93, 110);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(91, 25);
            this.lbTitulo.TabIndex = 44;
            this.lbTitulo.Text = "Buscar: ";
            // 
            // txtDescripcionPago
            // 
            this.txtDescripcionPago.Location = new System.Drawing.Point(20, 790);
            this.txtDescripcionPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionPago.Name = "txtDescripcionPago";
            this.txtDescripcionPago.Size = new System.Drawing.Size(661, 31);
            this.txtDescripcionPago.TabIndex = 60;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 761);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(179, 25);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "Descripcion pago";
            // 
            // txtMedioPago
            // 
            this.txtMedioPago.Location = new System.Drawing.Point(20, 701);
            this.txtMedioPago.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMedioPago.Name = "txtMedioPago";
            this.txtMedioPago.Size = new System.Drawing.Size(661, 31);
            this.txtMedioPago.TabIndex = 58;
            // 
            // lblNroTel2
            // 
            this.lblNroTel2.AutoSize = true;
            this.lblNroTel2.Location = new System.Drawing.Point(15, 672);
            this.lblNroTel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel2.Name = "lblNroTel2";
            this.lblNroTel2.Size = new System.Drawing.Size(155, 25);
            this.lblNroTel2.TabIndex = 57;
            this.lblNroTel2.Text = "Medio de pago";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(17, 625);
            this.txtIva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(661, 31);
            this.txtIva.TabIndex = 56;
            // 
            // lblNroTel
            // 
            this.lblNroTel.AutoSize = true;
            this.lblNroTel.Location = new System.Drawing.Point(15, 582);
            this.lblNroTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel.Name = "lblNroTel";
            this.lblNroTel.Size = new System.Drawing.Size(40, 25);
            this.lblNroTel.TabIndex = 55;
            this.lblNroTel.Text = "Iva";
            // 
            // txtCostoAsociado
            // 
            this.txtCostoAsociado.Location = new System.Drawing.Point(20, 532);
            this.txtCostoAsociado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCostoAsociado.Name = "txtCostoAsociado";
            this.txtCostoAsociado.Size = new System.Drawing.Size(661, 31);
            this.txtCostoAsociado.TabIndex = 54;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(15, 504);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(163, 25);
            this.lblNroDoc.TabIndex = 53;
            this.lblNroDoc.Text = "Costo Asociado";
            // 
            // txtDescripcionFactura
            // 
            this.txtDescripcionFactura.Location = new System.Drawing.Point(20, 448);
            this.txtDescripcionFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDescripcionFactura.Name = "txtDescripcionFactura";
            this.txtDescripcionFactura.Size = new System.Drawing.Size(661, 31);
            this.txtDescripcionFactura.TabIndex = 52;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(15, 419);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(204, 25);
            this.lblTipoDoc.TabIndex = 51;
            this.lblTipoDoc.Text = "Descripcion Factura";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(20, 368);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(661, 31);
            this.txtTipo.TabIndex = 50;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(15, 339);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(54, 25);
            this.lblApellido.TabIndex = 49;
            this.lblApellido.Text = "Tipo";
            // 
            // txtIdFactura
            // 
            this.txtIdFactura.Location = new System.Drawing.Point(20, 286);
            this.txtIdFactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdFactura.Name = "txtIdFactura";
            this.txtIdFactura.Size = new System.Drawing.Size(661, 31);
            this.txtIdFactura.TabIndex = 48;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 258);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(131, 25);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Id de factura";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(20, 209);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(661, 31);
            this.txtId.TabIndex = 46;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(20, 882);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(663, 124);
            this.btnBuscar.TabIndex = 45;
            this.btnBuscar.Text = "Buscar en la tabla";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(15, 180);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 43;
            this.lblId.Text = "Id";
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(300, 38);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(300, 38);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // cmsDatos
            // 
            this.cmsDatos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditar,
            this.toolStripEliminar});
            this.cmsDatos.Name = "contextMenuStrip1";
            this.cmsDatos.Size = new System.Drawing.Size(301, 124);
            // 
            // dgvDatos
            // 
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.ContextMenuStrip = this.cmsDatos;
            this.dgvDatos.Location = new System.Drawing.Point(752, 102);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(1623, 918);
            this.dgvDatos.TabIndex = 42;
            // 
            // frmDatosFacturasDetalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2391, 1035);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtDescripcionPago);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtMedioPago);
            this.Controls.Add(this.lblNroTel2);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.lblNroTel);
            this.Controls.Add(this.txtCostoAsociado);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.txtDescripcionFactura);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtIdFactura);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvDatos);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDatosFacturasDetalles";
            this.Text = "frmDatosFacturasDetalles";
            this.Load += new System.EventHandler(this.frmDatosFacturasDetalles_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.cmsDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmConexion;
        private System.Windows.Forms.ToolStripMenuItem tsmPC;
        private System.Windows.Forms.ToolStripMenuItem tsmReiniciar;
        private System.Windows.Forms.ToolStripMenuItem tslAgregarForm;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtDescripcionPago;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtMedioPago;
        private System.Windows.Forms.Label lblNroTel2;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label lblNroTel;
        private System.Windows.Forms.TextBox txtCostoAsociado;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtDescripcionFactura;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtIdFactura;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ContextMenuStrip cmsDatos;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}