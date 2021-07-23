// Doc: https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.signinmanager-1?view=aspnetcore-5.0

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SnackApp.ViewModels;

namespace SnackApp.Controllers
{
    // [Authorize]
    public class AccountController : Controller
    {
        private readonly SignInManager<IdentityUser> _signInManager;

        // Dependency injection
        private readonly UserManager<IdentityUser> _userManager;

        // ctor
        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginVM)
        {
            // Verifies if it is valid
            if (!ModelState.IsValid)
                return View(loginVM);

            // If it is valid
            // Search the user which was infomed on the login
            var user = await _userManager.FindByNameAsync(loginVM.UserName);

            if (user != null)
            {
                var result = await _signInManager
                    .PasswordSignInAsync(user, loginVM.Password, false, false);

                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(loginVM.ReturnUrl)) return RedirectToAction("Index", "Home");

                    return RedirectToAction(loginVM.ReturnUrl);
                }
            }

            ModelState.AddModelError("", "Usuário/Senha invpalidos ou não localizados");
            return View(loginVM);
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel registroVM)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser {UserName = registroVM.UserName};

                var result = await _userManager.CreateAsync(user, registroVM.Password);

                if (result.Succeeded) return RedirectToAction("Index", "Home");
            }

            return View(registroVM);
        }

        // Logout
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}