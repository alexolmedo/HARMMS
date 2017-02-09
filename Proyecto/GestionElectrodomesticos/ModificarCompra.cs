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
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButModelo_CheckedChanged(object sender, EventArgs e)
        {
            txtPorNumSer.ReadOnly = true;
            txtPorModelo.ReadOnly = false;
        }

        private void radioButNumSerie_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
        }



    }
}
