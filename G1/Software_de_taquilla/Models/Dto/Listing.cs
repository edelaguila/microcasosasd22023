using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Listing
    {
        public int id;
        public int id_desc;
        public int id_city;
        public Listing(int id, int id_desc, int id_c)
        {
            this.id = id;
            this.id_desc = id_desc;
            this.id_city = id_c;
        }
    }
}
