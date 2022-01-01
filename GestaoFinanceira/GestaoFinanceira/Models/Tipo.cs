using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceira.Models
{
    public class Tipo
    {
        [Key]
        public string Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [MaxLength(80, ErrorMessage = "Máximo 80 caracteres")]
        public string DescTipo { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Inativo { get; set; }
    }
}
