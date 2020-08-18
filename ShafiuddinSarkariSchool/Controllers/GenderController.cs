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
    public class GenderController : Controller
    {
        private readonly SchoolDbContext _context;

        public GenderController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Gender
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblGender.ToListAsync());
        }

        // GET: Gender/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGender = await _context.tblGender
                .FirstOrDefaultAsync(m => m.GenderId == id);
            if (tblGender == null)
            {
                return NotFound();
            }

            return View(tblGender);
        }

        // GET: Gender/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Gender/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GenderId,Name")] tblGender tblGender)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblGender);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblGender);
        }

        // GET: Gender/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGender = await _context.tblGender.FindAsync(id);
            if (tblGender == null)
            {
                return NotFound();
            }
            return View(tblGender);
        }

        // POST: Gender/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GenderId,Name")] tblGender tblGender)
        {
            if (id != tblGender.GenderId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblGender);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblGenderExists(tblGender.GenderId))
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
            return View(tblGender);
        }

        // GET: Gender/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblGender = await _context.tblGender
                .FirstOrDefaultAsync(m => m.GenderId == id);
            if (tblGender == null)
            {
                return NotFound();
            }

            return View(tblGender);
        }

        // POST: Gender/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblGender = await _context.tblGender.FindAsync(id);
            _context.tblGender.Remove(tblGender);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblGenderExists(int id)
        {
            return _context.tblGender.Any(e => e.GenderId == id);
        }
    }
}
