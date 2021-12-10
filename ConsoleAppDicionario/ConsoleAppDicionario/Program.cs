using System;
using System.Collections.Generic;

namespace ConsoleAppDicionario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*IDictionary<int, string> dic1 = new Dictionary<int, string>();
            dic1.Add(1, "Maria");
            dic1.Add(2, "Paulo");
            dic1.Add(3, "Pedro");*/

            Dictionary<int, string> dic1 = new Dictionary<int, string>()
            {
                {0, "Banana"},
                {1, "Banana"},
                {2, "Laranja"},
                {3, "Manga"},
                {4, "Abacate"},
                {5, "Maca"}
            };
            
            foreach (KeyValuePair<int, string> item in dic1)
	        {
                Console.WriteLine(item.Key+" "+item.Value);
	        }

            Console.WriteLine();
            Console.ReadKey();
            Console.WriteLine(dic1[2]);
            Console.WriteLine(dic1[4]);
            Console.ReadKey();
            Console.WriteLine();
            
            string resultado;
            if (dic1.TryGetValue(6, out resultado))
            {
                Console.WriteLine();
                Console.WriteLine(resultado);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Não foi possível achar a chave especificada.");
            }

            Console.WriteLine(dic1.ContainsKey(1)); // retorna true
            Console.WriteLine(dic1.ContainsKey(6)); // retorna false

            Console.WriteLine(dic1.ContainsValue("Manga"));

            Console.ReadKey();
            Console.WriteLine();

            int cont = 0;
            foreach (KeyValuePair<int, string> p in dic1)
            {
                if (p.Value == "Banana")
                {
                    cont++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(cont);
            Console.WriteLine();

            //Criando um dicionario ordenado
            SortedDictionary<string, int> dic2 = new SortedDictionary<string, int>();

            //Adicionando strings e chaves do tipo int
            dic2.Add("Zebra", 5);
            dic2.Add("Cachorro", 2);
            dic2.Add("Gato", 9);
            dic2.Add("Pardal", 4);
            dic2.Add("C#", 100);

            //Verifica se gato existe no dicionario
            if (dic2.ContainsKey("Gato"))
            {
                Console.WriteLine("Tem um gato ai...");
            }

            //Verifica se tem zebra
            if (dic2.ContainsKey("Zebra"))
            {
                Console.WriteLine("Deu zebra, pois não tem zebra ai...");
            }

            //Verifica se contém C#
            //e se tiver, pega o valor
            int v;
            if (dic2.TryGetValue("C#", out v))
            {
                Console.WriteLine(v);
            }

            //Imprime o SortedDictionary em ordem alfabetica
            foreach (KeyValuePair<string, int> p in dic2)
            {
                Console.WriteLine(p.Key + " " + p.Value);
            }
            Console.ReadKey();
        }

    }
}
