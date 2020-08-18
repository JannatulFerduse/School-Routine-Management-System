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
    public class TeacherController : Controller
    {
        private readonly SchoolDbContext _context;

        public TeacherController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Teacher
        public async Task<IActionResult> Index()
        {
            var schoolDbContext = _context.tblTeacher.Include(t => t.tblClass).Include(t => t.tblExam).Include(t => t.tblSection).Include(t => t.tblStudent);
            return View(await schoolDbContext.ToListAsync());
        }
        // GET: Teacher
        public async Task<IActionResult> Result()
        {
            var schoolDbContext = _context.tblTeacher.Include(t => t.tblClass).Include(t => t.tblExam).Include(t => t.tblSection).Include(t => t.tblStudent);
            return View(await schoolDbContext.ToListAsync());
        }

        // GET: Teacher/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTeacher = await _context.tblTeacher
                .Include(t => t.tblClass)
                .Include(t => t.tblExam)
                .Include(t => t.tblSection)
                .Include(t => t.tblStudent)
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (tblTeacher == null)
            {
                return NotFound();
            }

            return View(tblTeacher);
        }

        // GET: Teacher/Create
        public IActionResult Create()
        {
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "Name");
            ViewData["ExamId"] = new SelectList(_context.tblExam, "ExamId", "Name");
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name");
            ViewData["StudentId"] = new SelectList(_context.tblStudent, "StudentId", "Address");
            return View();
        }

        // POST: Teacher/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TeacherId,Name,ClassId,SectionId,StudentId,ExamId,Bangla,English,Math,Religion,SocialScience,Science,TotalMarks")] tblTeacher tblTeacher)
        {
            if (ModelState.IsValid)
            {
                tblTeacher.TotalMarks = tblTeacher.Bangla + tblTeacher.English + tblTeacher.Math + tblTeacher.Religion + tblTeacher.Science + tblTeacher.SocialScience;
                _context.Add(tblTeacher);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "Name", tblTeacher.ClassId);
            ViewData["ExamId"] = new SelectList(_context.tblExam, "ExamId", "Name", tblTeacher.ExamId);
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name", tblTeacher.SectionId);
            ViewData["StudentId"] = new SelectList(_context.tblStudent, "StudentId", "Address", tblTeacher.StudentId);
            return View(tblTeacher);
        }

        // GET: Teacher/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTeacher = await _context.tblTeacher.FindAsync(id);
            if (tblTeacher == null)
            {
                return NotFound();
            }
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "Name", tblTeacher.ClassId);
            ViewData["ExamId"] = new SelectList(_context.tblExam, "ExamId", "Name", tblTeacher.ExamId);
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name", tblTeacher.SectionId);
            ViewData["StudentId"] = new SelectList(_context.tblStudent, "StudentId", "Address", tblTeacher.StudentId);
            return View(tblTeacher);
        }

        // POST: Teacher/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TeacherId,Name,ClassId,SectionId,StudentId,ExamId,Bangla,English,Math,Religion,SocialScience,Science,TotalMarks")] tblTeacher tblTeacher)
        {
            if (id != tblTeacher.TeacherId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblTeacher);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblTeacherExists(tblTeacher.TeacherId))
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
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "Name", tblTeacher.ClassId);
            ViewData["ExamId"] = new SelectList(_context.tblExam, "ExamId", "Name", tblTeacher.ExamId);
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name", tblTeacher.SectionId);
            ViewData["StudentId"] = new SelectList(_context.tblStudent, "StudentId", "Address", tblTeacher.StudentId);
            return View(tblTeacher);
        }

        // GET: Teacher/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblTeacher = await _context.tblTeacher
                .Include(t => t.tblClass)
                .Include(t => t.tblExam)
                .Include(t => t.tblSection)
                .Include(t => t.tblStudent)
                .FirstOrDefaultAsync(m => m.TeacherId == id);
            if (tblTeacher == null)
            {
                return NotFound();
            }

            return View(tblTeacher);
        }

        // POST: Teacher/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblTeacher = await _context.tblTeacher.FindAsync(id);
            _context.tblTeacher.Remove(tblTeacher);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblTeacherExists(int id)
        {
            return _context.tblTeacher.Any(e => e.TeacherId == id);
        }
    }
}
