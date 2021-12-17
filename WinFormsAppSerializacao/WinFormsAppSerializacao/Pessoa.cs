using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsAppSerializacao
{
    [Serializable] //Se não marcar, para o SOAP não serializa
    public class Pessoa
    {
        public string nome;
        public int idade;
        //[XmlIgnore] //Importar a biblioteca using 'System.Xml.Serialization', ai ignora tudo para baixo
        //[NonSerialized] //Importar a biblioteca using 'System.Xml.Serialization', ai ignora tudo para baixo
        public float salario;
        public string[] telefone;
    }
}
