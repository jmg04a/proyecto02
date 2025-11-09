using ImageMagick;
using Octubre.Data;
using Proyecto2;
using Proyecto2.formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                              "stock AS \"Stock\", " +
                              "imagen AS \"Link de Imagen\" "+
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
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " nombre LIKE '%" + txtNombre.Text + "%'"; // ¡Inseguro!
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

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            frmEditorProductos frm = new frmEditorProductos(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0,
                dgvDatos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool s = datos.ExecuteQuery("DELETE FROM productos WHERE id=" + r);
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

        private void dgvDatos_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private async void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            // 1. Inicia el 'try' ANTES de tocar cualquier fila.
            try
            {
                // 2. Tu 'if' original. Es correcto.
                if (dgvDatos.SelectedRows.Count > 0)
                {
                    // 3. El posible punto de fallo.
                    DataGridViewRow filaSeleccionada = dgvDatos.SelectedRows[0];

                    // 4. El segundo posible punto de fallo.
                    if (filaSeleccionada.IsNewRow)
                    {
                        // Si es la fila nueva, limpia y sal.
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = null;
                        return;
                    }

                    // 5. El tercer posible punto de fallo (si la celda no existe)
                    string urlImagen = filaSeleccionada.Cells["Link de Imagen"].Value?.ToString();

                    // --- El resto de tu lógica de carga ---

                    if (string.IsNullOrWhiteSpace(urlImagen))
                    {
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = null;
                        return;
                    }

                    using (HttpClient cliente = new HttpClient())
                    {
                        byte[] bytesImagen = await cliente.GetByteArrayAsync(urlImagen);

                        using (var image = new MagickImage(bytesImagen))
                        {
                            pictureBox1.Image?.Dispose();
                            pictureBox1.Image = image.ToBitmap();
                        }
                    }
                    // (Tu propio 'catch' para la carga de imagen debería ir aquí dentro)
                }
            }
            // 6. EL 'CATCH' GENERAL
            catch (Exception ex)
            {
                // Si el evento se disparó al limpiar el grid,
                // simplemente ignoramos el error.

                // Opcional: Muestra el error si estás depurando
                // MessageBox.Show("Error de selección: " + ex.Message);

                // Lo más seguro es simplemente limpiar la imagen
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = null;
            }
        }
    }
}
