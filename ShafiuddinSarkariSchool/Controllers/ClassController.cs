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
    public class ClassController : Controller
    {
        private readonly SchoolDbContext _context;

        public ClassController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Classe
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblClass.ToListAsync());
        }

        // GET: Classe/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblClass = await _context.tblClass
                .FirstOrDefaultAsync(m => m.ClassId == id);
            if (tblClass == null)
            {
                return NotFound();
            }

            return View(tblClass);
        }

        // GET: Classe/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Classe/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ClassId,Name")] tblClass tblClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblClass);
        }

        // GET: Classe/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblClass = await _context.tblClass.FindAsync(id);
            if (tblClass == null)
            {
                return NotFound();
            }
            return View(tblClass);
        }

        // POST: Classe/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ClassId,Name")] tblClass tblClass)
        {
            if (id != tblClass.ClassId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblClassExists(tblClass.ClassId))
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
            return View(tblClass);
        }

        // GET: Classe/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblClass = await _context.tblClass
                .FirstOrDefaultAsync(m => m.ClassId == id);
            if (tblClass == null)
            {
                return NotFound();
            }

            return View(tblClass);
        }

        // POST: Classe/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblClass = await _context.tblClass.FindAsync(id);
            _context.tblClass.Remove(tblClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblClassExists(int id)
        {
            return _context.tblClass.Any(e => e.ClassId == id);
        }
    }
}
