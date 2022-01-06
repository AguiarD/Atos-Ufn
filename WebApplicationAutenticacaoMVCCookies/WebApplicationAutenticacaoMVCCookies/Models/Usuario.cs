using System.ComponentModel.DataAnnotations;

namespace WebApplicationAutenticacaoMVCCookies.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "O login deve ser informado")]
        public string Login { get; set; }

        [Required(ErrorMessage = "É necessario inserir uma senha")]
        public string Senha { get; set; }
    }
}
