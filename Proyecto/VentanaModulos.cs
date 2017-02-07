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

        private void VentanaModulos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void insertarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().Show();
            //this.Enabled = false;
        }

        private void consultarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.ConsultarCliente().Show();
        }

        private void actualizarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.ActualizarCliente().Show();
        }

        private void eliminarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Cliente.DeshabilitarCliente().Show();
        }

        private void generarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion.GenerarFactura().Show();
        }

        private void consultarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion.ConsultarFactura().Show();
        }

        private void deshabilitarFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Facturacion.DeshabilitarFactura().Show();
        }

        private void ingresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Repuestos.IngresarRepuesto().Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Repuestos.ModificarRepuesto().Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Repuestos.ConsultarRepuesto().Show();
        }

        private void deshabilitarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new Repuestos.DeshabilitarRepuesto().Show();
        }

        private void insertarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.IngresarOrden().Show();
        }

        private void consultarOrdenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ModificarOrden().Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.ConsultarOrden().Show();
        }

        private void deshabilitarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.DeshabilitarOrden().Show();
        }

        private void nuevaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.IngresarCompra().Show();
        }

        private void modificarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.ModificarCompra().Show();
        }

        private void eliminarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.EliminarCompra().Show();
        }

        private void usadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.ConsultarElectrodomestico().Show();
        }
    }
}
