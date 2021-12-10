using System;
using System.Collections.Generic;

namespace ConsoleAppListasEDicionarios
{
    class Program
    {
        static List<Pessoa> pessoas;
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(40, "Ricardo");
            Pessoa p2 = new Pessoa(25, "Ana");
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa(40, "Ricardo"));
            pessoas.Add(new Pessoa(25, "Jefferson"));
            pessoas.Add(new Pessoa(45, "Miriam"));

            foreach (Pessoa p in pessoas)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }
            Console.WriteLine();
            Console.WriteLine("Digite uma tecla. . .");
            Console.ReadKey();
            
            Console.WriteLine();
            ListaNaoOrdenada();

            Console.ReadKey();
            Console.WriteLine();
            ListaOrdenadaPorNome();

            Console.ReadKey();
            Console.WriteLine();
            ListaOrdenadaPorIdade();

            Console.ReadKey();
            Console.WriteLine();
            ListaInserirItemNaPosicao();
            ListaNaoOrdenada();

            Console.ReadKey();
            Console.WriteLine();
            ListaConverterParaArray();

            Console.ReadKey();
            Console.WriteLine();
            ListaLocalizaPessoaMaisJovem();

        }

        //Listar de forma desordenada
        static void ListaNaoOrdenada()
        {
            Console.WriteLine("Lista não ordenada");
            pessoas.ForEach(delegate (Pessoa p) { Console.WriteLine(p.Idade + " " + p.Nome); });
            Console.WriteLine();
        }

        static void ListaOrdenadaPorNome()
        {
            Console.WriteLine("Lista ordenada por Nome");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2) { return p1.Nome.CompareTo(p2.Nome); });
            pessoas.ForEach(delegate (Pessoa p) { Console.WriteLine(p.Idade + " " + p.Nome); });
            Console.WriteLine();
        }

        static void ListaOrdenadaPorIdade()
        {
            Console.WriteLine("Lista ordenada por Idade");
            pessoas.Sort(delegate (Pessoa p1, Pessoa p2) { return p1.Idade.CompareTo(p2.Idade); });
            pessoas.ForEach(delegate (Pessoa p) { Console.WriteLine(p.Idade + " " + p.Nome); });
            Console.WriteLine();
        }

        static void ListaInserirItemNaPosicao()
        {
            Console.WriteLine("Inserindo uma pessoa na posição 1 e outra na posição 3");

            pessoas.Insert(1, new Pessoa() { Nome = "Bob Dylan", Idade = 78 });
            pessoas.Insert(3, new Pessoa() { Nome = "Jimmi Page", Idade = 81 });
            Console.WriteLine();
        }

        static void ListaConverterParaArray()
        {
            Console.WriteLine("Convertendo a lista para um array");
            Pessoa[] ListaArray = pessoas.ToArray();
            foreach (Pessoa p in ListaArray)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            }
            Console.WriteLine();
        }

        static void ListaLocalizaPessoaMaisJovem()
        {
            List<Pessoa> jovem = pessoas.FindAll(delegate (Pessoa p) { return p.Idade < 45; });
            
            Console.WriteLine("Idade é menor que 45 : ");
            jovem.ForEach(delegate (Pessoa p) { Console.WriteLine(p.Nome + " " + p.Idade); });
            Console.WriteLine();
            
        }
    }
}
