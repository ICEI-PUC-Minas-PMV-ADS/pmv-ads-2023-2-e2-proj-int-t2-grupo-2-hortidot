using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório.")]
        public string Nome { get; set; }

        [Display(Name = "Data de inclusão")]
        [DataType(DataType.Date)]
        public DateTime DataProduto { get; set; } = DateTime.UtcNow;

        public virtual List<Pedido> Pedidos { get; set; }

    }
}
