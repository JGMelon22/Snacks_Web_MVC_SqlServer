using Microsoft.AspNetCore.Mvc;

namespace SnackApp.Controllers
{
    public class ContatoController : Controller
    {
        // GET
        public IActionResult Index()
        {
            // Verifies if user is authenticated
            return View();
        }
    }
}