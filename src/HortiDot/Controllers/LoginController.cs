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
            if(User.Identity.IsAuthenticated)
            {
                return Redirect("/Login/Menu");
            } else
            {
                return View();
            }
            
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Index(Usuario usuario)
        {
            var role = "";
            var dados = _context.usuarios
                .FirstOrDefault(acc => acc.Email == usuario.Email);

            if (dados == null)
            {
                ViewBag.Message = "erro";
            }

            if (dados.TipoDeUsuario == 0)
            {
                role = "Comprador";
            } else
                role = "Fornecedor";
            
            bool senhaOK = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaOK)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim("Cargo", role)
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
                return Redirect("/Login/Menu");

            }
            else
                ViewBag.Message = "erro";
            return View();
        }

        public IActionResult Menu() 
        {
            return View(); 
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

    }
}
