﻿using System;
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
                        Console.WriteLine(pessoas[0]);
                        Console.WriteLine(pessoas[1]);
                        Console.WriteLine(pessoas[2]);
                        Console.WriteLine(pessoas[3]);
                        Console.WriteLine(pessoas[4]);
                        Console.WriteLine(pessoas[5]);
                    }
                    else if (pessoas[0] == "Y")
                    {
                        Console.WriteLine(pessoas[0]);
                        Console.WriteLine(pessoas[1]);
                        Console.WriteLine(pessoas[2]);
                        Console.WriteLine(pessoas[3]);
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
