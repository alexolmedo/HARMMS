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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = false;
            txtPorNumSer.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButModelo_CheckedChanged(object sender, EventArgs e)
        {
            txtPorNumSer.ReadOnly = true;
            txtPorModelo.ReadOnly = false;
        }

        private void radioButNumSerie_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
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
                /*if (txtCedula.Text.Equals("") || txtNombre.Text.Equals(""))
                {
                    MessageBox.Show("No se puede realizar la busqueda\nLlene los campos de busqueda", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }*/

                string strquery3 = "";

                if (radioButModelo.Checked)
                {
                    strquery3 = "Select * from producto where modelo = '" + txtPorModelo.Text + "' and cantidad is null";
                }

                if (radioButNumSerie.Checked)
                {
                    strquery3 = "Select * from producto where numSerie = " + txtPorNumSer.Text + " and cantidad is null";
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
                    txtNombre.Text = r[0].ToString();
                    txtModelo.Text = r[1].ToString();
                    cbAños.SelectedItem = ponertimpoUsoCBAños(Convert.ToInt32(r[2])).ToString();
                    cbMeses.SelectedItem = ponertiempoUsoCBMese(Convert.ToInt32(r[2])).ToString();
                    txtNumSer.Text = r[3].ToString();
                    txtPrCompra.Text = r[4].ToString();
                    textPrVenta.Text = r[5].ToString();
                    cbEstado.SelectedItem = r[6].ToString();
                    txtDueñoAnt.Text = r[7].ToString();
                    textContacto.Text = r[8].ToString();
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

    }
}
