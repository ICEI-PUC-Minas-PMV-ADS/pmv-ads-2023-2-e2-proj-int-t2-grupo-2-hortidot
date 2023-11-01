using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HortiDot.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Data de Inclusão")]
        public DateTime DataDeInclusao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Preço")]
        public int Preco { get; set; }

    }
}