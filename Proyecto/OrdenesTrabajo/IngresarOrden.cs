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
    public partial class IngresarOrden : Form
    {
        public IngresarOrden()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cliente.SeleccionarCliente().Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.SeleccionarElectrodomestico().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.IngresarCompra().Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
