using Npgsql;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Proyecto2
{
    public partial class frmDatosClientes : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT id " +
                "AS  \"Id\", nombre AS \"Nombre\"," +
                "apellido AS \"Apellido\"," +
                "tipo_doc AS \"Tipo de Documento\"," +
                "nro_doc AS \"Numero de Documento\"," +
                "nro_tel_princ AS \"Numero de telefono\"," +
                "nro_tel_sec AS \"Numero de telefono (secundario)\"," +
                "email AS \"Correo Electronico\" FROM clientes";
        public frmDatosClientes()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtId.Text= string.Empty;
            txtNombre.Text= string.Empty;
            txtApellido.Text= string.Empty;
            txtTipoDocumento.Text= string.Empty;
            txtNumeroDocumento.Text= string.Empty;
            txtNumeroTelefono.Text= string.Empty;
            txtNumeroTelefono2.Text= string.Empty;
            txtEmail.Text= string.Empty;
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
                MessageBox.Show("Error al cargar los datos.", "Sistema",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery+";");
        }

        private void dgvDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            frmEditorClientes frm = new frmEditorClientes(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
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
                catch (Exception ex) {
                    MessageBox.Show("Esta opcion solo acepta numeros", "Programa", MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " nombre like '%" + txtNombre.Text + "%'";
                variasOpciones = true;
            }
            if (!string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " apellido like '%" + txtApellido.Text + "%'";
                variasOpciones = true;
            }
            if (!string.IsNullOrWhiteSpace(txtTipoDocumento.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " tipo_doc like '%" + txtTipoDocumento.Text + "%'";
                variasOpciones = true;
            }
            if (!string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " nro_doc like '%" + txtNumeroDocumento.Text + "%'";
                variasOpciones = true;
            }
            if (!string.IsNullOrWhiteSpace(txtNumeroTelefono.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " nro_tel_princ like '%" + txtNumeroTelefono.Text + "%'";
                variasOpciones = true;
            }
            if (!string.IsNullOrWhiteSpace(txtNumeroTelefono2.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " tipo_doc like '%" + txtNumeroTelefono2.Text +"%'";
                variasOpciones = true;
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

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {

                string r = dgvDatos[0,
                    dgvDatos.CurrentCell.RowIndex].Value.ToString();
                if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bool s = datos.ExecuteQuery("DELETE FROM clientes WHERE id=" + r);
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

        private void tsmCTabla_Click(object sender, EventArgs e)
        {

        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery + ";");

        }

        private void tsmPC_Click(object sender, EventArgs e)
        {
            if (datos.TestConnection())
            {
                MessageBox.Show("La conexion ha sido un exito","Programa",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La conexion ha fallado\nIntentalo mas tarde","Programa",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditorClientes frm =new frmEditorClientes();
            frm.Show();
        }

        private void tsmConexion_Click(object sender, EventArgs e)
        {

        }

        private void tsmCEliminar_Click(object sender, EventArgs e)
        {

        }

        private void tsmCEditar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
