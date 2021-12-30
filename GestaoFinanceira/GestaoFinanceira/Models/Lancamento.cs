using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GestaoFinanceira.Models
{
    public class Lancamento
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Informe o Tipo")]
        [MaxLength(80, ErrorMessage = "O tipo deve ter no máximo 80 caracteres")]
        public string tipo { get; set; }
        public double valor { get; set; }

        //[Required(ErrorMessage = "Informe o Grupo")]
        [MaxLength(80, ErrorMessage = "O tipo deve ter no máximo 80 caracteres")]
        public string grupo { get; set; }

        //[Required(ErrorMessage = "Informe a Conta")]
        [MaxLength(80, ErrorMessage = "A conta deve ter no máximo 80 caracteres")]
        public string conta { get; set; }
        public string obs { get; set; }
        public DateTime dt_previsao { get; set; }
        public DateTime dt_baixa { get; set; }
        public DateTime inativo { get; set; }
    }
}
