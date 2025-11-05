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
using Proyecto2.formularios;

namespace proyecto02.formularios.mostrartablas
{
    public partial class frmDatosProductos : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT id " +
                              "AS \"Id\", " +
                              "id_proveedor AS \"Id Proveedor\", " +
                              "codigo AS \"Código\", " +
                              "nombre AS \"Nombre\", " +
                              "marca AS \"Marca\", " +
                              "tipo AS \"Tipo\", " +
                              "grupo AS \"Grupo\", " +
                              "peso AS \"Peso\", " +
                              "precio_unidad AS \"Precio Unitario\", " +
                              "stock AS \"Stock\" " +
                              "FROM productos";
        public frmDatosProductos()
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
            txtIdProveedor.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtGrupo.Text = string.Empty;
            txtPeso.Text = string.Empty;
            txtStock.Text= string.Empty;
        }

        private void frmDatosProductos_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery+";");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // --- Versión Insegura (Literal) ---

            // Asumimos que defaultQuery = "SELECT ... FROM productos"
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

            // --- ID_Proveedor (int) ---
            if (!string.IsNullOrWhiteSpace(txtIdProveedor.Text))
            {
                try
                {
                    if (variasOpciones) { buscarQuery += " AND "; }
                    buscarQuery += " id_proveedor = " + int.Parse(txtIdProveedor.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID Proveedor solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- Codigo (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " codigo LIKE '%" + txtCodigo.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Nombre (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtIdProveedor.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " nombre LIKE '%" + txtIdProveedor.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Marca (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " marca LIKE '%" + txtMarca.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Tipo (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " tipo LIKE '%" + txtTipo.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Grupo (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtGrupo.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " grupo LIKE '%" + txtGrupo.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Peso (decimal) ---
            if (!string.IsNullOrWhiteSpace(txtPeso.Text))
            {
                try
                {
                    if (variasOpciones) { buscarQuery += " AND "; }
                    // (Esto es frágil, fallará si el usuario usa ',')
                    buscarQuery += " peso = " + decimal.Parse(txtPeso.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El Peso solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // (Y así sucesivamente para precio_unidad y stock...)

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

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery + ";");
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmConexion_Click(object sender, EventArgs e)
        {

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

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditorProductos frm =new frmEditorProductos();
            frm.ShowDialog();
        }
    }
}
