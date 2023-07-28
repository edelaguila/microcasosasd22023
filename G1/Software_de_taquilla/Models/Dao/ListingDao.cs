using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class ListingDao : DBContext
    {
        public List<Listing> getListings()
        {

            this.connection.Open();
            List<Listing> listings = new List<Listing>();
            string sql = "select * from cartelera";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int id2 = reader.GetInt32(1);
                int id3 = reader.GetInt32(2);
                Listing listing = new Listing(id, id2, id3);
                listings.Add(listing);
            }
            this.connection.Close();
            return listings;
        }
    }
}
