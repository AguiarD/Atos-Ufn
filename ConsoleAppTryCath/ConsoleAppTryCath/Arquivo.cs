using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Aula0312
{
    class Arquivo
    {
        string nome, mensagem;
        StreamWriter sw;
        StreamReader sr;
        public Arquivo(string nome)
        {
            this.nome = nome;
        }

        public void criaAbreArquivo()
        {
            sw = new StreamWriter("C:\\Users\\Cliente\\Pictures\\teste\\" + nome + ".txt", true, Encoding.UTF8);

        }

        public void lerArquivo()
        {
            string linha;
            sr = new StreamReader("C:\\Users\\Cliente\\Pictures\\teste\\" + nome + ".txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                Console.WriteLine(linha);
                linha = sr.ReadLine();
            }
            sr.Close();

        }

        public void gravaMensagem(string mensagem)
        {
            sw.WriteLine(mensagem);
        }

        public void fechaArquivo()
        {
            sw.Close();
        }

        public void calcularMedia()
        {
            string aluno, nota;
            double n1, n2, n3, media;
            sr = new StreamReader("C:\\Users\\Cliente\\Pictures\\teste\\" + nome + ".txt");
            nota = sr.ReadLine();

            while (nota != null)
            {
                aluno = nota;
                Console.WriteLine("Nome: " + aluno);
                nota = sr.ReadLine(); //pulo para a linha da primeira nota
                n1 = double.Parse(nota);

                nota = sr.ReadLine(); //pulo para a linha da segunda nota
                n2 = double.Parse(nota);

                nota = sr.ReadLine(); //pulo para a linha da terceira nota
                n3 = double.Parse(nota);

                media = (n1 + n2 + n3) / 3;

                Console.WriteLine("A média de " + aluno + " é " + media);
                nota = sr.ReadLine();

            }
            
            sr.Close();

        }

    }
}