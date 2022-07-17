using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Gestor_Proyectos.API.Data;
using Gestor_Proyectos.API.Data.Entities;

namespace Gestor_Proyectos.API.Controllers
{
    public class RequerimientoesController : Controller
    {
        private readonly DataContext _context;

        public RequerimientoesController(DataContext context)
        {
            _context = context;
        }

        // GET: Requerimientoes
        public async Task<IActionResult> Index()
        {
              return _context.Requerimientos != null ? 
                          View(await _context.Requerimientos.ToListAsync()) :
                          Problem("Entity set 'DataContext.Requerimientos'  is null.");
        }

        // GET: Requerimientoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Requerimientos == null)
            {
                return NotFound();
            }

            var requerimiento = await _context.Requerimientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requerimiento == null)
            {
                return NotFound();
            }

            return View(requerimiento);
        }

        // GET: Requerimientoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Requerimientoes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fecha_Reg,Nombre_Iniciativa,Detalle_Req,Aplicativo,Sustentac_Req,Objetivo1,Objetivo2,Objetivo3,Indicador1,Indicador2,Indicador3,Eviden_Mejora,Periodo_Ent,Fecha_Entrega,Ppto_Aprox,Ppto_Area")] Requerimiento requerimiento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(requerimiento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(requerimiento);
        }

        // GET: Requerimientoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Requerimientos == null)
            {
                return NotFound();
            }

            var requerimiento = await _context.Requerimientos.FindAsync(id);
            if (requerimiento == null)
            {
                return NotFound();
            }
            return View(requerimiento);
        }

        // POST: Requerimientoes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fecha_Reg,Nombre_Iniciativa,Detalle_Req,Aplicativo,Sustentac_Req,Objetivo1,Objetivo2,Objetivo3,Indicador1,Indicador2,Indicador3,Eviden_Mejora,Periodo_Ent,Fecha_Entrega,Ppto_Aprox,Ppto_Area")] Requerimiento requerimiento)
        {
            if (id != requerimiento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(requerimiento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RequerimientoExists(requerimiento.Id))
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
            return View(requerimiento);
        }

        // GET: Requerimientoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Requerimientos == null)
            {
                return NotFound();
            }

            var requerimiento = await _context.Requerimientos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (requerimiento == null)
            {
                return NotFound();
            }

            return View(requerimiento);
        }

        // POST: Requerimientoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Requerimientos == null)
            {
                return Problem("Entity set 'DataContext.Requerimientos'  is null.");
            }
            var requerimiento = await _context.Requerimientos.FindAsync(id);
            if (requerimiento != null)
            {
                _context.Requerimientos.Remove(requerimiento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RequerimientoExists(int id)
        {
          return (_context.Requerimientos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
