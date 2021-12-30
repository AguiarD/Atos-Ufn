using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFA.Models
{
    public class Conta
    {
        public int id { get; set; }
        public string desc_conta { get; set; }
        public string tipo_conta { get; set; }
        public string obs_conta { get; set; }
        public DateTime inativo { get; set; }
        public virtual ICollection<Lancamento> Lancamentos { get; set; }
    }
}
