using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Cine
    {
        public int id;
        public string lugar;
        public int id_ciudad;

        public Cine(int id, string lugar, int id_ciudad)
        {
            this.id = id;
            this.lugar = lugar;
            this.id_ciudad = id_ciudad;
        }

        public Cine(string lugar, int id_ciudad)
        {
            this.lugar = lugar;
            this.id_ciudad = id_ciudad;
        }
    }
}
