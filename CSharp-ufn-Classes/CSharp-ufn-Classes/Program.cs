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

        static void somar(int n1, int n2) {
            int soma;
            soma = n1 + n2;
            Console.WriteLine("A soma dos dois elementos é " + soma);
        }
        static void subtrair(int n1, int n2)
        {
            int sub;
            sub = n1 - n2;
            Console.WriteLine("A subtração dos dois elementos é " + sub);
        }
        static void multiplicar(int n1, int n2)
        {
            int mult;
            mult = n1 * n2;
            Console.WriteLine("A multiplicacao dos dois elementos é " + mult);
        }
        static void dividir(int n1, int n2)
        {
            int divid = n1 / n2;
            Console.WriteLine("A divisão dos dois elementos é " + divid);
        }
        static double somar2(double n1, double n2)
        {
            double soma = n1 + n2;
            return soma;
        }
        static double subtrair2(double n1, double n2)
        {
            double sub = n1 - n2;
            return sub;
        }
        static double multiplicar2(double n1, double n2)
        {
            double mult = n1 * n2;
            return mult;
        }
        static double dividir2(double n1, double n2)
        {
            double divid = n1 / n2;
            return divid;
        }


        static int[] vetor;
        static int repeteVetor;

        static void criarVetor() {
            Console.Write("Informe o tamanho do vetor! ");
            repeteVetor = int.Parse(Console.ReadLine());
            vetor = new int[repeteVetor];

            for (int i = 0; i < repeteVetor; i++)
            {
                Console.WriteLine("Elemento " + (i + 1) + " = ");
                vetor[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < repeteVetor; i++)
            {
                Console.Write(vetor[i] + " | ");
            }
        }


        static void Main(string[] args)
        {
            /*int n, num1, num2, resultado;
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
            n2 = Console.ReadLine();*/

            //************************************somar1

            /*Console.WriteLine("Informe N1 e N2: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            somar(n1, n2);
            subtrair(n1, n2);
            multiplicar(n1, n2);
            dividir(n1, n2);*/

            //Console.WriteLine(somar(n1, n2));

            //***************************************************** verificar
            /*Console.WriteLine("Informe N1: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe N2: ");
            double n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe a operação (+, -, *, /): ");
            char operacao = char.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case '+':
                        Console.WriteLine("A soma de N1 e N2 = " + somar2(n1, n2));
                        break;
                    case '-':
                        Console.WriteLine("A subtracao de N1 por N2 = " + subtrair2(n1, n2));
                        break;
                    case '*':
                        Console.WriteLine("A multiplicacao de N1 com N2 = " + multiplicar2(n1, n2));
                        break;
                    case '/':
                        Console.WriteLine("A divisao de N1 por N2 = " + dividir2(n1, n2));
                        break;
                    case 'q':
                        break;
                    default:
                        break;
                }*/

            //**********************************************************

            /*Escreva um programa que leia um vetor com 30 elementos inteiros e escreva funções para fazer o que se pede(utilizar o vetor declarado globalmente)

            a.Exibir os elementos do vetor na ordem inversa

            b.Decompor em dois outros vetores, um contendo os elementos de índice ímpar e outro com os elementos de índice par

            c.Decompor em dois outros vetores, um contendo os elementos de valor ímpar e outro com os elementos de valor par.*/

            //int repete;
            //int[] vetor;


            criarVetor();

            for (int i = 0; i < length; i++)
            {

            }
            
        }
    }
}
