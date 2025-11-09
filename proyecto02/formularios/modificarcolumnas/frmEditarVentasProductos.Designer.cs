namespace Proyecto2.formularios.editarElementos
{
    partial class frmEditarVentasProductos
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
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.txtIdVenta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(447, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ventas Productos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(625, 314);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 64);
            this.button2.TabIndex = 34;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(287, 314);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 64);
            this.button1.TabIndex = 33;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(547, 231);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(321, 31);
            this.txtCantidad.TabIndex = 28;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(547, 188);
            this.txtIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(321, 31);
            this.txtIdProducto.TabIndex = 27;
            this.txtIdProducto.TextChanged += new System.EventHandler(this.txtIdProducto_TextChanged);
            // 
            // txtIdVenta
            // 
            this.txtIdVenta.Location = new System.Drawing.Point(547, 154);
            this.txtIdVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdVenta.Name = "txtIdVenta";
            this.txtIdVenta.Size = new System.Drawing.Size(321, 31);
            this.txtIdVenta.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(197, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 25);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 195);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 25);
            this.label4.TabIndex = 21;
            this.label4.Text = "Id de Producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(197, 158);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Id de Venta";
            // 
            // frmEditarVentasProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtIdProducto);
            this.Controls.Add(this.txtIdVenta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditarVentasProductos";
            this.Text = "frmEditarVentasProductos";
            this.Load += new System.EventHandler(this.frmEditarVentasProductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.TextBox txtIdVenta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}