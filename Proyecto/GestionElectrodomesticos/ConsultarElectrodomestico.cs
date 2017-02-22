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
    public partial class ConsultarElectrodomestico : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public ConsultarElectrodomestico()
        {
            InitializeComponent();
            this.CenterToScreen();
            autoCompletarModelo();
            autoCompletarNumeroSerie();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = false;
            txtPorNumSer.ReadOnly = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void button2_Click(object sender, EventArgs e)
        {

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

        private void autoCompletarNumeroSerie() {

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
    }
}
