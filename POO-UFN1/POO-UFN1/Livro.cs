using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_UFN1
{
    class Livro
    {
        /*private string titulo;
        private string genero;
        private string autor;
        private string editora;
        public int ano;

        public string recebeTitulo()
        {
            titulo = Console.ReadLine();
            //Console.WriteLine(titulo);
            return titulo;
        }
        public string recebeGenero()
        {
            genero = Console.ReadLine();
            //Console.WriteLine(titulo);
            return genero;
        }
        public string recebeAutor()
        {
            autor = Console.ReadLine();
            //Console.WriteLine(titulo);
            return autor;
        }
        public string recebeEditora()
        {
            editora = Console.ReadLine();
            //Console.WriteLine(titulo);
            return editora;
        }*/

        public string titulo;
        public string autor;
        public string editora;
        public string genero;
        public int ano;
        public string isbn;

        public Livro(string tit, string aut, string edit, string gen, int ano, string isbn)
        {
            this.titulo = tit;
            this.autor = aut;
            this.editora = edit;
            this.genero = gen;
            this.ano = ano;
            this.isbn = isbn;
        }

    }
}
