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
    public partial class ConsultarCliente : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public ConsultarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();
            autoCompletarPorCedula();
            autocompletarPorNombre();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtCedula.Text = "";
            txtCedula.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
            txtNombre.Text = "";
            txtCedula.ReadOnly = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strquery3 = "";

                if (radioButNombre.Checked)
                {
                    if (txtNombre.Text == "") {

                        MessageBox.Show("No ha ingresado el nombre del cliente a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                    }
                    strquery3 = "Select * from cliente where NombreCliente = '" + txtNombre.Text + "'";

                }

                if (radioButCed.Checked)
                {
                    strquery3 = "Select * from cliente where CI_Cliente = " + txtCedula.Text + "";
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
                    cedConCliente.Text = r[0].ToString();
                    nomConCliente.Text = r[1].ToString();
                    telConCliente.Text = r[2].ToString();
                    dirConCliente.Text = r[3].ToString();
                    RUCConCliente.Text = r[4].ToString();
                    correoConCliente.Text = r[5].ToString();
                    estadoConCliente.Text = r[6].ToString();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
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

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
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

        private void autoCompletarPorCedula()
        {
            //Llenar los datos para autocompletar la búsqueda por cedula
            string strquery1 = "Select ci_cliente from cliente";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            txtCedula.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("ci_cliente");

                //Set the properties of a textbox to make it auto suggest and append.
                txtCedula.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCedula.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtCedula.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void autocompletarPorNombre(){

            //Llenar los datos para autocompletar la búsqueda por nombre
            string strquery2 = "Select nombrecliente from cliente";
            conexion.command = new SqlCommand(strquery2, conexion.connection);

            da = new SqlDataAdapter();
            //fetching query in the database.
            da.SelectCommand = conexion.command;
            //inicializar nueva datatable
            dt = new DataTable();
            //refresca las filas segun el rango especificado en el datasource. 
            da.Fill(dt);

            txtNombre.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("nombrecliente");

                //Set the properties of a textbox to make it auto suggest and append.
                txtNombre.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtNombre.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtNombre.AutoCompleteCustomSource.Add(rw);
            }
        }
    }
}
