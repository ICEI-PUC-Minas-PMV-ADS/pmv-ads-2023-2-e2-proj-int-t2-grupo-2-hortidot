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

        public async Task<IActionResult> EditarUsuario(int? ID)
            {
            if (ID == null)
                return NotFound();

            var dados = await _context.Usuarios.FindAsync(ID);

            if (dados == null)
                return NotFound();


            return View(dados);
            }

        [HttpPost]
        public async Task<IActionResult> EditarUsuario(int ID, Usuario usuario)
            {

            if (ID != usuario.ID)
                return NotFound();

            if (ModelState.IsValid)
                {
                _context.Usuarios.Update(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("/");
                }

            return View();
            }

        public async Task<IActionResult> DeletarConta(int? ID)
            {
            if (ID == null)
                return NotFound();


            var dados = await _context.Usuarios.FindAsync(ID);

            if (dados == null)
                return NotFound();

            return View(dados);
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

            return RedirectToAction("/Login/Home");
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
