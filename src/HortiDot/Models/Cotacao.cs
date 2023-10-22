using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    public class Cotacao
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Lista de Produtos")]
        public List<Produto> ListaDeProdutos { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Data de Inclusão")]
        public DateTime DataDeInclusao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Valor total")]
        public string ValorTotal { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        [Display(Name = "Código do Comprador")]
        public int CodigoDoComprador { get; set; }
    }
}
