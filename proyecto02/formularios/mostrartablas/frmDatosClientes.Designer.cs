namespace Proyecto2
{
    partial class frmDatosClientes
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
            this.cmsDatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblId = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.txtNumeroDocumento = new System.Windows.Forms.TextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtNumeroTelefono = new System.Windows.Forms.TextBox();
            this.lblNroTel = new System.Windows.Forms.Label();
            this.txtNumeroTelefono2 = new System.Windows.Forms.TextBox();
            this.lblNroTel2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tslAgregarForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPC = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.cmsDatos.SuspendLayout();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
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
            this.toolStripEditar.Size = new System.Drawing.Size(173, 38);
            this.toolStripEditar.Text = "Editar";
            this.toolStripEditar.Click += new System.EventHandler(this.toolStripEditar_Click);
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(173, 38);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(28, 179);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 9;
            this.lblId.Text = "Id";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(25, 109);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(91, 25);
            this.lbTitulo.TabIndex = 24;
            this.lbTitulo.Text = "Buscar: ";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(33, 923);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(663, 132);
            this.btnBuscar.TabIndex = 25;
            this.btnBuscar.Text = "Buscar en la tabla";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(33, 209);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(661, 31);
            this.txtId.TabIndex = 26;
            this.txtId.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(33, 292);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(661, 31);
            this.txtNombre.TabIndex = 28;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 261);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(87, 25);
            this.lblNombre.TabIndex = 27;
            this.lblNombre.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(33, 379);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(661, 31);
            this.txtApellido.TabIndex = 30;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 348);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(89, 25);
            this.lblApellido.TabIndex = 29;
            this.lblApellido.Text = "Apellido";
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Location = new System.Drawing.Point(33, 464);
            this.txtTipoDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(661, 31);
            this.txtTipoDocumento.TabIndex = 32;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(28, 433);
            this.lblTipoDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(199, 25);
            this.lblTipoDoc.TabIndex = 31;
            this.lblTipoDoc.Text = "Tipo de Documento";
            // 
            // txtNumeroDocumento
            // 
            this.txtNumeroDocumento.Location = new System.Drawing.Point(33, 555);
            this.txtNumeroDocumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroDocumento.Name = "txtNumeroDocumento";
            this.txtNumeroDocumento.Size = new System.Drawing.Size(661, 31);
            this.txtNumeroDocumento.TabIndex = 34;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(28, 524);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(232, 25);
            this.lblNroDoc.TabIndex = 33;
            this.lblNroDoc.Text = "Numero de Documento";
            // 
            // txtNumeroTelefono
            // 
            this.txtNumeroTelefono.Location = new System.Drawing.Point(31, 653);
            this.txtNumeroTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroTelefono.Name = "txtNumeroTelefono";
            this.txtNumeroTelefono.Size = new System.Drawing.Size(661, 31);
            this.txtNumeroTelefono.TabIndex = 36;
            // 
            // lblNroTel
            // 
            this.lblNroTel.AutoSize = true;
            this.lblNroTel.Location = new System.Drawing.Point(28, 608);
            this.lblNroTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel.Name = "lblNroTel";
            this.lblNroTel.Size = new System.Drawing.Size(207, 25);
            this.lblNroTel.TabIndex = 35;
            this.lblNroTel.Text = "Numero de Telefono";
            // 
            // txtNumeroTelefono2
            // 
            this.txtNumeroTelefono2.Location = new System.Drawing.Point(33, 735);
            this.txtNumeroTelefono2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumeroTelefono2.Name = "txtNumeroTelefono2";
            this.txtNumeroTelefono2.Size = new System.Drawing.Size(661, 31);
            this.txtNumeroTelefono2.TabIndex = 38;
            // 
            // lblNroTel2
            // 
            this.lblNroTel2.AutoSize = true;
            this.lblNroTel2.Location = new System.Drawing.Point(28, 704);
            this.lblNroTel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel2.Name = "lblNroTel2";
            this.lblNroTel2.Size = new System.Drawing.Size(333, 25);
            this.lblNroTel2.TabIndex = 37;
            this.lblNroTel2.Text = "Numero de Telefono (secundario)";
            this.lblNroTel2.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(33, 829);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(661, 31);
            this.txtEmail.TabIndex = 40;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 799);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(65, 25);
            this.lblEmail.TabIndex = 39;
            this.lblEmail.Text = "Email";
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
            this.msMenu.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.msMenu.Size = new System.Drawing.Size(2392, 42);
            this.msMenu.TabIndex = 41;
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
            this.tsmConexion.Click += new System.EventHandler(this.tsmConexion_Click);
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
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.ContextMenuStrip = this.cmsDatos;
            this.dgvDatos.Location = new System.Drawing.Point(735, 60);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1727, 1168);
            this.dgvDatos.TabIndex = 43;
            // 
            // frmDatosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2392, 1108);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtNumeroTelefono2);
            this.Controls.Add(this.lblNroTel2);
            this.Controls.Add(this.txtNumeroTelefono);
            this.Controls.Add(this.lblNroTel);
            this.Controls.Add(this.txtNumeroDocumento);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.lblTipoDoc);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmDatosClientes";
            this.Text = "frmClientes";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            this.cmsDatos.ResumeLayout(false);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip cmsDatos;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.TextBox txtNumeroDocumento;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtNumeroTelefono;
        private System.Windows.Forms.Label lblNroTel;
        private System.Windows.Forms.TextBox txtNumeroTelefono2;
        private System.Windows.Forms.Label lblNroTel2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tslAgregarForm;
        private System.Windows.Forms.ToolStripMenuItem tsmReiniciar;
        private System.Windows.Forms.ToolStripMenuItem tsmConexion;
        private System.Windows.Forms.ToolStripMenuItem tsmPC;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}