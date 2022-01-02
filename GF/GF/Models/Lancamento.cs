using System.ComponentModel.DataAnnotations;

namespace GF.Models
{
    public class Lancamento
    {
        [Key]
        public int Id { get; set; }

        public int Tipo { get; set; }
        public virtual Tipo Tipos { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        public float Valor { get; set; }

        public int Grupo { get; set; }
        public virtual Grupo Grupos { get; set; }

        public int Conta { get; set; }
        public virtual Conta Contas { get; set; }


        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? ObsLancamento { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime DtPrevisao { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DtBaixa { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Inativo { get; set; }
    }
}
