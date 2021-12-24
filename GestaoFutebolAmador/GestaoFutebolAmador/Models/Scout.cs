using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Models
{
    public class Scout
    {
        public int id { get; set; }
        public string dt_partida { get; set; }
        public virtual Jogador fk_jogador { get; set; }
        public string presenca { get; set; }
        public virtual Parametro fk_parametro { get; set; }
        public string resultado { get; set; }
        public int ponto { get; set; }
        public int gol { get; set; }
        public int assistencia { get; set; }
        public int obs_scout { get; set; }
        public string inativo { get; set; }

    }
}
