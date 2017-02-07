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

namespace Proyecto
{
    public partial class Login : Form
    {
        SqlConnection connection;
        SqlCommand command;

        public Login()
        {
            InitializeComponent();
            this.CenterToScreen();

            string connectionString;

            // Debe existir un archivo de texto loginbase.txt conteniendo un string de la forma:
            // Data Source=localhost;Initial Catalog=propietarios;User ID=sa;Password=qwerty
            // en la carpeta Proyecto\

            System.IO.StreamReader file = new System.IO.StreamReader("../../../loginbase.txt");
            connectionString = file.ReadLine();

            string sql = null;

            sql = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";

            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                //connection.Close();
                MessageBox.Show("¡La conexion es correcta! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡No se puede conectar! ");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            new VentanaModulos().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text.Equals("admin", StringComparison.Ordinal) && txtContrasena.Text.Equals("12345", StringComparison.Ordinal)){
                new VentanaModulos().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Los datos ingresados son incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                txtContrasena.Text = "";
                txtUsuario.Text = "";
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                button1.PerformClick();
            }
        }
    }
}
