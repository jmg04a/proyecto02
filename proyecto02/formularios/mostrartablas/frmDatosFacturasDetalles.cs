using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto2.formularios;

namespace proyecto02.formularios.mostrartablas
{
    public partial class frmDatosFacturasDetalles : Form
    {
        Datos datos = new Datos();
        string defaultQuery = "SELECT id " +
                              "AS  \"Id\", nombre AS \"Nombre\"," +
                              "apellido AS \"Apellido\"," +
                              "tipo_doc AS \"Tipo de Documento\"," +
                              "nro_doc AS \"Numero de Documento\"," +
                              "nro_tel_princ AS \"Numero de telefono\"," +
                              "nro_tel_sec AS \"Numero de telefono (secundario)\"," +
                              "email AS \"Correo Electronico\" FROM clientes";
        public frmDatosFacturasDetalles()
        {
            InitializeComponent();
        }b

        private void tslAgregarForm_Click(object sender, EventArgs e)
        {
            frmEditarFacturasDetalles frm = new frmEditarFacturasDetalles();
            frm.Show();
        }

        private void tsmReiniciar_Click(object sender, EventArgs e)
        {

        }
    }
}
