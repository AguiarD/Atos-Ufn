using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppDesafio
{
    class Aluno : Pessoa
    {
        public int pessoa { get; set; }
        public string matricula { get; set; }
        public string cdCurso { get; set; }
        public string nomeCurso { get; set; }

        public Aluno(int pessoa, string matricula, string cdCurso, string nomeCurso)
        {
            /*nome = "Nome teste";
            telefone = "Telefone Teste";
            cidade = "Cidade Teste";
            rg = "Rg teste";
            cpf = "Cpf teste";*/
            this.pessoa = pessoa;
            this.matricula = matricula;
            this.cdCurso = cdCurso;
            this.nomeCurso = nomeCurso;
        }
    }
}
