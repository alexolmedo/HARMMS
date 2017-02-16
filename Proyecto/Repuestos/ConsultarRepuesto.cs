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

            //Llenar los datos para autocompletar la búsqueda por cedula
            string strquery1 = "Select numserie from producto";
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
            string strquery2 = "Select modelo from producto";
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

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strquery3 = "";

                if (radioButModelo.Checked)
                {
                    strquery3 = "Select * from producto where modelo = '" + textBoxModelo.Text + "'";
                }

                if (radioButNumSerie.Checked)
                {
                    strquery3 = "Select * from producto where numSerie = " + textBoxNumSerie.Text + "";
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
                    textNombre.Text = r[1].ToString();
                    textModelo.Text = r[2].ToString();
                    textPrCompra.Text = r[5].ToString();
                    textPrVenta.Text = r[6].ToString();
                    textNumSer.Text = r[4].ToString();
                    textCant.Text = r[10].ToString();
                    textEstado.Text = r[7].ToString();
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
    }
}
