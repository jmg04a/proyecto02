using Octubre.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto2.formularios
{
    public partial class frmEditorComprasClientes : Form
    {
        private int id = -1;
        public frmEditorComprasClientes()
        {
            InitializeComponent();
        }

        public frmEditorComprasClientes(int idEditar)
        {
            InitializeComponent();
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM compras_clientes WHERE id=" + idEditar);
            txtIdVenta.Text = ds.Tables[0].Rows[0]["id_venta"].ToString();
            txtIdCliente.Text = ds.Tables[0].Rows[0]["id_cliente"].ToString();
            id = idEditar;
        }

        private void frmEditorComprasClientes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            bool resultado;
            Datos data = new Datos();

            string idVenta = txtIdVenta.Text;
            string idCliente = txtIdCliente.Text;

            if (id == -1)
            {
                resultado = data.ExecuteQuery(
                    "INSERT INTO compras_clientes(id_venta, id_cliente) VALUES(" +
                    idVenta + "," +
                    idCliente +
                    ");"
                );

                if (resultado)
                {
                    MessageBox.Show("Registro agregado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                resultado = data.ExecuteQuery(
                    "UPDATE compras_clientes SET " +
                    "id_venta = " + idVenta + ", " +
                    "id_cliente = " + idCliente + " " +
                    "WHERE id = " + id.ToString() + ";" 
                );

                if (resultado)
                {
                    // Corregí tu mensaje, antes decía "Registro agregado"
                    MessageBox.Show("Registro actualizado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
    }
}
