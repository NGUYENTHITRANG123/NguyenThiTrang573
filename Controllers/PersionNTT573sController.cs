using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NguyenThiTrang573.Models;

namespace NguyenThiTrang573.Controllers
{
    public class PersionNTT573sController : Controller
    {
        private readonly MvcMovieContext _context;

        public PersionNTT573sController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: PersionNTT573s
        public async Task<IActionResult> Index()
        {
            return View(await _context.PersionNTT573.ToListAsync());
        }

        // GET: PersionNTT573s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persionNTT573 = await _context.PersionNTT573
                .FirstOrDefaultAsync(m => m.PersionId == id);
            if (persionNTT573 == null)
            {
                return NotFound();
            }

            return View(persionNTT573);
        }

        // GET: PersionNTT573s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersionNTT573s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PersionId,PersionName")] PersionNTT573 persionNTT573)
        {
            if (ModelState.IsValid)
            {
                _context.Add(persionNTT573);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(persionNTT573);
        }

        // GET: PersionNTT573s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persionNTT573 = await _context.PersionNTT573.FindAsync(id);
            if (persionNTT573 == null)
            {
                return NotFound();
            }
            return View(persionNTT573);
        }

        // POST: PersionNTT573s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PersionId,PersionName")] PersionNTT573 persionNTT573)
        {
            if (id != persionNTT573.PersionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(persionNTT573);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersionNTT573Exists(persionNTT573.PersionId))
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
            return View(persionNTT573);
        }

        // GET: PersionNTT573s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var persionNTT573 = await _context.PersionNTT573
                .FirstOrDefaultAsync(m => m.PersionId == id);
            if (persionNTT573 == null)
            {
                return NotFound();
            }

            return View(persionNTT573);
        }

        // POST: PersionNTT573s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var persionNTT573 = await _context.PersionNTT573.FindAsync(id);
            _context.PersionNTT573.Remove(persionNTT573);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersionNTT573Exists(int id)
        {
            return _context.PersionNTT573.Any(e => e.PersionId == id);
        }
    }
}
