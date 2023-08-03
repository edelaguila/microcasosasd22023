using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dao
{
    public class BoletoDao : DBContext
    {

        public void open() { this.connection.Open(); }
        public void close() { this.connection.Close(); }
        public void insertBoleto(int idv, int idp, int idc, int idas, double pr, string cl)
        {
            open();
            string sql = "insert into boleto(id_venta, id_pelicula, id_cine, id_asiento, precio, clasificacion)";
            sql += "values('" + idv + "', '" + idp + "', '" + idc + "', '" + idas + "', '" + pr + "', '" + cl + "');";
            MySqlCommand cursor = new MySqlCommand(sql, this.connection);
            cursor.ExecuteNonQuery();
            close();
        }
    }
}
