using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{
    public partial class VentanaModulos : Form
    {
        public VentanaModulos()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void insertarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().Show();
        }

        private void VentanaModulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
