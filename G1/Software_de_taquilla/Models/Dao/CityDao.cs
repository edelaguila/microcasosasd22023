using MySql.Data.MySqlClient;
using Software_de_taquilla.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class CityDao : DBContext
    {
        public List<City> getCitys()
        {

            this.connection.Open();
            List<City> citys = new List<City>();
            string sql = "select * from ciudad";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string n = reader.GetString(1);
                string d = reader.GetString(2);
                City city = new City(id, n, d);
                citys.Add(city);
            }
            this.connection.Close();
            return citys;
        }

        public List<Cine> getCine()
        {

            this.connection.Open();
            List<Cine> citys = new List<Cine>();
            string sql = "select * from cine";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string n = reader.GetString(1);
                int d = reader.GetInt32(2);
                Cine city = new Cine(id, n, d);
                citys.Add(city);
            }
            this.connection.Close();
            return citys;
        }


    }
}
