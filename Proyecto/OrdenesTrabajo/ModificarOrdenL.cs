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
    public partial class ModificarOrdenL : Form
    {
        Conexion conexion = new Conexion();
        SqlDataAdapter da;
        DataTable dt;
        public ModificarOrdenL()
        {
            InitializeComponent();
            this.CenterToScreen();
            autocompletarOrdenLocal();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void autocompletarOrdenLocal()
        {
            string strquery1 = "Select num_ordentrabajo from ordendetrabajo where TIPOORDENTRABAJO='L'";
            conexion.command = new SqlCommand(strquery1, conexion.connection);

            da = new SqlDataAdapter();
            da.SelectCommand = conexion.command;
            dt = new DataTable();
            da.Fill(dt);

            txtOrdenLocal.AutoCompleteCustomSource.Clear();
            foreach (DataRow r in dt.Rows)
            {
                var rw = r.Field<string>("num_ordentrabajo");

                txtOrdenLocal.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtOrdenLocal.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtOrdenLocal.AutoCompleteCustomSource.Add(rw);
            }
        }

        private void ModificarOrdenL_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String strquery = "";

            strquery = "select [NUM_ORDENTRABAJO],[CI_CLIENTE],[TIPOORDENTRABAJO],CAST(FECHARECEP_REV AS DATE),CAST(FECHAENTREGA AS DATE),cast(HORAINICIOC as time(0)),[HABILITADA],[ESTADOOT],[DESCRIPCIONOT],[COSTOOT] from ordendetrabajo where num_ordentrabajo = " + txtOrdenLocal.Text + "";

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
                    txtCedulaLocal.Text = r[1].ToString();
                    fechaEntrega.Value = DateTime.Parse(r[3].ToString());
                    fechaRecepcion.Value = DateTime.Parse(r[4].ToString());
                    if (r[6].ToString().Equals("H"))
                    {
                        cbHabilitado.SelectedItem = "Habilitada";
                    }
                    else
                    {
                        cbHabilitado.Text = "Deshabilitada";
                    }

                    if (r[7].ToString().Equals("E"))
                    {
                        cbEstado.Text = "Entregada";
                    }
                    else
                    {
                        cbEstado.Text = "No entregada";
                    }

                    txtDescripcionLocal.Text = r[8].ToString();
                    txtCostoLocal.Text = r[9].ToString();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE ordendetrabajo SET FECHARECEP_REV='" + fechaRecepcion.Value.Date.ToString("yyyyMMdd") + "',FECHAENTREGA='" + fechaEntrega.Value.Date.ToString("yyyyMMdd") + "',HABILITADA='" + cbHabilitado.SelectedItem.ToString()[0] + "',DESCRIPCIONOT='" + txtDescripcionLocal.Text + "',COSTOOT=" + txtCostoLocal.Text + ",ESTADOOT='" + cbEstado.SelectedItem.ToString()[0] + "' WHERE NUM_ORDENTRABAJO=" + txtOrdenLocal.Text;
            //Console.WriteLine(sql);
            conexion.command = new SqlCommand(sql, conexion.connection);
            conexion.command.ExecuteNonQuery();
            conexion.command.Dispose();
            MessageBox.Show("La orden se modificó correctamente", "Orden Agregada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
