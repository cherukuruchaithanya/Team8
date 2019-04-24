using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Team8.Data;
using Team8.Models;

namespace Team8.Controllers
{
    public class StudentDegreePlansController : Controller
    {
        private readonly ApplicationDbContext _context;

        public StudentDegreePlansController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: StudentDegreePlans................................................
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.StudentDegreePlans
                .Include(p => p.Degree).ThenInclude(pd => pd.DegreeRequirements)
                .Include(p => p.DegreeStatus)
                .Include(p => p.Student);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: StudentDegreePlans/Details/5.........................................
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) { return NotFound(); }
            var studentDegreePlan = await _context.StudentDegreePlans
                .Include(p => p.Degree)
                .Include(p => p.DegreeStatus)
                .Include(p => p.Student)
                .SingleOrDefaultAsync(m => m.StudentDegreePlanId == id);
            if (studentDegreePlan == null) { return NotFound(); }
            return View(studentDegreePlan);
        }

        // GET: StudentDegreePlans/Create................................................
        public IActionResult Create()
        {
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbrev");
            ViewData["DegreeStatusId"] = new SelectList(_context.DegreeStatuses, "DegreeStatusId", "Status");
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "GivenName");
            return View();
        }

        // POST: StudentDegreePlans/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentDegreePlanId,StudentId,DegreeId,PlanNumber,PlanAbbrev,PlanName,DegreeStatusId,IncludesInternship")] StudentDegreePlan studentDegreePlan)
        {
            if (ModelState.IsValid)
            {
                _context.Add(studentDegreePlan);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbrev", studentDegreePlan.DegreeId);
            ViewData["DegreeStatusId"] = new SelectList(_context.DegreeStatuses, "DegreeStatusId", "Status", studentDegreePlan.DegreeStatusId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "GivenName", studentDegreePlan.StudentId);
            return View(studentDegreePlan);
        }

        // GET: StudentDegreePlans/Edit/5................................PLANNING.........................................
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) { return NotFound(); }
            var studentDegreePlan = await _context.StudentDegreePlans
                .Include(p => p.Degree).ThenInclude(pd => pd.DegreeRequirements)
                .Include(p => p.DegreeStatus)
                .Include(p => p.Student)
                .Include(p => p.PlanTerms).ThenInclude(pt => pt.PlanTermRequirements)
                .SingleOrDefaultAsync(m => m.StudentDegreePlanId == id);

            if (studentDegreePlan == null) { return NotFound(); }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbrev", studentDegreePlan.DegreeId);
            ViewData["DegreeStatusId"] = new SelectList(_context.DegreeStatuses, "DegreeStatusId", "Status", studentDegreePlan.DegreeStatusId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "GivenName", studentDegreePlan.StudentId);
            return View(studentDegreePlan);
        }

        // POST: StudentDegreePlans/Edit/5...............................................................................
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("StudentDegreePlanId,StudentId,DegreeId,PlanNumber,PlanAbbrev,PlanName,DegreeStatusId,IncludesInternship")] StudentDegreePlan studentDegreePlan)
        {
            if (id != studentDegreePlan.StudentDegreePlanId) { return NotFound(); }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(studentDegreePlan);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentDegreePlanExists(studentDegreePlan.StudentDegreePlanId)) { return NotFound(); }
                    else { throw; }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["DegreeId"] = new SelectList(_context.Degrees, "DegreeId", "DegreeAbbrev", studentDegreePlan.DegreeId);
            ViewData["DegreeStatusId"] = new SelectList(_context.DegreeStatuses, "DegreeStatusId", "Status", studentDegreePlan.DegreeStatusId);
            ViewData["StudentId"] = new SelectList(_context.Students, "StudentId", "GivenName", studentDegreePlan.StudentId);
            return View(studentDegreePlan);
        }

        // GET: StudentDegreePlans/Delete/5........................................................................
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) { return NotFound(); }
            var studentDegreePlan = await _context.StudentDegreePlans
                .Include(s => s.Degree)
                .Include(s => s.DegreeStatus)
                .Include(s => s.Student)
                .SingleOrDefaultAsync(m => m.StudentDegreePlanId == id);
            if (studentDegreePlan == null) { return NotFound(); }
            return View(studentDegreePlan);
        }

        // POST: StudentDegreePlans/Delete/5........................................................................
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var studentDegreePlan = await _context.StudentDegreePlans.SingleOrDefaultAsync(m => m.StudentDegreePlanId == id);
            _context.StudentDegreePlans.Remove(studentDegreePlan);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentDegreePlanExists(int id)
        {
            return _context.StudentDegreePlans.Any(e => e.StudentDegreePlanId == id);
        }
    }
}
