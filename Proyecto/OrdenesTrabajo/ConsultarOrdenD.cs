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

        private void ConsultarOrden_Load(object sender, EventArgs e)
        {

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
    }
}
