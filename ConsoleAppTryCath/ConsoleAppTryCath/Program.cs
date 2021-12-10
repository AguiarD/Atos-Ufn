using System;
using System.IO;
using System.Text;

namespace Aula0312
{
    class Program
    {

        static void Main(string[] args)
        {
            string nome, mensagem;
            Console.WriteLine("Digite o nome do arquivo: ");
            nome = Console.ReadLine();
            Arquivo a = new Arquivo(nome);
            int op;
            while (true)
            {
                Console.WriteLine("Digite uma operação:\n1 - para escrever no arquivo\n2 - para apresentar o texto do arquivo\n3 - para finalizar a execução\n4 - Exibir media ");
                op = int.Parse(Console.ReadLine());
                if (op == 1)
                {
                    a.criaAbreArquivo();
                    Console.WriteLine("Digite a mensagem para ser armazenada: \nPara sair, digite SAIR");
                    while (true)
                    {
                        mensagem = Console.ReadLine();
                        if (mensagem.Equals("SAIR"))
                        {
                            a.fechaArquivo();
                            break;
                        }
                        else
                        {
                            a.gravaMensagem(mensagem);
                        }
                    }
                }
                else if (op == 2)
                {
                    a.lerArquivo();
                }
                else if (op == 4)
                {
                    a.calcularMedia();
                }
            }
        }
    }
}