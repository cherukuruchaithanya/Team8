using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Team8.Data;
using Team8.Models;

namespace Team8.Controllers {
  public class DegreesController : Controller {
    private readonly ApplicationDbContext _context;

    public DegreesController (ApplicationDbContext context) {
      _context = context;
    }

    // GET: Degrees
    public async Task<IActionResult> Index (string sortOrder, string searchString) {
      ViewData["AbbrevSortParam"] = String.IsNullOrEmpty (sortOrder) ? "abbrev_desc" : "";
      ViewData["NameSortParam"] = sortOrder == "name" ? "name_desc" : "name";
      ViewData["CurrentFilter"] = searchString;

      var degrees = from d in _context.Degrees
      select d;

      if (!String.IsNullOrEmpty (searchString)) {
        degrees = degrees.Where (d => d.DegreeAbbrev.Contains (searchString) ||
          d.DegreeName.Contains (searchString));
      }

      switch (sortOrder) {
        case "abbrev_desc":
          degrees = degrees.OrderByDescending (d => d.DegreeAbbrev);
          break;
        case "name_desc":
          degrees = degrees.OrderByDescending (d => d.DegreeName);
          break;
        case "name":
          degrees = degrees.OrderBy (d => d.DegreeName);
          break;
        default:
          degrees = degrees.OrderBy (d => d.DegreeAbbrev);
          break;
      }
      return View (await degrees.AsNoTracking ().ToListAsync ());
    }

    // GET: Degrees/Details/5
    public async Task<IActionResult> Details (int? id) {
      if (id == null) {
        return NotFound ();
      }

      var degree = await _context.Degrees
        .Include (d => d.DegreeRequirements)
        .SingleOrDefaultAsync (m => m.DegreeId == id);

      if (degree == null) {
        return NotFound ();
      }

      return View (degree);
    }

    // GET: Degrees/Create
    public IActionResult Create () {
      return View ();
    }

    // POST: Degrees/Create
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create ([Bind ("DegreeId,DegreeAbbrev,DegreeName")] Degree degree) {
      try {
        if (ModelState.IsValid) {
          _context.Add (degree);
          await _context.SaveChangesAsync ();
          return RedirectToAction (nameof (Index));
        }
      } catch (DbUpdateException ex) {
        ModelState.AddModelError ("", "Unable to save changes. " + ex.Message + " " + ex.InnerException);
      }
      return View (degree);
    }

    // GET: Degrees/Edit/5
    public async Task<IActionResult> Edit (int? id) {
      if (id == null) {
        return NotFound ();
      }

      var degreeToUpdate = await _context.Degrees.SingleOrDefaultAsync (m => m.DegreeId == id);

      if (degreeToUpdate == null) {
        return NotFound ();
      }
      if (await TryUpdateModelAsync<Degree> (
          degreeToUpdate,
          "",
          m => m.DegreeAbbrev, m => m.DegreeName)) {
        try {
          await _context.SaveChangesAsync ();
          return RedirectToAction (nameof (Index));
        } catch (DbUpdateException ex) {
          ModelState.AddModelError ("", "Unable to save changes. " + ex.Message + " " + ex.InnerException);
        }
      }
      return View (degreeToUpdate);
    }

    // POST: Degrees/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit (int id, [Bind ("DegreeId,DegreeAbbrev,DegreeName")] Degree degree) {
      if (id != degree.DegreeId) {
        return NotFound ();
      }

      if (ModelState.IsValid) {
        try {
          _context.Update (degree);
          await _context.SaveChangesAsync ();
        } catch (DbUpdateConcurrencyException) {
          if (!DegreeExists (degree.DegreeId)) {
            return NotFound ();
          } else {
            throw;
          }
        }
        return RedirectToAction (nameof (Index));
      }
      return View (degree);
    }

    // GET: Degrees/Delete/5
    public async Task<IActionResult> Delete (int? id, bool? saveChangesError = false) {
      if (id == null) {
        return NotFound ();
      }

      var degree = await _context.Degrees
        .AsNoTracking ()
        .SingleOrDefaultAsync (m => m.DegreeId == id);
      if (degree == null) {
        return NotFound ();
      }
      if (saveChangesError.GetValueOrDefault ()) {
        ViewData["ErrorMessage"] =
          "Delete failed. Try again.";
      }

      return View (degree);
    }

    // POST: Degrees/Delete/5
    [HttpPost, ActionName ("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed (int id) {
      var degree = await _context.Degrees.SingleOrDefaultAsync (m => m.DegreeId == id);

      if (degree == null) {
        return RedirectToAction (nameof (Index));
      }

      try {
        _context.Degrees.Remove (degree);
        await _context.SaveChangesAsync ();
        return RedirectToAction (nameof (Index));
      } catch (DbUpdateException) {
        return RedirectToAction (nameof (Delete), new { id, saveChangesError = true });
      }
    }

    private bool DegreeExists (int id) {
      return _context.Degrees.Any (e => e.DegreeId == id);
    }
  }
}