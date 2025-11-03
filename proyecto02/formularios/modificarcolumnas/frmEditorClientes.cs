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

namespace Proyecto2
{
    public partial class frmEditorClientes : Form
    {
        int id=-1;
        public frmEditorClientes()
        {
            InitializeComponent();

        }

        public frmEditorClientes(int idEditar)
        {
            InitializeComponent(); 
            Datos data = new Datos();
            DataSet ds = data.getAllData("SELECT * FROM clientes WHERE id=" + idEditar);
            txtNombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
            txtApellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
            txtTipoDocumento.Text = ds.Tables[0].Rows[0]["tipo_doc"].ToString();
            txtNumeroDocumento.Text = ds.Tables[0].Rows[0]["nro_doc"].ToString();
            txtNumeroTelefono.Text = ds.Tables[0].Rows[0]["nro_tel_princ"].ToString();
            txtNumeroTelefono2.Text = ds.Tables[0].Rows[0]["nro_tel_sec"].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0]["email"].ToString();
            id = idEditar;
        }

        private void frmEditorClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado;
            Datos data = new Datos();

            if (id == -1)
            {     
                resultado = data.ExecuteQuery(
                    "INSERT INTO clientes(nombre,apellido,tipo_doc,nro_doc,nro_tel_princ,nro_tel_sec,email)Values('" +
                    txtNombre.Text + "','" +
                    txtApellido.Text + "','" +
                    txtTipoDocumento.Text + "','" +
                    txtNumeroDocumento.Text + "','" +
                    txtNumeroTelefono.Text + "','" +
                    txtNumeroTelefono2.Text + "','" +
                    txtEmail.Text +
                    "');"
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
                    "UPDATE clientes SET nombre='" + txtNombre.Text +
                    "',apellido= '" + txtApellido.Text +
                    "',tipo_doc= '" + txtTipoDocumento.Text +
                    "',nro_doc= '" + txtNumeroDocumento.Text +
                    "',nro_tel_princ= '" + txtNumeroTelefono.Text +
                    "',nro_tel_sec= '" + txtNumeroTelefono2.Text +
                    "',email= '" + txtEmail.Text + "' WHERE id ="+id+";"
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
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
