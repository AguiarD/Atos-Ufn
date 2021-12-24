using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Models
{
    public class Parametro
    {
        public string id { get; set; }
        public string desc_parametro { get; set; }
        public int ponto { get; set; }
        public string inativo { get; set; }
        public virtual ICollection<Scout> Scouts { get; set; }

    }
}
