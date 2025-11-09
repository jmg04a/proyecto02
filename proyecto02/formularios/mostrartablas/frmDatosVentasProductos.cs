using Octubre.Data;
using Proyecto2;
using Proyecto2.formularios.editarElementos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto02.formularios.mostrartablas
{
    public partial class frmDatosVentasProductos : Form
    {

        Datos datos = new Datos();
        string defaultQuery = "SELECT " +
                              "id AS  \"Id\", " +
                              "id_venta AS \"Id de Venta\"," +
                              "id_producto AS \"Id de Producto\"," +
                              "cantidad AS \"Cantidad\"" +
                              "FROM ventas_productos";
        public frmDatosVentasProductos()
        {
            InitializeComponent();
        }
        private void mostrarDatos(string query)
        {
            DataSet ds = datos.getAllData(query);
            if (ds != null)
            {
                dgvDatos.DataSource = ds.Tables[0];
            }
            else
            {
                MessageBox.Show("Error al cargar los datos.", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void limpiar()
        {
            txtId.Text = string.Empty;
            txtIdVenta.Text = string.Empty;
            txtIdProducto.Text = string.Empty;
            txtCantidad.Text = string.Empty;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmPC_Click(object sender, EventArgs e)
        {
            if (datos.TestConnection())
            {
                MessageBox.Show("La conexion ha sido un exito", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La conexion ha fallado\nIntentalo mas tarde", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDatosVentasProductos_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery+";");
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery+";");
        }

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditarVentasProductos frm = new frmEditarVentasProductos();
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // (Asegúrate de que 'defaultQuery' ahora sea "SELECT * FROM ventas_productos")
            String buscarQuery = defaultQuery + " WHERE ";
            bool variasOpciones = false;

            // --- ID (int) ---
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                try
                {
                    buscarQuery += " id = " + int.Parse(txtId.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // --- ID_Venta (int) ---
            if (!string.IsNullOrWhiteSpace(txtIdVenta.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }

                try
                {
                    buscarQuery += " id_venta = " + int.Parse(txtIdVenta.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID de Venta solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // --- ID_Producto (int) ---
            if (!string.IsNullOrWhiteSpace(txtIdProducto.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }

                try
                {
                    buscarQuery += " id_producto = " + int.Parse(txtIdProducto.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID de Producto solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // --- Cantidad (int) ---
            if (!string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }

                try
                {
                    buscarQuery += " cantidad = " + int.Parse(txtCantidad.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La Cantidad solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // (El resto de 'if' de txtNombre, txtApellido, etc. no aplican)

            // --- Ejecución ---
            if (variasOpciones)
            {
                mostrarDatos(buscarQuery + ";");
            }
            else
            {
                mostrarDatos(defaultQuery + ";");
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            frmEditarVentasProductos frm = new frmEditarVentasProductos(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0,
                dgvDatos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool s = datos.ExecuteQuery("DELETE FROM ventas_productos WHERE id=" + r);
                if (s)
                {
                    MessageBox.Show("Registro Eliminado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mostrarDatos(defaultQuery);
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
