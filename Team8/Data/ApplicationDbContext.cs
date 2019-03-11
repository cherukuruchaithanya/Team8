using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
           

            modelBuilder.Entity<Models.Degree>().ToTable("Degrees");

            modelBuilder.Entity<Models.Requirement>().ToTable("Requirements");
            modelBuilder.Entity<Models.DegreeRequirement>().ToTable("DegreeRequirements");
            modelBuilder.Entity<Models.DegreePlanTermRequirement>().ToTable("DegreePlanTermRequirements");
            modelBuilder.Entity<Models.DegreePlan>().ToTable("DegreePlans");
            modelBuilder.Entity<Models.StudentTerm>().ToTable("StudentTerms");
            modelBuilder.Entity<Models.Student>().ToTable("Students");
        }
    }
}
