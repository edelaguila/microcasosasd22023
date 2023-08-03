using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Software_de_taquilla.Models.Dto;

namespace Software_de_taquilla.Models.Dao
{
    public class VentaDao : DBContext
    {
        public void insertVenta(double total, int id_cine)
        {
            this.connection.Open();
            string sql = "insert into venta(total, id_cine, fecha)values('" + total + "', '" + id_cine + "', NOW())";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            this.connection.Close();
        }

        public List<Venta> getVenta()
        {
            this.connection.Open();
            List<Venta> ventas = new List<Venta>();
            string sql = "select * from venta";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            while (reader.Read())
            {
                int id = reader.GetInt32(0);
                double total = reader.GetDouble(1);
                int id_cine = reader.GetInt32(2);
                string fecha = reader.GetString(3);
                Venta venta = new Venta(id, total, id_cine, fecha);
                ventas.Add(venta);
            }
            this.connection.Close();
            return ventas;
        }

        public int getlastID()
        {
            this.connection.Open();
            List<Venta> ventas = new List<Venta>();
            string sql = "SELECT LAST_INSERT_ID();";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            MySqlDataReader reader = cursor.ExecuteReader();
            if (reader.Read())
            {
                int id = reader.GetInt32(0);
                return id;
            }
            this.connection.Close();
            return -1;
        }


    }
}
