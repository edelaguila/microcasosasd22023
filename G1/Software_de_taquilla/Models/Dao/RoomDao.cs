using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class RoomDao : DBContext
    {

        public List<Room> getRooms()
        {

            this.connection.Open();
            List<Room> rooms = new List<Room>();
            string sql = "select * from sala";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                int id2 = reader.GetInt32(1);
                Room room = new Room(id, id2);
                rooms.Add(room);
            }
            this.connection.Close();
            return rooms;
        }
    }
}
