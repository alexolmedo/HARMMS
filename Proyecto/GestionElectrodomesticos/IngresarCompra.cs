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

namespace Proyecto.GestionElectrodomesticos
{
    public partial class IngresarCompra : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public IngresarCompra()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Equals("") || txtModelo.Text.Equals("") || 
                txtNumSer.Text.Equals("") || txtPrVenta.Text.Equals("") || 
                txtPrCompra.Text.Equals("") || txtDueñoAnt.Text.Equals("") || 
                txtConacto.Text.Equals("") || cbAños.SelectedItem.Equals("") || cbMeses.SelectedItem.Equals(""))
            {

                MessageBox.Show("Datos Incompletos \n Todos los campos son obligatorios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
            else if (!txtNombre.Text.Equals("") || !txtModelo.Text.Equals("") ||
                !txtNumSer.Text.Equals("") || !txtPrVenta.Text.Equals("") ||
                !txtPrCompra.Text.Equals("") || !txtDueñoAnt.Text.Equals("") ||
                !txtConacto.Text.Equals("") || !cbAños.SelectedItem.Equals("") || !cbMeses.SelectedItem.Equals("")) {

                //Console.WriteLine(validadorDeCedula(txtCedAgrCliente.Text));
               
                string sql = "insert into producto values('" + txtNombre.Text + "','" + txtModelo.Text + "'," + pasCBs_Meses(cbAños.SelectedItem.ToString(), cbMeses.SelectedItem.ToString())+ ",'"
                    + txtNumSer.Text + "', " + txtPrCompra.Text + "," + txtPrVenta.Text + ", 'Disponible','" + txtDueñoAnt.Text + "','" + txtConacto.Text + "',null)";
                conexion.command = new SqlCommand(sql, conexion.connection);
                conexion.command.ExecuteNonQuery();
                conexion.command.Dispose();
                MessageBox.Show("El electrodoméstico se agregó correctamente", "Electrodoméstico Agregado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                butNuevo.PerformClick();
            }
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtModelo.Text = "";
            txtNumSer.Text = "";
            txtPrCompra.Text = "";
            txtPrVenta.Text = "";
            txtDueñoAnt.Text = "";
            txtConacto.Text = "";
            cbAños.SelectedItem = "-";
            cbMeses.SelectedItem = "-";
        }

        public int pasCBs_Meses(String años, String meses ) {

            int mes = 0;

            if (años == "-") {

                mes =0;
            }

            else if (años == "1 Año") {
                mes = 12;
            }
            else if (años.Length == 6) {
                mes = 12*Convert.ToInt32(años.Substring(0,1));
            }
            else if (años == "10 Años") {
                mes = 12*Convert.ToInt32(años.Substring(0,2));
            }

            if (meses == "1 mes") {

                mes += 1;
            }

            else if (meses.Length == 7) {
                mes+= Convert.ToInt32(meses.Substring(0,1));
            }

            else if (meses.Length == 8) {

                mes+= Convert.ToInt32(meses.Substring(0,2));
            }
            return mes;
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length > 20)
            {
                MessageBox.Show("El nombre es muy extenso \n Se aceptan hasta 20 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNombre.Text = "";
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtModelo_Leave(object sender, EventArgs e)
        {
            if (txtModelo.Text.Length > 30) {

                MessageBox.Show("El modelo es muy extenso \n Se aceptan hasta 30 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtModelo.Text = "";
            }
        }

        private void txtNumSer_Leave(object sender, EventArgs e)
        {
            if (txtNumSer.Text.Length > 15) {

                MessageBox.Show("El número de serie es muy extenso\n Se aceptan hasta 15 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtNumSer.Text = "";
            }

            string strquery1 = "Select numserie from producto";
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
                if (r[0].ToString().Equals(txtNumSer.Text))
                {
                    MessageBox.Show("El número de serie ya se encuentra registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtNumSer.Text = "";
                }
            }
        }

        private void txtNumSer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtPrCompra_Leave(object sender, EventArgs e)
        {
            if (txtPrCompra.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrCompra.Text, "^[0-9]{1,4}([.][0-9]{1,2})?$"))
                {
                    MessageBox.Show("El precio de compra no es válido\nSe puede ingresar hasta 4 números enteros y 2 decimales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPrCompra.Text = "";
                }
            }
        }

        private void txtPrCompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDueñoAnt_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDueñoAnt_Leave(object sender, EventArgs e)
        {
            if (txtDueñoAnt.Text.Length > 60) {

                MessageBox.Show("El nombre del propietario anterior es muy extenso \n Se aceptan hasta 60 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtDueñoAnt.Text = "";
            }
        }

        private void txtConacto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtConacto_Leave(object sender, EventArgs e)
        {
            if (txtConacto.Text != "")
            {
                if (txtConacto.Text.Length == 8 || txtConacto.Text.Length < 7 || txtConacto.Text.Length > 10 || !System.Text.RegularExpressions.Regex.IsMatch(txtConacto.Text, "^[0-9]{7,10}$"))
                {
                    MessageBox.Show("El contacto (teléfono) del \npropietario anterior no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtConacto.Text = "";
                }
            }
        }

        private void txtPrVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrVenta.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrVenta.Text, "^[0-9]{1,4}([.][0-9]{1,2})?$"))
                {
                    MessageBox.Show("El precio de venta no es válido\nSe puede ingresar hasta 4 números enteros y 2 decimales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPrVenta.Text = "";
                }
            }
        }

        private void txtPrVenta_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
