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

        [Required]
        public List<Produto> ListaProdutos { get; set; }


        [Display(Name = "Data do Pedido")]
        public string DataPedido { get; set; }

        [Display(Name = "Status do Pedido")]
        public string StatusPedidos { get; set; }

        [Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }

        [Display(Name = "Código do Comprador")]
        public int CodigoComprador { get; set; }

        [Display(Name = "Código do Fornecedor")]
        public int CodigoFornecedor { get; set; }
    }
}
