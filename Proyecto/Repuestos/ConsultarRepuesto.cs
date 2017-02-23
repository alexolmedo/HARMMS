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
    public partial class ConsultarRepuesto : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public ConsultarRepuesto()
        {
            InitializeComponent();
            this.CenterToScreen();
            autocompletarModelo();
            autocompletarNumSerie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxNumSerie.ReadOnly = true;
            textBoxModelo.ReadOnly = false;
            textBoxNumSerie.Text = "";
            textBoxModelo.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxModelo.ReadOnly = true;
            textBoxNumSerie.ReadOnly = false;
            textBoxNumSerie.Text = "";
            textBoxModelo.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strquery3 = "";

                if (radioButModelo.Checked)
                {
                    if (textBoxModelo.Text == "")
                    {

                        MessageBox.Show("No ha ingresado el modelo del repuesto a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else
                    {

                        strquery3 = "Select * from producto where modelo = '" + textBoxModelo.Text + "' and tiempousoelec is null";
                    }
                }

                if (radioButNumSerie.Checked)
                {
                    if (textBoxNumSerie.Text == "")
                    {

                        MessageBox.Show("No ha ingresado el código del repuesto a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else
                    {
                        strquery3 = "Select * from producto where numSerie = '" + textBoxNumSerie.Text + "' and tiempousoelec is null";
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
                    MessageBox.Show("El repuesto no está registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    limpiarCampos();
                }
                else
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        //obtiene todas las filas de una columna
                        textNombre.Text = r[0].ToString();
                        textModelo.Text = r[1].ToString();
                        textPrCompra.Text = r[4].ToString();
                        textPrVenta.Text = r[5].ToString();
                        textNumSer.Text = r[3].ToString();
                        textCant.Text = r[9].ToString();
                        textEstado.Text = r[6].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void autocompletarModelo()
        {
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

        private void autocompletarNumSerie()
        {
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
        }

        private void limpiarCampos()
        {
            textNombre.Text = "";
            textModelo.Text = "";
            textPrCompra.Text = "";
            textPrVenta.Text = "";
            textNumSer.Text = "";
            textCant.Text = "";
            textEstado.Text = "";
        }

        private void textBoxNumSerie_KeyPress(object sender, KeyPressEventArgs e)
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
