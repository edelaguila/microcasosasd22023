using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class Role
    {
        public int id;
        public string description;
        public int level;
        public Role(int i, string d, int l)
        {
            this.id = i;
            this.description = d;
            this.level = l;
        }

        public Role(string d, int l)
        {
            this.level = l;
            this.description = d;
        }
    }
}
