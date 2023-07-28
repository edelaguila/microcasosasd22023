using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Usuario
{
    internal class Conexion
    {
        MySqlConnection conex = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "Polideportivo";
        static string usuario = "root";
        static string password = "PerezF15";
        static string puerto = "3306";

        string cadenaConexion = "server=" + servidor + ";" + "port" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database=" + bd + ";";

        public MySqlConnection establecerConexion()
        {
            try {

                conex.ConnectionString = cadenaConexion;
                conex.Open();
                MessageBox.Show("Se conecto a la base de datos");

            }
            catch(Exception ex) {

                MessageBox.Show("No conecto a la base de datos, error:"+ex.ToString());
            }
            return conex;
        }
        public void cerrarConexion()
        {
            conex.Close();
        }
    }
}
