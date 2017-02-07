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
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCedAgrCliente.Text, "^[0-9]{10}$"))
            {
                MessageBox.Show("La cedula NO es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("La cedula SI es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNomAgrCliente.Text = "";
            txtCedAgrCliente.Text="";
            txtTelAgrCliente.Text = "";
            txtDirecAgrCliente .Text = "";
            txtRUCAgrCliente.Text = "";
            txtCorreoAgrCliente.Text = "";
        }

        private void nomAgrCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void cedAgrCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void txtCedAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
              
        }

        private void btnAgregarAgrCliente_Click(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtCedAgrCliente.Text, "^[0-9]{10}$"))
            {
                MessageBox.Show("La cedula NO es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("La cedula SI es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void txtTelAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtRUCAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
