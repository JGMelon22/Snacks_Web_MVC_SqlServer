using Microsoft.AspNetCore.Mvc;
using SnackApp.Models;
using SnackApp.ViewModels;

namespace SnackApp.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        // Dependency injection
        private readonly CarrinhoCompra _carrinhoCompra;

        public CarrinhoCompraResumo(CarrinhoCompra carrinhCompra)
        {
            _carrinhoCompra = carrinhCompra;
        }

        // Method 
        public IViewComponentResult Invoke()
        {
            var itens = _carrinhoCompra.GetCarrinhoCompraItens();

            // var itens = new List<CarrinhoCompraItem> {new(), new()};
            _carrinhoCompra.CarrinhoCompraItens = itens;

            var CarrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = _carrinhoCompra,
                CarrinhoCompraTotal = _carrinhoCompra.GetCarrinhoCompraTotal()
            };

            return View(CarrinhoCompraVM);
        }
    }
}