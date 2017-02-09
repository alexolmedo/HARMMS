using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.OrdenesTrabajo
{
    public partial class BuscarOrdenM : Form
    {
        public BuscarOrdenM()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ModificarOrdenD().ShowDialog();
        }

        private void radioButNumOT_CheckedChanged(object sender, EventArgs e)
        {
            textBoxCI.ReadOnly = true;
            textBoxNumOT.ReadOnly = false;
        }

        private void radioButCI_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumOT.ReadOnly = true;
            textBoxCI.ReadOnly = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
