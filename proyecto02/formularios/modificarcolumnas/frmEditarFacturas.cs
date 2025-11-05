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
    public partial class frmEditarFacturas : Form
    {
        private int id = -1;

        public frmEditarFacturas()
        {
            InitializeComponent();
        }

        public frmEditarFacturas(int idEditar)
        {
            InitializeComponent();
            Datos data = new Datos();

            // Vulnerabilidad (menor, pero mala práctica)
            DataSet ds = data.getAllData("SELECT * FROM TuNuevaTabla WHERE id=" + idEditar);

            // Esto puede fallar si el ID no existe
            DataRow row = ds.Tables[0].Rows[0];

            // Los .ToString() directos pueden dar formatos no deseados
            // ej. la fecha podría salir como "07/10/2025 12:00:00 a.m."
            // ej. el importe podría salir como "150.4" (en lugar de 150.40)
            txtNumero.Text = row["numero"].ToString();
            txtCodigo.Text = row["codigo"].ToString();
            txtFecha.Text = row["fecha"].ToString();
            txtHora.Text = row["hora"].ToString();
            txtImporteTotal.Text = row["importe_total"].ToString();

            id = idEditar;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos data = new Datos();
            string queryInsegura;
            bool resultado;

            // --- 1. Declarar variables para guardar los valores convertidos ---
            string numero, codigo;
            DateTime fechaValue;
            TimeSpan horaValue;
            decimal importeValue;

            // --- 2. Validación de Campos ---
            // (Los strings 'varchar' no necesitan 'try-catch', solo 'Parse')

            numero = txtNumero.Text; // Asumimos que estos no pueden fallar
            codigo = txtCodigo.Text; // (Aunque aún son inseguros)

            // --- Validar Fecha ---
            try
            {
                // Intentamos convertir el texto a una fecha real
                fechaValue = DateTime.Parse(txtFecha.Text);
            }
            catch (Exception ex)
            {
                // ¡Éxito! Capturamos el error solo de la fecha.
                MessageBox.Show(
                    "El formato de la FECHA no es válido.\n\n" +
                    "Ejemplo de formato soportado: '2025-10-07'",
                    "Error de Formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Detiene la ejecución, no continúa
            }

            // --- Validar Hora ---
            try
            {
                // Intentamos convertir el texto a una hora real
                horaValue = TimeSpan.Parse(txtHora.Text);
            }
            catch (Exception ex)
            {
                // ¡Éxito! Capturamos el error solo de la hora.
                MessageBox.Show(
                    "El formato de la HORA no es válido.\n\n" +
                    "Ejemplo de formato soportado: '14:30:00'",
                    "Error de Formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Detiene la ejecución
            }

            // --- Validar Importe ---
            try
            {
                // Intentamos convertir el texto a un decimal real
                // (Usamos CultureInfo.InvariantCulture para asegurar que acepte '.' como decimal)
                importeValue = decimal.Parse(txtImporteTotal.Text, System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                // ¡Éxito! Capturamos el error solo del importe.
                MessageBox.Show(
                    "El formato del IMPORTE TOTAL no es válido.\n\n" +
                    "Ejemplo de formato soportado: '123.45' (use punto, no coma).",
                    "Error de Formato",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return; // Detiene la ejecución
            }

            // --- 3. Si todas las validaciones pasan, construimos la consulta ---
            // (Nota: formateamos los valores para que SQL los entienda)
            if (id == -1)
            {
                // INSERT
                queryInsegura =
                    "INSERT INTO facturas(numero, codigo, fecha, hora, importe_total) VALUES ('" +
                    numero + "', '" +                  // Aún inseguro
                    codigo + "', '" +                  // Aún inseguro
                    fechaValue.ToString("yyyy-MM-dd") + "', '" + // Formato correcto
                    horaValue.ToString(@"hh\:mm\:ss") + "', " + // Formato correcto
                    importeValue.ToString(System.Globalization.CultureInfo.InvariantCulture) + // Formato correcto
                    ");";
            }
            else
            {
                // UPDATE
                queryInsegura =
                    "UPDATE facturas SET " +
                    "numero = '" + numero + "', " +                // Aún inseguro
                    "codigo = '" + codigo + "', " +                // Aún inseguro
                    "fecha = '" + fechaValue.ToString("yyyy-MM-dd") + "', " +
                    "hora = '" + horaValue.ToString(@"hh\:mm\:ss") + "', " +
                    "importe_total = " + importeValue.ToString(System.Globalization.CultureInfo.InvariantCulture) + " " +
                    "WHERE id = " + id + ";";
            }

            // --- 4. Ejecutar la consulta ---
            // (Esto ya no debería fallar por formato, pero lo dejamos por si acaso)
            try
            {
                resultado = data.ExecuteQuery(queryInsegura);
                if (resultado)
                {
                    string mensaje = (id == -1) ? "Registro agregado" : "Registro actualizado";
                    MessageBox.Show(mensaje, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // ... (resto de tus mensajes)
            }
            catch (Exception ex)
            {
                // Error inesperado (ej. se cayó la conexión)
                MessageBox.Show("Error inesperado al ejecutar la consulta: " + ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
