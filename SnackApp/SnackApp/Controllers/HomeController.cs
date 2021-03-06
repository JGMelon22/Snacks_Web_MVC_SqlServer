using Microsoft.AspNetCore.Mvc;
using SnackApp.Repositories;
using SnackApp.ViewModels;

namespace SnackApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        // Dependency injection
        public HomeController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                // Access the defined prop on the ViewModel
                // Assign the favorite snacks on the repo
                LanchesPreferidos = _lancheRepository.LanchesPreferidos
            };

            return View(homeViewModel);
        }

        public ViewResult AccessDenied()
        {
            return View();
        }
    }
}