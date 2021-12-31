using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    public class Lancamento
    {
        [Key]
        public int Id { get; set; }

        public int ContaId { get; set; }

        public virtual Conta Contas { get; set; }

        public int JogadoresId { get; set; }
        public virtual Jogador Jogadores { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        public float Valor { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? ObsLancamento { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DtPrevisao { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DtBaixa { get; set; }
        //public virtual Jogador fk_jogador { get; set; }
        //public virtual Conta fk_conta { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Inativo { get; set; }
    }
}
