using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    interface IArvore
    {
        int id { get; set; }
        string nome { get; set; }
        
        void viver();
        void morrer();
    }
}
