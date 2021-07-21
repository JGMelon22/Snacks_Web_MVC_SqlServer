using Microsoft.AspNetCore.Mvc;
using SnackApp.Models;
using SnackApp.Repositories;

namespace SnackApp.Controllers
{
    public class PedidoController : Controller
    {
        // Dependency injection
        private readonly IPedidoRepository _pedidoRepository;
        private readonly CarrinhoCompra _carrinhoCompra;

        // ctor
        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }
        
        // Method for checkout
        public IActionResult Checkout()
        {
            return View();
        }
    }
}