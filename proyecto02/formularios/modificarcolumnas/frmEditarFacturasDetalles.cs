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
    public partial class frmEditarFacturasDetalles : Form
    {
        public frmEditarFacturasDetalles()
        {
            InitializeComponent();
        }

        // --- Versión Literal (INSEGURA y con mal formato) ---

        int id=-1; // Variable para guardar el ID

        public frmEditarFacturasDetalles(int idEditar)
        {
            InitializeComponent();
            Datos data = new Datos();

            // ¡PELIGRO! Sigue siendo vulnerable a Inyección SQL
            DataSet ds = data.getAllData("SELECT * FROM facturas_detalles WHERE id=" + idEditar);

            // Esto fallará si el ID no existe
            DataRow row = ds.Tables[0].Rows[0];

            // Asignación directa a los TextBox
            txtIdFactura.Text = row["id_factura"].ToString();
            txtTipo.Text = row["tipo"].ToString();
            txtDescripcionFactura.Text = row["descr_factura"].ToString();

            // ¡PROBLEMA DE FORMATO!
            // Si el costo es 12.50, .ToString() puede mostrar "12.5"
            txtCostoAsociado.Text = row["costo_asoc"].ToString();

            // ¡PROBLEMA DE FORMATO!
            // Si el IVA es 21.00, .ToString() puede mostrar "21"
            txtIva.Text = row["iva"].ToString();

            txtMedioPago.Text = row["medio_de_pago"].ToString();
            txtDescripcionPago.Text = row["descr_pago"].ToString();

            id = idEditar; // Guardamos el ID para el botón "Guardar"
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = -1;
            bool resultado;
            Datos data = new Datos();

            if (id == -1)
            {
                // --- LÓGICA DE INSERT ---
                // (Literal, sin validación previa, con un try...catch general)
                try
                {
                    // NOTA: 'id_factura', 'costo_asoc', 'iva' van SIN comillas ' '
                    // Los .Replace(",",".") son un "parche" para que no falle si el 
                    // usuario escribe comas, pero sigue siendo muy frágil.
                    string queryInsegura =
                        "INSERT INTO facturas_detalles(id_factura, tipo, descr_factura, costo_asoc, iva, medio_de_pago, descr_pago) " +
                        "VALUES(" +
                        txtIdFactura.Text + ", '" +                      // int (sin comillas)
                        txtTipo.Text + "', '" +                          // varchar (con comillas)
                        txtDescripcionFactura.Text + "', " +                   // varchar (con comillas)
                        txtCostoAsociado.Text.Replace(",", ".") + ", " +     // decimal (sin comillas)
                        txtIva.Text.Replace(",", ".") + ", '" +          // decimal (sin comillas)
                        txtMedioPago.Text + "', '" +                   // varchar (con comillas)
                        txtDescripcionPago.Text + "'" +                        // varchar (con comillas)
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
                    // ERROR GENERAL: No podemos saber si falló el int, el decimal o la fecha.
                    MessageBox.Show(
                        "Error de formato en uno de los campos.\n\n" +
                        "Asegúrese de que:\n" +
                        "- ID Factura sea un número.\n" +
                        "- Costo e IVA usen punto (ej. 123.45).\n\n" +
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

                int idFacturaValue;
                decimal costoAsocValue;
                decimal ivaValue;

                // --- 1. Validar Campos ---
                try
                {
                    idFacturaValue = int.Parse(txtIdFactura.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El 'ID de Factura' debe ser un número entero. Ej: 123", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }

                try
                {
                    costoAsocValue = decimal.Parse(txtCostoAsociado.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El 'Costo Asociado' no es válido. Use punto decimal. Ej: 123.45", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }

                try
                {
                    ivaValue = decimal.Parse(txtIva.Text, System.Globalization.CultureInfo.InvariantCulture);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El 'IVA' no es válido. Use punto decimal. Ej: 123.45", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }

                // --- 2. Construir la consulta (aún insegura para los campos de texto) ---
                try
                {
                    string queryInsegura =
                        "UPDATE facturas_detalles SET " +
                        "id_factura = " + idFacturaValue + ", " +                                       // int (sin comillas)
                        "tipo = '" + txtTipo.Text + "', " +                                            // varchar (con comillas)
                        "descr_factura = '" + txtDescripcionFactura.Text + "', " +                           // varchar (con comillas)
                        "costo_asoc = " + costoAsocValue.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", " + // decimal (sin comillas)
                        "iva = " + ivaValue.ToString(System.Globalization.CultureInfo.InvariantCulture) + ", " +          // decimal (sin comillas)
                        "medio_de_pago = '" + txtMedioPago.Text + "', " +                            // varchar (con comillas)
                        "descr_pago = '" + txtDescripcionPago.Text + "' " +                                  // varchar (con comillas)
                        "WHERE id = " + id + ";";

                    resultado = data.ExecuteQuery(queryInsegura);

                    if (resultado)
                    {
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
                    // Captura errores de la base de datos (ej. Inyección SQL en un campo de texto)
                    MessageBox.Show("Error de base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarFacturasDetalles_Load(object sender, EventArgs e)
        {

        }
    }
}
