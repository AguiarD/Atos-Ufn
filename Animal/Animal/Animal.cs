using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    abstract class Animal
    {
        private string _nome;// { get; set; }; // Get e Set direto no atributo
        private string _sexo;// { get; set; }; //aqui vou criar propriedade
        private string _raca;// { get; set; };

        public string nome
        {
            get
            {
                return this._nome;
            }
            set
            {
                this._nome = value;
            }
        }


        /*public string getNome()
        {
            return this._nome;
        }

        public void setNome(string nome)
        {
            this._nome = nome;
        }*/

        public string sexo
        {
            get
            {
                return this._sexo;
            }
            set
            {
                this._sexo = value;
            }
        }

        /*//tradicional
        public void setRaca(string raca)
        {
            this._raca = raca;
        }
        public string getRaca()
        {
            return this._raca;
        }*/

        public string raca
        {
            get
            {
                return this._raca;
            }
            set
            {
                this._raca = value;
            }
        }


        public abstract string emitirSom();

        /*public void emitirSom()
        {
            Console.WriteLine("Muuu");
        }*/

        public void dormir()
        {
            Console.WriteLine("zzzzzzzzzzzzzzzzzzzzz");
        }

        public void caminhar()
        {
            Console.WriteLine("");
        }
    }
}
