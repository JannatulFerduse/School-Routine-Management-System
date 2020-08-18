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
    public class LoginController : Controller
    {
        private readonly SchoolDbContext _context;

        public LoginController(SchoolDbContext context)
        {
            _context = context;
        }

        // GET: Login
        public async Task<IActionResult> Index()
        {
            return View(await _context.tblLogin.ToListAsync());
        }


        public IActionResult AdminLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AdminLogin(tblLogin log)
        {
            var test = (from s in _context.tblLogin
                        where s.UserName == log.UserName && s.Password == log.Password && s.UserType == log.UserType
                        select s).FirstOrDefault();
            if (test != null)
            {
                if (test.UserType == "Admin")
                {
                    return RedirectToAction("Index", new { username = test.UserName });
                }
                else if (test.UserType == "Teacher")
                {
                    return RedirectToAction("Create", "Teacher", new { username = test.UserName });
                }
                else if (test.UserType == "Student")
                {
                    return RedirectToAction("Result", "Teacher", new { username = test.UserName });
                }
            }
            else
            {
                ViewBag.msg = "Username or Password or User Type is incorrect";
            }
            return View();
        }

        // GET: Login/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblLogin = await _context.tblLogin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblLogin == null)
            {
                return NotFound();
            }

            return View(tblLogin);
        }

        // GET: Login/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,UserType,Password")] tblLogin tblLogin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tblLogin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tblLogin);
        }

        // GET: Login/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblLogin = await _context.tblLogin.FindAsync(id);
            if (tblLogin == null)
            {
                return NotFound();
            }
            return View(tblLogin);
        }

        // POST: Login/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UserName,UserType,Password")] tblLogin tblLogin)
        {
            if (id != tblLogin.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tblLogin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!tblLoginExists(tblLogin.Id))
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
            return View(tblLogin);
        }

        // GET: Login/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tblLogin = await _context.tblLogin
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tblLogin == null)
            {
                return NotFound();
            }

            return View(tblLogin);
        }

        // POST: Login/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tblLogin = await _context.tblLogin.FindAsync(id);
            _context.tblLogin.Remove(tblLogin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool tblLoginExists(int id)
        {
            return _context.tblLogin.Any(e => e.Id == id);
        }
    }
}
