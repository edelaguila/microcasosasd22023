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

namespace Interface_Admin
{
    public partial class empleadoEdicion : Form
    {

        public empleadoEdicion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConnection dbConnection = DatabaseConnection.Instance;

            SqlConnection connection = dbConnection.OpenConnection();

            
                // Obtener los datos ingresados por el usuario desde el formulario de creación
                string nombre = Nombre.Text;
                string apellido = Apellido.Text;
                int edad = Convert.ToInt32(Edad.Text);
                int telefono = Convert.ToInt32(Telefono.Text);
                string correo = Correo.Text;
                string cargo = Cargo.Text;

                // Realizar la inserción en la base de datos
                try
                {
                    // Abrir la conexión a la base de datos


                    {
                        string sqlQuery = "INSERT INTO empleados (nombre, apellido, edad, telefono, correo, cargo) VALUES (@nombre, @apellido, @edad, @telefono, @correo, @cargo);";
                        using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                        {
                            command.Parameters.AddWithValue("@nombre", nombre);
                            command.Parameters.AddWithValue("@apellido", apellido);
                            command.Parameters.AddWithValue("@edad", edad);
                            command.Parameters.AddWithValue("@telefono", telefono);
                            command.Parameters.AddWithValue("@correo", correo);
                            command.Parameters.AddWithValue("@cargo", cargo);

                            int rowsAffected = command.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Nuevo empleado agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Actualizar el DataGridView después de la inserción
                                
                            }
                            else
                            {
                                MessageBox.Show("No se pudo agregar el nuevo empleado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Manejo de errores (mostrar mensaje, registrar el error, etc.)
                    MessageBox.Show("Error al agregar el nuevo empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    // Cerrar la conexión a la base de datos
                    dbConnection.CloseConnection();
                }
            
        }
    }
}
