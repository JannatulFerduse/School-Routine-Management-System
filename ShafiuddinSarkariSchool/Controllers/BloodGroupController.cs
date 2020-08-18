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
    public class BloodGroupController : Controller
    {
        private readonly SchoolDbContext _context;

        public BloodGroupController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: BloodGroup
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblBloodGroup.ToListAsync());
        }

        // GET: BloodGroup/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblBloodGroup = await _context.tblBloodGroup
                .FirstOrDefaultAsync(m => m.BloodGroupId == id);
            if (tblBloodGroup == null)
            {
                return NotFound();
            }

            return View(tblBloodGroup);
        }

        // GET: BloodGroup/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BloodGroup/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BloodGroupId,Name")] tblBloodGroup tblBloodGroup)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblBloodGroup);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblBloodGroup);
        }

        // GET: BloodGroup/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblBloodGroup = await _context.tblBloodGroup.FindAsync(id);
            if (tblBloodGroup == null)
            {
                return NotFound();
            }
            return View(tblBloodGroup);
        }

        // POST: BloodGroup/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("BloodGroupId,Name")] tblBloodGroup tblBloodGroup)
        {
            if (id != tblBloodGroup.BloodGroupId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblBloodGroup);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblBloodGroupExists(tblBloodGroup.BloodGroupId))
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
            return View(tblBloodGroup);
        }

        // GET: BloodGroup/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblBloodGroup = await _context.tblBloodGroup
                .FirstOrDefaultAsync(m => m.BloodGroupId == id);
            if (tblBloodGroup == null)
            {
                return NotFound();
            }

            return View(tblBloodGroup);
        }

        // POST: BloodGroup/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblBloodGroup = await _context.tblBloodGroup.FindAsync(id);
            _context.tblBloodGroup.Remove(tblBloodGroup);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblBloodGroupExists(int id)
        {
            return _context.tblBloodGroup.Any(e => e.BloodGroupId == id);
        }
    }
}
