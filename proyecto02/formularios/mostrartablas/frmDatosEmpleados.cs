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
    public partial class frmDatosEmpleados : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT id AS \"Id\", " +
                              "nombre AS \"Nombre\"," +
                              "apellido AS \"Apellido\"," +
                              "tipo_doc AS \"Tipo de Documento\"," +
                              "nro_doc AS \"Numero de Documento\"," +
                              "cuil AS \"CUIL\"," +
                              "direccion AS \"Direccion\","+
                              "nro_tel_princ AS \"Numero de telefono\"," +
                              "nro_tel_sec AS \"Numero de telefono (secundario)\"," +
                              "email AS \"Correo Electronico\"," +
                              "cargo AS \"Cargo\","+
                              "antiguedad AS \"Antiguedad\","+
                              "fecha_ingreso AS \"Fecha de Ingreso\"," +
                              "salario_anual AS \"Salario Anual\"" +
                              "FROM empleados";
        public frmDatosEmpleados()
        {
            InitializeComponent();
        }

        private void limpiar()
        {
            txtId.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtTipoDocumento.Text = string.Empty;
            txtNumeroDocumento.Text = string.Empty;
            txtCuil.Text = string.Empty;
            txtDireccion.Text= string.Empty;
            txtNumeroTelefono.Text = string.Empty;
            txtNumeroTelefono2.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCargo.Text=String.Empty;
            txtAntiguedad.Text=String.Empty;
            txtFechaIngreso.Text=String.Empty;
            txtSalarioAnual.Text=  String.Empty;
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
        private void frmDatosEmpleados_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery + ";");
        }

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditarEmpleados frm = new frmEditarEmpleados();
            frm.Show();
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            frmEditarEmpleados frm = new frmEditarEmpleados(Convert.ToInt32(r));
            frm.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // Asumimos que defaultQuery = "SELECT * FROM empleados"
            String buscarQuery = defaultQuery + " WHERE ";
            bool variasOpciones = false;

            // --- ID ---
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                try
                {
                    // Búsqueda exacta para ID
                    buscarQuery += " id = " + int.Parse(txtId.Text) + "";
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID solo acepta numeros", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // --- Nombre ---
            if (!string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " nombre like '%" + txtNombre.Text + "%'";
                variasOpciones = true;
            }

            // --- Apellido ---
            if (!string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " apellido like '%" + txtApellido.Text + "%'";
                variasOpciones = true;
            }

            // --- Tipo Documento ---
            if (!string.IsNullOrWhiteSpace(txtTipoDocumento.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " tipo_doc like '%" + txtTipoDocumento.Text + "%'";
                variasOpciones = true;
            }

            // --- Número Documento ---
            if (!string.IsNullOrWhiteSpace(txtNumeroDocumento.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " nro_doc like '%" + txtNumeroDocumento.Text + "%'";
                variasOpciones = true;
            }
            // --- Direccion---
            if (!string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " direccion like '%" + txtDireccion.Text + "%'";
                variasOpciones = true;
            }
            // --- Teléfono Principal ---
            if (!string.IsNullOrWhiteSpace(txtNumeroTelefono.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " nro_tel_princ like '%" + txtNumeroTelefono.Text + "%'";
                variasOpciones = true;
            }

            // --- Teléfono Secundario ---
            if (!string.IsNullOrWhiteSpace(txtNumeroTelefono2.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " nro_tel_sec like '%" + txtNumeroTelefono2.Text + "%'";
                variasOpciones = true;
            }

            // --- Antigüedad (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtAntiguedad.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                buscarQuery += " antiguedad like '%" + txtAntiguedad.Text + "%'";
                variasOpciones = true;
            }

            // --- Fecha Ingreso (date) ---
            if (!string.IsNullOrWhiteSpace(txtFechaIngreso.Text))
            {
                if (variasOpciones)
                {
                    buscarQuery += " AND ";
                }
                // Para que 'LIKE' funcione en un campo de fecha, hay que convertirlo a texto.
                // Esto te permite buscar por año (ej: "2024") o mes (ej: "-05-")
                buscarQuery += " CAST(fecha_ingreso AS TEXT) like '%" + txtFechaIngreso.Text + "%'";
                variasOpciones = true;
            }

            // --- Salario Anual (decimal) ---
            if (!string.IsNullOrWhiteSpace(txtSalarioAnual.Text))
            {
                try
                {
                    if (variasOpciones)
                    {
                        buscarQuery += " AND ";
                    }

                    // Convertimos el texto a decimal.
                    decimal salario = decimal.Parse(txtSalarioAnual.Text);

                    // Aseguramos que use '.' como separador decimal para SQL
                    // (Esto evita problemas si tu Windows usa ',' como separador)
                    string salarioSql = salario.ToString(System.Globalization.CultureInfo.InvariantCulture);

                    // Es más útil buscar "mayor o igual que" para un salario
                    buscarQuery += " salario_anual >= " + salarioSql;
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El Salario Anual solo acepta numeros válidos", "Programa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Detener
                }
            }

            // --- Ejecución final de la consulta ---
            if (variasOpciones)
            {
                mostrarDatos(buscarQuery + ";");
            }
            else
            {
                // Si no se llenó ningún campo, muestra todo
                mostrarDatos(defaultQuery + ";");
            }
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery + ";");
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
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
                bool s = datos.ExecuteQuery("DELETE FROM empleados WHERE id=" + r);
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
