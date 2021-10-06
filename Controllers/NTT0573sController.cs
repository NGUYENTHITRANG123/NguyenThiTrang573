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
    public class NTT0573sController : Controller
    {
        private readonly MvcMovieContext _context;

        public NTT0573sController(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: NTT0573s
        public async Task<IActionResult> Index()
        {
            return View(await _context.NTT0573.ToListAsync());
        }

        // GET: NTT0573s/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTT0573 = await _context.NTT0573
                .FirstOrDefaultAsync(m => m.NTTId == id);
            if (nTT0573 == null)
            {
                return NotFound();
            }

            return View(nTT0573);
        }

        // GET: NTT0573s/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: NTT0573s/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NTTId,NTTName,NTTGender")] NTT0573 nTT0573)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nTT0573);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nTT0573);
        }

        // GET: NTT0573s/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTT0573 = await _context.NTT0573.FindAsync(id);
            if (nTT0573 == null)
            {
                return NotFound();
            }
            return View(nTT0573);
        }

        // POST: NTT0573s/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NTTId,NTTName,NTTGender")] NTT0573 nTT0573)
        {
            if (id != nTT0573.NTTId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nTT0573);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NTT0573Exists(nTT0573.NTTId))
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
            return View(nTT0573);
        }

        // GET: NTT0573s/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nTT0573 = await _context.NTT0573
                .FirstOrDefaultAsync(m => m.NTTId == id);
            if (nTT0573 == null)
            {
                return NotFound();
            }

            return View(nTT0573);
        }

        // POST: NTT0573s/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nTT0573 = await _context.NTT0573.FindAsync(id);
            _context.NTT0573.Remove(nTT0573);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NTT0573Exists(int id)
        {
            return _context.NTT0573.Any(e => e.NTTId == id);
        }
    }
}
