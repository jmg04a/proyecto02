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

namespace proyecto02.formularios.mostrartablas
{
    public partial class frmDatosVentas : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT " +
                              "id AS \"Id\"," +
                              "id_empleado AS \"Id del Empleado\"," +
                              "id_factura AS \"Id de la Factura\""+
                              "FROM ventas";
        public frmDatosVentas()
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
            txtEmpleado.Text = string.Empty;
            txtFactura.Text = string.Empty;
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmConexion_Click(object sender, EventArgs e)
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

        private void tsmPC_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery + ";");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // (Asegúrate de que 'defaultQuery' ahora sea "SELECT * FROM ventas")
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

            // --- ID_Empleado (int) ---
            // (Reemplaza la lógica de txtNombre, txtApellido, etc.)
            if (!string.IsNullOrWhiteSpace(txtEmpleado.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }

                // Usamos la misma lógica 'try-catch' porque es un 'int'
                try
                {
                    buscarQuery += " id_empleado = " + int.Parse(txtEmpleado.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID de Empleado solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // --- ID_Factura (int) ---
            if (!string.IsNullOrWhiteSpace(txtFactura.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }

                try
                {
                    buscarQuery += " id_factura = " + int.Parse(txtFactura.Text);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID de Factura solo acepta números.", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // (El resto de 'if' de txtApellido, txtTipoDocumento, etc. no aplican)

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

        private void frmDatosVentas_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery+";");
        }
    }
}
