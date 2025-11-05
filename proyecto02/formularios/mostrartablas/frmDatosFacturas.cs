using Octubre.Data;
using Proyecto2;
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
    public partial class frmDatosFacturas : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT " +
                              "id AS \"Id\"," +
                              "numero AS \"Numero\"," +
                              "codigo AS \"Codigo\"," +
                              "fecha AS \"Fecha\"," +
                              "hora AS \"Hora\"," +
                              "importe_total AS \"Importe total\"" +
                              "FROM facturas";

        public frmDatosFacturas()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtId.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtFecha.Text = string.Empty;
            txtHora.Text = string.Empty;
            textBox1.Text = string.Empty;
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

        private void frmDatosFacturas_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery + ";");
        }

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditarFacturas frm = new frmEditarFacturas();
            frm.Show();
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery + ";");

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

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // --- Versión Insegura (Literal) con if + try-catch por variable ---

            String buscarQuery = defaultQuery + " WHERE ";
            bool variasOpciones = false;

            // --- ID (int) ---
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                try
                {
                    // Como NO está vacío, intentamos el Parse
                    int idValue = int.Parse(txtId.Text);

                    // Si funciona, lo agregamos
                    buscarQuery += " id = " + idValue;
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    // Si falla (ej. "hola"), mostramos error
                    MessageBox.Show("El ID solo acepta números enteros.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- Numero (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }

                // (Inseguro: Vulnerable a Inyección SQL)
                buscarQuery += " numero LIKE '%" + txtNumero.Text + "%'";
                variasOpciones = true;
            }

            // --- Codigo (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }

                // (Inseguro: Vulnerable a Inyección SQL)
                buscarQuery += " codigo LIKE '%" + txtCodigo.Text + "%'";
                variasOpciones = true;
            }

            // --- Fecha (date) ---
            if (!string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                try
                {
                    // Como NO está vacío, intentamos el Parse
                    DateTime fechaValue = DateTime.Parse(txtFecha.Text);

                    // Si funciona, lo agregamos
                    if (variasOpciones) { buscarQuery += " AND "; }
                    buscarQuery += " fecha = '" + fechaValue.ToString("yyyy-MM-dd") + "'";
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    // Si falla, mostramos error
                    MessageBox.Show("El formato de la FECHA no es válido. Use YYYY-MM-DD.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- Hora (time) ---
            if (!string.IsNullOrWhiteSpace(txtHora.Text))
            {
                try
                {
                    // Como NO está vacío, intentamos el Parse
                    TimeSpan horaValue = TimeSpan.Parse(txtHora.Text);

                    // Si funciona, lo agregamos
                    if (variasOpciones) { buscarQuery += " AND "; }
                    buscarQuery += " hora = '" + horaValue.ToString(@"hh\:mm\:ss") + "'";
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    // Si falla, mostramos error
                    MessageBox.Show("El formato de la HORA no es válido. Use HH:MM:SS.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- Importe Total (decimal) ---
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                try
                {
                    // Como NO está vacío, intentamos el Parse
                    decimal importeValue = decimal.Parse(txtImporteTotal.Text, System.Globalization.CultureInfo.InvariantCulture);

                    // Si funciona, lo agregamos
                    if (variasOpciones) { buscarQuery += " AND "; }
                    buscarQuery += " importe_total = " + importeValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    // Si falla, mostramos error
                    MessageBox.Show("El formato del IMPORTE no es válido. Use 123.45 (con punto).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

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

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            frmEditorClientes frm = new frmEditorClientes(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0,
                dgvDatos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool s = datos.ExecuteQuery("DELETE FROM facturas WHERE id=" + r);
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
