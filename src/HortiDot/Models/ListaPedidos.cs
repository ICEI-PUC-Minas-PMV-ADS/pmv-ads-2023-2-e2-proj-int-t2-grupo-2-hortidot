namespace HortiDot.Models
{
    public class ListaPedidos
    {
        public List<Produto> ListaProdutos { get; set; } = new List<Produto>();

        public List<Produto> ProdutosSelecionados { get; set; } = new List<Produto>();
    }
}
