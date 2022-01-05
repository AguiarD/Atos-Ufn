using System.ComponentModel.DataAnnotations;

namespace WebApplicationConsumirAPI.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="Nome da pessoa:")]
        [StringLength(100, MinimumLength =5)]
        public string Nome { get; set; }
    }
}
