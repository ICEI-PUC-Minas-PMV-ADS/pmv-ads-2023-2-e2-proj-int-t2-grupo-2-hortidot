using HortiDot.Config;
using HortiDot.Models;
using Microsoft.AspNetCore.Mvc;

namespace HortiDot.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        public IActionResult CriarUsuario()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriarUsuario([Bind("ID,Nome,Email,Cpf,Telefone,NomeEmpresa,CNPJ,Endereco,Senha,Pedidos,TipoDeUsuario")] Usuario usuario)
        {
            

            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);
            usuario.Pedidos = "";

            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return Redirect("/Login");
           
           
        }
    }
}
