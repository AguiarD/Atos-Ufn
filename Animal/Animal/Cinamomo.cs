using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Cinamomo : IArvore
    {
        public int id { get => id; set => id = value; }
        public string nome { get => nome; set => nome = value; }

        public void morrer()
        {
            Console.WriteLine("Sou um cinamomo partindo");
        }

        public void viver()
        {
            Console.WriteLine("Sou um cinamomo vivendo");
        }
    }
}
