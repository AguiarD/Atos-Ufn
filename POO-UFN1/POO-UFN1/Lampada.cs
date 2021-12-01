using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_UFN1
{
    class Lampada
    {
        /*private bool ligado;*/
        //private string marca;
        //private int potencia;


        /*public void ligar()
        {
            Console.WriteLine("Ligando");
            ligado = true;
        }
        public void desligar()
        {
            Console.WriteLine("Desligando");
            ligado = false;
        }
        public bool estaLigada()
        {
            return ligado;
        }*/

        /*private int ligado;

        public void apagar()
        {
            Console.WriteLine("Apagando");
            ligado = 0;
        }

        public void acender()
        {
            Console.WriteLine("Apagando");
            ligado = 1;
        }

        public void estaMeioAcesa()
        {
            Console.WriteLine("Meia Luz");
            ligado = 2;
        }

        public int estaLigado()
        {
            return ligado;
        }*/


        private int ligado;
        //0 -> Desligado
        //1 -> Ligado
        //2 -> Meia Luz
        public void ligar()
        {
            Console.WriteLine("Ligando");
            ligado = 1;
        }

        public void desligar()
        {
            Console.WriteLine("Desligando");
            ligado = 0;
        }

        public void meiaLuz()
        {
            Console.WriteLine("Ligando meia luz");
            ligado = 2;
        }

        public string estaLigado()
        {
            switch (ligado)
            {
                case 0:
                    return "Desligado";
                    break;

                case 1:
                    return "Ligado";
                    break;

                case 2:
                    return "Meia Luz";
                    break;

                default:
                    return "Resposta inválida";
                    break;
            }
        }

        public void setaLuz(int n)
        {
            ligado = n;
        }

    }
}
