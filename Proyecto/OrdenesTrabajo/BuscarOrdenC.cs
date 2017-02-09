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
    public partial class BuscarOrdenC : Form
    {
        public BuscarOrdenC()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ConsultarOrdenD().ShowDialog();
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

    }
}
