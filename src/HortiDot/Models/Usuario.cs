using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    public abstract class Usuario
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string senha { get; set; }

        public string pedidos { get; set; }

        public string contatos { get; set; }

    }
}
