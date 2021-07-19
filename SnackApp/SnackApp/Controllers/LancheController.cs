using Microsoft.AspNetCore.Mvc;
using SnackApp.Repositories;

namespace SnackApp.Controllers
{
    public class LancheController : Controller
    {
        private readonly ICategoriasRepository _categoriaRepository;
        private readonly ILancheRepository _lancheRepository;

        // Dependency injection 
        public LancheController(ILancheRepository lancheRepository,
            ICategoriasRepository categoriaRepository)
        {
            _lancheRepository = lancheRepository;
            _categoriaRepository = categoriaRepository;
        }

        // Action method which returns the snacks
        public IActionResult List()
        {
            ViewBag.Lanche = "Lanches";
            ViewData["Categoria"] = "Categoria";

            var lanches = _lancheRepository.Lanches;
            return View(lanches);
        }
    }
}