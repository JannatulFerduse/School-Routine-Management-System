using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShafiuddinSarkariSchool.Context;
using ShafiuddinSarkariSchool.Models;

namespace ShafiuddinSarkariSchool.Controllers
{
    public class ReligionController : Controller
    {
        private readonly SchoolDbContext _context;

        public ReligionController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Religion
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblReligion.ToListAsync());
        }

        // GET: Religion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblReligion = await _context.tblReligion
                .FirstOrDefaultAsync(m => m.ReligionId == id);
            if (tblReligion == null)
            {
                return NotFound();
            }

            return View(tblReligion);
        }

        // GET: Religion/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Religion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReligionId,Name")] tblReligion tblReligion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblReligion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblReligion);
        }

        // GET: Religion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblReligion = await _context.tblReligion.FindAsync(id);
            if (tblReligion == null)
            {
                return NotFound();
            }
            return View(tblReligion);
        }

        // POST: Religion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReligionId,Name")] tblReligion tblReligion)
        {
            if (id != tblReligion.ReligionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblReligion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblReligionExists(tblReligion.ReligionId))
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
            return View(tblReligion);
        }

        // GET: Religion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblReligion = await _context.tblReligion
                .FirstOrDefaultAsync(m => m.ReligionId == id);
            if (tblReligion == null)
            {
                return NotFound();
            }

            return View(tblReligion);
        }

        // POST: Religion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblReligion = await _context.tblReligion.FindAsync(id);
            _context.tblReligion.Remove(tblReligion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblReligionExists(int id)
        {
            return _context.tblReligion.Any(e => e.ReligionId == id);
        }
    }
}
