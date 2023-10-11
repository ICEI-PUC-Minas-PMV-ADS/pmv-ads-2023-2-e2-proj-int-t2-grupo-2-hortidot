using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HortiDot.Models
{
    [Table("Compradores")]
    public class Comprador : Usuario
    {
        [Required]
        [Display(Name = "CPF")]
        public string cpf { get; set; }
    }
}
