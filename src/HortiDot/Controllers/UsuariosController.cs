using HortiDot.Config;
using HortiDot.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HortiDot.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly DataContext _context;

        public UsuariosController(DataContext context)
        {
            _context = context;
        }

        public IActionResult CriarConta()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CriarConta([Bind("ID,Nome,Email,Cpf,Telefone,NomeEmpresa,CNPJ,Endereco,Senha,TipoDeUsuario,Contatos,Pedidos")] Usuario usuario)
        {
            usuario.Pedidos = "";
            usuario.Contatos = "";

            usuario.Senha = BCrypt.Net.BCrypt.HashPassword(usuario.Senha);

            _context.Add(usuario);
            await _context.SaveChangesAsync();
            return Redirect("/");
           
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.usuarios == null)
            {
                return NotFound();
            }

            var cotacao = await _context.cotacoes
                .FirstOrDefaultAsync(m => m.ID == id);
            if (cotacao == null)
            {
                return NotFound();
            }

            return View(cotacao);
        }

        // POST: Cotacaos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.cotacoes == null)
            {
                return Problem("Entity set 'DataContext.cotacoes'  is null.");
            }
            var cotacao = await _context.cotacoes.FindAsync(id);
            if (cotacao != null)
            {
                _context.cotacoes.Remove(cotacao);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
