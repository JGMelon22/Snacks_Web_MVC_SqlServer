using Microsoft.AspNetCore.Mvc;

namespace SnackApp.Controllers
{
    public class ContatoController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}