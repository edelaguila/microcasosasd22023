using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Asiento
    {
        public int numero;
        public int id_sala;

        public Asiento(int numero, int id_sala)
        {
            this.numero = numero;
            this.id_sala = id_sala;
        }

        public Asiento(int id_sala)
        {
            this.id_sala = id_sala;
        }
    }
}
