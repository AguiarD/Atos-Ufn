using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDesafio
{
    class Arquivo
    {
        StreamReader sr;
        public int contP = 0, contA = 0;
        Pessoa a = new Pessoa();

        public void lerArquivo()
        {
            string linha;
            string[] pessoas;
            sr = new StreamReader("C:\\Users\\Cliente\\Pictures\\teste\\desafio1.txt");
            linha = sr.ReadLine();
            while (linha != null)
            {
                linha = sr.ReadLine();

                try
                {

                    pessoas = linha.Split('-');

                    if (pessoas[0] == "Z")
                    {
                        //Pessoa a = new Pessoa();
                        a.nome = pessoas[1];
                        a.tel = pessoas[2];
                        a.cidade = pessoas[3];
                        a.rg = pessoas[4];
                        a.cpf = pessoas[5];
                        /*Console.WriteLine(pessoas[0]);
                        Console.WriteLine(pessoas[1]);
                        Console.WriteLine(pessoas[2]);
                        Console.WriteLine(pessoas[3]);
                        Console.WriteLine(pessoas[4]);
                        Console.WriteLine(pessoas[5]);*/
                        a.gravarPessoa();
                        contP++;
                    }
                    else if (pessoas[0] == "Y")
                    {
                        
                        
                        /*Console.WriteLine(pessoas[0]);
                        Console.WriteLine(pessoas[1]);
                        Console.WriteLine(pessoas[2]);
                        Console.WriteLine(pessoas[3]);*/
                    }
                    Console.WriteLine();
                    //}
                }
                catch (Exception ex)
                {

                    sr.Close();
                }
            }

        }
    }
}
