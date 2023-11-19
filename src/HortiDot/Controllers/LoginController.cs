using HortiDot.Config;
using HortiDot.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
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
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Login/Home");
            }
            else
            {
                return View();
            }

        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login(Login login)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View("Login", login);
            //}

            var role = "";
            var dados = _context.Usuarios
                .FirstOrDefault(acc => acc.Email == login.Email);

            if (dados == null)
            {
                ViewBag.Message = "erro";
                return Redirect("/Login");
            }

            bool senhaOK = BCrypt.Net.BCrypt.Verify(login.Senha, dados.Senha);

            if (senhaOK)
            {
                var pedidos = await _context.Pedidos.Where(p => p.CompradorId == dados.ID).ToListAsync();

                TempData["Pedidos"] = JsonConvert.SerializeObject(pedidos);

                if (dados.TipoDeUsuario == 0)
                {
                    role = "Comprador";
                }
                else
                    role = "Fornecedor";

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
                return Redirect("/Login/Home");

            }
            else
                ViewBag.Message = "erro";

            return View();
        }

        public async Task<IActionResult> Home()
        {

            var dados = _context.Usuarios
                .FirstOrDefault(acc => acc.Nome.Equals(User.Identity.Name));

            try
            {
                var pedidos = await _context.Pedidos.Where(p => p.CompradorId == dados.ID).ToListAsync();
                TempData["Pedidos"] = JsonConvert.SerializeObject(pedidos);
            } 

            catch { }

            return View();
        }
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }
    }
}
