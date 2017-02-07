using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.GestionElectrodomesticos
{
    public partial class ConsultarElectrodomestico : Form
    {
        public ConsultarElectrodomestico()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = false;
            txtPorNumSer.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
