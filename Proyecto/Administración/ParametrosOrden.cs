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
    public partial class ParametrosOrden : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;

        public ParametrosOrden()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void btnCerrarAgrCliente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void cargarDatos() {

            try
            {
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
                    textNumInicio.Text = r[5].ToString();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
