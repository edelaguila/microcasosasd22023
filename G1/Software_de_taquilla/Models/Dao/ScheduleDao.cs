using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;
using MySql.Data.MySqlClient;

namespace Software_de_taquilla.Models.Dao
{
    public class ScheduleDao : DBContext
    {
        public List<Schedule> getSchedules()
        {
            this.connection.Open();
            List<Schedule> schedules = new List<Schedule>();
            string sql = "select * from horario";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                string h_i = reader.GetString(1);
                string h_f = reader.GetString(2);
                int id_m = reader.GetInt32(3);
                Schedule sc = new Schedule(id, h_i, h_f, id_m);
                schedules.Add(sc);
            }
            this.connection.Close();
            return schedules;
        }

        public void insertarSchedule(Schedule sc)
        {
            this.connection.Open();
            string sql = "insert into horario(hora_inicio, hora_fin, id_pelicula)";
            sql += "values('" + sc.h_start + "', '" + sc.h_final + "', '" + sc.id_movie + "' );";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

    }
}
