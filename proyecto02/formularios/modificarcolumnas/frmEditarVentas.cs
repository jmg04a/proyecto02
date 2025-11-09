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

namespace Proyecto2.formularios.editarElementos
{
    public partial class frmEditarVentas : Form
    {
        private int id = -1;
        public frmEditarVentas()
        {
            InitializeComponent();
        }

        public frmEditarVentas(int idEditar)
        {
            InitializeComponent();
            Datos data = new Datos();

            // ¡PELIGRO! Sigue siendo vulnerable a Inyección SQL
            // 1. Cambiada la tabla a "ventas"
            DataSet ds = data.getAllData("SELECT * FROM ventas WHERE id=" + idEditar);

            // Esto fallará si el ID no existe
            DataRow row = ds.Tables[0].Rows[0];

            // 2. Asignación a los nuevos TextBox
            // (Los campos de clientes como nombre, apellido, etc., ya no aplican)
            txtEmpleado.Text = row["id_empleado"].ToString();
            txtFactura.Text = row["id_factura"].ToString();

            id = idEditar; // Guardamos el ID para el botón "Guardar"
        }

        private void label1_Click(object sender, EventArgs e)
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
                // --- LÓGICA DE INSERT ---
                // (Literal, con un try...catch general)
                try
                {
                    // ¡ADVERTENCIA! Esto es vulnerable a Inyección SQL
                    // Nota: Se quitan las comillas ' ' porque los campos son 'int'
                    string queryInsegura =
                        "INSERT INTO ventas(id_empleado, id_factura) VALUES(" +
                        txtEmpleado.Text + "," +
                        txtFactura.Text +
                        ");";

                    resultado = data.ExecuteQuery(queryInsegura);

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
                catch (Exception ex)
                {
                    // Error general si CUALQUIER campo no es un número
                    MessageBox.Show(
                        "Error de formato. Asegúrese de que todos los campos sean números.\n\n" +
                        "Error original: " + ex.Message,
                        "Error de Formato",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                // --- LÓGICA DE UPDATE ---
                // (Con validación 'try...catch' por campo, como pediste)

                int idEmpValue;
                int idFactValue;

                // --- 1. Validar Campos ---
                try
                {
                    idEmpValue = int.Parse(txtEmpleado.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El 'ID de Empleado' debe ser un número entero. Ej: 123", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }

                try
                {
                    idFactValue = int.Parse(txtFactura.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El 'ID de Factura' debe ser un número entero. Ej: 456", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }

                // --- 2. Construir la consulta (aún insegura) ---
                try
                {
                    // ¡ADVERTENCIA! Esto sigue siendo vulnerable
                    string queryInsegura =
                        "UPDATE ventas SET " +
                        "id_empleado = " + idEmpValue + ", " +
                        "id_factura = " + idFactValue + " " +
                        "WHERE id = " + id + ";"; // 'id' también es vulnerable

                    resultado = data.ExecuteQuery(queryInsegura);

                    if (resultado)
                    {
                        // Corregido el mensaje de éxito
                        MessageBox.Show("Registro actualizado", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el registro", "Sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNroDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTipoDocumento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
