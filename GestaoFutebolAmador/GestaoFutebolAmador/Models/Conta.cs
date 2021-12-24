using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Models
{
    public class Conta
    {
        public int id { get; set; }
        public string desc_conta { get; set; }
        public string tipo_conta { get; set; } 
        public string obs_conta { get; set; } 
        public string inativo { get; set; }
        public virtual ICollection<Financeiro> Financeiros { get; set; }
    }
}
