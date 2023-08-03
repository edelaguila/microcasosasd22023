using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Schedule
    {
        public int id;
        public string h_start;
        public string h_final;
        public int id_movie;

        public Schedule(int id, string h_start, string h_final, int id_movie)
        {
            this.id = id;
            this.h_start = h_start;
            this.h_final = h_final;
            this.id_movie = id_movie;
        }

        public Schedule(string h_start, string h_final, int id_movie)
        {
            this.h_start = h_start;
            this.h_final = h_final;
            this.id_movie = id_movie;
        }
    }
}
