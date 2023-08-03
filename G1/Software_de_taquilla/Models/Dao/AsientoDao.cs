using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using MySql.Data.MySqlClient;

namespace Software_de_taquilla.Models.Dao
{
    public class AsientoDao : DBContext
    {
        public List<Asiento> getAsiento()
        {

            this.connection.Open();
            List<Asiento> asientos = new List<Asiento>();
            string sql = "select * from asiento";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int n = reader.GetInt32(1);
                int e = reader.GetInt32(2);
                Asiento asiento = new Asiento(id, n, e);
                asientos.Add(asiento);
            }
            this.connection.Close();
            return asientos;
        }


        public void updateAsiento(int id, int state)
        {
            this.connection.Open();
            string sql = "update asiento set estado=" + state + " where numero=" + id + ";";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

    }
}
