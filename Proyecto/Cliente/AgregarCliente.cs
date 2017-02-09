using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Cliente
{
    public partial class AgregarCliente : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

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

                        MessageBox.Show("La cedula NO es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); //DAMOS UN MENSAJE DE ERROR
                    }

                    else
                    {
                        Console.WriteLine(validadorDeCedula(txtCedAgrCliente.Text));
                        string sql = "INSERT INTO cliente VALUES ('" + txtCedAgrCliente.Text + "','" + txtNomAgrCliente.Text + "','" + txtTelAgrCliente.Text + "','" + txtDirecAgrCliente.Text + "','" + txtRUCAgrCliente.Text + "','" + txtCorreoAgrCliente.Text + "','Habilitado')";
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

        private bool validadorDeCedula(string cedula) {

            int isNumeric;
            var total = 0;
            const int tamanoLongitudCedula = 10;
            int[] coeficientes = { 2, 1, 2, 1, 2, 1, 2, 1, 2 };
            const int numeroProvincias = 24;
            const int tercerDigito = 6;
            bool res = false;

            if (int.TryParse(cedula, out isNumeric) && cedula.Length == tamanoLongitudCedula)
            {
                var provincia = Convert.ToInt32(string.Concat(cedula[0], cedula[1], string.Empty));
                var digitoTres = Convert.ToInt32(cedula[2] + string.Empty);
                if ((provincia > 0 && provincia <= numeroProvincias) && digitoTres <tercerDigito) {

                
                    var digitoVerificadorRecibido = Convert.ToInt32(cedula[9] + string.Empty);
                    for (var k = 0; k < coeficientes.Length; k++)
                    {
                        var valor = Convert.ToInt32(coeficientes[k] + string.Empty) *
                                    Convert.ToInt32(cedula[k] + string.Empty);
                        total = valor >= 10 ? total + (valor - 9) : total + valor;
                    }
                    var digitoVerificadorObtenido = total >= 10 ? (total % 10) != 0 ?
                        10 - (total % 10) : (total % 10) : total;

                    res = (digitoVerificadorObtenido == digitoVerificadorRecibido);
                    
                }
                else
                {
                    res = false;
                    
                }
                
            }

            return res;
	    }

        private void txtCedAgrCliente_Leave(object sender, EventArgs e)
        {
            if (!txtCedAgrCliente.Text.Equals(""))
            {
                if(!validadorDeCedula(txtCedAgrCliente.Text))
                {
                    MessageBox.Show("La cedula NO es valida", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCedAgrCliente.Text = "";
                }
            }

            string strquery1 = "Select ci_cliente from cliente";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            foreach (DataRow r in dt.Rows)
            {
                if (r[0].ToString().Equals(txtCedAgrCliente.Text))
                {
                    MessageBox.Show("La cedula ya se encuentra registrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCedAgrCliente.Text = "";
                }
            }


        }

        private void txtCorreoAgrCliente_Leave(object sender, EventArgs e)
        {
            if (txtCorreoAgrCliente.Text != "")
            {
                try
                {
                    MailAddress m = new MailAddress(txtCorreoAgrCliente.Text);

                }
                catch (FormatException)
                {
                    MessageBox.Show("El correo no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtCorreoAgrCliente.Text = "";
                }
            }
        }

        private void txtTelAgrCliente_Leave(object sender, EventArgs e)
        {
            if (txtTelAgrCliente.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtTelAgrCliente.Text, "^[0-9]{7,10}$"))
                {
                    MessageBox.Show("El telefono no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtTelAgrCliente.Text = "";
                }
            }
        }

        private void txtDirecAgrCliente_Leave(object sender, EventArgs e)
        {
            if (!System.Text.RegularExpressions.Regex.IsMatch(txtDirecAgrCliente.Text, "^[a-zA-Z0-9., -]{0,150}$"))
            {
                MessageBox.Show("La dirección no es válida", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtDirecAgrCliente.Text = "";
            }
        }
    }
}
