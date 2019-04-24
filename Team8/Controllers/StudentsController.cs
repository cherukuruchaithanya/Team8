using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team8.Data;
using Team8.Models;

namespace Team8.Controllers {
  [Authorize]
  public class StudentsController : Controller {
    private readonly ApplicationDbContext _context;

    public StudentsController (ApplicationDbContext context) {
      _context = context;
    }

    // GET: Students
    public async Task<IActionResult> Index (string sortOrder, string searchString) {
      ViewData["FamilySortParam"] = String.IsNullOrEmpty (sortOrder) ? "family_desc" : "";
      ViewData["GivenSortParam"] = sortOrder == "given" ? "given_desc" : "given";
      ViewData["CurrentFilter"] = searchString;

      var students = from s in _context.Students
      select s;

      if (!String.IsNullOrEmpty (searchString)) {
        students = students.Where (s => s.FamilyName.Contains (searchString) ||
          s.GivenName.Contains (searchString));
      }

      switch (sortOrder) {
        case "family_desc":
          students = students.OrderByDescending (s => s.FamilyName);
          break;
        case "given_desc":
          students = students.OrderByDescending (s => s.GivenName);
          break;
        case "given":
          students = students.OrderBy (s => s.GivenName);
          break;
        default:
          students = students.OrderBy (s => s.FamilyName);
          break;
      }

      return View (await students.AsNoTracking().ToListAsync ());
    }

    // GET: Students/Details/5
    public async Task<IActionResult> Details (int? id) {
      if (id == null) {
        return NotFound ();
      }

      var student = await _context.Students
        .Include (d => d.StudentDegreePlans)
        .SingleOrDefaultAsync (m => m.StudentId == id);

      if (student == null) {
        return NotFound ();
      }

      return View (student);
    }

    // GET: Students/Create
    [Authorize]
    public IActionResult Create () {
      return View ();
    }

    // POST: Students/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create ([Bind ("StudentId,GivenName,FamilyName")] Student student) {
      if (ModelState.IsValid) {
        _context.Add (student);
        await _context.SaveChangesAsync ();
        return RedirectToAction (nameof (Index));
      }
      return View (student);
    }

    // GET: Students/Edit/5
    public async Task<IActionResult> Edit (int? id) {
      if (id == null) {
        return NotFound ();
      }

      var student = await _context.Students.SingleOrDefaultAsync (m => m.StudentId == id);
      if (student == null) {
        return NotFound ();
      }
      return View (student);
    }

    // POST: Students/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit (int id, [Bind ("StudentId,GivenName,FamilyName")] Student student) {
      if (id != student.StudentId) {
        return NotFound ();
      }

      if (ModelState.IsValid) {
        try {
          _context.Update (student);
          await _context.SaveChangesAsync ();
        } catch (DbUpdateConcurrencyException) {
          if (!StudentExists (student.StudentId)) {
            return NotFound ();
          } else {
            throw;
          }
        }
        return RedirectToAction (nameof (Index));
      }
      return View (student);
    }

    // GET: Students/Delete/5
    public async Task<IActionResult> Delete (int? id) {
      if (id == null) {
        return NotFound ();
      }
      var student = await _context.Students
        .SingleOrDefaultAsync (m => m.StudentId == id);
      if (student == null) {
        return NotFound ();
      }
      return View (student);
    }

    // POST: Students/Delete/5
    [HttpPost, ActionName ("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed (int id) {
      var student = await _context.Students.SingleOrDefaultAsync (m => m.StudentId == id);
      _context.Students.Remove (student);
      await _context.SaveChangesAsync ();
      return RedirectToAction (nameof (Index));
    }

    private bool StudentExists (int id) {
      return _context.Students.Any (e => e.StudentId == id);
    }
  }
}