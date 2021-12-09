using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesafio
{
    class Arquivo
    {        
        StreamReader sr;
        
        public void lerArquivo()
        {
            string linha, tipo;
            sr = new StreamReader("C:\\Users\\Cliente\\Pictures\\teste\\desafio1.txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                linha = sr.ReadLine();
                //Console.WriteLine(linha);

                //tipo = linha.Substring(0, 2);
                //if (tipo == "Z")
                //{
                    string[] pessoas = linha.Split('-');

                    foreach (var pessoa in pessoas)
                    {
                        if (pessoas[0] == "Z")
                        {
                            Console.WriteLine(pessoas[1]);
                        }
                    }
                        Console.WriteLine();
                //}
            }
            sr.Close();

        }

        /*public void gravaMensagem(string mensagem)
        {
            sw.WriteLine(mensagem);
        }

        public void fechaArquivo()
        {
            sw.Close();
        }*/


    }
}
