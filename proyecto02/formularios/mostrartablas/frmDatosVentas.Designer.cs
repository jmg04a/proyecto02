namespace proyecto02.formularios.mostrartablas
{
    partial class frmDatosVentas
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.tslAgregarForm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmReiniciar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPC = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtEmpleado = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.cmsDatos = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripEliminar = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            this.cmsDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
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
            this.msMenu.Size = new System.Drawing.Size(2439, 40);
            this.msMenu.TabIndex = 81;
            this.msMenu.Text = "menuStrip1";
            // 
            // tslAgregarForm
            // 
            this.tslAgregarForm.Name = "tslAgregarForm";
            this.tslAgregarForm.Size = new System.Drawing.Size(226, 36);
            this.tslAgregarForm.Text = "Agregar Elemento";
            // 
            // tsmReiniciar
            // 
            this.tsmReiniciar.Name = "tsmReiniciar";
            this.tsmReiniciar.Size = new System.Drawing.Size(123, 36);
            this.tsmReiniciar.Text = "Reiniciar";
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
            this.lbTitulo.Location = new System.Drawing.Point(20, 319);
            this.lbTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitulo.Name = "lbTitulo";
            this.lbTitulo.Size = new System.Drawing.Size(91, 25);
            this.lbTitulo.TabIndex = 64;
            this.lbTitulo.Text = "Buscar: ";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(28, 571);
            this.txtFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(661, 31);
            this.txtFactura.TabIndex = 70;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(23, 542);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(131, 25);
            this.lblApellido.TabIndex = 69;
            this.lblApellido.Text = "Id de factura";
            // 
            // txtEmpleado
            // 
            this.txtEmpleado.Location = new System.Drawing.Point(28, 490);
            this.txtEmpleado.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmpleado.Name = "txtEmpleado";
            this.txtEmpleado.Size = new System.Drawing.Size(661, 31);
            this.txtEmpleado.TabIndex = 68;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(23, 461);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(165, 25);
            this.lblNombre.TabIndex = 67;
            this.lblNombre.Text = "Id de empleado ";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(28, 412);
            this.txtId.Margin = new System.Windows.Forms.Padding(4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(661, 31);
            this.txtId.TabIndex = 66;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(28, 856);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(663, 124);
            this.btnBuscar.TabIndex = 65;
            this.btnBuscar.Text = "Buscar en la tabla";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 384);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(29, 25);
            this.lblId.TabIndex = 63;
            this.lblId.Text = "Id";
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
            // 
            // toolStripEliminar
            // 
            this.toolStripEliminar.Name = "toolStripEliminar";
            this.toolStripEliminar.Size = new System.Drawing.Size(173, 38);
            this.toolStripEliminar.Text = "Eliminar";
            // 
            // dgvDatos
            // 
            this.dgvDatos.AllowUserToAddRows = false;
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.ContextMenuStrip = this.cmsDatos;
            this.dgvDatos.Location = new System.Drawing.Point(724, 65);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.MultiSelect = false;
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.RowHeadersWidth = 62;
            this.dgvDatos.RowTemplate.Height = 28;
            this.dgvDatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDatos.Size = new System.Drawing.Size(1727, 1168);
            this.dgvDatos.TabIndex = 82;
            // 
            // frmDatosVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2439, 1114);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.msMenu);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtEmpleado);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblId);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatosVentas";
            this.Text = "frmDatosVentas";
            this.Load += new System.EventHandler(this.frmDatosVentas_Load);
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.cmsDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem tslAgregarForm;
        private System.Windows.Forms.ToolStripMenuItem tsmReiniciar;
        private System.Windows.Forms.ToolStripMenuItem tsmConexion;
        private System.Windows.Forms.ToolStripMenuItem tsmPC;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.Label lbTitulo;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.ContextMenuStrip cmsDatos;
        private System.Windows.Forms.ToolStripMenuItem toolStripEditar;
        private System.Windows.Forms.ToolStripMenuItem toolStripEliminar;
        private System.Windows.Forms.DataGridView dgvDatos;
    }
}