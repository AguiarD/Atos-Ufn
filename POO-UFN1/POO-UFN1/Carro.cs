using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_UFN1
{
    class Carro
    {
        private string _modelo;
        private string _cor;
        private int _ano;
        private string _marca;
        private string _chassi;
        private string _proprietario;
        private int _vMaxima;
        private int _vAtual;
        private int _nPorta;
        private bool _tetoSolar;
        private bool _automatico;
        private int _cCombustivel;

        //public string modelo { get => _modelo; set => _modelo = value; }

        public string modelo
        {
            get
            {
                return _modelo;
            }

            set
            {
                _modelo = value;
            }
        }

        public string cor
        {
            get
            {
                return _cor;
            }

            set
            {
                _cor = value;
            }
        }

        public int ano
        {
            get
            {
                return _ano;
            }

            set
            {
                _ano = value;
            }
        }

        public string marca
        {
            get
            {
                return _marca;
            }

            set
            {
                _marca = value;
            }
        }

        public string chassi
        {
            get
            {
                return _chassi;
            }

            set
            {
                _chassi = value;
            }
        }

        public string proprietario
        {
            get
            {
                return _proprietario;
            }

            set
            {
                _proprietario = value;
            }
        }

        public int vMaxima
        {
            get
            {
                return _vMaxima;
            }

            set
            {
                _vMaxima = value;
            }
        }

        public int vAtual
        {
            get
            {
                return _vAtual;
            }

            set
            {
                _vAtual = value;
            }
        }

        public int nPorta
        {
            get
            {
                return _nPorta;
            }

            set
            {
                _nPorta = value;
            }
        }

        public bool tetoSolar
        {
            get
            {
                return _tetoSolar;
            }

            set
            {
                _tetoSolar = value;
            }
        }

        public bool automatico
        {
            get
            {
                return _automatico;
            }

            set
            {
                _automatico = value;
            }
        }

        public int cCombustivel
        {
            get
            {
                return _cCombustivel;
            }

            set
            {
                _cCombustivel = value;
            }
        }

        public void acelera()
        {
            if (_vAtual < _vMaxima)
            {
                this.vAtual++;
            }
        }
    }
}
