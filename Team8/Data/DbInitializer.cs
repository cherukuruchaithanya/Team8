using Team8.Models;
using System;
using System.Linq;

namespace Team8.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            //context.Database.EnsureCreated();

            // Look for any Degrees.
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degrees already exist.");
            }
            else
            {


                var degrees = new Degree[]
                {
                new Degree{DegreeId = 1 , DegreeAbrrev =  "ACS+2", DegreeName = "MS ACS +2" },
                new Degree{DegreeId = 2 , DegreeAbrrev =  "ACS+DB", DegreeName = "MS ACS + DB"},
                new Degree{DegreeId = 3 , DegreeAbrrev =  "ACS+NF", DegreeName = "MS ACS+  NF"},
                new Degree{DegreeId = 4 , DegreeAbrrev =  "ACS", DegreeName = "MS ACS"}

                };

                Console.WriteLine($"Inserted {degrees.Length} new degrees.");


                foreach (Degree d in degrees)
                {
                    context.Degrees.Add(d);
                }
                context.SaveChanges();
            }



            if (context.Requirements.Any())
            {
                Console.WriteLine("Requirements already exist.");
            }
            else
            {
                var requirements = new Requirement[]
                {


                new Requirement{ RequirementID = 460 , DegreeId = 3 ,RequirementAbbrev = "DB" , CourseName = "44-460 Database"},
                new Requirement{ RequirementID = 356 , DegreeId = 3 ,RequirementAbbrev = "NF", CourseName = "44-356 Network Fundamentals"},
                new Requirement{ RequirementID = 542 , DegreeId = 3 ,RequirementAbbrev = "OOP" , CourseName = "44-542 Object Oriented Programming"},
                new Requirement{ RequirementID = 563 , DegreeId = 3 ,RequirementAbbrev = "Web apps" , CourseName = "44-563 Web apps"},
new Requirement{ RequirementID = 560 , DegreeId = 3 ,RequirementAbbrev = "ADB" , CourseName = "44-560 Advance Database topics"},
new Requirement{ RequirementID = 555 , DegreeId = 3 ,RequirementAbbrev = "NS" , CourseName = "44-555 Network Security"},
new Requirement{ RequirementID = 618 , DegreeId = 3 ,RequirementAbbrev = "PM" , CourseName = "44-618 Project Management"},
new Requirement{ RequirementID = 1 , DegreeId = 3 ,RequirementAbbrev = "Mobile Computing" , CourseName = "Mobile Computing"},
new Requirement{ RequirementID = 664 , DegreeId = 3 ,RequirementAbbrev = "HCI" , CourseName = "44-664  User Experience Design"},
new Requirement{ RequirementID = 10 , DegreeId = 3 ,RequirementAbbrev = "E1" , CourseName = "Elective 1"},
new Requirement{ RequirementID = 20 , DegreeId = 3 ,RequirementAbbrev = "E2" , CourseName = "Elective 2"},
new Requirement{ RequirementID = 691 , DegreeId = 3 ,RequirementAbbrev = "GDP1" , CourseName = "GDP1"},
new Requirement{ RequirementID = 692 , DegreeId = 3 ,RequirementAbbrev = "GDP2" , CourseName = "GDP2"}

};
                Console.WriteLine($"Inserted {requirements.Length} new reuirements.");
                foreach (Requirement d in requirements)
                {
                    context.Requirements.Add(d);
                }
                context.SaveChanges();
            }

            if (context.Students.Any())
            {
                Console.WriteLine("Students already exist.");
            }
            else
            {
                var student = new Student[]
                {
new Student{ StudentId = 531369 , First = "Girish" , Last = "Guntuku" , Snumber = "S531369" , _919 = 919534222},
new Student{ StudentId = 531495 , First = "Chaithanya" , Last = "Cherukuru" , Snumber = "S531495" , _919 = 919531369},
new Student{ StudentId = 531333 , First = "Midhun" , Last = "Kumar" , Snumber = "S531333" , _919 = 919531495},
new Student{ StudentId = 534222 , First = "Pappu" , Last = "Sah" , Snumber = "S534222" , _919 = 919531333},




                };


                Console.WriteLine($"Inserted {student.Length} new student.");
                foreach (Student d in student)
                {
                    context.Students.Add(d);
                }
                context.SaveChanges();
            }

            if (context.DegreePlans.Any())
            {
                Console.WriteLine("Degree Plans already exist.");
            }
            else
            {
                var degreeplan = new DegreePlan[]
                {
new DegreePlan{ DegreePlanId = 10 ,  DegreeID = 3 ,  StudentID = 531369 , DegreePlanAbbrev = "NS" , DegreePlanName = "No Summer"},
new DegreePlan{ DegreePlanId = 11 ,  DegreeID = 3 ,  StudentID = 531369 , DegreePlanAbbrev = "S" , DegreePlanName = "Summer"},
new DegreePlan{ DegreePlanId = 12 ,  DegreeID = 3 ,  StudentID = 531495 , DegreePlanAbbrev = "NS" , DegreePlanName = "No Summer"},
new DegreePlan{ DegreePlanId = 13 ,  DegreeID = 3 ,  StudentID = 531495 , DegreePlanAbbrev = "S" , DegreePlanName = "Summer"},
new DegreePlan{ DegreePlanId = 14 ,  DegreeID = 3 ,  StudentID = 531333 , DegreePlanAbbrev = "NS" , DegreePlanName = "No Summer"},
new DegreePlan{ DegreePlanId = 15 ,  DegreeID = 3 ,  StudentID = 531333 , DegreePlanAbbrev = "S" , DegreePlanName = "Summer"},
new DegreePlan{ DegreePlanId = 16 ,  DegreeID = 3 ,  StudentID = 534222 , DegreePlanAbbrev = "NS" , DegreePlanName = "No Summer"},
new DegreePlan{ DegreePlanId = 17 ,  DegreeID = 3 ,  StudentID = 534222 , DegreePlanAbbrev = "S" , DegreePlanName = "Summer"},


                };
                Console.WriteLine($"Inserted {degreeplan.Length} new degree plans.");
                foreach (DegreePlan d in degreeplan)
                {
                    context.DegreePlans.Add(d);
                }
                context.SaveChanges();
            }

            if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("DegreePlan Term Requirements already exist.");
            }
            else
            {
                var degreeplantermrequirement = new DegreePlanTermRequirement[]
                {
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 1 ,  DegreePlanID = 10 , TermID =  1 , RequirementID = 560},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 2 ,  DegreePlanID = 10 , TermID =  1 , RequirementID = 356},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 3 ,  DegreePlanID = 10 , TermID =  1 , RequirementID = 542},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 4 ,  DegreePlanID = 10 , TermID =  1 , RequirementID = 563},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 5 ,  DegreePlanID = 10 , TermID =  2 , RequirementID = 664},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 6 ,  DegreePlanID = 10 , TermID =  2 , RequirementID = 1},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 7 ,  DegreePlanID = 10 , TermID =  2 , RequirementID = 10},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 8 ,  DegreePlanID = 10 , TermID =  3 , RequirementID = 618},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 9 ,  DegreePlanID = 10 , TermID =  3 , RequirementID = 691},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 10 ,  DegreePlanID = 10 , TermID =  4 , RequirementID = 555},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 11 ,  DegreePlanID = 10 , TermID =  4 , RequirementID = 20},
new DegreePlanTermRequirement{ DegreePlanTermRequirementId = 12 ,  DegreePlanID = 10 , TermID =  4 , RequirementID = 692}
};
                Console.WriteLine($"Inserted {degreeplantermrequirement.Length} new student terms.");
                foreach (DegreePlanTermRequirement d in degreeplantermrequirement)
                {
                    context.DegreePlanTermRequirements.Add(d);
                }
                context.SaveChanges();
            }


            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("Degree Requirements already exist.");
            }
            else
            {
                var degreerequirement = new DegreeRequirement[]
                {
                     new DegreeRequirement{DegreeRequirementId = 1 ,  DegreeId = 3 , RequirementId = 356},
 new DegreeRequirement{DegreeRequirementId = 2 ,  DegreeId = 3 , RequirementId = 542},
 new DegreeRequirement{DegreeRequirementId = 3 ,  DegreeId = 3 , RequirementId = 563},
 new DegreeRequirement{DegreeRequirementId = 4 ,  DegreeId = 3 , RequirementId = 560},
 new DegreeRequirement{DegreeRequirementId = 5 ,  DegreeId = 3 , RequirementId = 555},
 new DegreeRequirement{DegreeRequirementId = 6 ,  DegreeId = 3 , RequirementId = 618},
 new DegreeRequirement{DegreeRequirementId = 7 ,  DegreeId = 3 , RequirementId = 1},
 new DegreeRequirement{DegreeRequirementId = 8 ,  DegreeId = 3 , RequirementId = 664},
 new DegreeRequirement{DegreeRequirementId = 9 ,  DegreeId = 3 , RequirementId = 10},
 new DegreeRequirement{DegreeRequirementId = 10 ,  DegreeId = 3 , RequirementId = 20},
 new DegreeRequirement{DegreeRequirementId = 11 ,  DegreeId = 3 , RequirementId = 691},
 new DegreeRequirement{DegreeRequirementId = 12 ,  DegreeId = 3 , RequirementId = 692}
 };
                Console.WriteLine($"Inserted { degreerequirement.Length} new student terms.");
                foreach (DegreeRequirement d in degreerequirement)
                {
                    context.DegreeRequirements.Add(d);
                }
                context.SaveChanges();
            }




            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Student Terms already exist.");
            }
            else
            {
                var studentterm = new StudentTerm[]
                {
                     new StudentTerm { StudentTermId = 1 ,  Term = 1 , TermLabel = "Fall 2017" , DegreePlanId = 10},
 new StudentTerm { StudentTermId = 2 ,  Term = 2 , TermLabel = "Spring 2018" , DegreePlanId = 10},
 new StudentTerm { StudentTermId = 3 ,  Term = 3 , TermLabel = "Summer 2018" , DegreePlanId = 10},
 new StudentTerm { StudentTermId = 4 ,  Term = 4 , TermLabel = "Fall 2018" , DegreePlanId = 10},
 new StudentTerm { StudentTermId = 5 ,  Term = 1 , TermLabel = "Spring 2018" , DegreePlanId = 12},
 new StudentTerm { StudentTermId = 6 , Term = 2 , TermLabel = "Summer 2018" , DegreePlanId = 12},
 new StudentTerm { StudentTermId = 7 ,  Term = 3 , TermLabel = "Fall 2018" , DegreePlanId = 12},
 new StudentTerm { StudentTermId = 8 ,  Term = 4 , TermLabel = "Spring 2019" , DegreePlanId = 12},
 new StudentTerm { StudentTermId = 9 ,  Term = 1 , TermLabel = "Spring 2018" , DegreePlanId = 14},
 new StudentTerm { StudentTermId = 10 ,  Term = 2 , TermLabel = "Summer 2018" , DegreePlanId = 14},
 new StudentTerm { StudentTermId = 11 ,  Term = 3 , TermLabel = "Fall 2018" , DegreePlanId = 14},
 new StudentTerm { StudentTermId = 12 ,  Term = 4 , TermLabel = "Spring 2019" , DegreePlanId = 14},
 new StudentTerm { StudentTermId = 13 ,  Term = 5 , TermLabel = "Summer 2019" , DegreePlanId = 14},
 new StudentTerm { StudentTermId = 14 ,  Term = 6 , TermLabel = "Fall 2019" , DegreePlanId = 14},
 new StudentTerm { StudentTermId = 15 , Term = 1 , TermLabel = "Fall 2018" , DegreePlanId = 16},
 new StudentTerm { StudentTermId = 16 ,  Term = 2 , TermLabel = "Spring 2019" , DegreePlanId = 16},
 new StudentTerm { StudentTermId = 17 , Term = 3 , TermLabel = "Summer 2019" , DegreePlanId = 16},
 new StudentTerm { StudentTermId = 18 ,  Term = 4 , TermLabel = "Fall 2019" , DegreePlanId = 16},
 new StudentTerm { StudentTermId = 19 ,  Term = 1 , TermLabel = "Fall2018" , DegreePlanId = 18},
 new StudentTerm { StudentTermId = 20 ,  Term = 2 , TermLabel = "Spring2019" , DegreePlanId = 18},
 new StudentTerm { StudentTermId = 21 ,  Term = 3 , TermLabel = "Summer 2019" , DegreePlanId = 18},
 new StudentTerm { StudentTermId = 22 ,  Term = 4 , TermLabel = "Fall2019" , DegreePlanId = 18},
 new StudentTerm { StudentTermId = 23 ,  Term = 5 , TermLabel = "Spring 2020" , DegreePlanId = 18},
 new StudentTerm { StudentTermId = 24 , Term = 6 , TermLabel = "Summer 2020" , DegreePlanId = 18}


                };
                Console.WriteLine($"Inserted {studentterm.Length} new student terms.");
                foreach (StudentTerm d in studentterm)
                {
                    context.StudentTerms.Add(d);
                }
                context.SaveChanges();




            }
        }
    }
}
