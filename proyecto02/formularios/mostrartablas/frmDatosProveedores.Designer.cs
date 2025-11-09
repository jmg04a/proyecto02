namespace proyecto02.formularios.mostrartablas
{
    partial class frmDatosProveedores
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
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tslAgregarForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPC = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.cmsDatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblNroTel2 = new System.Windows.Forms.Label();
            this.txtTelefono2 = new System.Windows.Forms.TextBox();
            this.lblNroTel = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtEmpresa = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.msMenu.SuspendLayout();
            this.cmsDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(300, 38);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
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
            this.msMenu.Size = new System.Drawing.Size(2429, 40);
            this.msMenu.TabIndex = 85;
            this.msMenu.Text = "menuStrip1";
            // 
            // tslAgregarForm
            // 
            this.tslAgregarForm.Name = "tslAgregarForm";
            this.tslAgregarForm.Size = new System.Drawing.Size(226, 36);
            this.tslAgregarForm.Text = "Agregar Elemento";
            this.tslAgregarForm.Click += new System.EventHandler(this.tslAgregarForm_Click);
            // 
            // tsmReiniciar
            // 
            this.tsmReiniciar.Name = "tsmReiniciar";
            this.tsmReiniciar.Size = new System.Drawing.Size(123, 36);
            this.tsmReiniciar.Text = "Reiniciar";
            this.tsmReiniciar.Click += new System.EventHandler(this.tsmReiniciar_Click);
            // 
            // tsmConexion
            // 
            this.tsmConexion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmPC});
            this.tsmConexion.Name = "tsmConexion";
            this.tsmConexion.Size = new System.Drawing.Size(135, 36);
            this.tsmConexion.Text = "Conexion";
            // 
            // tsmPC
            // 
            this.tsmPC.Name = "tsmPC";
            this.tsmPC.Size = new System.Drawing.Size(359, 44);
            this.tsmPC.Text = "Probar conexion";
            this.tsmPC.Click += new System.EventHandler(this.tsmPC_Click);
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(7, 90);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(91, 25);
            this.lbTitulo.TabIndex = 68;
            this.lbTitulo.Text = "Buscar: ";
            // 
            // cmsDatos
            // 
            this.cmsDatos.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsDatos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripEditar,
            this.toolStripEliminar});
            this.cmsDatos.Name = "contextMenuStrip1";
            this.cmsDatos.Size = new System.Drawing.Size(174, 80);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(300, 38);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(15, 676);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(661, 31);
            this.txtEmail.TabIndex = 82;
            // 
            // lblNroTel2
            // 
            this.lblNroTel2.AutoSize = true;
            this.lblNroTel2.Location = new System.Drawing.Point(9, 648);
            this.lblNroTel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel2.Name = "lblNroTel2";
            this.lblNroTel2.Size = new System.Drawing.Size(65, 25);
            this.lblNroTel2.TabIndex = 81;
            this.lblNroTel2.Text = "Email";
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.Location = new System.Drawing.Point(12, 600);
            this.txtTelefono2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(661, 31);
            this.txtTelefono2.TabIndex = 80;
            // 
            // lblNroTel
            // 
            this.lblNroTel.AutoSize = true;
            this.lblNroTel.Location = new System.Drawing.Point(9, 558);
            this.lblNroTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel.Name = "lblNroTel";
            this.lblNroTel.Size = new System.Drawing.Size(336, 25);
            this.lblNroTel.TabIndex = 79;
            this.lblNroTel.Text = "Numero de Telefono (Secundario)";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(15, 508);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(661, 31);
            this.txtTelefono.TabIndex = 78;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(9, 479);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(206, 25);
            this.lblNroDoc.TabIndex = 77;
            this.lblNroDoc.Text = "Numero de telefono ";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(15, 422);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(661, 31);
            this.txtDireccion.TabIndex = 76;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(9, 394);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(102, 25);
            this.lblTipoDoc.TabIndex = 75;
            this.lblTipoDoc.Text = "Direccion";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(9, 314);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(176, 25);
            this.lblApellido.TabIndex = 73;
            this.lblApellido.Text = "Tipo de Producto";
            // 
            // txtEmpresa
            // 
            this.txtEmpresa.Location = new System.Drawing.Point(15, 261);
            this.txtEmpresa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpresa.Name = "txtEmpresa";
            this.txtEmpresa.Size = new System.Drawing.Size(661, 31);
            this.txtEmpresa.TabIndex = 72;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(9, 232);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(97, 25);
            this.lblNombre.TabIndex = 71;
            this.lblNombre.Text = "Empresa";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(15, 184);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(661, 31);
            this.txtId.TabIndex = 70;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(12, 759);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(663, 124);
            this.btnBuscar.TabIndex = 69;
            this.btnBuscar.Text = "Buscar en la tabla";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(9, 155);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 67;
            this.lblId.Text = "Id";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AllowUserToDeleteRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.ContextMenuStrip = this.cmsDatos;
            this.dgvDatos.Location = new System.Drawing.Point(729, 59);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.Size = new System.Drawing.Size(1623, 879);
            this.dgvDatos.TabIndex = 66;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(15, 342);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(661, 31);
            this.txtProducto.TabIndex = 74;
            // 
            // frmDatosProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2429, 980);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblNroTel2);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.lblNroTel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtEmpresa);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtProducto);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDatosProveedores";
            this.Text = "frmDatosProveedores";
            this.Load += new System.EventHandler(this.frmDatosProveedores_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.cmsDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tslAgregarForm;
        private System.Windows.Forms.ToolStripMenuItem tsmReiniciar;
        private System.Windows.Forms.ToolStripMenuItem tsmConexion;
        private System.Windows.Forms.ToolStripMenuItem tsmPC;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.ContextMenuStrip cmsDatos;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblNroTel2;
        private System.Windows.Forms.TextBox txtTelefono2;
        private System.Windows.Forms.Label lblNroTel;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtEmpresa;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.TextBox txtProducto;
    }
}