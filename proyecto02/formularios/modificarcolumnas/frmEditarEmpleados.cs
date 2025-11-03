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
    public partial class frmEditarEmpleados : Form
    {
        int id=-1;
        public frmEditarEmpleados()
        {
            InitializeComponent();
        }
        public frmEditarEmpleados(int idEditar)
        {
            InitializeComponent();
            Datos data = new Datos();

            // 1. (ADVERTENCIA: Esto sigue siendo vulnerable a Inyección SQL)
            DataSet ds = data.getAllData("SELECT * FROM empleados WHERE id=" + idEditar);

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                DataRow fila = ds.Tables[0].Rows[0];

                // --- Asignaciones Correctas ---
                txtNombre.Text = fila["nombre"].ToString();
                txtApellido.Text = fila["apellido"].ToString();
                txtEdad.Text = fila["edad"].ToString();
                txtTipoDocumento.Text = fila["tipo_doc"].ToString();
                txtNroDocumento.Text = fila["nro_doc"].ToString();
                txtAntiguedad.Text = fila["antiguedad"].ToString();
                txtSalarioAnual.Text = fila["salario_anual"].ToString();
                txtNumeroTelefono.Text = fila["nro_tel_princ"].ToString();
                txtCargo.Text = fila["cargo"].ToString();
                txtCuil.Text = fila["cuil"].ToString();
                txtDireccion.Text = fila["direccion"].ToString(); // (Asumiendo que tienes txtDireccion)

                // --- Fechas con formato ---
                txtFechaNacimiento.Text = ((DateTime)fila["fecha_nac"]).ToString("dd/MM/yyyy");
                txtFechaIngreso.Text = ((DateTime)fila["fecha_ingreso"]).ToString("dd/MM/yyyy");

                // --- Campos NULABLES (Manejo de DBNull) ---

                // Email
                txtEmail.Text = fila["email"] == DBNull.Value ? "" : fila["email"].ToString();

                // Teléfono Secundario
                txtNumeroTelefono2.Text = fila["nro_tel_sec"] == DBNull.Value ? "" : fila["nro_tel_sec"].ToString();

                id = idEditar;
            }
            else
            {
                MessageBox.Show("No se encontró el empleado con ID: " + idEditar, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void frmEditarEmpleados_Load(object sender, EventArgs e)
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

            // --- 1. PREPARACIÓN DE DATOS (OBLIGATORIO) ---
            // Necesitamos convertir los campos que NO son texto
            // Esto es muy frágil. Si el usuario deja 'txtEdad' vacío, esto crasheará.

            string edadSql, salarioSql, fechaNacSql, fechaIngresoSql;
            string emailSql, telSecSql; // Para manejar valores NULL

            try
            {
                // --- Campos Numéricos (int, decimal) ---
                // (Asumimos que los campos NOT NULL como 'edad' siempre se llenan)
                edadSql = int.Parse(txtEdad.Text).ToString();

                // El salario debe usar '.' (punto) como separador decimal para SQL
                salarioSql = decimal.Parse(txtSalarioAnual.Text).ToString(System.Globalization.CultureInfo.InvariantCulture);

                // --- Campos de Fecha (date) ---
                // Asumimos formato dd/MM/yyyy y lo convertimos a yyyy-MM-dd para SQL
                DateTime fechaNac = DateTime.ParseExact(txtFechaNacimiento.Text, "dd/MM/yyyy", null);
                fechaNacSql = "'" + fechaNac.ToString("yyyy-MM-dd") + "'"; // Las fechas SÍ llevan comillas

                DateTime fechaIngreso = DateTime.ParseExact(txtFechaIngreso.Text, "dd/MM/yyyy", null);
                fechaIngresoSql = "'" + fechaIngreso.ToString("yyyy-MM-dd") + "'";
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Error de formato. Asegúrate de que los campos de edad, salario y fechas (dd/MM/yyyy) no estén vacíos y sean correctos.", "Error de Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Detener la ejecución
            }

            // --- Campos Opcionales (que pueden ser NULL) ---
            // (nro_tel_sec y email)
            telSecSql = string.IsNullOrWhiteSpace(txtNumeroTelefono2.Text) ? "NULL" : "'" + txtNumeroTelefono2.Text + "'";
            emailSql = string.IsNullOrWhiteSpace(txtEmail.Text) ? "NULL" : "'" + txtEmail.Text + "'";


            // --- 2. LÓGICA DE INSERT/UPDATE ---

            if (id == -1)
            {
                // --- INSERTAR ---
                // (Vulnerable a Inyección SQL)
                string queryInsert = "INSERT INTO empleados(" +
                    "nombre, apellido, edad, fecha_nac, tipo_doc, nro_doc, cuil, direccion, " +
                    "nro_tel_princ, nro_tel_sec, email, cargo, antiguedad, fecha_ingreso, salario_anual" +
                    ") VALUES(" +
                    "'" + txtNombre.Text + "'," +
                    "'" + txtApellido.Text + "'," +
                    edadSql + "," +           // Numérico (sin comillas)
                    fechaNacSql + "," +       // Fecha (con comillas)
                    "'" + txtTipoDocumento.Text + "'," +
                    "'" + txtNroDocumento.Text + "'," +
                    "'" + txtCuil.Text + "'," +
                    "'" + txtEmail.Text + "'," +
                    "'" + txtNumeroTelefono.Text + "'," +
                    telSecSql + "," +         // Maneja NULL
                    emailSql + "," +          // Maneja NULL
                    "'" + txtCargo.Text + "'," +
                    "'" + txtAntiguedad.Text + "'," +
                    fechaIngresoSql + "," +   // Fecha (con comillas)
                    salarioSql +              // Numérico (sin comillas)
                    ");";

                resultado = data.ExecuteQuery(queryInsert);

                if (resultado)
                {
                    MessageBox.Show("Registro agregado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al agregar el registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // --- ACTUALIZAR ---
                // (Vulnerable a Inyección SQL)
                string queryUpdate = "UPDATE empleados SET " +
                    "nombre='" + txtNombre.Text + "'," +
                    "apellido='" + txtApellido.Text + "'," +
                    "edad=" + edadSql + "," +
                    "fecha_nac=" + fechaNacSql + "," +
                    "tipo_doc='" + txtTipoDocumento.Text + "'," +
                    "nro_doc='" + txtNroDocumento.Text + "'," +
                    "cuil='" + txtCuil.Text + "'," +
                    "direccion='" + txtEmail.Text + "'," +
                    "nro_tel_princ='" + txtNumeroTelefono.Text + "'," +
                    "nro_tel_sec=" + telSecSql + "," +
                    "email=" + emailSql + "," +
                    "cargo='" + txtCargo.Text + "'," +
                    "antiguedad='" + txtAntiguedad.Text + "'," +
                    "fecha_ingreso=" + fechaIngresoSql + "," +
                    "salario_anual=" + salarioSql + " " +
                    "WHERE id=" + id.ToString() + ";"; // El ID actual que se está editando

                resultado = data.ExecuteQuery(queryUpdate);

                if (resultado)
                {
                    MessageBox.Show("Registro actualizado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al actualizar el registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
