using System;

namespace CSharp_ufn_Classes
{
    class Program
    {
        static void mostraMensagem()
        {
            Console.WriteLine("Oi pessoal, tudo bem?");
        }
        static void mostrarNumero(int n)
        {
            Console.WriteLine("O número digitado foi: " + n);
        }
        static string lerNome()
        {
            string name;
            Console.WriteLine("Digite o nome: ");
            name = Console.ReadLine();
            return name;
        }
        static int somaValores(int n1, int n2)
        {
            int soma;
            soma = n1 + n2;
            return soma;
        }
        static int multiplicaValores(int n1, int n2)
        {
            return n1 * n2;
        }
        static Boolean retornaVerdade()
        {
            return true;
        }
        static void Main(string[] args)
        {
            int n, num1, num2, resultado;
            string nome;
            Console.WriteLine("Digite um numero: ");
            n = int.Parse(Console.ReadLine());
            mostrarNumero(n);
            mostraMensagem();
            nome = lerNome();
            Console.WriteLine("O nome digitado foi: " + nome);
            Console.WriteLine("Digite dois valores: ");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            resultado = somaValores(num1, num2);
            Console.WriteLine("O resultado da soma é: " + resultado);
            Console.WriteLine("O resultado da multiplicação é: " + multiplicaValores(num1, num2));
            string n2;
            n2 = Console.ReadLine();
        }
    }
}
