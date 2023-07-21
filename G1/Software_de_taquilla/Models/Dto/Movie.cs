using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Movie
    {
        public int id;
        public string name;
        public string image;
        public string public_;
        public string duration;
        public int id_listing;
        public int id_room;

        public Movie(int id, string name, string image, string duration, int id_listing, int id_room, string p)
        {
            this.public_ = p;
            this.id = id;
            this.name = name;
            this.image = image;
            this.duration = duration;
            this.id_listing = id_listing;
            this.id_room = id_room;
        }
    }

}
