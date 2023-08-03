using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Room
    {
        public int id;
        public int capacity;

        public Room(int id, int capacity)
        {
            this.id = id;
            this.capacity = capacity;
        }
        public Room(int capacity)
        {
            this.capacity = capacity;
        }
    }
}
