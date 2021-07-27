using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SnackApp.Models;
using SnackApp.Repositories;

namespace SnackApp.Controllers
{
    public class PedidoController : Controller
    {
        // Dependency injection
        private readonly CarrinhoCompra _carrinhoCompra;
        private readonly IPedidoRepository _pedidoRepository;

        // ctor
        public PedidoController(IPedidoRepository pedidoRepository, CarrinhoCompra carrinhoCompra)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        // HttpPost Method
        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Pedido pedido)
        {
            var precoTotalPedido = 0.0m;
            var totalItensPedido = 0;

            var items = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = items;

            // Verifies if the cart has snacks in
            // if not, error
            if (_carrinhoCompra.CarrinhoCompraItens.Count == 0)
                ModelState.AddModelError("", "Seu carrinho está vazio. Inclua um lanche...");


            // Calculates the total order
            foreach (var item in items)
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += item.Lanche.Preco * item.Quantidade;
            }

            // Assign the total order itens
            pedido.TotalItensPedido = totalItensPedido;

            // Assign the total order to order it self
            pedido.PedidoTotal = precoTotalPedido;

            // If there is a snack, and it is valid
            // checkout
            if (ModelState.IsValid)
            {
                _pedidoRepository.CriarPedido(pedido);
                _carrinhoCompra.LimparCarrinho();

                // Fancy pants goes here
                // Display order details when finished
                ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :D";

                // Clear the cart
                _carrinhoCompra.LimparCarrinho();

                // Redirects to the View
                // Passing the path
                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }

            // Any errors, return to view pedido
            return View(pedido);
        }

        // Action CheckoutCompleto
        public IActionResult CheckoutCompleto()
        {
            // Display infos from TempData to the ViewBag
            ViewBag.Cliente = TempData["Cliente"];
            ViewBag.NumeroPedido = TempData["NumeroPedido"];
            ViewBag.DataPedido = TempData["DataPedido"];
            ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :D";
            return View();
        }
    }
}