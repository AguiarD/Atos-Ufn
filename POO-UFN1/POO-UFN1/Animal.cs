using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_UFN1
{
    class Animal
    {
        private string _nome;
        private string _sexo;
        private string _raca;
        private string _emiteSom;
        

        public Animal(string nome, string sexo, string raca)
        {
            this._nome = nome;
            this._sexo = sexo;
            this._raca = raca;
        }

        public string nome { get => _nome; set => _nome = value; }

        public string sexo { get => _sexo; set => _sexo = value; }

        public string raca { get => _raca; set => _raca = value; }

        public string emiteSom { get => _emiteSom; set => _emiteSom = value; }

        public void emitirSom()
        {
            Console.WriteLine("Emite som ? ");
        }

    }
}
