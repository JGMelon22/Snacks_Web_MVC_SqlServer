using System;
using SnackApp.Context;
using SnackApp.Models;

namespace SnackApp.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        // Dependency injection
        private readonly AppDbContext _appDbContext;
        private readonly CarrinhoCompra _carrinhoCompra;

        // ctor
        public PedidoRepository(AppDbContext appDbContext, CarrinhoCompra carrinhoCompra)
        {
            _appDbContext = appDbContext;
            _carrinhoCompra = carrinhoCompra;
        }

        // Method
        public void CriarPedido(Pedido pedido)
        {
            // Adds the order based on time which was ordered
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            // Obtains the cart itens 
            var carrinhoCompraItens = _carrinhoCompra.CarrinhoCompraItens;

            foreach (var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetalhe = new PedidoDetalhe
                {
                    Quantidade = carrinhoItem.Quantidade,
                    LancheId = carrinhoItem.Lanche.LancheId,
                    PedidoId = pedido.PedidoID,
                    Preco = carrinhoItem.Lanche.Preco
                };

                _appDbContext.PedidoDetalhes.Add(pedidoDetalhe);
            }

            // Commit changes
            _appDbContext.SaveChanges();
        }
    }
}