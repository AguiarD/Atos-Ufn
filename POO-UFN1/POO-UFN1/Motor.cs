using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_UFN1
{
    class Motor
    {
        private string _nomeFabricante;
        private int _potencia;
        private string _tipo;
        /*public Motor(string fabricante, int potencia, string tipo)
        {
            this.nomeFabricante = fabricante;
            this.potencia = potencia;
            this.tipo = tipo;
        }*/

        public string getNomeFabricante()
        {
            return this._nomeFabricante;
        }

        public void setNomeFabricante(string nomeFabricante)
        {
            this._nomeFabricante = nomeFabricante;
        }

        //apenas no C#
        public int potencia
        {
            get
            {
                return _potencia;
            }

            set
            {
                _potencia = value;
            }
        }

        public string tipo
        {
            get
            {
                return _tipo;
            }

            set
            {
                _tipo = value;
            }
        }



        public void mostraDados()
        {
            Console.WriteLine(_nomeFabricante);
            Console.WriteLine(_potencia);
            Console.WriteLine(_tipo);
        }

    }

}
