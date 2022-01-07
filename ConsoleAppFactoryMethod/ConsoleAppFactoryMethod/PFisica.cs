using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFactoryMethod
{
    public class PFisica : Pessoa
    {
        public PFisica(string nome)
        {
            this.Nome = nome;
            this.Tipo = "PF";
        }
    }
}
