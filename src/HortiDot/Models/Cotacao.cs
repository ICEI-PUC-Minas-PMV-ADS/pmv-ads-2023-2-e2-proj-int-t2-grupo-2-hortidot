using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    public class Cotacao
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Produtos Listados")]
        public List<Produto> ListaDeProdutos { get; set; }

        [Required]
        [Display(Name = "Observações")]
        public string Observacao { get; set; }

        [Required]
        [Display(Name = "Código do Comprador")]
        public int CodigoDoComprador { get; set; }
    }
}
