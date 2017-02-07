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
    public partial class ConsultarCliente : Form
    {
        public ConsultarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtCedula.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
            txtCedula.ReadOnly = false;
        }
    }
}
