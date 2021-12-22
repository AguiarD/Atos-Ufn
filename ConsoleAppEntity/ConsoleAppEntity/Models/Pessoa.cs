using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEntity.Models
{
    public class Pessoa
    {
        public int id { get; set; }
        public string Nome { get; set; }

        public ICollection<Email> Emails { get; set; } //criando um vículo dizendo que essa pessoa possui vários emails.
                                                       //É para entender que email pode ter uma pessoa, e uma pessoa pode
                                                       //ter varios emails
    }
}
