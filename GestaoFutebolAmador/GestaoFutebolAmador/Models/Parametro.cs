using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFutebolAmador.Models
{
    public class Parametro
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [MaxLength(80, ErrorMessage = "Máximo 80 caracteres")]
        public string DescParametro { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        public int Ponto { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Inativo { get; set; }
        //public virtual ICollection<Scout> Scouts { get; set; }

    }
}
