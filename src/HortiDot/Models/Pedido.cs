using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata.Ecma335;

namespace HortiDot.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public List<Produto> ListaItens { get; set; }
        public string DataPedido { get; set; }
        public string StatusPedidos { get; set; }
        public decimal ValorTotal { get; set; }
        public int CodigoComprador { get; set; }
        public int CodigoFornecedor { get; set; }
    }
}
