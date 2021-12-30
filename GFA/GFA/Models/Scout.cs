using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GFA.Models
{
    public class Scout
    {
        [Key]
        public int id { get; set; }
        [Required]
        [Display(Name = "Data Partida")]
        [DataType(DataType.Date)]
        public DateTime dt_partida { get; set; }
        public virtual Jogador fk_jogador { get; set; }
        public int presenca { get; set; }
        public virtual Parametro fk_parametro { get; set; }
        public string resultado { get; set; }
        public int ponto { get; set; }
        public int gol { get; set; }
        public int assistencia { get; set; }
        public string obs_scout { get; set; }
        public DateTime inativo { get; set; }
    }
}
