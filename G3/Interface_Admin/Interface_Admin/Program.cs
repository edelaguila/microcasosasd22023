using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Interface_Admin
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

            string connectionString = @"Data Source=polideportivog3analisis.database.windows.net;Initial Catalog=polideportivog3;User ID=adminsql1;Password=Grupo3analisis;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sqlQuery = "SELECT * FROM EMPLEADOS;";
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                // Leer los datos retornados por la consulta
                                // Ejemplo: int id = reader.GetInt32(0);
                                //         string nombre = reader.GetString(1);
                                //         ...
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores (mostrar mensaje, registrar el error, etc.)
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}
