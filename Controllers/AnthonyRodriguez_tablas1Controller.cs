using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Examen.Data;
using Examen.Models;

namespace Examen.Controllers
{
    public class AnthonyRodriguez_tablas1Controller : Controller
    {
        private readonly ExamenContext _context;

        public AnthonyRodriguez_tablas1Controller(ExamenContext context)
        {
            _context = context;
        }

        // GET: AnthonyRodriguez_tablas1
        public async Task<IActionResult> Index()
        {
              return _context.AnthonyRodriguez_tabla1 != null ? 
                          View(await _context.AnthonyRodriguez_tabla1.ToListAsync()) :
                          Problem("Entity set 'ExamenContext.AnthonyRodriguez_tabla1'  is null.");
        }

        // GET: AnthonyRodriguez_tablas1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AnthonyRodriguez_tabla1 == null)
            {
                return NotFound();
            }

            var anthonyRodriguez_tabla1 = await _context.AnthonyRodriguez_tabla1
                .FirstOrDefaultAsync(m => m.arCedula == id);
            if (anthonyRodriguez_tabla1 == null)
            {
                return NotFound();
            }

            return View(anthonyRodriguez_tabla1);
        }

        // GET: AnthonyRodriguez_tablas1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AnthonyRodriguez_tablas1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("arCedula,arNombre,arEstudiante,arEstatura")] AnthonyRodriguez_tabla1 anthonyRodriguez_tabla1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anthonyRodriguez_tabla1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(anthonyRodriguez_tabla1);
        }

        // GET: AnthonyRodriguez_tablas1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AnthonyRodriguez_tabla1 == null)
            {
                return NotFound();
            }

            var anthonyRodriguez_tabla1 = await _context.AnthonyRodriguez_tabla1.FindAsync(id);
            if (anthonyRodriguez_tabla1 == null)
            {
                return NotFound();
            }
            return View(anthonyRodriguez_tabla1);
        }

        // POST: AnthonyRodriguez_tablas1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("arCedula,arNombre,arEstudiante,arEstatura")] AnthonyRodriguez_tabla1 anthonyRodriguez_tabla1)
        {
            if (id != anthonyRodriguez_tabla1.arCedula)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anthonyRodriguez_tabla1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnthonyRodriguez_tabla1Exists(anthonyRodriguez_tabla1.arCedula))
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
            return View(anthonyRodriguez_tabla1);
        }

        // GET: AnthonyRodriguez_tablas1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AnthonyRodriguez_tabla1 == null)
            {
                return NotFound();
            }

            var anthonyRodriguez_tabla1 = await _context.AnthonyRodriguez_tabla1
                .FirstOrDefaultAsync(m => m.arCedula == id);
            if (anthonyRodriguez_tabla1 == null)
            {
                return NotFound();
            }

            return View(anthonyRodriguez_tabla1);
        }

        // POST: AnthonyRodriguez_tablas1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AnthonyRodriguez_tabla1 == null)
            {
                return Problem("Entity set 'ExamenContext.AnthonyRodriguez_tabla1'  is null.");
            }
            var anthonyRodriguez_tabla1 = await _context.AnthonyRodriguez_tabla1.FindAsync(id);
            if (anthonyRodriguez_tabla1 != null)
            {
                _context.AnthonyRodriguez_tabla1.Remove(anthonyRodriguez_tabla1);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnthonyRodriguez_tabla1Exists(int id)
        {
          return (_context.AnthonyRodriguez_tabla1?.Any(e => e.arCedula == id)).GetValueOrDefault();
        }
    }
}
