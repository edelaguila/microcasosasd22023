using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class MovieDao : DBContext
    {
        public List<Movie> getMovies()
        {
            this.connection.Open();
            List<Movie> movies = new List<Movie>();
            string sql = "select * from pelicula";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string image = reader.GetString(2);
                string public_ = reader.GetString(3);
                string duration = reader.GetString(4);
                int id_listing = reader.GetInt32(5);
                int id_room = reader.GetInt32(6);
                Movie movie = new Movie(id, name, image, duration, id_listing, id_room, public_);
                movies.Add(movie);
            }
            this.connection.Close();
            return movies;
        }

        public void insertMovie(string name, string image, string duration, int id_listing, int id_room, string p)
        {
            MessageBox.Show(id_room + "," + id_listing);
            this.connection.Open();
            string sql = "INSERT INTO `pelicula` (`nombre`, `imagen`, `publico`, `duracion`, `id_cartelera`, `id_sala`) VALUES";
            //string query = "INSERT INTO Pelicula (nombre, imagen, publico, duracion, id_cartelera, id_sala)VALUES";
            //query += "('" + name + "', '" + image + "' , '" + p + "', '" + duration + "', '" + id_listing + "', '" + id_room + "');";
            sql += "('" + name + "', '" + image + "' ,'" + p + "',  '" + duration + "', '" + id_listing + "', '" + id_room + "');";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }
    }
}
