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
    public partial class ModificarCompra : Form
    {
        public ModificarCompra()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = false;
            txtPorNumSer.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModeloR.ReadOnly = false;
            txtPorNumSerR.ReadOnly = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModeloR.ReadOnly = true;
            txtPorNumSerR.ReadOnly = false;
        }

    }
}
