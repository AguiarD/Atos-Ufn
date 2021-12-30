using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GFA.Models
{
    public class Lancamento
    {
        public int id { get; set; }
        public float valor { get; set; }
        public string obs_lancamento { get; set; }
        public DateTime dt_previsao { get; set; }
        public DateTime dt_baixa { get; set; }
        public virtual Jogador fk_jogador { get; set; }
        public virtual Conta fk_conta { get; set; }
        public DateTime inativo { get; set; }
    }
}
