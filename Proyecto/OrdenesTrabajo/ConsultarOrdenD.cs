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
    public partial class ConsultarOrdenD : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;
        public ConsultarOrdenD()
        {
            InitializeComponent();
            this.CenterToScreen();
            autocompletarOrdenDomicilio();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autocompletarOrdenDomicilio()
        {
            string strquery1 = "Select num_ordentrabajo from ordendetrabajo where TIPOORDENTRABAJO='D'";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            da.SelectCommand = conexion.command;
            dt = new DataTable();
            da.Fill(dt);

            txtOrdenDomicilio.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                var rw = r.Field<string>("num_ordentrabajo");

                txtOrdenDomicilio.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtOrdenDomicilio.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtOrdenDomicilio.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strquery = "";

            strquery = "select [NUM_ORDENTRABAJO],[CI_CLIENTE],[TIPOORDENTRABAJO],CAST(FECHARECEP_REV AS DATE),[FECHAENTREGA],cast(HORAINICIOC as time(0)),[HABILITADA],[ESTADOOT],[DESCRIPCIONOT],[COSTOOT] from ordendetrabajo where num_ordentrabajo = " + txtOrdenDomicilio.Text + "";

            conexion.command = new SqlCommand(strquery, conexion.connection);

            da = new SqlDataAdapter();
            da.SelectCommand = conexion.command;
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("La orden no está registrada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                foreach (DataRow r in dt.Rows)
                {
                    txtCedulaDomicilio.Text = r[1].ToString();
                    txtFechaDomicilio.Text = r[3].ToString();
                    txtHoraDomicilio.Text = r[5].ToString();
                    if (r[6].ToString().Equals("H")) {
                        txtHabilitadaDomicilio.Text = "Habilitada" ;
                    } else {
                        txtHabilitadaDomicilio.Text = "Deshabilitada";
                    }

                    if (r[7].ToString().Equals("E")) {
                        txtEstadodomicilio.Text = "Entregada";
                    } else {
                        txtEstadodomicilio.Text = "No entregada";
                    }

                    txtDescripcionDomicilio.Text = r[8].ToString();
                    txtCostoDomicilio.Text = r[9].ToString();
                }
            }
        }
    }
}
