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
    public partial class frmDatosComprasClientes : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT id " +
                              "AS  \"Id\", " +
                              "id_venta AS \"Id de venta\"," +
                              "id_cliente AS \"Id de cliente\" FROM compras_clientes";
        public frmDatosComprasClientes()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String buscarQuery = defaultQuery + " WHERE ";
            bool variasOpciones = false;

            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                try
                {
                    buscarQuery += " id = " + int.Parse(txtId.Text) + "";
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Esta opcion solo acepta numeros", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }

                try
                {
                    buscarQuery += " id_venta = " + int.Parse(txtNombre.Text) + "";
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Esta opcion solo acepta numeros", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (!string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                try
                {
                    buscarQuery += " id_cliente = " + int.Parse(txtNombre.Text) + "";
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Esta opcion solo acepta numeros", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            if (variasOpciones)
            {
                mostrarDatos(buscarQuery + ";");
            }
            else
            {
                mostrarDatos(defaultQuery + ";");
            }

        }

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditorComprasClientes frm = new frmEditorComprasClientes(); 
            frm.ShowDialog();
        }

        private void frmDatosComprasClientes_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery + ";");
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            frmEditorComprasClientes frm = new frmEditorComprasClientes(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0,
                dgvDatos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
            {
                bool s = datos.ExecuteQuery("DELETE FROM compras_clientes WHERE id=" + r);
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
