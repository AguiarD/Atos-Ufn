using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSingleton
{
    public class Singleton
    {
        private static Singleton instancia = null;
        public static string nome;

        public static Singleton getInstance()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
                nome = "Douglas";
            }

            return instancia;
        }
    }
}
