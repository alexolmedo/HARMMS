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
            colocarNumOT();
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
            //txtCedulaLocal.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("ci_cliente");

                //Set the properties of a textbox to make it auto suggest and append.
                txtCedulaDomicilio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtCedulaDomicilio.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //txtCedulaLocal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //txtCedulaLocal.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
            txtCedulaLocal.Text = "";
            txtCostoLocal.Text = "";
            txtDescripcionLocal.Text = "";
            txtNombreLocal.Text = "";
            txtTelefonoLocal.Text = "";
            txtDireccionLocal.Text = "";
        }

        private void txtCedulaDomicilio_Leave(object sender, EventArgs e)
        {
            try
            {

                string strquery3 = "Select * from cliente where CI_Cliente = '" + txtCedulaDomicilio.Text + "'";

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
                    txtNombreDomicilio.Text = r[1].ToString();
                    txtDireccionDomicilio.Text = r[2].ToString();
                    txtTelefonoDomicilio.Text = r[3].ToString();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void txtCedulaLocal_Leave(object sender, EventArgs e)
        {
            try
            {
                string strquery3 = "Select * from cliente where CI_Cliente = '" + txtCedulaLocal.Text + "'";

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
                    txtNombreLocal.Text = r[1].ToString();
                    txtDireccionLocal.Text = r[2].ToString();
                    txtTelefonoLocal.Text = r[3].ToString();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtNombreDomicilio.Text = "";
            txtTelefonoDomicilio.Text = "";
            txtDireccionDomicilio.Text = "";
            txtTelefonoDomicilio.Text = "";
            txtDescripcionDomicilio.Text = "";
            txtCostoDomicilio.Text = "";
            txtCedulaDomicilio.Text = "";
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            button8.PerformClick();
            button4.PerformClick();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private String numOTAnterior()
        {

            String num = "";
            try
            {

                string strquery3 = "Select Max(num_ordentrabajo) from ordendetrabajo";

                conexion.command = new SqlCommand(strquery3, conexion.connection);

                da = new SqlDataAdapter();
                da.SelectCommand = conexion.command;
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow r in dt.Rows)
                {
                    num = r[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return num;
        }

        private void colocarNumOT()
        {
            try
            {
                // Numero OT
                string strquery3 = "Select max(num_ordentrabajo) from ordendetrabajo";
                String aux ="";
                conexion.command = new SqlCommand(strquery3, conexion.connection);

                da = new SqlDataAdapter();
                da.SelectCommand = conexion.command;
                dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow r in dt.Rows)
                {
                    aux = r[0].ToString();
                }

                if (numOTAnterior() == "")
                {
                    txtNumDomicilio.Text = aux;
                    txtNumLocal.Text = aux;
                }

                else
                {
                    txtNumDomicilio.Text = (Convert.ToInt32(numOTAnterior()) + 1).ToString();
                    txtNumLocal.Text = (Convert.ToInt32(numOTAnterior()) + 1).ToString(); 
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
