using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class UserDao : DBContext
    {

        public bool isConnected()
        {
            try
            {

                this.connection.Open();
                return this.connection != null;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al conectar con la base de datos: " +
               ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }
        public bool userExist(string username, string password, int role)
        {
            try
            {
                bool exist = false;
                this.connection.Open();
                string query = "select * from usuario where nombre='" + username + "' and contrasenia='" + password + "' and rol='" + role + "'";
                MySqlCommand cursor = new MySqlCommand(query, this.connection);
                MySqlDataReader reader = cursor.ExecuteReader();
                if (reader.HasRows) exist = true;
                this.connection.Close();
                return exist;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al verificar el usuario: " + ex.Message,
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public void insertUser(string username, string pass, int rol)
        {
            try
            {
                this.connection.Open();
                string sql = "insert into usuario(nombre, contrasenia, rol)values('" + username + "', '" + pass + "', '" + rol + "')";
                MySqlCommand cursor = new MySqlCommand(sql, this.connection);
                cursor.ExecuteNonQuery();
                this.connection.Close();
            }
            catch (Exception ex)
            {  

                MessageBox.Show("Error al insertar el usuario: " + ex.Message,
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

            public List<User> getUsers()
        {
            try
            {
                this.connection.Open();
                List<User> users = new List<User>();
                string sql = "select * from usuario";
                MySqlCommand cursor = new MySqlCommand(sql, this.connection);
                MySqlDataReader reader = cursor.ExecuteReader();
                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);
                    string pass = reader.GetString(2);
                    int rol = reader.GetInt32(3);
                    User usr = new User(id, name, pass, rol);
                    users.Add(usr);
                }
                this.connection.Close();
                return users;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al obtener los usuarios: " + ex.Message,
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void deleteUser(int id)
        {
            try
            {
                this.connection.Open();
                string sql = "delete from usuario where id='" + id + "'";
                MySqlCommand cursor = new MySqlCommand(sql, this.connection);
                cursor.ExecuteNonQuery();
                this.connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al eliminar el usuario: " + ex.Message,
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public void updateUser(int id, string n, string c, int r)
        {
            try {
                this.connection.Open();
                string sql = "update usuario set nombre='" + n + "', contrasenia='" + c + "', rol='" + r + "' where id='" + id + "'";
                MySqlCommand cursor = new MySqlCommand(sql, this.connection);
                cursor.ExecuteNonQuery();
                this.connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error al actualizar el usuario: " + ex.Message,
               "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}
