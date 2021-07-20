using System.ComponentModel.DataAnnotations;

namespace SnackApp.Models
{
    public class CarrinhoCompraItem
    {
        // Properties which represents a ShoppingCart
        public int CarrinhoCompraItemId { get; set; }
        public Lanche Lanche { get; set; }
        public int Quantidade { get; set; }

        // Guid RelationShip between CarrinhoCompraItem x CarrinhoCompra
        [StringLength(200)] public string CarrinhoCompraId { get; set; }
    }
}