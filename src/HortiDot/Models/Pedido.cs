using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public virtual List<Produto> Produtos { get; set; }

        [Display(Name = "Data do Pedido")]
        [DataType(DataType.Date)]
        public DateTime DataPedido { get; set; } = DateTime.UtcNow;

        [Display(Name = "Status do Pedido")]
        public StatusPedidos StatusPedidos { get; set; } = StatusPedidos.EmAndamento;

        public int CompradorId { get; set; }

        public virtual Usuario FornecedorId { get; set; } = null!;
    }

    public enum StatusPedidos
    {
        EmAndamento,
        Finalizado,
        Cancelado
    }
}