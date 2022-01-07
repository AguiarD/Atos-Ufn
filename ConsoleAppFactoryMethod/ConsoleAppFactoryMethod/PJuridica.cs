using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFactoryMethod
{
    public class PJuridica : Pessoa
    {
        public PJuridica(string nome)
        {
            this.Nome = nome;
            this.Tipo = "PJ";
        }
    }
}
