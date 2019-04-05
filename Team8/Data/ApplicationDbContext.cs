using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Team8.Models;

namespace Team8.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Models.Degree> Degrees { get; set; }
        public DbSet<Models.Requirement> Requirements { get; set; }
        public DbSet<Models.DegreeRequirement> DegreeRequirements { get; set; }
        public DbSet<Models.DegreePlanTermRequirement> DegreePlanTermRequirements { get; set; }
        public DbSet<Models.DegreePlan> DegreePlans { get; set; }
        public DbSet<Models.StudentTerm> StudentTerms { get; set; }
        public DbSet<Models.Student> Students { get; set; }
        public DbSet<Team8.Models.Todo> Todo { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            modelBuilder.Entity<Degree>().ToTable("Degree");
            modelBuilder.Entity<Models.Requirement>().ToTable("Requirement");
            modelBuilder.Entity<Models.DegreeRequirement>().ToTable("DegreeRequirement");
            modelBuilder.Entity<Models.DegreePlanTermRequirement>().ToTable("DegreePlanTermRequirement");
            modelBuilder.Entity<Models.DegreePlan>().ToTable("DegreePlan");
            modelBuilder.Entity<Models.StudentTerm>().ToTable("StudentTerm");
            modelBuilder.Entity<Models.Student>().ToTable("Student");
            modelBuilder.Entity<Models.Todo>().ToTable("Todo");

        }
    }
}
