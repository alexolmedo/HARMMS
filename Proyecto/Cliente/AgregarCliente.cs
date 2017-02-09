using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Cliente
{
    public partial class AgregarCliente : Form
    {
        Conexion conexion = new Conexion();

        public AgregarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNomAgrCliente.Text = "";
            txtCedAgrCliente.Text = "";
            txtTelAgrCliente.Text = "";
            txtDirecAgrCliente.Text = "";
            txtRUCAgrCliente.Text = "";
            txtCorreoAgrCliente.Text = "";
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
            if (txtNomAgrCliente.Text.Equals("") || txtCedAgrCliente.Text.Equals("") || txtDirecAgrCliente.Text.Equals("") || txtTelAgrCliente.Text.Equals("") || txtCorreoAgrCliente.Text.Equals(""))
            {

                MessageBox.Show("Datos Incompletos, los campos con * son obligatorios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (!txtNomAgrCliente.Text.Equals("") || !txtCedAgrCliente.Text.Equals("") || !txtDirecAgrCliente.Text.Equals("") || !txtTelAgrCliente.Text.Equals("") || !txtCorreoAgrCliente.Text.Equals(""))
            {

                if (!validadorDeCedula(txtCedAgrCliente.Text))
                {
                    Console.WriteLine(validadorDeCedula(txtCedAgrCliente.Text));
                    MessageBox.Show("La cedula NO es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    string sql = "INSERT INTO cliente VALUES ('" + txtCedAgrCliente.Text + "','" + txtNomAgrCliente.Text + "','" + txtTelAgrCliente.Text + "','" + txtDirecAgrCliente.Text + "','" + txtRUCAgrCliente.Text + "','" + txtCorreoAgrCliente.Text + "','H')";
                    conexion.command = new SqlCommand(sql, conexion.connection);
                    conexion.command.ExecuteNonQuery();
                    conexion.command.Dispose();
                    MessageBox.Show("El cliente se agregó correctamente", "Cliente Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
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

        private void txtNomAgrCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private void txtDirecAgrCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
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

        private Boolean validadorDeCedula(String cedula) {
            Boolean cedulaCorrecta = false;
 
        try {
 
            if (cedula.Length == 10) // ConstantesApp.LongitudCedula
            {
            int tercerDigito =  Int32.Parse(cedula.Substring(2, 3));
            if (tercerDigito < 6) {
            // Coeficientes de validación cédula
            // El decimo digito se lo considera dígito verificador
             int[] coefValCedula = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
             int verificador = Convert.ToInt32(cedula.Substring(9,10));
             int suma = 0;
             int digito = 0;
            for (int i = 0; i < (cedula.Length- 1); i++) {
             digito = Convert.ToInt32(cedula.Substring(i, i + 1))* coefValCedula[i];
             suma += ((digito % 10) + (digito / 10));
            }
 
            if ((suma % 10 == 0) && (suma % 10 == verificador)) {
             cedulaCorrecta = true;
            }
            else if ((10 - (suma % 10)) == verificador) {
             cedulaCorrecta = true;
            } else {
             cedulaCorrecta = false;
            }
            } else {
            cedulaCorrecta = false;
            }
            } else {
            cedulaCorrecta = false;
            }
            } catch (FormatException nfe) {
            cedulaCorrecta = false;
        } catch (Exception err) {
        
            Console.WriteLine("Una excepcion ocurrio en el proceso de validadcion" + err);
            cedulaCorrecta = false;
        }
 
        if (!cedulaCorrecta) {
              Console.WriteLine(cedulaCorrecta);
              Console.WriteLine("La Cédula ingresada es Incorrecta");
        }

        return cedulaCorrecta;
        }
    }
}
