using HortiDot.Config;
using HortiDot.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Security.Claims;

namespace HortiDot.Controllers
{
    [Authorize]
    public class LoginController : Controller
    {
        private readonly DataContext _context;

        public LoginController(DataContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Fornecedor fornecedor)
        {
            var dados = _context.fornecedores
                .FirstOrDefault(acc => acc.Email == fornecedor.Email);

            if (dados == null)
            {
                ViewBag.Message = "erro";
            }

            bool senhaOK = BCrypt.Net.BCrypt.Verify(fornecedor.senha, dados.senha);

            if (senhaOK)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.Email.ToString())
                };

                var fornecedorIdentiy = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(fornecedorIdentiy);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true
                };
                
                await HttpContext.SignInAsync(principal, props);
                return Redirect("/login/Menu");

            }
            else
                ViewBag.Message = "erro";
            return View();
        }

        public IActionResult Menu() { return View(); }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "fornecedores");
        }

    }
}
