using System;
using System.Collections.Generic;
using System.Linq;
using Team8.Models;
using System.Threading.Tasks;

namespace Team8.Data
{
    public static class DbInitializer
    {

        public static void Initialize(ApplicationDbContext context)
        {
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree Already Exist");
            }
            else
            {
                var degrees = new Degree[] {
                    new Degree{DegreeId =1,Degrees ="ACS+2",DegreeName="MS ACS+2" },
                    new Degree{DegreeId =2,Degrees ="ACS+DB",DegreeName="MS ACS+DB" },
                    new Degree{DegreeId =3,Degrees ="ACS+NF",DegreeName="MS ACS+NF" },
                    new Degree{DegreeId =4,Degrees ="ACS",DegreeName="MS ACS" },
                };
                Console.WriteLine($"Inserted{degrees.Length} new degree.");
                foreach (Degree s in degrees)
                {
                    context.Degrees.Add(s);
                }
                context.SaveChanges();
            }


            if (context.Requirements.Any())
            {
                Console.WriteLine("Requirement Already Exist");
            }
            else
            {
                var all = new Requirement[] {
                    new Requirement{RequirementId =460,Requirements ="DB",RequirementName="44-460 Database", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =356,Requirements ="NF",RequirementName="44-356 Network Fundamemtals", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="OOP",RequirementName="44-542 OOP with Java", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="Web apps",RequirementName="44-563 Web apps", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="ADB",RequirementName="44-560 ADB", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="NS",RequirementName="44-555 Network Security", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="PM",RequirementName="44-618 PM", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="Mobile",RequirementName="44-643 or 44-644", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="UX",RequirementName="44-664 UX", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="E1",RequirementName="Elective 1", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="E2",RequirementName="Elective 2", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="GDP1",RequirementName="GDP1", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                    new Requirement{RequirementId =460,Requirements ="GDP2",RequirementName="GDP2", IsSummer = 0, IsSpring = 1, IsFall = 1  },
                };
                Console.WriteLine($"Inserted{all.Length} new requirement.");
                foreach (Requirement s in all)
                {
                    context.Requirements.Add(s);
                }
                context.SaveChanges();
            }


            if (context.DegreeRequirements.Any())
            {
                Console.WriteLine("DegreeRequirement Already Exist");
            }
            else
            {
                var degreerequirements = new DegreeRequirement[] {
                    new DegreeRequirement{DegreeRequirementId =1,DegreeId =1,RequirementId=460 },
                    new DegreeRequirement{DegreeRequirementId =2,DegreeId =1,RequirementId=356 },
                    new DegreeRequirement{DegreeRequirementId =3,DegreeId =1,RequirementId=542 },
                    new DegreeRequirement{DegreeRequirementId =4,DegreeId =1,RequirementId=563 },
                    new DegreeRequirement{DegreeRequirementId =5,DegreeId =1,RequirementId=560 },
                    new DegreeRequirement{DegreeRequirementId =6,DegreeId =1,RequirementId=555 },
                    new DegreeRequirement{DegreeRequirementId =7,DegreeId =1,RequirementId=618 },
                    new DegreeRequirement{DegreeRequirementId =8,DegreeId =1,RequirementId=1},
                    new DegreeRequirement{DegreeRequirementId =9,DegreeId =1,RequirementId=664 },
                    new DegreeRequirement{DegreeRequirementId =10,DegreeId =1,RequirementId=10 },
                    new DegreeRequirement{DegreeRequirementId =11,DegreeId =1,RequirementId=20 },
                    new DegreeRequirement{DegreeRequirementId =12,DegreeId =1,RequirementId=691 },
                    new DegreeRequirement{DegreeRequirementId =13,DegreeId =1,RequirementId=692 },
                    new DegreeRequirement{DegreeRequirementId =14,DegreeId =2,RequirementId=460 },
                    new DegreeRequirement{DegreeRequirementId =15,DegreeId =2,RequirementId=542 },
                    new DegreeRequirement{DegreeRequirementId =16,DegreeId =2,RequirementId=563 },
                    new DegreeRequirement{DegreeRequirementId =17,DegreeId =2,RequirementId=560 },
                    new DegreeRequirement{DegreeRequirementId =18,DegreeId =2,RequirementId=555 },
                    new DegreeRequirement{DegreeRequirementId =19,DegreeId =2,RequirementId=618 },
                    new DegreeRequirement{DegreeRequirementId =20,DegreeId =2,RequirementId=1 },
                    new DegreeRequirement{DegreeRequirementId =21,DegreeId =2,RequirementId=664 },
                    new DegreeRequirement{DegreeRequirementId =22,DegreeId =2,RequirementId=10 },
                    new DegreeRequirement{DegreeRequirementId =23,DegreeId =2,RequirementId=20 },
                    new DegreeRequirement{DegreeRequirementId =24,DegreeId =2,RequirementId=691 },
                    new DegreeRequirement{DegreeRequirementId =25,DegreeId =2,RequirementId=692 },
                    new DegreeRequirement{DegreeRequirementId =26,DegreeId =3,RequirementId=356 },
                    new DegreeRequirement{DegreeRequirementId =27,DegreeId =3,RequirementId=542 },
                    new DegreeRequirement{DegreeRequirementId =28,DegreeId =3,RequirementId=563 },
                    new DegreeRequirement{DegreeRequirementId =29,DegreeId =3,RequirementId=560 },
                    new Models.DegreeRequirement{DegreeRequirementId =30,DegreeId =3,RequirementId=555 },
                    new Models.DegreeRequirement{DegreeRequirementId =31,DegreeId =3,RequirementId=618 },
                    new Models.DegreeRequirement{DegreeRequirementId =32,DegreeId =3,RequirementId=1},
                    new Models.DegreeRequirement{DegreeRequirementId =33,DegreeId =3,RequirementId=664 },
                    new Models.DegreeRequirement{DegreeRequirementId =34,DegreeId =3,RequirementId=10 },
                    new Models.DegreeRequirement{DegreeRequirementId =35,DegreeId =3,RequirementId=20 },
                    new Models.DegreeRequirement{DegreeRequirementId =36,DegreeId =3,RequirementId=691 },
                    new Models.DegreeRequirement{DegreeRequirementId =37,DegreeId =3,RequirementId=692 },
                    new Models.DegreeRequirement{DegreeRequirementId =38,DegreeId =4,RequirementId=542 },
                    new Models.DegreeRequirement{DegreeRequirementId =39,DegreeId =4,RequirementId=563 },
                    new Models.DegreeRequirement{DegreeRequirementId =40,DegreeId =4,RequirementId=560 },
                    new Models.DegreeRequirement{DegreeRequirementId =41,DegreeId =4,RequirementId=555 },
                    new Models.DegreeRequirement{DegreeRequirementId =42,DegreeId =4,RequirementId=618 },
                    new Models.DegreeRequirement{DegreeRequirementId =43,DegreeId =4,RequirementId=1 },
                    new Models.DegreeRequirement{DegreeRequirementId =44,DegreeId =4,RequirementId=664 },
                    new Models.DegreeRequirement{DegreeRequirementId =45,DegreeId =4,RequirementId=10 },
                    new Models.DegreeRequirement{DegreeRequirementId =46,DegreeId =4,RequirementId=20 },
                    new Models.DegreeRequirement{DegreeRequirementId =47,DegreeId =4,RequirementId=691 },
                    new Models.DegreeRequirement{DegreeRequirementId =48,DegreeId =4,RequirementId=692 },
                };
                Console.WriteLine($"Inserted{degreerequirements.Length} new degreerequirement.");
                foreach (Models.DegreeRequirement s in degreerequirements)
                {
                    context.DegreeRequirements.Add(s);
                }
                context.SaveChanges();
            }
            if (context.Students.Any())
            {
                Console.WriteLine("Student already exist");
            }
            else
            {
                var student = new Models.Student[] {
                    new Models.Student{StudentId =531495,FirstName = "Chaithanya", LastName ="Cherukuru" },
                    new Models.Student{StudentId =531502,FirstName = "Midhun", LastName ="Kurapati" },
                     new Models.Student{StudentId =531495,FirstName = "Girish", LastName ="Guntuku" },
                      new Models.Student{StudentId =531495,FirstName = "Pappu", LastName ="sha" },
                   };
                Console.WriteLine($"Inserted{student.Length} new studenttable.");
                foreach (Models.Student s in student)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();
            }
            if (context.DegreePlans.Any())
            {
                Console.WriteLine(" DegreePlan already exist");
            }
            else
            {
                var DegreePlans = new Models.DegreePlan[]
                {
                    new Models.DegreePlan{DegreePlanId=20,DegreeId=4,StudentId=531495,DegreePlans="NS",DegreePlanName="No summer off", SortOrder = 1 },
                    new Models.DegreePlan{DegreePlanId=21,DegreeId=4,StudentId=531502,DegreePlans="S",DegreePlanName="summer off", SortOrder = 2 },
                    new Models.DegreePlan{DegreePlanId=22,DegreeId=4,StudentId=531369,DegreePlans="S",DegreePlanName="No summer off", SortOrder = 1},
                    new Models.DegreePlan{DegreePlanId=23,DegreeId=4,StudentId=525956,DegreePlans="S",DegreePlanName="summer off", SortOrder = 2},
                    new Models.DegreePlan{DegreePlanId=24,DegreeId=4,StudentId=531495,DegreePlans="S",DegreePlanName="No summer off", SortOrder = 1},
                    new Models.DegreePlan{DegreePlanId=25,DegreeId=4,StudentId=531502,DegreePlans="NS",DegreePlanName="summer off", SortOrder = 2},
                    new Models.DegreePlan{DegreePlanId=26,DegreeId=4,StudentId=531369,DegreePlans="NS",DegreePlanName="No summer off", SortOrder = 1},
                    new Models.DegreePlan{DegreePlanId=27,DegreeId=4,StudentId=525956,DegreePlans="NS",DegreePlanName="summer off", SortOrder = 2}
                 };
                Console.WriteLine($"Inserted {DegreePlans.Length} new DegreePlans");

                foreach (Models.DegreePlan degreePlan in DegreePlans)
                {
                    context.DegreePlans.Add(degreePlan);
                }
                context.SaveChanges();
            }




            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Degreess already exist");
            }
            else
            {
                var studentterms = new Models.StudentTerm[] {
new Models.StudentTerm{StudentTermId=1,StudentId=531495,Term=1,Abbrev="Sp19",TermLabel="Spring2019"},
new Models.StudentTerm{StudentTermId=2,StudentId=531495,Term=2,Abbrev="Su19",TermLabel="Summer2019"},
new Models.StudentTerm{StudentTermId=3,StudentId=531495,Term=3,Abbrev="Fa19",TermLabel="Fall2019"},
new Models.StudentTerm{StudentTermId=4,StudentId=531495,Term=4,Abbrev="Sp20",TermLabel="Spring2020"},
new Models.StudentTerm{StudentTermId=5,StudentId=531495,Term=5,Abbrev="Su20",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermId=6,StudentId=531502,Term=1,Abbrev="Fa19",TermLabel="Fall2019"},
new Models.StudentTerm{StudentTermId=7,StudentId=531502,Term=2,Abbrev="Sp20",TermLabel="Spring2020"},
new Models.StudentTerm{StudentTermId=8,StudentId=531502,Term=3,Abbrev="Su20",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermId=9,StudentId=531502,Term=4,Abbrev="Fa20",TermLabel="Fall2020"},
new Models.StudentTerm{StudentTermId=10,StudentId=531502,Term=5,Abbrev="Fa22",TermLabel="Fall2022"},
new Models.StudentTerm{StudentTermId=11,StudentId=531502,Term=1,Abbrev="Sp21",TermLabel="Spring2021"},
new Models.StudentTerm{StudentTermId=12,StudentId=531369,Term=1,Abbrev="Sp21",TermLabel="Spring2021"},
new Models.StudentTerm{StudentTermId=13,StudentId=531369,Term=2,Abbrev="Su21",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermId=14,StudentId=531369,Term=3,Abbrev="Fa21",TermLabel="Fall2021"},
new Models.StudentTerm{StudentTermId=15,StudentId=531369,Term=4,Abbrev="Sp22",TermLabel="Spring2022"},
new Models.StudentTerm{StudentTermId=16,StudentId=525956,Term=1,Abbrev="Fa22",TermLabel="Fall2019"},
new Models.StudentTerm{StudentTermId=17,StudentId=525956,Term=2,Abbrev="Sp23",TermLabel="Spring2023"},
new Models.StudentTerm{StudentTermId=18,StudentId=525956,Term=3,Abbrev="Su23",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermId=19,StudentId=525956,Term=4,Abbrev="Fa23",TermLabel="Fall2023"},
new Models.StudentTerm{StudentTermId=20,StudentId=525956,Term=5,Abbrev="Sp24",TermLabel="Spring2024"},

                };
                Console.WriteLine($"Inserted{studentterms.Length} new students.");
                foreach (Models.StudentTerm s in studentterms)
                {
                    context.StudentTerms.Add(s);
                }
                context.SaveChanges();
            } if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("DegreePlanTermRequirements already exist");
            }
            else
            {
                var degreePlanTermRequirements = new Models.DegreePlanTermRequirement[]
                {
                  new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=1,DegreePlanId=22,Term=1,RequirementId=542,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=2,DegreePlanId=22,Term=1,RequirementId=563,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=3,DegreePlanId=22,Term=1,RequirementId=560,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=4,DegreePlanId=22,Term=2,RequirementId=555,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=5,DegreePlanId=22,Term=2,RequirementId=618,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=6,DegreePlanId=22,Term=2,RequirementId=1,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=7,DegreePlanId=22,Term=3,RequirementId=664,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=8,DegreePlanId=22,Term=3,RequirementId=691,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=9,DegreePlanId=22,Term=4,RequirementId=10,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=10,DegreePlanId=22,Term=4,RequirementId=20,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=11,DegreePlanId=22,Term=4,RequirementId=692,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=12,DegreePlanId=23,Term=1,RequirementId=542,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=13,DegreePlanId=23,Term=1,RequirementId=563,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=14,DegreePlanId=23,Term=1,RequirementId=560,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=15,DegreePlanId=23,Term=3,RequirementId=555,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=16,DegreePlanId=23,Term=3,RequirementId=618,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=17,DegreePlanId=23,Term=4,RequirementId=1,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=18,DegreePlanId=23,Term=4,RequirementId=664,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=19,DegreePlanId=23,Term=4,RequirementId=691,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=20,DegreePlanId=23,Term=5,RequirementId=10,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=21,DegreePlanId=23,Term=5,RequirementId=20,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=22,DegreePlanId=23,Term=5,RequirementId=692,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=23,DegreePlanId=24,Term=1,RequirementId=542,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=24,DegreePlanId=24,Term=1,RequirementId=563,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=25,DegreePlanId=24,Term=1,RequirementId=560,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=26,DegreePlanId=24,Term=2,RequirementId=555,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=27,DegreePlanId=24,Term=2,RequirementId=618,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=28,DegreePlanId=24,Term=2,RequirementId=1,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=29,DegreePlanId=24,Term=3,RequirementId=664,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=30,DegreePlanId=24,Term=3,RequirementId=691,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=31,DegreePlanId=24,Term=4,RequirementId=10,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=32,DegreePlanId=24,Term=4,RequirementId=20,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=33,DegreePlanId=24,Term=5,RequirementId=692,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=34,DegreePlanId=25,Term=1,RequirementId=542,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=35,DegreePlanId=25,Term=1,RequirementId=563,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=36,DegreePlanId=25,Term=1,RequirementId=560,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=37,DegreePlanId=25,Term=2,RequirementId=555,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=38,DegreePlanId=25,Term=2,RequirementId=618,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=39,DegreePlanId=25,Term=2,RequirementId=1,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=40,DegreePlanId=25,Term=3,RequirementId=664,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=41,DegreePlanId=25,Term=4,RequirementId=691,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=42,DegreePlanId=25,Term=4,RequirementId=10,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=43,DegreePlanId=25,Term=4,RequirementId=20,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=44,DegreePlanId=25,Term=5,RequirementId=692,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=45,DegreePlanId=26,Term=1,RequirementId=542,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=46,DegreePlanId=26,Term=1,RequirementId=563,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=47,DegreePlanId=26,Term=1,RequirementId=560,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=48,DegreePlanId=26,Term=2,RequirementId=555,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=49,DegreePlanId=26,Term=2,RequirementId=618,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=50,DegreePlanId=26,Term=2,RequirementId=1,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=51,DegreePlanId=26,Term=4,RequirementId=664,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=52,DegreePlanId=26,Term=4,RequirementId=691,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=53,DegreePlanId=26,Term=4,RequirementId=10,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=54,DegreePlanId=26,Term=5,RequirementId=20,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=55,DegreePlanId=26,Term=5,RequirementId=692,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=56,DegreePlanId=27,Term=1,RequirementId=542,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=57,DegreePlanId=27,Term=1,RequirementId=563,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=58,DegreePlanId=27,Term=1,RequirementId=560,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=59,DegreePlanId=27,Term=3,RequirementId=555,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=60,DegreePlanId=27,Term=3,RequirementId=618,Status="P"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=61,DegreePlanId=27,Term=3,RequirementId=1,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=62,DegreePlanId=27,Term=4,RequirementId=664,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=63,DegreePlanId=27,Term=4,RequirementId=691,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=64,DegreePlanId=27,Term=4,RequirementId=10,Status="C"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=65,DegreePlanId=27,Term=5,RequirementId=20,Status="A"},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementId=66,DegreePlanId=27,Term=5,RequirementId=692,Status="P"},
  };
                Console.WriteLine($"Inserted {degreePlanTermRequirements.Length} new DegreePlanTermRequirement");

                foreach (Models.DegreePlanTermRequirement degreePlanReq in degreePlanTermRequirements)
                {
                    context.DegreePlanTermRequirements.Add(degreePlanReq);
                }
                context.SaveChanges();

            }






        }

    }
}




















