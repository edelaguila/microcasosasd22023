using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class City
    {
        public int id;
        public string name;
        public string dir;

        public City(int id, string name, string dir)
        {
            this.id = id;
            this.name = name;
            this.dir = dir;
        }
    }
}
