using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Repuestos
{
    public partial class IngresarRepuesto : Form
    {
        Conexion conexion = new Conexion();
        //SqlDataAdapter da;
        //DataTable dt;

        public IngresarRepuesto()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Length > 20)
            {
                MessageBox.Show("El nombre del repuesto es muy extenso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxNombre.Text = "";
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text.Length > 15)
            {
                MessageBox.Show("El código es muy extenso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxCodigo.Text = "";
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBoxPrCompra.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPrCompra.Text, "^[0-9]{1,4}([.][0-9]{1,2})?$"))
                {
                    MessageBox.Show("El precio de compra no es válido\nSe puede ingresar hasta 4 números enteros y 2 decimales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBoxPrCompra.Text = "";
                }
            }
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBoxPrVenta.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textBoxPrVenta.Text, "^[0-9]{1,4}([.][0-9]{1,2})?$"))
                {
                    MessageBox.Show("El precio de venta no es válido\nSe puede ingresar hasta 4 números enteros y 2 decimales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textBoxPrVenta.Text = "";
                }
            }
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text.Equals("") || textBoxModelo.Text.Equals("") || textBoxCodigo.Text.Equals("") || textBoxPrCompra.Text.Equals("") || textBoxPrVenta.Text.Equals("") || textBoxCantidad.Text.Equals(""))
            {
                MessageBox.Show("Todos los campos son obligatorios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (!textBoxNombre.Text.Equals("") || !textBoxModelo.Text.Equals("") || !textBoxCodigo.Text.Equals("") || !textBoxPrCompra.Text.Equals("") || !textBoxPrVenta.Text.Equals("") || !textBoxCantidad.Text.Equals(""))
            {

                Console.WriteLine("rshtrh");
                string sql = "insert into producto values('" + textBoxNombre.Text + "','" + textBoxModelo.Text + "',null,'"
                    + textBoxCodigo.Text + "', " + textBoxPrCompra.Text + "," + textBoxPrVenta.Text + ",null,null,null,"
                    + textBoxCantidad.Text + ")";
                conexion.command = new SqlCommand(sql, conexion.connection);
                conexion.command.ExecuteNonQuery();
                conexion.command.Dispose();
                MessageBox.Show("El repuesto se agregó correctamente", "Repuesto Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void textBoxCodigo_Leave(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text.Length > 15)
            {
                MessageBox.Show("El código es muy extenso", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textBoxCodigo.Text = "";
            }
        }
    }
}
