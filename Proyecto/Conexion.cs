using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto
{


    public class Conexion
    {
        public SqlConnection connection;
        public SqlCommand command;

        public Conexion()
        {
            string connectionString;

            // Debe existir un archivo de texto loginbase.txt conteniendo un string de la forma:
            // Data Source=localhost;Initial Catalog=ProyPropietarios;User ID=sa;Password=qwerty
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
                //MessageBox.Show("¡La conexion es correcta! ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡No se puede conectar! ");
                Console.WriteLine(ex.Message);
            }
        }
    }


}
