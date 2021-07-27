using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SnackApp.Areas.Admin.Servicos;

namespace SnackApp.Areas.Admin.Controllers
{
    // GET
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AdminRelatorioVendasController : Controller
    {
        // Inject into the ctor
        private readonly RelatorioVendasService relatorioVendasService;

        public AdminRelatorioVendasController(RelatorioVendasService _relatorioVendasService)
        {
            relatorioVendasService = _relatorioVendasService;
        }

        // Report View Index
        public IActionResult Index()
        {
            return View();
        }

        // Report itself
        public async Task<IActionResult> RelatorioVendasSimples(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue) minDate = new DateTime(DateTime.Now.Year, 1, 1);

            if (!maxDate.HasValue) maxDate = DateTime.Now;

            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = await relatorioVendasService.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
    }
}