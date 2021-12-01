using System;

namespace POO_UFN1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Lampada l1 = new Lampada();
            l1.ligar();
            //l1.desligar();


            Console.WriteLine("Ligado? " + l1.estaLigada());
            
            l1.desligar();

            Console.WriteLine("Ligado? " + l1.estaLigada());*/

            /*Lampada l2 = new Lampada();
            l2.acender();
            Console.WriteLine(l2.estaLigado());

            l2.estaMeioAcesa();
            Console.WriteLine(l2.estaLigado());

            l2.apagar();
            Console.WriteLine(l2.estaLigado());*/

            /*int n;
            Lampada l3 = new Lampada();

            l3.desligar();

            while (true)
            {
                if (l3.estaLigado() == "Desligado")
                {
                    Console.WriteLine("Digite 1 para ligar ou 2 para deixar em meia luz");
                    n = int.Parse(Console.ReadLine());
                    l3.setaLuz(n);
                    Console.WriteLine("Ligado? " + l3.estaLigado());
                }
                else if (l3.estaLigado() == "Ligado")
                {
                    Console.WriteLine("Digite 0 para desligar ou 2 para deixar em meia luz");
                    n = int.Parse(Console.ReadLine());
                    l3.setaLuz(n);
                    Console.WriteLine("Ligado? " + l3.estaLigado());
                }
                else if (l3.estaLigado() == "Meia Luz")
                {
                    Console.WriteLine("Digite 0 para desligar ou 1 para ligar");
                    n = int.Parse(Console.ReadLine());
                    l3.setaLuz(n);
                    Console.WriteLine("Ligado? " + l3.estaLigado());
                } else
                {
                    break;
                }
            }*/

            /*Livro Livro1 = new Livro();

            Console.WriteLine("Informe o Titulo do Livro: " + "/n");
            Console.WriteLine("Titulo: " + Livro1.recebeTitulo());
            
            Console.WriteLine("Informe o Genero do Livro: " + "/n");
            Console.WriteLine("Genero: " + Livro1.recebeGenero());
            
            Console.WriteLine("Informe o Autor do Livro: " + "/n");
            Console.WriteLine("Autor: " + Livro1.recebeAutor());
            
            Console.WriteLine("Informe a Editora do Livro: " + "/n");
            Console.WriteLine("Editora: " + Livro1.recebeEditora());*/

            //Livro livro2 = new Livro("Harry Poiier", "Autor teste", "Editora Teste", "Fantasia", 1980, "12345678912");

            /*livro2.titulo = "Harry Poiier";
            livro2.autor = "Autor teste";
            livro2.editora = "Editora Teste";
            livro2.ano = 1980;
            livro2.genero = "Fantasia";
            livro2.isbn = "12345678912";*/

            /*Pessoa pessoa1 = new Pessoa("Douglas", "12345678912", "04-12-1991");
            pessoa1.retornaNome();
            pessoa1.retornaCpf();
            pessoa1.retornaNascimento();

            pessoa1.setNome("Aguiar");*/
            //Console.WriteLine(setNome(pessoa1));


            /*Concluir
            Curso c = new Curso("Capacitação");
            Disciplina*/



            //-----------------------------

            /*concluir
            Motor m = new Motor();
            m.getNomeFabricante = "Teste";
            m.mostraDados();*/

            //--------------------------------

            /*Carro car1 = new Carro();
            car1.modelo = "Mustang";
            car1.cor = "Preto";
            car1.ano = 1967;
            car1.marca = "Ford";
            car1.chassi = "sadfsfsfgdfghgfh";
            car1.proprietario = "Douglas";
            car1.vAtual = 80;
            car1.vMaxima = 100;

            for (int i = 0; i < 100; i++)
            {
                car1.acelera();
            }
            
            

            Console.WriteLine("Modelo: " + car1.modelo);
            Console.WriteLine("Cor: " + car1.cor);
            Console.WriteLine("ano: " + car1.ano);
            Console.WriteLine("Marca: " + car1.marca);
            Console.WriteLine("Chassi: " + car1.chassi);
            Console.WriteLine("Proprietario: " + car1.proprietario);
            //Console.WriteLine("Velocidade atual: " + car1.vAtual);
            Console.WriteLine("Velocidade atual: " + car1.acelera());/*
        }
    }
}
