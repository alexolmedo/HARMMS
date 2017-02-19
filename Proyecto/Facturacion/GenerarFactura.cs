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

namespace Proyecto.Facturacion
{
    public partial class GenerarFactura : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public GenerarFactura()
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

            textCedula.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("ci_cliente");

                //Set the properties of a textbox to make it auto suggest and append.
                textCedula .AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textCedula.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                textCedula.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Cliente.SeleccionarCliente().Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            
            
        }

        private void textCedula_Leave(object sender, EventArgs e)
        {
            try
            {

                string strquery3 = "Select * from cliente where CI_Cliente = '" + textCedula.Text + "'";

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
                    textNombreC.Text = r[1].ToString();
                    textDireccionC.Text = r[2].ToString();
                    textTelfC.Text = r[3].ToString();

                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void butNuevo_Click(object sender, EventArgs e)
        {
            new Cliente.AgregarCliente().ShowDialog();
        }

      

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string strquery3 = "Select * from producto where numSerie = '" + Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value) + "'";

                Console.WriteLine(Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value));

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
                    dataGridView1.Rows[e.RowIndex].Cells[1].Value = r[1] + " - " + r[2];
                    dataGridView1.Rows[e.RowIndex].Cells[3].Value = r[6];
                    dataGridView1.Rows[e.RowIndex].Cells[4].Value = Convert.ToDouble(r[6]) * Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value);    
                }

                double subtotal = 0;
                double iva = 0;
                for (int i = 0; i < e.RowIndex; i++)
                {
                     subtotal += Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                     iva = subtotal * 0.14;
                }
                textSubtotal.Text = subtotal.ToString();
                textIVA.Text = iva.ToString();
                textTotal.Text = (subtotal + iva).ToString();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
