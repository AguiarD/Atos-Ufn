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
        public int Id { get; set; }
        
        //[Required]
        //[Display(Name = "Nome do Jogador")]
        //[StringLength(100, MinimumLength = 4)]
        public string NomeJogador { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [MaxLength(1, ErrorMessage = "S, N ou E")]
        public string Mensalista { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? ObsMensalista { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Inativo { get; set; }
        //public virtual ICollection<Scout> Scouts { get; set; }
        //public virtual ICollection<Financeiro> Financeiros { get; set; }
    }
}
