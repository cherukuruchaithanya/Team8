using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Team8.Models;
using Team8.Data;

namespace Team8.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // after adding a new model, run: dotnet ef migrations add degree  
            // rename to a short name e.g. degree
            // apply with: dotnet ef database update

            // if we have degree data already, skip adding degrees, otherwise add
            if (context.Degrees.Any()) { Console.WriteLine("Degrees already exist."); }
            else
            {
                var degrees = new Degree[]
                {
                     new Degree {DegreeId = 1, DegreeAbbr = "ACS+2", DegreeName = "MS ACS+2" },
                     new Degree {DegreeId = 2, DegreeAbbr = "ACS+DB", DegreeName = "MS ACS+DB" },
                     new Degree {DegreeId = 3, DegreeAbbr = "ACS+NF", DegreeName = "MS ACS+NF" },
                     new Degree {DegreeId = 4, DegreeAbbr = "ACS", DegreeName = "MS ACS" },
                };
                Console.WriteLine($"Inserting {degrees.Length} new degrees.");
                foreach (Degree d in degrees) { context.Degrees.Add(d); }
                context.SaveChanges();
            }

            // if we have requirement data already, skip adding, otherwise add
            if (context.Requirements.Any()) { Console.WriteLine("Requirements already exist."); }
            else
            {
                var all = new Requirement[]
                {
                      new Requirement {RequirementId = 460, RequirementAbbr ="DB", RequirementName = "44-460 Database", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 356, RequirementAbbr = "NF", RequirementName = "44-356 Network Fundamemtals", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 542, RequirementAbbr = "OOP", RequirementName = "44-542 OOP with Java", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 563, RequirementAbbr = "Web apps", RequirementName = "44-563 Web apps", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 560, RequirementAbbr = "ADB", RequirementName = "44-560 ADB", IsSummer = 1, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 664, RequirementAbbr = "NS", RequirementName = "44-555 Network Security", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 618, RequirementAbbr = "PM", RequirementName = "44-618 PM", IsSummer = 1, IsSpring = 0, IsFall = 0 },
 new Requirement {RequirementId = 555, RequirementAbbr = "Mobile", RequirementName = "44-643 or 44-644", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 691, RequirementAbbr = "UX", RequirementName = "44-664 UX", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 692, RequirementAbbr = "E1", RequirementName = "Elective 1", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 6, RequirementAbbr = "E2", RequirementName = "Elective 2", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 10, RequirementAbbr = "GDP1", RequirementName = "GDP1", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 new Requirement {RequirementId = 20, RequirementAbbr = "GDP2", RequirementName = "GDP2", IsSummer = 0, IsSpring = 1, IsFall = 1 },
 };
                Console.WriteLine($"Inserting {all.Length} new requirements.");
                foreach (Requirement i in all) { context.Requirements.Add(i); }
                context.SaveChanges();
            }

            // if we have DegreeRequirements already, skip adding, otherwise add
            if (context.DegreeRequirements.Any()) { Console.WriteLine("DegreeRequirements already exist."); }
            else
            {
                var all = new DegreeRequirement[]
                {
 new DegreeRequirement {DegreeRequirementId = 1460, DegreeId = 1, RequirementId = 460 },
 new DegreeRequirement {DegreeRequirementId = 1356, DegreeId = 1, RequirementId = 356 },
 new DegreeRequirement {DegreeRequirementId = 1542, DegreeId = 1, RequirementId = 542 },
 new DegreeRequirement {DegreeRequirementId = 1563, DegreeId = 1, RequirementId = 563 },
 new DegreeRequirement {DegreeRequirementId = 1560, DegreeId = 1, RequirementId = 560 },
 new DegreeRequirement {DegreeRequirementId = 1555, DegreeId = 1, RequirementId = 555 },
 new DegreeRequirement {DegreeRequirementId = 1618, DegreeId = 1, RequirementId = 618 },
 new DegreeRequirement {DegreeRequirementId = 16, DegreeId = 1, RequirementId = 6 },
 new DegreeRequirement {DegreeRequirementId = 1664, DegreeId = 1, RequirementId = 664 },
 new DegreeRequirement {DegreeRequirementId = 110, DegreeId = 1, RequirementId = 10 },
 new DegreeRequirement {DegreeRequirementId = 120, DegreeId = 1, RequirementId = 20 },
 new DegreeRequirement {DegreeRequirementId = 1691, DegreeId = 1, RequirementId = 691 },
 new DegreeRequirement {DegreeRequirementId = 1692, DegreeId = 1, RequirementId = 692 },
 new DegreeRequirement {DegreeRequirementId = 2460, DegreeId = 2, RequirementId = 460 },
 new DegreeRequirement {DegreeRequirementId = 2542, DegreeId = 2, RequirementId = 542 },
 new DegreeRequirement {DegreeRequirementId = 2563, DegreeId = 2, RequirementId = 563 },
 new DegreeRequirement {DegreeRequirementId = 2560, DegreeId = 2, RequirementId = 560 },
 new DegreeRequirement {DegreeRequirementId = 2555, DegreeId = 2, RequirementId = 555 },
 new DegreeRequirement {DegreeRequirementId = 2618, DegreeId = 2, RequirementId = 618 },
 new DegreeRequirement {DegreeRequirementId = 26, DegreeId = 2, RequirementId = 6 },
 new DegreeRequirement {DegreeRequirementId = 2664, DegreeId = 2, RequirementId = 664 },
 new DegreeRequirement {DegreeRequirementId = 210, DegreeId = 2, RequirementId = 10 },
 new DegreeRequirement {DegreeRequirementId = 220, DegreeId = 2, RequirementId = 20 },
 new DegreeRequirement {DegreeRequirementId = 2691, DegreeId = 2, RequirementId = 691 },
 new DegreeRequirement {DegreeRequirementId = 2692, DegreeId = 2, RequirementId = 692 },
 new DegreeRequirement {DegreeRequirementId = 3356, DegreeId = 3, RequirementId = 356 },
 new DegreeRequirement {DegreeRequirementId = 3542, DegreeId = 3, RequirementId = 542 },
 new DegreeRequirement {DegreeRequirementId = 3563, DegreeId = 3, RequirementId = 563 },
 new DegreeRequirement {DegreeRequirementId = 3560, DegreeId = 3, RequirementId = 560 },
 new DegreeRequirement {DegreeRequirementId = 3555, DegreeId = 3, RequirementId = 555 },
 new DegreeRequirement {DegreeRequirementId = 3618, DegreeId = 3, RequirementId = 618 },
 new DegreeRequirement {DegreeRequirementId = 36, DegreeId = 3, RequirementId = 6 },
 new DegreeRequirement {DegreeRequirementId = 3664, DegreeId = 3, RequirementId = 664 },
 new DegreeRequirement {DegreeRequirementId = 310, DegreeId = 3, RequirementId = 10 },
 new DegreeRequirement {DegreeRequirementId = 320, DegreeId = 3, RequirementId = 20 },
 new DegreeRequirement {DegreeRequirementId = 3691, DegreeId = 3, RequirementId = 691 },
 new DegreeRequirement {DegreeRequirementId = 3692, DegreeId = 3, RequirementId = 692 },
 new DegreeRequirement {DegreeRequirementId = 4542, DegreeId = 4, RequirementId = 542 },
 new DegreeRequirement {DegreeRequirementId = 4563, DegreeId = 4, RequirementId = 563 },
 new DegreeRequirement {DegreeRequirementId = 4560, DegreeId = 4, RequirementId = 560 },
 new DegreeRequirement {DegreeRequirementId = 4555, DegreeId = 4, RequirementId = 555 },
 new DegreeRequirement {DegreeRequirementId = 4618, DegreeId = 4, RequirementId = 618 },
 new DegreeRequirement {DegreeRequirementId = 46, DegreeId = 4, RequirementId = 6 },
 new DegreeRequirement {DegreeRequirementId = 4664, DegreeId = 4, RequirementId = 664 },
 new DegreeRequirement {DegreeRequirementId = 410, DegreeId = 4, RequirementId = 10 },
 new DegreeRequirement {DegreeRequirementId = 420, DegreeId = 4, RequirementId = 20 },
 new DegreeRequirement {DegreeRequirementId = 4691, DegreeId = 4, RequirementId = 691 },
 new DegreeRequirement {DegreeRequirementId = 4692, DegreeId = 4, RequirementId = 692 },
};
                Console.WriteLine($"Inserted {all.Length} new DegreeRequirements.");
                foreach (DegreeRequirement i in all) { context.DegreeRequirements.Add(i); }
                context.SaveChanges();
            }

            // if we have Students already, skip adding, otherwise add
            if (context.Students.Any()) { Console.WriteLine("Students already exist."); }
            else
            {
                var all = new Student[]

                {
                    new Student {StudentId = 531495, Family = "Cherukuru", Given = "Chaithanya" },

new Student {StudentId = 531502, Family = "Midhun", Given = "Kurapati" },

new Student {StudentId = 531369, Family = "Girish", Given = "Guntuku" },

  new Student {StudentId = 525956, Family = "Pappu", Given = "sha" },


                  };
                Console.WriteLine($"Inserted {all.Length} new Students.");
                foreach (Student i in all) { context.Students.Add(i); }
                context.SaveChanges();
            }

            // if we have DegreePlans already, skip adding, otherwise add
            if (context.DegreePlans.Any()) { Console.WriteLine("DegreePlans already exist."); }
            else
            {
                var all = new DegreePlan[]
                {
                     new DegreePlan {DegreePlanId = 5681, DegreeId = 4, StudentId = 531369, DegreePlanAbbrev = "S", DegreePlanName = "With Summer", SortOrder = 1 },
                     new DegreePlan {DegreePlanId = 7081, DegreeId = 4, StudentId = 531369, DegreePlanAbbrev = "S", DegreePlanName = "With Summer", SortOrder = 1 },
                     new DegreePlan {DegreePlanId = 8971, DegreeId = 4, StudentId = 531495, DegreePlanAbbrev = "S", DegreePlanName = "With Summer", SortOrder = 1 },
                     new DegreePlan {DegreePlanId = 8975, DegreeId = 4, StudentId = 531495, DegreePlanAbbrev = "S", DegreePlanName = "With Summer", SortOrder = 1 },
                     new DegreePlan {DegreePlanId = 5682, DegreeId = 4, StudentId = 531502, DegreePlanAbbrev = "NS", DegreePlanName = "No Summer", SortOrder = 2 },
                     new DegreePlan {DegreePlanId = 7082, DegreeId = 4, StudentId = 531502, DegreePlanAbbrev = "NS", DegreePlanName = "No Summer", SortOrder = 2 },
                     new DegreePlan {DegreePlanId = 8972, DegreeId = 4, StudentId = 525956, DegreePlanAbbrev = "NS", DegreePlanName = "No Summer", SortOrder = 2 },
                     new DegreePlan {DegreePlanId = 8977, DegreeId = 4, StudentId = 525956, DegreePlanAbbrev = "NS", DegreePlanName = "No Summer", SortOrder = 2 },
                  };
                Console.WriteLine($"Inserted {all.Length} new DegreePlans.");
                foreach (DegreePlan i in all) { context.DegreePlans.Add(i); }
                context.SaveChanges();
            }

            // if we have StudentTerms already, skip adding, otherwise add

            if (context.StudentTerms.Any()) { Console.WriteLine("StudentTerms already exist."); }
            else
            {
                var all = new StudentTerm[]
                {
                     new StudentTerm {StudentTermId = 5335681, StudentId = "533568", Term = 1, Abbrev = "F18", Name = "Fall 2018" },
                    new StudentTerm {StudentTermId = 5335682, StudentId = "533568", Term = 2, Abbrev = "SP19", Name = "Spring 2019" },
                    new StudentTerm {StudentTermId = 5335683, StudentId = "533568", Term = 3, Abbrev = "SU19", Name = "Summer 2019" },
                    new StudentTerm {StudentTermId = 5335684, StudentId = "533568", Term = 4, Abbrev = "F19", Name = "Fall 2019" },
                    new StudentTerm {StudentTermId = 5335685, StudentId = "533568", Term = 5, Abbrev = "SP20", Name = "Spring 2020" },
                    new StudentTerm {StudentTermId = 5335686, StudentId = "533568", Term = 6, Abbrev = "SU20", Name = "Summer 2020" },
                    new StudentTerm {StudentTermId = 5337081, StudentId = "533708", Term = 1, Abbrev = "F18", Name = "Fall 2018" },
                    new StudentTerm {StudentTermId = 5337082, StudentId = "533708", Term = 2, Abbrev = "SP19", Name = "Spring 2019" },
                    new StudentTerm {StudentTermId = 5337083, StudentId = "533708", Term = 3, Abbrev = "SU19", Name = "Summer 2019" },
                    new StudentTerm {StudentTermId = 5337084, StudentId = "533708", Term = 4, Abbrev = "F19", Name = "Fall 2019" },
                    new StudentTerm {StudentTermId = 5337085, StudentId = "533708", Term = 5, Abbrev = "SP20", Name = "Spring 2020" },
                    new StudentTerm {StudentTermId = 5337086, StudentId = "533708", Term = 6, Abbrev = "SU20", Name = "Summer 2020" },
                    new StudentTerm {StudentTermId = 5338971, StudentId = "533897", Term = 1, Abbrev = "SP20", Name = "Spring 2020" },
                    new StudentTerm {StudentTermId = 5338972, StudentId = "533897", Term = 2, Abbrev = "FA20", Name = "Fall 2020" },
                    new StudentTerm {StudentTermId = 5338973, StudentId = "533897", Term = 3, Abbrev = "SP21", Name = "Spring 2021" },
                    new StudentTerm {StudentTermId = 5338974, StudentId = "533897", Term = 4, Abbrev = "SU21", Name = "Summer 2021" },
                    new StudentTerm {StudentTermId = 5338975, StudentId = "533897", Term = 5, Abbrev = "F21", Name = "Fall 2021" },
                    new StudentTerm {StudentTermId = 5338976, StudentId = "533897", Term = 6, Abbrev = "SP2022", Name = "Spring 2022"},

                  };
                Console.WriteLine($"Inserted {all.Length} new StudentTerms.");
                foreach (StudentTerm i in all) { context.StudentTerms.Add(i); }
                context.SaveChanges();
            }


            // if we have DegreePlanTermRequirements already, skip adding, otherwise add
            if (context.DegreePlanTermRequirements.Any()) { Console.WriteLine("DegreePlanTermRequirements already exist."); }
            else
            {
                var all = new DegreePlanTermRequirement[]
                {
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56811542, DegreePlanId = 5681, Term = 1, RequirementId = 542, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56811563, DegreePlanId = 5681, Term = 1, RequirementId = 563, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56811560, DegreePlanId = 5681, Term = 1, RequirementId = 560, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56812664, DegreePlanId = 5681, Term = 2, RequirementId = 664, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 568126, DegreePlanId = 5681, Term = 2, RequirementId = 6, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 5681210, DegreePlanId = 5681, Term = 2, RequirementId = 10, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56813618, DegreePlanId = 5681, Term = 3, RequirementId = 618, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56813691, DegreePlanId = 5681, Term = 3, RequirementId = 691, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56814692, DegreePlanId = 5681, Term = 4, RequirementId = 692, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 5681420, DegreePlanId = 5681, Term = 4, RequirementId = 20, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56814555, DegreePlanId = 5681, Term = 4, RequirementId = 555, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70811542, DegreePlanId = 7081, Term = 1, RequirementId = 542, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70811563, DegreePlanId = 7081, Term = 1, RequirementId = 563, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70811560, DegreePlanId = 7081, Term = 1, RequirementId = 560, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70812664, DegreePlanId = 7081, Term = 2, RequirementId = 664, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 708126, DegreePlanId = 7081, Term = 2, RequirementId = 6, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 7081210, DegreePlanId = 7081, Term = 2, RequirementId = 10, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70813618, DegreePlanId = 7081, Term = 3, RequirementId = 618, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70814691, DegreePlanId = 7081, Term = 4, RequirementId = 691, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 7081420, DegreePlanId = 7081, Term = 4, RequirementId = 20, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70815692, DegreePlanId = 7081, Term = 5, RequirementId = 692, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70815555, DegreePlanId = 7081, Term = 5, RequirementId = 555, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89711542, DegreePlanId = 8971, Term = 1, RequirementId = 542, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89711563, DegreePlanId = 8971, Term = 1, RequirementId = 563, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89711560, DegreePlanId = 8971, Term = 1, RequirementId = 560, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89712664, DegreePlanId = 8971, Term = 2, RequirementId = 664, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 897126, DegreePlanId = 8971, Term = 2, RequirementId = 6, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 8971210, DegreePlanId = 8971, Term = 2, RequirementId = 10, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 8971320, DegreePlanId = 8971, Term = 3, RequirementId = 20, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89713555, DegreePlanId = 8971, Term = 3, RequirementId = 555, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89713691, DegreePlanId = 8971, Term = 3, RequirementId = 691, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89714618, DegreePlanId = 8971, Term = 4, RequirementId = 618, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89714692, DegreePlanId = 8971, Term = 4, RequirementId = 692, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56821542, DegreePlanId = 5682, Term = 1, RequirementId = 542, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56821563, DegreePlanId = 5682, Term = 1, RequirementId = 563, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56821560, DegreePlanId = 5682, Term = 1, RequirementId = 560, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56822664, DegreePlanId = 5682, Term = 2, RequirementId = 664, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 568226, DegreePlanId = 5682, Term = 2, RequirementId = 6, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 5682210, DegreePlanId = 5682, Term = 2, RequirementId = 10, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56823618, DegreePlanId = 5682, Term = 3, RequirementId = 618, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56823691, DegreePlanId = 5682, Term = 3, RequirementId = 691, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56824692, DegreePlanId = 5682, Term = 4, RequirementId = 692, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 5682420, DegreePlanId = 5682, Term = 4, RequirementId = 20, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 56824555, DegreePlanId = 5682, Term = 4, RequirementId = 555, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70821542, DegreePlanId = 7082, Term = 1, RequirementId = 542, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70821563, DegreePlanId = 7082, Term = 1, RequirementId = 563, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70821560, DegreePlanId = 7082, Term = 1, RequirementId = 560, Status = "C" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70822664, DegreePlanId = 7082, Term = 2, RequirementId = 664, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 708226, DegreePlanId = 7082, Term = 2, RequirementId = 6, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 7082210, DegreePlanId = 7082, Term = 2, RequirementId = 10, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70823618, DegreePlanId = 7082, Term = 3, RequirementId = 618, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70824691, DegreePlanId = 7082, Term = 4, RequirementId = 691, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 7082420, DegreePlanId = 7082, Term = 4, RequirementId = 20, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70825692, DegreePlanId = 7082, Term = 5, RequirementId = 692, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 70825555, DegreePlanId = 7082, Term = 5, RequirementId = 555, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89721542, DegreePlanId = 8972, Term = 1, RequirementId = 542, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89721563, DegreePlanId = 8972, Term = 1, RequirementId = 563, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89721560, DegreePlanId = 8972, Term = 1, RequirementId = 560, Status = "A" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89722664, DegreePlanId = 8972, Term = 2, RequirementId = 664, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 897226, DegreePlanId = 8972, Term = 2, RequirementId = 6, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 8972210, DegreePlanId = 8972, Term = 2, RequirementId = 10, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 8972320, DegreePlanId = 8972, Term = 3, RequirementId = 20, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89723555, DegreePlanId = 8972, Term = 3, RequirementId = 555, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89723691, DegreePlanId = 8972, Term = 3, RequirementId = 691, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89724618, DegreePlanId = 8972, Term = 4, RequirementId = 618, Status = "P" },
                     new DegreePlanTermRequirement {DegreePlanTermRequirementId = 89724692, DegreePlanId = 8972, Term = 4, RequirementId = 692, Status = "P" },

                  };
                Console.WriteLine($"Inserted {all.Length} new DegreePlanTermRequirements.");
                foreach (DegreePlanTermRequirement i in all) { context.DegreePlanTermRequirements.Add(i); }
                context.SaveChanges();
            }




        }
    }
}