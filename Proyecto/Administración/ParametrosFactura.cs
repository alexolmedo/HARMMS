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

namespace Proyecto.Administración
{
    public partial class ParametrosFactura : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public ParametrosFactura()
        {
            InitializeComponent();

            try {
                String strquery3 = "Select * from parametros";
              
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
                    textIVA.Text = r[0].ToString();
                    textNumInicio.Text = r[3].ToString();
                    textNumFinal.Text = r[4].ToString();
                    dateTimeInicio.Value = new DateTime(Convert.ToInt32(r[1].ToString().Substring(6, 4)), Convert.ToInt32(r[1].ToString().Substring(3, 2)), Convert.ToInt32(r[1].ToString().Substring(0, 2)));
                    dateTimeFinal.Value = new DateTime(Convert.ToInt32(r[2].ToString().Substring(6, 4)), Convert.ToInt32(r[2].ToString().Substring(3, 2)), Convert.ToInt32(r[2].ToString().Substring(0, 2)));
                    //dateTimeFinal.Value =
                    //d
                }
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
