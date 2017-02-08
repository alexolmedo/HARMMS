using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Facturacion
{
    public partial class ConsultarFactura : Form
    {
        public ConsultarFactura()
        {
            InitializeComponent();
        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Console.Write("doble click");
            new Facturacion.ConsultarFactura().ShowDialog();
        }
    }
}
