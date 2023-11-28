using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HortiDot.Config;
using HortiDot.Models;
using Newtonsoft.Json;

namespace HortiDot.Controllers
{
    public class PedidosController : Controller
    {
        private readonly DataContext _context;

        public PedidosController(DataContext context)
        {
            _context = context;
        }

        // Add prod ao pedido
        public async Task<IActionResult> AddSelectedProduct(int Id)
        {
            ListaPedidos listaPedidos = JsonConvert.DeserializeObject<ListaPedidos>((string)TempData["listaPedidos"]);
            listaPedidos.ListaProdutos = _context.Produtos.ToList();
            listaPedidos.ProdutosSelecionados.Add(await _context.Produtos.FirstOrDefaultAsync(p => p.Id == Id));
            ViewBag.listaPedidos = listaPedidos;
            return View("Create");
        }

        // Remove prod ao pedido
        public async Task<IActionResult> RemoveSelectedProduct(int Id)
        {
            ListaPedidos listaPedidos = JsonConvert.DeserializeObject<ListaPedidos>((string)TempData["listaPedidos"]);
            listaPedidos.ListaProdutos = _context.Produtos.ToList();
            listaPedidos.ProdutosSelecionados.RemoveAll(p => p.Id == Id);
            ViewBag.listaPedidos = listaPedidos;
            return View("Create");
        }


        // GET: Pedidos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Pedidos.ToListAsync());
        }

        // GET: Pedidos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Pedidos == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.Include(p => p.Produtos)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // GET: Pedidos/Create
        public IActionResult Create()
        {
            ListaPedidos listaPedidos = new ListaPedidos();
            listaPedidos.ListaProdutos = _context.Produtos.ToList();
            ViewBag.listaPedidos = listaPedidos;
            return View();
        }

        // POST: Pedidos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateAsync()
        {
            ListaPedidos listaPedidos = JsonConvert.DeserializeObject<ListaPedidos>((string)TempData["listaPedidos"]);

            Pedido pedido = new Pedido();
            pedido.Produtos = new List<Produto>();
            pedido.Produtos.AddRange(listaPedidos.ProdutosSelecionados);

            var usuarioLogado = _context.Usuarios.FirstOrDefault(U => U.Nome.Equals(User.Identity.Name));
            pedido.CompradorId = usuarioLogado.ID;

            foreach (var produto in listaPedidos.ProdutosSelecionados)
            {
                _context.Attach(produto);
            }

            await _context.Pedidos.AddAsync(pedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Pedidos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Pedidos == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return View(pedido);
        }

        // POST: Pedidos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, StatusPedidos statusPedidos)
        {
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            try
                {
                    pedido.StatusPedidos = statusPedidos;
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidoExists(pedido.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
        }


        // GET: Pedidos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Pedidos == null)
            {
                return NotFound();
            }

            var pedido = await _context.Pedidos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedido == null)
            {
                return NotFound();
            }

            return View(pedido);
        }

        // POST: Pedidos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Pedidos == null)
            {
                return Problem("Entity set 'DataContext.Pedidos'  is null.");
            }
            var pedido = await _context.Pedidos.FindAsync(id);
            if (pedido != null)
            {
                _context.Pedidos.Remove(pedido);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidoExists(int id)
        {
            return _context.Pedidos.Any(e => e.Id == id);
        }
    }
}
