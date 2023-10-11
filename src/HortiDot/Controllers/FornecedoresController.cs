using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HortiDot.Config;
using HortiDot.Models;

namespace HortiDot.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly DataContext _context;

        public FornecedoresController(DataContext context)
        {
            _context = context;
        }

        // GET: Fornecedores
        public async Task<IActionResult> Index()
        {
              return _context.fornecedores != null ? 
                          View(await _context.fornecedores.ToListAsync()) :
                          Problem("Entity set 'DataContext.fornecedores'  is null.");
        }

        // GET: Fornecedores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.fornecedores == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.fornecedores
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // GET: Fornecedores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Fornecedores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("cnpj,ID,Nome,Email,Endereco,senha,pedidos,contatos")] Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fornecedor);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        // GET: Fornecedores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.fornecedores == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.fornecedores.FindAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return View(fornecedor);
        }

        // POST: Fornecedores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("cnpj,ID,Nome,Email,Endereco,senha,pedidos,contatos")] Fornecedor fornecedor)
        {
            if (id != fornecedor.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fornecedor);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FornecedorExists(fornecedor.ID))
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
            return View(fornecedor);
        }

        // GET: Fornecedores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.fornecedores == null)
            {
                return NotFound();
            }

            var fornecedor = await _context.fornecedores
                .FirstOrDefaultAsync(m => m.ID == id);
            if (fornecedor == null)
            {
                return NotFound();
            }

            return View(fornecedor);
        }

        // POST: Fornecedores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.fornecedores == null)
            {
                return Problem("Entity set 'DataContext.fornecedores'  is null.");
            }
            var fornecedor = await _context.fornecedores.FindAsync(id);
            if (fornecedor != null)
            {
                _context.fornecedores.Remove(fornecedor);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FornecedorExists(int id)
        {
          return (_context.fornecedores?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
