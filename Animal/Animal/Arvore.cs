using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Arvore : IArvore
    {
        public int id { get; set; }
        public string nome { get; set; }

        public void morrer()
        {
            Console.WriteLine("Oi");
        }

        public void viver()
        {
            Console.WriteLine("Tchau");
        }
    }
}
