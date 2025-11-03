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
                              "numero AS \"Nombre\"," +
                              "codigo AS \"Apellido\"," +
                              "fecha AS \"Tipo de Documento\"," +
                              "hora AS \"Numero de Documento\"," +
                              "importe_total AS \"Numero de telefono\"," +
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
            txtNumeroTelefono.Text = string.Empty;
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
            frmDatosFacturas frm = new frmDatosFacturas();
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
            // --- Versión Insegura (NO RECOMENDADA) ---
            String buscarQuery = defaultQuery + " WHERE ";
            bool variasOpciones = false;

            // --- ID (int) ---
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                try
                {
                    buscarQuery += " id = " + int.Parse(txtId.Text) + "";
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID solo acepta numeros", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // --- Numero (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtNumero.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " numero like '%" + txtNumero.Text + "%'";
                variasOpciones = true;
            }

            // --- Codigo (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " codigo like '%" + txtCodigo.Text + "%'";
                variasOpciones = true;
            }

            // --- Fecha (date) ---
            if (!string.IsNullOrWhiteSpace(txtFecha.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                // Esto es muy peligroso y depende del formato de la base de datos
                buscarQuery += " fecha = '" + txtFecha.Text + "'";
                variasOpciones = true;
            }

            // --- Hora (time) ---
            if (!string.IsNullOrWhiteSpace(txtHora.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " hora = '" + txtHora.Text + "'";
                variasOpciones = true;
            }

            // --- Importe Total (decimal) ---
            if (!string.IsNullOrWhiteSpace(txtImporteTotal.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                // Esto fallará si el usuario usa ',' en lugar de '.'
                buscarQuery += " importe_total = " + txtImporteTotal.Text;
                variasOpciones = true;
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
            frmEditarFacturas frm = new frmEditarFacturas(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0,
                dgvDatos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
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
