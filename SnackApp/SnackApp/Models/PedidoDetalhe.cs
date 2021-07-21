namespace SnackApp.Models
{
    public class PedidoDetalhe
    {
        // prop
        public int PedidoDetalheId { get; set; }
        public int PedidoId { get; set; }
        public int LancheId { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }
        public virtual Lanche Lanche { get; set; }
        public virtual Pedido Pedido { get; set; }
    }
}