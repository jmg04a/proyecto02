namespace proyecto02.formularios.mostrartablas
{
    partial class frmDatosProductos
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
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblNroTel2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblNroTel = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsDatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            this.cmsDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(98, 36);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            this.cerrarToolStripMenuItem.Click += new System.EventHandler(this.cerrarToolStripMenuItem_Click);
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
            this.tsmPC.Size = new System.Drawing.Size(320, 44);
            this.tsmPC.Text = "Probar conexion";
            this.tsmPC.Click += new System.EventHandler(this.tsmPC_Click);
            // 
            // tsmReiniciar
            // 
            this.tsmReiniciar.Name = "tsmReiniciar";
            this.tsmReiniciar.Size = new System.Drawing.Size(123, 36);
            this.tsmReiniciar.Text = "Reiniciar";
            this.tsmReiniciar.Click += new System.EventHandler(this.tsmReiniciar_Click);
            // 
            // tslAgregarForm
            // 
            this.tslAgregarForm.Name = "tslAgregarForm";
            this.tslAgregarForm.Size = new System.Drawing.Size(226, 36);
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
            this.msMenu.Size = new System.Drawing.Size(2509, 40);
            this.msMenu.TabIndex = 61;
            this.msMenu.Text = "menuStrip1";
            // 
            // lbTitulo
            // 
            this.lbTitulo.AutoSize = true;
            this.lbTitulo.Location = new System.Drawing.Point(26, 277);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(91, 25);
            this.lbTitulo.TabIndex = 44;
            this.lbTitulo.Text = "Buscar: ";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Location = new System.Drawing.Point(31, 868);
            this.txtGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(661, 31);
            this.txtGrupo.TabIndex = 60;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(25, 839);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(71, 25);
            this.lblEmail.TabIndex = 59;
            this.lblEmail.Text = "Grupo";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(31, 779);
            this.txtTipo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(661, 31);
            this.txtTipo.TabIndex = 58;
            // 
            // lblNroTel2
            // 
            this.lblNroTel2.AutoSize = true;
            this.lblNroTel2.Location = new System.Drawing.Point(25, 750);
            this.lblNroTel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel2.Name = "lblNroTel2";
            this.lblNroTel2.Size = new System.Drawing.Size(54, 25);
            this.lblNroTel2.TabIndex = 57;
            this.lblNroTel2.Text = "Tipo";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(28, 703);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(661, 31);
            this.txtMarca.TabIndex = 56;
            // 
            // lblNroTel
            // 
            this.lblNroTel.AutoSize = true;
            this.lblNroTel.Location = new System.Drawing.Point(25, 660);
            this.lblNroTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroTel.Name = "lblNroTel";
            this.lblNroTel.Size = new System.Drawing.Size(72, 25);
            this.lblNroTel.TabIndex = 55;
            this.lblNroTel.Text = "Marca";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(31, 610);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(661, 31);
            this.txtNombre.TabIndex = 54;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(25, 582);
            this.lblNroDoc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(87, 25);
            this.lblNroDoc.TabIndex = 53;
            this.lblNroDoc.Text = "Nombre";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(34, 529);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(661, 31);
            this.txtCodigo.TabIndex = 50;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 500);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(80, 25);
            this.lblApellido.TabIndex = 49;
            this.lblApellido.Text = "Codigo";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(34, 448);
            this.txtIdProveedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(661, 31);
            this.txtIdProveedor.TabIndex = 48;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 419);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(162, 25);
            this.lblNombre.TabIndex = 47;
            this.lblNombre.Text = "Id de proveedor";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(34, 370);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(661, 31);
            this.txtId.TabIndex = 46;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(26, 1126);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
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
            this.lblId.Location = new System.Drawing.Point(29, 318);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 43;
            this.lblId.Text = "Id";
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(173, 38);
            this.toolStripEliminar.Text = "Eliminar";
            this.toolStripEliminar.Click += new System.EventHandler(this.toolStripEliminar_Click);
            // 
            // toolStripEditar
            // 
            this.toolStripEditar.Name = "toolStripEditar";
            this.toolStripEditar.Size = new System.Drawing.Size(173, 38);
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
            this.cmsDatos.Size = new System.Drawing.Size(174, 80);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(31, 1042);
            this.txtStock.Margin = new System.Windows.Forms.Padding(4);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(661, 31);
            this.txtStock.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 1013);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 64;
            this.label1.Text = "Stock";
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(31, 953);
            this.txtPeso.Margin = new System.Windows.Forms.Padding(4);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(661, 31);
            this.txtPeso.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 924);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 25);
            this.label2.TabIndex = 62;
            this.label2.Text = "Precio unidad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(350, 63);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(323, 280);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Previsualizador";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.ContextMenuStrip = this.cmsDatos;
            this.dgvDatos.Location = new System.Drawing.Point(733, 63);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1727, 1168);
            this.dgvDatos.TabIndex = 68;
            // 
            // frmDatosProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2509, 1300);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtGrupo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.lblNroTel2);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblNroTel);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNroDoc);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtIdProveedor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatosProductos";
            this.Text = "frmDatosProductos";
            this.Load += new System.EventHandler(this.frmDatosProductos_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.cmsDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox txtGrupo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblNroTel2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblNroTel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtIdProveedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ContextMenuStrip cmsDatos;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}