using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Models
{
    public class Scout
    {
        [Key]
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DtPartida { get; set; }
        //public virtual Jogador fk_jogador { get; set; }
        public int Presenca { get; set; }
        //public virtual Parametro fk_parametro { get; set; }
        public string Resultado { get; set; }
        public int Ponto { get; set; }
        public int? Gol { get; set; }
        public int? Assistencia { get; set; }
        public string? ObsScout { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Inativo { get; set; }

        public int JogadorId { get; set; }
        public virtual Jogador Jogadores { get; set; }

        public int ParametrosId { get; set; }
        public virtual Parametro Parametros { get; set; }

        //Criar construtor para somar resultados
    }
}
