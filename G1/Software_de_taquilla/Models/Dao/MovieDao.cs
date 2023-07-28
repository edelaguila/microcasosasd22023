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
            this.connection.Open();
            string sql = "INSERT INTO `pelicula` (`nombre`, `imagen`, `publico`, `duracion`, `id_cartelera`, `id_sala`) VALUES";
            sql += "('" + name + "', '" + image + "' ,'" + p + "',  '" + duration + "', '" + id_listing + "', '" + id_room + "');";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

        public List<Movie> getMovies(int id_c, int id_l)
        {

            this.connection.Open();
            List<Movie> movies = new List<Movie>();

            string sql = "SELECT pelicula.id, pelicula.nombre,pelicula.imagen,pelicula.publico, pelicula.duracion, pelicula.id_sala, Cine.lugar FROM pelicula INNER JOIN Cartelera ON pelicula.id_cartelera = cartelera.id INNER JOIN Cine ON test.cartelera.id_cine = Cine.id ";
            sql += " where Cine.id_ciudad = '" + id_c + "' and Cine.id = '" + id_l + "';";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string name = reader.GetString(1);
                string image = reader.GetString(2);
                string public_ = reader.GetString(3);
                string duration = reader.GetString(4);
                int id_room = reader.GetInt32(5);
                Movie movie = new Movie(id, name, image, duration, 0, id_room, public_);
                movies.Add(movie);
            }
            this.connection.Close();
            return movies;
        }
    }
}
