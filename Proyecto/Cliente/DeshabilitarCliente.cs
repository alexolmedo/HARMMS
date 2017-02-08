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
    public partial class DeshabilitarCliente : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public DeshabilitarCliente()
        {
            InitializeComponent();
            this.CenterToScreen();

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


        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¿Confirma eliminar cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            txtCedula.Text = "";
            txtCedula.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = true;
            txtNombre.Text = "";
            txtCedula.ReadOnly = false;
        }
    }
}
