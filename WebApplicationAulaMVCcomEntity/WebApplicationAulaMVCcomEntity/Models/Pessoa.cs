using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationAulaMVCcomEntity.Models
{
    public class Pessoa
    {
        [Key]
        public int id { get; set; }

        [Required]
        [Display(Name ="Nome da Pessoa")]
        [StringLength(100, MinimumLength = 8)]
        public string Nome { get; set; }

        public virtual ICollection<Email> Emails { get; set; } //criando um vículo dizendo que essa pessoa possui vários emails.
                                                               //É para entender que email pode ter uma pessoa, e uma pessoa pode
                                                               //ter varios emails
    }
}
