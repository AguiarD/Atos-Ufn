using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDesafio
{
    class Aluno : Pessoa
    {
        public string matricula;
        public string codigoCurso;
        public string nomeCurso;

        public Aluno(string matricula, string codigoCurso, string nomeCurso)
        {
            nome = "Nome teste";
            telefone = "Telefone Teste";
            cidade = "Cidade Teste";
            rg = "Rg teste";
            cpf = "Cpf teste";
            this.matricula = matricula;
            this.codigoCurso = codigoCurso;
            this.nomeCurso = nomeCurso;
        }
    }
}
