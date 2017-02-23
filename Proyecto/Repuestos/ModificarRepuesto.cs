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

namespace Proyecto.Repuestos
{
    public partial class ModificarRepuesto : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public ModificarRepuesto()
        {
            InitializeComponent();
            this.CenterToScreen();

            //Llenar los datos para autocompletar la búsqueda por cedula
            string strquery1 = "Select numserie from producto where tiempousoelec is null";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            textBoxNumSerie.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("numserie");

                //Set the properties of a textbox to make it auto suggest and append.
                textBoxNumSerie.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxNumSerie.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                textBoxNumSerie.AutoCompleteCustomSource.Add(rw);
            }

            //Llenar los datos para autocompletar la búsqueda por nombre
            string strquery2 = "Select modelo from producto where tiempousoelec is null";
            conexion.command = new SqlCommand(strquery2, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            textBoxModelo.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("modelo");

                //Set the properties of a textbox to make it auto suggest and append.
                textBoxModelo.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textBoxModelo.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                textBoxModelo.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumSerie.ReadOnly = true;
            textBoxModelo.ReadOnly = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxModelo.ReadOnly = true;
            textBoxNumSerie.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string strquery3 = "";

                if (radioButModelo.Checked)
                {
                    strquery3 = "Select * from producto where modelo = '" + textBoxModelo.Text + "' and tiempousoelec is null";
                }

                if (radioButNumSerie.Checked)
                {
                    strquery3 = "Select * from producto where numSerie = " + textBoxNumSerie.Text + "and tiempousoelec is null";
                }

                conexion.command = new SqlCommand(strquery3, conexion.connection);

                da = new SqlDataAdapter();
                //fetching query in the database.
                da.SelectCommand = conexion.command;
                //inicializar nueva datatable
                dt = new DataTable();
                //refresca las filas segun el rango especificado en el datasource. 
                da.Fill(dt);

                foreach (DataRow r in dt.Rows)
                {
                    //obtiene todas las filas de una columna
                    textNombre.Text = r[0].ToString();
                    textModelo.Text = r[1].ToString();

                    textPrCompra.Text = cambiarComaPorPunto(r[4].ToString());
                    textPrVenta.Text = cambiarComaPorPunto(r[5].ToString());
                    textNumSer.Text = r[3].ToString();
                    textCant.Text = r[9].ToString();
                    cBEstado.SelectedItem = r [6].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
 



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dr = MessageBox.Show("¿Confirma modificación?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                if (dr == DialogResult.Yes)
                {
                    string sql = "Update producto set nombre = '" + textNombre.Text + "', modelo ='" + textModelo.Text + "', precioCompra=" + textPrCompra.Text +
                        ",precioVenta=" + textPrVenta.Text + ",numserie='" + Double.Parse(textNumSer.Text) + "', cantidad =" + textCant.Text + ", estadoprod ='" + cBEstado.SelectedItem
                        + "' where numSerie = '" + textNumSer.Text + "'";
                    Console.WriteLine(sql);

                    conexion.command = new SqlCommand(sql, conexion.connection);
                    conexion.command.ExecuteNonQuery();
                    conexion.command.Dispose();
                    MessageBox.Show("El repuesto se modificó correctamente", "Repuesto Modificado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public String cambiarComaPorPunto(String numero) 
        {
            return numero.Replace(',', '.');
            
        }

        private void textNombre_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text.Length > 20)
            {
                MessageBox.Show("El nombre del repuesto es muy extenso\nSe aceptan hasta 20 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textNombre.Text = "";
            }
        }

        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textNumSer_Leave(object sender, EventArgs e)
        {
            if (textNumSer.Text.Length > 15)
            {
                MessageBox.Show("El código es muy extenso\nSe acptan hasta 15 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textNumSer.Text = "";
            }
        }

        private void textNumSer_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textModelo_Leave(object sender, EventArgs e)
        {
            if (textNombre.Text.Length > 20)
            {
                MessageBox.Show("El modelo del repuesto es muy extenso\nSe aceptan hasta 30 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                textNombre.Text = "";
            }
        }

        private void textPrCompra_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textPrCompra_Leave(object sender, EventArgs e)
        {
            if (textPrCompra.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textPrCompra.Text, "^[0-9]{1,4}([.][0-9]{1,2})?$"))
                {
                    MessageBox.Show("El precio de compra no es válido\nSe puede ingresar hasta 4 números enteros y 2 decimales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textPrCompra.Text = "";
                }
            }
        }

        private void textPrVenta_Leave(object sender, EventArgs e)
        {
            if (textPrVenta.Text != "")
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(textPrVenta.Text, "^[0-9]{1,4}([.][0-9]{1,2})?$"))
                {
                    MessageBox.Show("El precio de venta no es válido\nSe puede ingresar hasta 4 números enteros y 2 decimales", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    textPrVenta.Text = "";
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

        private void textCant_KeyPress(object sender, KeyPressEventArgs e)
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
