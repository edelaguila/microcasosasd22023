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
            this.connection.Open();
            return this.connection != null;
        }
        public bool userExist(string username, string password)
        {
            bool exist = false;
            this.connection.Open();
            string query = "select * from usuario where nombre='" + username + "' and contrasenia='" + password + "'";
            MySqlCommand cursor = new MySqlCommand(query, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            if (reader.HasRows) exist = true;
            this.connection.Close();
            return exist;
        }

        public void insertUser(string username, string pass, int rol)
        {
            this.connection.Open();
            string sql = "insert into usuario(nombre, contrasenia, rol)values('" + username + "', '" + pass + "', '" + rol + "')";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

        public List<User> getUsers()
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

        public void deleteUser(int id)
        {
            this.connection.Open();
            string sql = "delete from usuario where id='" + id + "'";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

        public void updateUser(int id, string n, string c, int r)
        {
            this.connection.Open();
            string sql = "update usuario set nombre='" + n + "', contrasenia='" + c + "', rol='" + r + "' where id='" + id + "'";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }


    }
}
