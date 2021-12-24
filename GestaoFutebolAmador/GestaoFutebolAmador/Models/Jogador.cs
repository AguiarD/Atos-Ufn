using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Models
{
    public class Jogador
    {
        [Key]
        public int id { get; set; }
        
        //[Required]
        //[Display(Name = "Nome do Jogador")]
        //[StringLength(100, MinimumLength = 4)]
        public string nome_jogador { get; set; }
        public string mensalista { get; set; }
        public string obs_mensalista { get; set; }
        public string inativo { get; set; }
        public virtual ICollection<Scout> Scouts { get; set; }
        public virtual ICollection<Financeiro> Financeiros { get; set; }
    }
}
