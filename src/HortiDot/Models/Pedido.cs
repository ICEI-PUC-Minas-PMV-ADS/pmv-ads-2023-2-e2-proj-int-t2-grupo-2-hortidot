using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace HortiDot.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }

        public List<Produto> ListaProdutos = new List<Produto> { };

        [Display(Name = "Data do Pedido")]
        [DataType(DataType.Date)]
        public DateTime DataPedido { get; set; }

        [Display(Name = "Status do Pedido")]
        public StatusPedidos StatusPedidos { get; set; }

        [Display(Name = "Código do Comprador")]
        public int CodigoComprador { get; set; }

        [Display(Name = "Código do Fornecedor")]
        public int CodigoFornecedor { get; set; }
    }

    public enum StatusPedidos
    {
        EmAndamento,
        Finalizado,
        Cancelado
    }
}
