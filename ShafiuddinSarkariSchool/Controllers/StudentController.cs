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
    public class StudentController : Controller
    {
        private readonly SchoolDbContext _context;

        public StudentController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Student
        public async Task<IActionResult> Index()
        {
            var schoolDbContext = _context.tblStudent.Include(t => t.tblBloodGroup).Include(t => t.tblClass).Include(t => t.tblGender).Include(t => t.tblMedium).Include(t => t.tblReligion).Include(t => t.tblSection);
            return View(await schoolDbContext.ToListAsync());
        }

        // GET: Student/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblStudent = await _context.tblStudent
                .Include(t => t.tblBloodGroup)
                .Include(t => t.tblClass)
                .Include(t => t.tblGender)
                .Include(t => t.tblMedium)
                .Include(t => t.tblReligion)
                .Include(t => t.tblSection)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (tblStudent == null)
            {
                return NotFound();
            }

            return View(tblStudent);
        }

        // GET: Student/Create
        public IActionResult Create()
        {
            ViewData["BloodGroupId"] = new SelectList(_context.tblBloodGroup, "BloodGroupId", "Name");
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "Name");
            ViewData["GenderId"] = new SelectList(_context.tblGender, "GenderId", "Name");
            ViewData["MediumId"] = new SelectList(_context.tblMedium, "MediumId", "Name");
            ViewData["ReligionId"] = new SelectList(_context.tblReligion, "ReligionId", "Name");
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name");
            return View();
        }

        // POST: Student/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentId,MediumId,ClassId,RollNo,SectionId,AdmissionDate,Name,Password,ConfirmPassword,FathersName,MothersName,DateOfBirth,GenderId,Address,Nationality,BloodGroupId,ReligionId,ParentsCell")] tblStudent tblStudent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblStudent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["BloodGroupId"] = new SelectList(_context.tblBloodGroup, "BloodGroupId", "Name", tblStudent.BloodGroupId);
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "Name", tblStudent.ClassId);
            ViewData["GenderId"] = new SelectList(_context.tblGender, "GenderId", "Name", tblStudent.GenderId);
            ViewData["MediumId"] = new SelectList(_context.tblMedium, "MediumId", "Name", tblStudent.MediumId);
            ViewData["ReligionId"] = new SelectList(_context.tblReligion, "ReligionId", "Name", tblStudent.ReligionId);
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "Name", tblStudent.SectionId);
            return View(tblStudent);
        }

        // GET: Student/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblStudent = await _context.tblStudent.FindAsync(id);
            if (tblStudent == null)
            {
                return NotFound();
            }
            ViewData["BloodGroupId"] = new SelectList(_context.tblBloodGroup, "BloodGroupId", "BloodGroupId", tblStudent.BloodGroupId);
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "ClassId", tblStudent.ClassId);
            ViewData["GenderId"] = new SelectList(_context.tblGender, "GenderId", "GenderId", tblStudent.GenderId);
            ViewData["MediumId"] = new SelectList(_context.tblMedium, "MediumId", "MediumId", tblStudent.MediumId);
            ViewData["ReligionId"] = new SelectList(_context.tblReligion, "ReligionId", "ReligionId", tblStudent.ReligionId);
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "SectionId", tblStudent.SectionId);
            return View(tblStudent);
        }

        // POST: Student/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentId,MediumId,ClassId,RollNo,SectionId,AdmissionDate,Name,Password,ConfirmPassword,FathersName,MothersName,DateOfBirth,GenderId,Address,Nationality,BloodGroupId,ReligionId,ParentsCell")] tblStudent tblStudent)
        {
            if (id != tblStudent.StudentId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblStudent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblStudentExists(tblStudent.StudentId))
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
            ViewData["BloodGroupId"] = new SelectList(_context.tblBloodGroup, "BloodGroupId", "BloodGroupId", tblStudent.BloodGroupId);
            ViewData["ClassId"] = new SelectList(_context.tblClass, "ClassId", "ClassId", tblStudent.ClassId);
            ViewData["GenderId"] = new SelectList(_context.tblGender, "GenderId", "GenderId", tblStudent.GenderId);
            ViewData["MediumId"] = new SelectList(_context.tblMedium, "MediumId", "MediumId", tblStudent.MediumId);
            ViewData["ReligionId"] = new SelectList(_context.tblReligion, "ReligionId", "ReligionId", tblStudent.ReligionId);
            ViewData["SectionId"] = new SelectList(_context.tblSection, "SectionId", "SectionId", tblStudent.SectionId);
            return View(tblStudent);
        }

        // GET: Student/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblStudent = await _context.tblStudent
                .Include(t => t.tblBloodGroup)
                .Include(t => t.tblClass)
                .Include(t => t.tblGender)
                .Include(t => t.tblMedium)
                .Include(t => t.tblReligion)
                .Include(t => t.tblSection)
                .FirstOrDefaultAsync(m => m.StudentId == id);
            if (tblStudent == null)
            {
                return NotFound();
            }

            return View(tblStudent);
        }

        // POST: Student/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblStudent = await _context.tblStudent.FindAsync(id);
            _context.tblStudent.Remove(tblStudent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblStudentExists(int id)
        {
            return _context.tblStudent.Any(e => e.StudentId == id);
        }
    }
}
