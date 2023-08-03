using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Venta
    {
        public int id;
        public double total;
        public int id_cine;
        public string fecha;
        public Venta(int id, double t, int id_c)
        {
            this.id = id;
            this.total = t;
            this.id_cine = id_c;
        }

        public Venta(int id, double t, int id_c, string fecha)
        {
            this.id = id;
            this.total = t;
            this.id_cine = id_c;
            this.fecha = fecha;
        }

        public Venta(double t, int id_c)
        {
            this.total = t;
            this.id_cine = id_c;
        }
    }
}
