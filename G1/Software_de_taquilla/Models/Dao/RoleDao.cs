using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class RoleDao : DBContext
    {
        public List<Role> getRoles()
        {
            this.connection.Open();
            List<Role> roles = new List<Role>();
            string sql = "select * from rol";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string desc = reader.GetString(1);
                int n = reader.GetInt32(2);
                Role role = new Role(id, desc, n);
                roles.Add(role);
            }
            this.connection.Close();
            return roles;
        }
    }
}
