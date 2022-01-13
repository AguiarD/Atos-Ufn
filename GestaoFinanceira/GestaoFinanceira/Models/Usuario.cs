using System.ComponentModel.DataAnnotations;

namespace GestaoFinanceira.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O login deve ser iformado!")]
        public string Login { get; set; }

        [Required(ErrorMessage ="É necessario uma senha!")]
        public string Senha { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? Expirar { get; set; }
    }
}
