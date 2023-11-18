using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
        public class Login
        {

            [Required(ErrorMessage = "Campo obrigatório.")]
            [EmailAddress(ErrorMessage = "E-mail inválido.")]
            [Display(Name = "E-mail*:")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Campo obrigatório.")]
            [Display(Name = "Senha*:")]
            [DataType(DataType.Password)]
            public string Senha { get; set; }
        }
}