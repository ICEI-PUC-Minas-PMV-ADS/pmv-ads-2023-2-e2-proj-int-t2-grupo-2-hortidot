using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HortiDot.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Imagem { get; set; }

        [Required]
        [Display(Name = "Data de Inclusão")]
        public DateTime DataDeInclusao { get; set; }

        [Required]
        [Display(Name = "Preço")]
        public int preco { get; set; }

    }
}
