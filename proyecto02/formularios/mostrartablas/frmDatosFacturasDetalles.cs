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
    public partial class frmDatosFacturasDetalles : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT " +
            "id AS  \"Id\", " +
            "id_factura AS \"Nombre\"," +
                              "tipo AS \"Tipo\"," +
                              "descr_factura AS \"Descripcion de la Factura\"," +
                              "costo_asoc AS \"Costo Asociado\"," +
                              "iva AS \"Iva\"," +
                              "medio_de_pago AS \"Medio de pago\"," +
                              "descr_pago AS \"Descripcion de pago\" " +
            "FROM facturas_detalles";
        public frmDatosFacturasDetalles()
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
            txtIdFactura.Text = string.Empty;
            txtTipo.Text = string.Empty;
            txtDescripcionFactura.Text = string.Empty;
            txtCostoAsociado.Text = string.Empty;
            txtIva.Text = string.Empty;
            txtMedioPago.Text = string.Empty;
            txtDescripcionPago.Text = string.Empty;
        }

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditarFacturasDetalles frm = new frmEditarFacturasDetalles();
            frm.Show();
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {
            limpiar();
            mostrarDatos(defaultQuery);
        }

        private void frmDatosFacturasDetalles_Load(object sender, EventArgs e)
        {
            mostrarDatos(defaultQuery + ";");
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // 1. Definimos la consulta base para la nueva tabla
            String buscarQuery = defaultQuery + " WHERE ";
            bool variasOpciones = false;

            // --- ID (int) ---
            if (!string.IsNullOrWhiteSpace(txtId.Text))
            {
                try
                {
                    int idValue = int.Parse(txtId.Text);
                    buscarQuery += " id = " + idValue;
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID solo acepta números enteros.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- ID_Factura (int) ---
            if (!string.IsNullOrWhiteSpace(txtIdFactura.Text))
            {
                try
                {
                    int idFacturaValue = int.Parse(txtIdFactura.Text);
                    if (variasOpciones) { buscarQuery += " AND "; }
                    buscarQuery += " id_factura = " + idFacturaValue;
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El ID de Factura solo acepta números enteros.", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- Tipo (enum como varchar) ---
            if (!string.IsNullOrWhiteSpace(txtTipo.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                // (Inseguro) Usamos CAST a TEXT y UPPER para buscar en el ENUM de PostgreSQL
                buscarQuery += " tipo::text LIKE '%" + txtTipo.Text.ToUpper() + "%'";
                variasOpciones = true;
            }

            // --- Descr_Factura (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtDescripcionFactura.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                // (Inseguro)
                buscarQuery += " descr_factura LIKE '%" + txtDescripcionFactura.Text + "%'";
                variasOpciones = true;
            }

            // --- Costo_Asoc (decimal) ---
            if (!string.IsNullOrWhiteSpace(txtCostoAsociado.Text))
            {
                try
                {
                    decimal costoValue = decimal.Parse(txtCostoAsociado.Text, System.Globalization.CultureInfo.InvariantCulture);
                    if (variasOpciones) { buscarQuery += " AND "; }
                    buscarQuery += " costo_asoc = " + costoValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El formato del Costo Asociado no es válido. Use 123.45 (con punto).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- IVA (decimal) ---
            if (!string.IsNullOrWhiteSpace(txtIva.Text))
            {
                try
                {
                    decimal ivaValue = decimal.Parse(txtIva.Text, System.Globalization.CultureInfo.InvariantCulture);
                    if (variasOpciones) { buscarQuery += " AND "; }
                    buscarQuery += " iva = " + ivaValue.ToString(System.Globalization.CultureInfo.InvariantCulture);
                    variasOpciones = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El formato del IVA no es válido. Use 123.45 (con punto).", "Error de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // --- Medio_De_Pago (enum como varchar) ---
            if (!string.IsNullOrWhiteSpace(txtMedioPago.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                // (Inseguro) Usamos CAST a TEXT y UPPER para buscar en el ENUM de PostgreSQL
                // (Ej. 'TARJETA' encontrará 'TARJETA CREDITO' y 'TARJETA DEBITO')
                buscarQuery += " medio_de_pago::text LIKE '%" + txtMedioPago.Text.ToUpper() + "%'";
                variasOpciones = true;
            }

            // --- Descr_Pago (varchar) ---
            if (!string.IsNullOrWhiteSpace(txtDescripcionPago.Text))
            {
                if (variasOpciones) { buscarQuery += " AND "; }
                // (Inseguro)
                buscarQuery += " descr_pago LIKE '%" + txtDescripcionPago.Text + "%'";
                variasOpciones = true;
            }


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

        private void toolStripEliminar_Click(object sender, EventArgs e)
        {
            // --- Versión Literal (INSEGURA) ---

            // Asumimos que la columna 0 (índice 0) de tu dgvDatos es el 'id'
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();

            if (MessageBox.Show("Deseas Eliminar el Registro", "Sistema",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // CAMBIO: de "clientes" a "facturas_detalles"
                // ¡ADVERTENCIA! Esta línea sigue siendo vulnerable a Inyección SQL.
                bool s = datos.ExecuteQuery("DELETE FROM facturas_detalles WHERE id=" + r);

                if (s)
                {
                    MessageBox.Show("Registro Eliminado", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Asegúrate de que 'defaultQuery' ahora apunte a 'facturas_detalles'
                    mostrarDatos(defaultQuery + ";");
                }
                else
                {
                    MessageBox.Show("Error al Eliminar el Registro", "Sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void toolStripEditar_Click(object sender, EventArgs e)
        {
            string r = dgvDatos[0, dgvDatos.CurrentCell.RowIndex].Value.ToString();
            frmEditarFacturasDetalles frm = new frmEditarFacturasDetalles(Convert.ToInt32(r));
            frm.ShowDialog();
        }
    }
}
