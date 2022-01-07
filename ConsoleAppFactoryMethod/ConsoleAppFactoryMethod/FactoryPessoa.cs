using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFactoryMethod
{
    public class FactoryPessoa  //Ele que vai gerenciar tudo
    {
        public Pessoa getPessoa(string nome, string tipo)
        {
            if (tipo.Equals("PF"))
            {
                Console.WriteLine("Pessoa Fisica");
                return new PFisica(nome);
            }
            else if (tipo.Equals("PJ"))
            {
                Console.WriteLine("Pessoa Juridica");
                return new PJuridica(nome);
            }
            else
            {
                Console.WriteLine("Nada");
                return null;  //Sefor != de "PF" ou "PJ", retorna null e vai dar erro nesta aplicação
            }

        }
    }
}
