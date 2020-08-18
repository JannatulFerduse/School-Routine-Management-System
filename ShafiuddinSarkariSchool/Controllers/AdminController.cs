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
    public class AdminController : Controller
    {
        private readonly SchoolDbContext _context;

        public AdminController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Admin
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblAdmin.ToListAsync());
        }

        // GET: Admin/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblAdmin = await _context.tblAdmin
                .FirstOrDefaultAsync(m => m.AdminId == id);
            if (tblAdmin == null)
            {
                return NotFound();
            }

            return View(tblAdmin);
        }

        // GET: Admin/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AdminId,Name,ExamDate,MarksSubmitDate,ResultPublishDate")] tblAdmin tblAdmin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblAdmin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblAdmin);
        }

        // GET: Admin/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblAdmin = await _context.tblAdmin.FindAsync(id);
            if (tblAdmin == null)
            {
                return NotFound();
            }
            return View(tblAdmin);
        }

        // POST: Admin/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AdminId,Name,ExamDate,MarksSubmitDate,ResultPublishDate")] tblAdmin tblAdmin)
        {
            if (id != tblAdmin.AdminId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblAdmin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblAdminExists(tblAdmin.AdminId))
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
            return View(tblAdmin);
        }

        // GET: Admin/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblAdmin = await _context.tblAdmin
                .FirstOrDefaultAsync(m => m.AdminId == id);
            if (tblAdmin == null)
            {
                return NotFound();
            }

            return View(tblAdmin);
        }

        // POST: Admin/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblAdmin = await _context.tblAdmin.FindAsync(id);
            _context.tblAdmin.Remove(tblAdmin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblAdminExists(int id)
        {
            return _context.tblAdmin.Any(e => e.AdminId == id);
        }
    }
}
