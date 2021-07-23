using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SnackApp.Models;
using SnackApp.Repositories;
using SnackApp.ViewModels;

namespace SnackApp.Controllers
{
    public class CarrinhoCompraController : Controller
    {
        private readonly CarrinhoCompra _carrinhoCompra;

        // Dependency injection
        private readonly ILancheRepository _lancheRepository;

        // Access snacks and shopping cart
        public CarrinhoCompraController(ILancheRepository lancheRepository, CarrinhoCompra carrinhoCompra)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompra = carrinhoCompra;
        }

        // GET
        public IActionResult Index()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();
            _carrinhoCompra.CarrinhoCompraItens = itens;

            // Instance of viewModel
            var carrinhoCompraViewModel = new CarrinhoCompraViewModel
            {
                // Have access to the properties  
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraViewModel);
        }

        // Method which adds an item on the shopping cart
        [Authorize]
        public RedirectToActionResult AdicionarItemNoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches.FirstOrDefault(p => p.LancheId == lancheId);

            if (lancheSelecionado != null) _carrinhoCompra.AdicionarAoCarrinho(lancheSelecionado);

            return RedirectToAction("Index");
        }


        // Method which remove an item from the shopping cart
        [Authorize]
        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado = _lancheRepository.Lanches
                .FirstOrDefault(p => p.LancheId == lancheId);

            if (lancheSelecionado != null)
                // If it is different of null, add to cart
                _carrinhoCompra.RemoverDoCarrinho(lancheSelecionado);

            return RedirectToAction("Index");
        }
    }
}