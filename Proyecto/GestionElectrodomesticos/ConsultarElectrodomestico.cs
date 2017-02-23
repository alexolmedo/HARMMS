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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = false;
            txtPorNumSer.ReadOnly = true;
            txtPorModelo.Text = "";
            txtPorNumSer.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
            txtPorModelo.Text = "";
            txtPorNumSer.Text = "";
        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButModelo_CheckedChanged(object sender, EventArgs e)
        {
            txtPorNumSer.ReadOnly = true;
            txtPorModelo.ReadOnly = false;
            txtPorNumSer.Text = "";
            txtPorModelo.Text = "";
        }

        private void radioButNumSerie_CheckedChanged(object sender, EventArgs e)
        {
            txtPorModelo.ReadOnly = true;
            txtPorNumSer.ReadOnly = false;
            txtPorNumSer.Text = "";
            txtPorModelo.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strquery3 = "";

                if (radioButModelo.Checked)
                {
                    if (txtPorModelo.Text == "")
                    {

                        MessageBox.Show("No ha ingresado el modelo del electrodoméstico a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else
                    {
                        strquery3 = "Select * from producto where modelo = '" + txtPorModelo.Text + "' and cantidad is null";
                    }
                }

                if (radioButNumSerie.Checked)
                {
                    if (txtPorNumSer.Text == "")
                    {

                        MessageBox.Show("No ha ingresado el número de serie del electrodoméstico a buscar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        limpiarCampos();
                    }
                    else
                    {
                        strquery3 = "Select * from producto where numSerie = '" + txtPorNumSer.Text + "' and cantidad is null";
                    }
                }

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
                    MessageBox.Show("El electrodoméstico no está registrado", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    limpiarCampos();
                }
                else
                {
                    foreach (DataRow r in dt.Rows)
                    {
                        //obtiene todas las filas de una columna
                        txtNombre.Text = r[0].ToString();
                        txtModelo.Text = r[1].ToString();
                        textTiempoUso.Text = r[2].ToString();
                        txtNumSer.Text = r[3].ToString();
                        txtPrCompra.Text = r[4].ToString();
                        textPrVenta.Text = r[5].ToString();
                        textEstado.Text = r[6].ToString();
                        txtPropAnterior.Text = r[7].ToString();
                        textContacto.Text = r[8].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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

        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtModelo.Text = "";
            textTiempoUso.Text = "";
            txtNumSer.Text = "";
            txtPrCompra.Text = "";
            textPrVenta.Text = "";
            textEstado.Text = "";
            txtPropAnterior.Text = "";
            textContacto.Text = "";
        }

        private void txtPorNumSer_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
