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
                llenarOT(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),e);
                llenarDetElectrodo(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), e);
                llenarDetRepuesto(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), e);
                double subtotal = 0;
                double iva = 0;
                for (int i = 0; i < e.RowIndex+1; i++)
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
                + "' between fechainiciof and fechacaducidadf";

                conexion.command = new SqlCommand(strquery3, conexion.connection);

                da = new SqlDataAdapter();
                //fetching query in the database.
                da.SelectCommand = conexion.command;
                //inicializar nueva datatable
                dt = new DataTable();
                //refresca las filas segun el rango especificado en el datasource. 
                da.Fill(dt);
                //int añoI, añoF, mesI, mesF, diaI, diaF

                //if (dt.Rows.Count == 0)
                //{
                    //MessageBox.Show("", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    
                //}
                //else
                //{

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
                }               
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void textNumFac_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregarFactura_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "INSERT INTO factura VALUES (" + textNumFac.Text + ",'" + dateEmision.Value.Date.ToString("yyyyMMdd") + "','" + textCedula.Text + "'," + textIVA.Text.Replace(",",".") + ",'Válida'" + "," + textSubtotal.Text.Replace(",", ".") + "," + textTotal.Text.Replace(",", ".") + ")";
                Console.WriteLine(sql);
                //Console.WriteLine(sql);
                conexion.command = new SqlCommand(sql, conexion.connection);
                conexion.command.ExecuteNonQuery();
                conexion.command.Dispose();

                //button8.PerformClick();

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    string sql1 = "INSERT INTO detallefactura VALUES ('" + textNumFac.Text + "','" + dataGridView1.Rows[i].Cells[0].Value.ToString() + "','null','null'," + dataGridView1.Rows[i].Cells[3].Value.ToString() + ")";
                    Console.WriteLine(sql);
                    //Console.WriteLine(sql);
                    conexion.command = new SqlCommand(sql1, conexion.connection);
                    conexion.command.ExecuteNonQuery();
                    conexion.command.Dispose();
                    MessageBox.Show("La factura se agregó correctamente", "Factura Agregada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //button8.PerformClick();
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Cliente.ConsultarCliente().ShowDialog();
        }

        private void validarCantidadRepuesto(int cantidadVende, String id, DataGridViewCellEventArgs e)
        {

            try
            {
                Console.WriteLine(cantidadVende.ToString(), id);
                string strquery3 = "Select * from producto where numSerie = '" + id + "' and cantidad is not null";

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
                    if (r[9].ToString() != "") { 
                    int cantidadExistente= Convert.ToInt32(r[9].ToString());
                    
                        if (cantidadExistente >= cantidadVende)
                        {
                            /*if ((cantidadExistente - cantidadVende) == 0)
                            {
                                string sql = "Update producto set cantidad = " + (cantidadExistente - cantidadVende) +
                                 ", estadoprod = 'Agotado' where numSerie = '" + id + "'";
                                conexion.command = new SqlCommand(sql, conexion.connection);
                                conexion.command.ExecuteNonQuery();
                                conexion.command.Dispose();
                                Console.WriteLine("El electrodoméstico se modificó correctamente");
                            }
                            else {
                                string sql = "Update producto set cantidad = " + (cantidadExistente - cantidadVende) +
                                " where numSerie = '" + id + "'";
                                conexion.command = new SqlCommand(sql, conexion.connection);
                                conexion.command.ExecuteNonQuery();
                                conexion.command.Dispose();
                                Console.WriteLine("El electrodoméstico se modificó correctamente");
                            }*/
                            
                        }
                        else if (cantidadExistente < cantidadVende)
                        {
                            if (cantidadExistente != 0)
                            {
                                MessageBox.Show("Tiene " + cantidadExistente+" unidades del repuesto disponibles", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dataGridView1.Rows[e.RowIndex].Cells[2].Value = "";
                            }
                            else if (cantidadExistente == 0)
                            {
                                MessageBox.Show("El repuesto está agotado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                                dataGridView1.Rows[e.RowIndex].Cells[0].Value = ""; 
                                dataGridView1.Rows[e.RowIndex].Cells[1].Value = "";
                                dataGridView1.Rows[e.RowIndex].Cells[2].Value = "";
                                dataGridView1.Rows[e.RowIndex].Cells[3].Value = "";
                            }                     
                        }           
                    }
                }
            }            
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void llenarDetRepuesto(String id, DataGridViewCellEventArgs e)
        {
            try
            {
                string strquery3 = "Select * from producto where numSerie = '" + id + "' and cantidad is not null";

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
                    //MessageBox.Show("No se ha encontrado ningún repuesto con ese código", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        //obtiene todas las filas de una columna
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = r[0] + " - " + r[1];
                        validarCantidadRepuesto(Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()), dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), e);
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = r[5];
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = Convert.ToDouble(r[5]) * Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void llenarOT(String id, DataGridViewCellEventArgs e)
        {
            try
            {
                string strquery3 = "Select * from ordendetrabajo where num_ordentrabajo = '" + id + "'";

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
                    //MessageBox.Show("No se ha encontrado ninguna Orden de Trabajo \ncon ese número de orden de trabajo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {

                    foreach (DataRow r in dt.Rows)
                    {
                        //obtiene todas las filas de una columna
                        dataGridView1.Rows[e.RowIndex].Cells[1].Value = r[8] + " - " + r[2];
                        dataGridView1.Rows[e.RowIndex].Cells[2].Value = "---";
                        dataGridView1.Rows[e.RowIndex].Cells[3].Value = r[9];
                        dataGridView1.Rows[e.RowIndex].Cells[4].Value = r[9];
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }

        private void llenarDetElectrodo(string id, DataGridViewCellEventArgs e)
        {
            try
            {
                string strquery3 = "Select * from producto where numSerie = '" + id + "' and cantidad is null";

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
                    //MessageBox.Show("No se ha encontrado ningún electrodoméstico con ese número de serie", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    //dataGridView1.Rows[e.RowIndex].Cells[0].Value = "";
                }

                else
                {
                    
                    foreach (DataRow r in dt.Rows)
                    {
                        if (r[6].ToString() == "Agotado")
                        {
                            MessageBox.Show("El electrodoméstico está agotado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            dataGridView1.Rows[e.RowIndex].Cells[0].Value = "";
                        }
                        else if (r[6].ToString() == "Disponible")
                        {
                            //obtiene todas las filas de una columna
                            dataGridView1.Rows[e.RowIndex].Cells[1].Value = r[0] + " - " + r[1];
                            dataGridView1.Rows[e.RowIndex].Cells[2].Value = "1";
                            dataGridView1.Rows[e.RowIndex].Cells[2].ReadOnly = true;
                            dataGridView1.Rows[e.RowIndex].Cells[3].Value = r[5];
                            dataGridView1.Rows[e.RowIndex].Cells[4].Value = r[5];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new GestionElectrodomesticos.ConsultarElectrodomestico().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Repuestos.ConsultarRepuesto().ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new OrdenesTrabajo.BuscarOrdenC().ShowDialog();
        }

    }
}
