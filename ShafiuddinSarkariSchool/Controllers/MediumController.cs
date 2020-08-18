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
    public class MediumController : Controller
    {
        private readonly SchoolDbContext _context;

        public MediumController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Medium
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblMedium.ToListAsync());
        }

        // GET: Medium/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMedium = await _context.tblMedium
                .FirstOrDefaultAsync(m => m.MediumId == id);
            if (tblMedium == null)
            {
                return NotFound();
            }

            return View(tblMedium);
        }

        // GET: Medium/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Medium/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MediumId,Name")] tblMedium tblMedium)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblMedium);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblMedium);
        }

        // GET: Medium/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMedium = await _context.tblMedium.FindAsync(id);
            if (tblMedium == null)
            {
                return NotFound();
            }
            return View(tblMedium);
        }

        // POST: Medium/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MediumId,Name")] tblMedium tblMedium)
        {
            if (id != tblMedium.MediumId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblMedium);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblMediumExists(tblMedium.MediumId))
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
            return View(tblMedium);
        }

        // GET: Medium/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblMedium = await _context.tblMedium
                .FirstOrDefaultAsync(m => m.MediumId == id);
            if (tblMedium == null)
            {
                return NotFound();
            }

            return View(tblMedium);
        }

        // POST: Medium/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblMedium = await _context.tblMedium.FindAsync(id);
            _context.tblMedium.Remove(tblMedium);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblMediumExists(int id)
        {
            return _context.tblMedium.Any(e => e.MediumId == id);
        }
    }
}
