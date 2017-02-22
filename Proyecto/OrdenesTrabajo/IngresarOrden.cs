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

namespace Proyecto.OrdenesTrabajo
{
    public partial class IngresarOrden : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public IngresarOrden()
        {
            InitializeComponent();
            this.CenterToScreen();
            autcompletarCedulaDomicilio();
            autcompletarCedulaLocal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cliente.SeleccionarCliente().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.SeleccionarElectrodomestico().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.IngresarCompra().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autcompletarCedulaDomicilio()
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

            txtCedulaDomicilio.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("ci_cliente");

                //Set the properties of a textbox to make it auto suggest and append.
                txtCedulaDomicilio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCedulaDomicilio.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtCedulaDomicilio.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void autcompletarCedulaLocal()
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

            txtCedulaLocal.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("ci_cliente");

                //Set the properties of a textbox to make it auto suggest and append.
                txtCedulaLocal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCedulaLocal.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                txtCedulaLocal.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
