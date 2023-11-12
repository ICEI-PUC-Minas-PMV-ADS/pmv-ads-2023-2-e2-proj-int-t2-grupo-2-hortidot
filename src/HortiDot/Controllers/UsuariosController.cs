using HortiDot.Config;
using HortiDot.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
            

            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return Redirect("/Login");
           
           
        }

        public IActionResult CriarPedido()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CriarPedido([Bind("Id, Pedido,StatusPedidos, DataPedido")] Pedido pedido)
        {

            pedido.StatusPedidos = StatusPedidos.EmAndamento;
            pedido.DataPedido = DateTime.UtcNow;

            _context.Add(pedido);
            await _context.SaveChangesAsync();


            return View();
        }
    }
}
