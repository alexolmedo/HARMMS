using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Cliente
{
    public partial class DeshabilitarCliente : Form
    {
        public DeshabilitarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Confirma eliminar cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }
    }
}
