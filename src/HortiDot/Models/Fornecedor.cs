using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HortiDot.Models
{
    [Table("Fornecedores")]
    public class Fornecedor : Usuario
    {
        [Required]
        [Display(Name = "CNPJ")]
        public string cnpj { get; set; }
    }
}
