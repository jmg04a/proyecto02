using Proyecto2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using proyecto02.formularios.mostrartablas;

namespace proyecto02
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDatosClientes frm = new frmDatosClientes();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDatosComprasClientes frm = new frmDatosComprasClientes();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmDatosEmpleados frm = new frmDatosEmpleados();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmDatosFacturas frm = new frmDatosFacturas();
            frm.Show();
        }
    }
}
