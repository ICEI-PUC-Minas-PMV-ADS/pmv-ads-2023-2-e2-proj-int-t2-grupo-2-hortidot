using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace HortiDot.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [ForeignKey("Produto")]
        public string ListaProdutos { get; set; }

        [Display(Name = "Data do Pedido")]
        [DataType(DataType.Date)]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Status do Pedido")]
        public StatusPedidos StatusPedidos { get; set; }

        [AllowNull]
        public List<String> Envolvidos { get; set; }
    }

    public enum StatusPedidos
    {
        EmAndamento,
        Finalizado,
        Cancelado
    }
}
