using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_UFN1
{
    class Pessoa
    {
        //Atributos
        private string nome;
        private string cpf;
        private string nascimento;

        //Construtor
        public Pessoa(string nome, string cpf, string nascimento) // Construtor
        {
            this.nome = nome;
            this.cpf = cpf;
            this.nascimento = nascimento;
        }

        //Métodos
        public void retornaNome()
        {
            Console.WriteLine(this.nome);
        }

        public void retornaCpf()
        {
            Console.WriteLine(this.cpf);
        }

        public void retornaNascimento()
        {
            Console.WriteLine(this.nascimento);
        }

        //Metodos Get e Set
        public string getNome()
        {
            return this.nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }
    }
}
