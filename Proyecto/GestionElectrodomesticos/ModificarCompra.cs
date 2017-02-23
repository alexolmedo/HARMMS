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

namespace Proyecto.GestionElectrodomesticos
{
    public partial class ModificarCompra : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public ModificarCompra()
        {
            InitializeComponent();
            this.CenterToScreen();
            autoCompletarModelo();
            autoCompletarNumeroSerie();
        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButModelo_CheckedChanged(object sender, EventArgs e)
        {
            txtPorNumSer.ReadOnly = true;
            txtPorModelo.ReadOnly = false;
            txtPorNumSer.Text = "";
            txtPorModelo.Text = "";
        }

        private void radioButNumSerie_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
            txtPorNumSer.Text = "";
            txtPorModelo.Text = "";
        }

        private void autoCompletarModelo()
        {
            //Llenar los datos para autocompletar la búsqueda por nombre
            string strquery2 = "Select modelo from producto where cantidad is null";
            conexion.command = new SqlCommand(strquery2, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            txtPorModelo.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("modelo");

                //Set the properties of a textbox to make it auto suggest and append.
                txtPorModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPorModelo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtPorModelo.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void autoCompletarNumeroSerie()
        {

            //Llenar los datos para autocompletar la búsqueda por cedula
            string strquery1 = "Select numserie from producto where cantidad is null";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            txtPorNumSer.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("numserie");

                //Set the properties of a textbox to make it auto suggest and append.
                txtPorNumSer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtPorNumSer.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtPorNumSer.AutoCompleteCustomSource.Add(rw);
            }

        }

        private void butBuscar_Click(object sender, EventArgs e)
        {
            try
            {

                string strquery3 = "";

                if (radioButModelo.Checked)
                {

                    if (txtPorModelo.Text == "")
                    {

                        MessageBox.Show("No ha ingresado el modelo del electrodoméstico a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else {
                    
                        strquery3 = "Select * from producto where modelo = '" + txtPorModelo.Text + "' and cantidad is null";
                    }
                }

                if (radioButNumSerie.Checked)
                {
                    if (txtPorNumSer.Text == "")
                    {

                        MessageBox.Show("No ha ingresado el número de serie del electrodoméstico a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else
                    {
                        strquery3 = "Select * from producto where numSerie = '" + txtPorNumSer.Text + "' and cantidad is null";
                    }
                }

                conexion.command = new SqlCommand(strquery3, conexion.connection);

                da = new SqlDataAdapter();
                //fetching query in the database.
                da.SelectCommand = conexion.command;
                //inicializar nueva datatable
                dt = new DataTable();
                //refresca las filas segun el rango especificado en el datasource. 
                da.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("El electrodoméstico no está registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    limpiarCampos();
                }
                else
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        //obtiene todas las filas de una columna
                        txtNombre.Text = r[0].ToString();
                        txtModelo.Text = r[1].ToString();
                        cbAños.SelectedItem = ponertimpoUsoCBAños(Convert.ToInt32(r[2])).ToString();
                        cbMeses.SelectedItem = ponertiempoUsoCBMese(Convert.ToInt32(r[2])).ToString();
                        txtNumSer.Text = r[3].ToString();
                        txtPrCompra.Text = r[4].ToString().Replace(",", ".");
                        textPrVenta.Text = r[5].ToString().Replace(",", ".");
                        cbEstado.SelectedItem = r[6].ToString();
                        txtDueñoAnt.Text = r[7].ToString();
                        textContacto.Text = r[8].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        public string ponertimpoUsoCBAños(int meses)
        {
            int años = (meses / 12);
            String res = "";
            if (años == 0) {
                res = "-";
            }
            else if (años == 1) {
                res = años + " Año";
            }
            else 
            {
                res = años + " Años";
            }
            
            return res;
        }

        public string  ponertiempoUsoCBMese(int meses)
        {
            int mese = (meses % 12);
            String res = "";
            if (mese == 0)
            {
                res = "-";
            }
            else if (mese == 1)
            {
                res = mese + " mes";
            }
            else
            {
                res = mese + " meses";
            }

            return res;
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Confirma modificación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dr == DialogResult.Yes)
                {
                    if (txtNombre.Text.Equals("") || txtModelo.Text.Equals("") ||                 
                    txtNumSer.Text.Equals("") || textPrVenta.Text.Equals("") || 
                    txtPrCompra.Text.Equals("") || txtDueñoAnt.Text.Equals("") || 
                    textContacto.Text.Equals("") || cbAños.SelectedItem.Equals("") || cbMeses.SelectedItem.Equals(""))            
                    {
                        MessageBox.Show("Datos Incompletos \n Todos los campos son obligatorios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    
                    else if (!txtNombre.Text.Equals("") || !txtModelo.Text.Equals("") ||
                        !txtNumSer.Text.Equals("") || !textPrVenta.Text.Equals("") ||
                        !txtPrCompra.Text.Equals("") || !txtDueñoAnt.Text.Equals("") ||
                        !textContacto.Text.Equals("") || !cbAños.SelectedItem.Equals("") || !cbMeses.SelectedItem.Equals(""))
                    {

                        string sql = "Update producto set nombre = '" + txtNombre.Text + "', modelo ='" + txtModelo.Text + "', tiempousoelec = " +
                            pasCBs_Meses(cbAños.SelectedItem.ToString(), cbMeses.SelectedItem.ToString()) + ", numserie='" +
                             txtNumSer.Text + "',precioCompra = " + txtPrCompra.Text + ", precioVenta=" + textPrVenta.Text +
                             ",estadoProd = '" + cbEstado.SelectedItem + "', propanterior = '" + txtDueñoAnt.Text + "', telefpropanterior ='" + textContacto.Text +
                             "' where numSerie = '" + txtNumSer.Text + "'";

                        Console.WriteLine(sql);

                        conexion.command = new SqlCommand(sql, conexion.connection);
                        conexion.command.ExecuteNonQuery();
                        conexion.command.Dispose();
                        MessageBox.Show("El electrodoméstico se modificó correctamente", "Electrodoméstico Modificado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public int pasCBs_Meses(String años, String meses)
        {

            int mes = 0;

            if (años == "-")
            {

                mes = 0;
            }

            else if (años == "1 Año")
            {
                mes = 12;
            }
            else if (años.Length == 6)
            {
                mes = 12 * Convert.ToInt32(años.Substring(0, 1));
            }
            else if (años == "10 Años")
            {
                mes = 12 * Convert.ToInt32(años.Substring(0, 2));
            }

            if (meses == "1 mes")
            {

                mes += 1;
            }

            else if (meses.Length == 7)
            {
                mes += Convert.ToInt32(meses.Substring(0, 1));
            }

            else if (meses.Length == 8)
            {

                mes += Convert.ToInt32(meses.Substring(0, 2));
            }
            return mes;
        }

        public void limpiarCampos()
        {
            txtNombre.Text = "";
            txtModelo.Text = "";
            cbAños.SelectedItem = "-";
            cbMeses.SelectedItem = "-";           
            txtNumSer.Text = "";
            txtPrCompra.Text = "";
            textPrVenta.Text = "";
            cbEstado.Text = "";
            txtDueñoAnt.Text = "";
            textContacto.Text = "";
        }

        private void txtPorNumSer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPrVenta_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPrVenta_Leave(object sender, EventArgs e)
        {
            if (txtPrCompra.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtPrCompra.Text, "^[0-9]{1,4}([.][0-9]{1,2})?$"))
                {
                    MessageBox.Show("El precio de venta no es válido\nSe puede ingresar hasta 4 números enteros y 2 decimales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    txtPrCompra.Text = "";
                }
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

        private void textContacto_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textContacto_Leave(object sender, EventArgs e)
        {
            if (textContacto.Text != "")
            {
                if (textContacto.Text.Length == 8 || textContacto.Text.Length < 7 || textContacto.Text.Length > 10 || !System.Text.RegularExpressions.Regex.IsMatch(textContacto.Text, "^[0-9]{7,10}$"))
                {
                    MessageBox.Show("El contacto (teléfono) del \npropietario anterior no es válido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textContacto.Text = "";
                }
            }
        }
    }
}
