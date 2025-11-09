using Octubre.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageMagick;
using ImageMagick.Drawing;


namespace Proyecto2.formularios
{
    public partial class frmEditorProductos : Form
    {
        int id = -1;
        public frmEditorProductos()
        {
            InitializeComponent();
        }
        public frmEditorProductos(int idEditar) // Cambiado el nombre del formulario
        {
            InitializeComponent();
            Datos data = new Datos();

            // ¡PELIGRO! Sigue siendo vulnerable a Inyección SQL
            DataSet ds = data.getAllData("SELECT * FROM productos WHERE id=" + idEditar);

            // Esto fallará si el ID no existe
            DataRow row = ds.Tables[0].Rows[0];

            // Asignación directa a los TextBox
            txtIdProveedor.Text = row["id_proveedor"].ToString();
            txtCodigo.Text = row["codigo"].ToString();
            txtImagen.Text = row["imagen"].ToString(); // (si tienes un textbox para esto)
            txtNombre.Text = row["nombre"].ToString();
            txtMarca.Text = row["marca"].ToString();
            txtTipo.Text = row["tipo"].ToString();
            txtGrupo.Text = row["grupo"].ToString();

            // ¡PROBLEMA DE FORMATO!
            // Tu DDL dice decimal(8,3). Si el peso es 1.500, .ToString() mostrará "1.5"
            txtPeso.Text = row["peso"].ToString();

            // ¡PROBLEMA DE FORMATO!
            // Si el precio es 120.000, .ToString() mostrará "120"
            txtPrecio.Text = row["precio_unidad"].ToString();

            txtStock.Text = row["stock"].ToString();

            id = idEditar; // Guardamos el ID para el botón "Guardar"
        }

        private void frmEditorProductos_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtImagen_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button3_Click(object sender, EventArgs e)
        {
            string url = txtImagen.Text;

            using (HttpClient cliente = new HttpClient())
            {
                try
                {
                    byte[] bytesImagen = await cliente.GetByteArrayAsync(url);

                    // Leemos los bytes
                    using (var image = new MagickImage(bytesImagen))
                    {
                        // EL ATAJO: Magick.NET lo convierte a Bitmap por ti
                        pictureBox1.Image?.Dispose();
                        pictureBox1.Image = image.ToBitmap(); // ¡Mucho más simple!
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    
}
