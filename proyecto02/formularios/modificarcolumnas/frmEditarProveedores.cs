using ImageMagick;
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
    public partial class frmEditarProveedores : Form
    {
        private int id = -1;
        public frmEditarProveedores()
        {
            InitializeComponent();
        }
        public frmEditarProveedores(int idEditar)
        {
            InitializeComponent();
            Datos data = new Datos();

            // ¡PELIGRO! Sigue siendo vulnerable a Inyección SQL
            // 1. Cambiada la tabla a "proveedores"
            DataSet ds = data.getAllData("SELECT * FROM proveedores WHERE id=" + idEditar);

            // Esto fallará si el ID no existe
            DataRow row = ds.Tables[0].Rows[0];

            // 2. Asignación a los nuevos TextBox
            txtEmpresa.Text = row["empresa"].ToString();
            txtProducto.Text = row["tipo_producto"].ToString();
            txtDireccion.Text = row["direccion"].ToString();
            txtTelefono.Text = row["nro_tel_princ"].ToString();
            txtTelefono2.Text = row["nro_tel_sec"].ToString();
            txtEmail.Text = row["email"].ToString();

            id = idEditar; // Guardamos el ID para el botón "Guardar"
        }
        private void label3_Click(object sender, EventArgs e)
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

            if (id == -1)
            {
                // --- INSERT ---
                // ¡ADVERTENCIA! Este código es vulnerable a Inyección SQL
                resultado = data.ExecuteQuery(
                    "INSERT INTO proveedores(empresa, tipo_producto, direccion, nro_tel_princ, nro_tel_sec, email) VALUES ('" +
                    txtEmpresa.Text + "','" +
                    txtProducto.Text + "','" +
                    txtDireccion.Text + "','" +
                    txtTelefono.Text + "','" +
                    txtTelefono2.Text + "','" +
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
                // --- UPDATE ---
                // ¡ADVERTENCIA! Este código es vulnerable a Inyección SQL
                resultado = data.ExecuteQuery(
                    "UPDATE proveedores SET empresa='" + txtEmpresa.Text +
                    "',tipo_producto= '" + txtProducto.Text +
                    "',direccion= '" + txtDireccion.Text +
                    "',nro_tel_princ= '" + txtTelefono.Text +
                    "',nro_tel_sec= '" + txtTelefono2.Text +
                    "',email= '" + txtEmail.Text + "' WHERE id =" + id + ";"
                );

                if (resultado)
                {
                    // (Nota: Tu mensaje original dice "agregado" aquí también)
                    MessageBox.Show("Registro agregado", "Sistema", // Debería ser "Registro actualizado"
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Sistema", // Debería ser "Error al actualizar"
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }
    }
}
