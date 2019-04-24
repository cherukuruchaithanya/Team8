using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Team8.Models;

namespace Team8.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> {
    public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {
            
        }
        

            public DbSet<DegreeStatus> DegreeStatuses { get; set; }
            public DbSet<RequirementStatus> RequirementStatuses { get; set; }
            public DbSet<Degree> Degrees { get; set; }
            public DbSet<Student> Students { get; set; }
            public DbSet<DegreeRequirement> DegreeRequirements { get; set; }
            public DbSet<StudentDegreePlan> StudentDegreePlans { get; set; }
            public DbSet<PlanTerm> PlanTerms { get; set; }
            public DbSet<PlanTermRequirement> PlanTermRequirements { get; set; }

            protected override void OnModelCreating (ModelBuilder builder) {
              base.OnModelCreating (builder);

     
              builder.Entity<DegreeStatus> ().ToTable ("DegreeStatus");
              builder.Entity<RequirementStatus> ().ToTable ("RequirementStatus");
              builder.Entity<Degree> ().ToTable ("Degree");
              builder.Entity<Student> ().ToTable ("Student");
              builder.Entity<DegreeRequirement> ().ToTable ("DegreeRequirement");
              builder.Entity<StudentDegreePlan> ().ToTable ("StudentDegreePlan");
              builder.Entity<PlanTerm> ().ToTable ("PlanTerm");
              builder.Entity<PlanTermRequirement> ().ToTable ("PlanTermRequirement");
            }
          }
        }