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
    public partial class frmEditarVentasProductos : Form
    {
        private int id = -1;
        public frmEditarVentasProductos()
        {
            InitializeComponent();
        }
        public frmEditarVentasProductos(int idEditar)
        {
            InitializeComponent();
            Datos data = new Datos();

            // ¡PELIGRO! Sigue siendo vulnerable a Inyección SQL
            // 1. Cambiada la tabla a "ventas_productos"
            DataSet ds = data.getAllData("SELECT * FROM ventas_productos WHERE id=" + idEditar);

            // Esto fallará si el ID no existe
            DataRow row = ds.Tables[0].Rows[0];

            // 2. Asignación a los nuevos TextBox
            txtIdVenta.Text = row["id_venta"].ToString();
            txtIdProducto.Text = row["id_producto"].ToString();
            txtCantidad.Text = row["cantidad"].ToString();

            id = idEditar; // Guardamos el ID para el botón "Guardar"
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarVentasProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void txtIdProducto_TextChanged(object sender, EventArgs e)
        {

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
                        "INSERT INTO ventas_productos(id_venta, id_producto, cantidad) VALUES(" +
                        txtIdVenta.Text + "," +
                        txtIdProducto.Text + "," +
                        txtCantidad.Text +
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

                int idVentaValue;
                int idProdValue;
                int cantValue;

                // --- 1. Validar Campos ---
                try
                {
                    idVentaValue = int.Parse(txtIdVenta.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El 'ID de Venta' debe ser un número entero. Ej: 123", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }

                try
                {
                    idProdValue = int.Parse(txtIdProducto.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El 'ID de Producto' debe ser un número entero. Ej: 456", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }

                try
                {
                    cantValue = int.Parse(txtCantidad.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La 'Cantidad' debe ser un número entero. Ej: 10", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }


                // --- 2. Construir la consulta (aún insegura) ---
                try
                {
                    // ¡ADVERTENCIA! Esto sigue siendo vulnerable
                    string queryInsegura =
                        "UPDATE ventas_productos SET " +
                        "id_venta = " + idVentaValue + ", " +
                        "id_producto = " + idProdValue + ", " +
                        "cantidad = " + cantValue + " " +
                        "WHERE id = " + id + ";"; // 'id' también es vulnerable

                    resultado = data.ExecuteQuery(queryInsegura);

                    if (resultado)
                    {
                        // Corregido el mensaje de éxito (tu original decía "agregado")
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
    }
}
