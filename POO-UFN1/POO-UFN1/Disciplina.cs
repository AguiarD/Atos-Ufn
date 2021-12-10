using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_UFN1
{
    class Disciplina
    {
        public Disciplina() { }

        public string nome;
        public int carga;

        public Disciplina(string nome, int ch)
        {
            this.nome = nome;
            this.carga = ch;
        }

        public void exibeInformacoes()
        {
            Console.WriteLine("O nome da disciplina é: " + this.nome + " com carga horaria de "  + this.carga);
        }
    }
}
