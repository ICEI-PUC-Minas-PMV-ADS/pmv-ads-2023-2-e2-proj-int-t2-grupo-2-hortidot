using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    public abstract class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [DataType(DataType.Password)]
        public string senha { get; set; }

        public string pedidos { get; set; }

        public string contatos { get; set; }

    }
}
