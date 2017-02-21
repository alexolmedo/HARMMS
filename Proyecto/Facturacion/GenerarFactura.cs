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
            autoCompletarCedula();
            colocarNumFactura();
        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void autoCompletarCedula()
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

            textCedula.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                //obtiene todas las filas de una columna
                var rw = r.Field<string>("ci_cliente");

                //Set the properties of a textbox to make it auto suggest and append.
                textCedula.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                textCedula.AutoCompleteSource = AutoCompleteSource.CustomSource;
                //adding all rows into the textbox
                textCedula.AutoCompleteCustomSource.Add(rw);
            }
        }

        private String numFacturaAnterior(String fechaI, String fechaF){

            String num = "";
            try
            {

                string strquery3 = "Select Max(num_Factura) from factura where fechaemisionf between '" + fechaI + "' and '" + fechaF + "'";

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
                    num = r[0].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "  NumFacAnterior");
            }

            return num;
        }

        private void colocarNumFactura()
        {
            try
            {
                // Numero Factura
                String fechaEmision = dateEmision.Value.Date.ToString().Substring(6, 4) +
                    dateEmision.Value.Date.ToString().Substring(3, 2) + dateEmision.Value.Date.ToString().Substring(0, 2);
                string strquery3 = "Select * from parametros where '" + fechaEmision
                + "' between fechainicio and fechacaducidadf";

                conexion.command = new SqlCommand(strquery3, conexion.connection);

                da = new SqlDataAdapter();
                //fetching query in the database.
                da.SelectCommand = conexion.command;
                //inicializar nueva datatable
                dt = new DataTable();
                //refresca las filas segun el rango especificado en el datasource. 
                da.Fill(dt);
                //int añoI, añoF, mesI, mesF, diaI, diaF

                foreach (DataRow r in dt.Rows)
                {
                    //obtiene todas las filas de una columna
                    if (r[0].ToString() != "")
                    {

                        if (numFacturaAnterior(r[1].ToString().Substring(6, 4) + r[1].ToString().Substring(3, 2) + r[1].ToString().Substring(0, 2), r[2].ToString().Substring(6, 4) + r[2].ToString().Substring(3, 2) + r[2].ToString().Substring(0, 2)) == r[3].ToString())
                        {
                            Console.WriteLine(strquery3 + " dfgrtg");
                        }

                        else if (numFacturaAnterior(r[1].ToString().Substring(6, 4) + r[1].ToString().Substring(3, 2) + r[1].ToString().Substring(0, 2), r[2].ToString().Substring(6, 4) + r[2].ToString().Substring(3, 2) + r[2].ToString().Substring(0, 2)) == r[3].ToString())
                        {
                            Console.WriteLine(strquery3 + " else if");
                        }

                        else if (numFacturaAnterior(r[1].ToString().Substring(6, 4) + r[1].ToString().Substring(3, 2) + r[1].ToString().Substring(0, 2), r[2].ToString().Substring(6, 4) + r[2].ToString().Substring(3, 2) + r[2].ToString().Substring(0, 2)) == "")
                        {
                            textNumFac.Text = r[3].ToString();
                        }
                        else
                        {
                            Console.WriteLine((1 + Convert.ToInt32(numFacturaAnterior(r[1].ToString().Substring(6, 4) + r[1].ToString().Substring(3, 2) + r[1].ToString().Substring(0, 2),
                                r[2].ToString().Substring(6, 4) + r[2].ToString().Substring(3, 2) + r[2].ToString().Substring(0, 2)))).ToString());
                            textNumFac.Text = (1 + Convert.ToInt32(numFacturaAnterior(r[1].ToString().Substring(6, 4) + r[1].ToString().Substring(3, 2) + r[1].ToString().Substring(0, 2),
                                r[2].ToString().Substring(6, 4) + r[2].ToString().Substring(3, 2) + r[2].ToString().Substring(0, 2)))).ToString();
                        }
                    }

                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
