using HortiDot.Config;
using HortiDot.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HortiDot.Controllers
{
    [Authorize]
    public class UsuariosController : Controller
    {
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public IActionResult CriarUsuario()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriarUsuario([Bind("ID,Nome,Email,Cpf,Telefone,NomeEmpresa,CNPJ,Endereco,Senha,TipoDeUsuario")] Usuario usuario)
        {

            if (!ModelState.IsValid)
            {
                return View(usuario);
            }

            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return Redirect("/Login");
        }

        public async Task<IActionResult> EditarUsuario()
        {
            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Nome.Equals(User.Identity.Name));

            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost]
        public async Task<IActionResult> EditarUsuario(int ID, Usuario usuario)
        {

            if (ID != usuario.ID)
                return NotFound();

            if (ModelState.IsValid)
            {
                usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                //return RedirectToAction("Home", "Login");
                await HttpContext.SignOutAsync();
            }
            
            return View();
        }

        public async Task<IActionResult> DeletarConta()
        {

            var usuario = await _context.Usuarios.FirstOrDefaultAsync(u => u.Nome.Equals(User.Identity.Name));

            if (usuario == null)
                return NotFound();

            return View(usuario);
        }

        [HttpPost, ActionName("DeletarConta")]
        public async Task<IActionResult> DeletarContaConfirmed(int? ID)
        {
            if (ID == null)
                return NotFound();

            var dados = await _context.Usuarios.FindAsync(ID);

            if (dados == null)
                return NotFound();

            _context.Usuarios.Remove(dados);
            await _context.SaveChangesAsync();

            await HttpContext.SignOutAsync();
            return RedirectToAction("Home", "Login");
        }
    }
}
