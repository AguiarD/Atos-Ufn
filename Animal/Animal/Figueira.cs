using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Figueira : IArvore
    {
        public int id { get; set; }
        public string nome { get; set; }

        public void morrer()
        {
            Console.WriteLine("Sou uma Figueira partindo");
        }

        public void viver()
        {
            Console.WriteLine("Sou uma Figueira vivendo");
        }
    }
}
