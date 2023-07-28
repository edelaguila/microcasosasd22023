using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Software_de_taquilla.Models.Dao
{
    public class DBContext
    {
        protected MySqlConnection connection = new MySqlConnection("server=testglobal.mysql.database.azure.com;database=test;uid=Adminandrea;pwd=analisis2!;");
    }
}
