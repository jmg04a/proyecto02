using Octubre.Data;
using Proyecto2;
using Proyecto2.formularios;
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
    public partial class frmDatosProveedores : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT id AS  \"Id\"," +
                              "empresa AS \"Empresa\"," +
                              "tipo_producto AS \"Tipo de Producto\"," +
                              "direccion AS \"Direccion\"," +
                              "nro_tel_princ AS \"Numero de Telefono\"," +
                              "nro_tel_sec AS \"Numero de Telefono (Secundario)\"," +
                              "email AS \"Correo Electronico\"" +
                              "FROM proveedores";
        public frmDatosProveedores()
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
            txtEmpresa.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtTelefono2.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void frmDatosProveedores_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery);
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

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery+";");
        }

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditarProveedores frm = new frmEditarProveedores();
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // (Asegúrate de que 'defaultQuery' ahora sea "SELECT * FROM proveedores")
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

            // --- Empresa (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtEmpresa.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " empresa LIKE '%" + txtEmpresa.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Tipo_Producto (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " tipo_producto LIKE '%" + txtProducto.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Direccion (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " direccion LIKE '%" + txtDireccion.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Nro_Tel_Princ (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " nro_tel_princ LIKE '%" + txtTelefono.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Nro_Tel_Sec (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtTelefono2.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                // (Corregido: ahora busca en nro_tel_sec)
                buscarQuery += " nro_tel_sec LIKE '%" + txtTelefono2.Text + "%'"; // ¡Inseguro!
                variasOpciones = true;
            }

            // --- Email (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                buscarQuery += " email LIKE '%" + txtEmail.Text + "%'"; // ¡Inseguro!
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
            frmEditarProveedores frm = new frmEditarProveedores(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0,
                dgvDatos.CurrentCell.RowIndex].Value.ToString();
            if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool s = datos.ExecuteQuery("DELETE FROM proveedores WHERE id=" + r);
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
