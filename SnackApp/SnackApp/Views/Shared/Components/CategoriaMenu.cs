using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SnackApp.Repositories;

namespace SnackApp.Views.Shared.Components
{
    public class CategoriaMenu : ViewComponent
    {
        // Dependency injection
        private readonly ICategoriasRepository _categoriaRepository;

        public CategoriaMenu(ICategoriasRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        // Method to return viewComponentResult
        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.Categorias
                .OrderBy(c => c.CategoriaNome);
            return View(categorias);
        }
    }
}