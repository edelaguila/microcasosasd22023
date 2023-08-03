using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software_de_taquilla.Models.Dto
{
    public class User
    {
        public int id;
        public string name;
        public string pass;
        public int rol;

        public User(int id, string name, string pass, int rol)
        {
            this.id = id;
            this.name = name;
            this.pass = pass;
            this.rol = rol;
        }

        public User(string name, string pass, int rol)
        {
            this.name = name;
            this.pass = pass;
            this.rol = rol;
        }
    }
}
