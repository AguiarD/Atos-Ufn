using System.ComponentModel.DataAnnotations;

namespace GPS.Models
{
    public class Conta
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [MaxLength(80, ErrorMessage = "Máximo 80 caracteres")]
        public string DescConta { get; set; }

        [Required(ErrorMessage = "Obrigatorio")]
        [MaxLength(10, ErrorMessage = "Máximo 10 caracteres")]
        public string TipoConta { get; set; }

        [MaxLength(100, ErrorMessage = "Máximo 100 caracteres")]
        public string? ObsConta { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Inativo { get; set; }
        //public virtual ICollection<Financeiro> Financeiros { get; set; }
    }
}
