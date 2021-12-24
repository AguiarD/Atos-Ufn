using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Models
{
    public class Financeiro
    {
        public int id { get; set; }
        public float valor { get; set; }
        public string obs_lancamento { get; set; }
        public string dt_previsao { get; set; }
        public string dt_baixa { get; set; }
        public virtual Jogador fk_jogador { get; set; }
        public virtual Conta fk_conta { get; set; }
        public string inativo { get; set; }
    }
}
