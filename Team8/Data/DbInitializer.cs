using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Team8.Data
{
    public static class DbInitializer
    {

        public static void DB(ApplicationDbContext context)
        {
            if (context.Degrees.Any())
            {
                Console.WriteLine("Degree Already Exist");
            }
            else
            {
                var degree = new Models.Degree[] {
                    new Models.Degree{DegreeId =1,Degrees ="ACS+2",DegreeName="MS ACS+2" },
                    new Models.Degree{DegreeId =2,Degrees ="ACS+DB",DegreeName="MS ACS+DB" },
                    new Models.Degree{DegreeId =3,Degrees ="ACS+NF",DegreeName="MS ACS+NF" },
                    new Models.Degree{DegreeId =4,Degrees ="ACS",DegreeName="MS ACS" },
                };
                Console.WriteLine($"Inserted{degree.Length} new degree.");
                foreach (Models.Degree s in degree)
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
                var requirement = new Models.Requirement[] {
                    new Models.Requirement{RequirementId =460,Requirements ="DB",RequirementName="44-460 Database" },
                    new Models.Requirement{RequirementId =356,Requirements ="NF",RequirementName="44-356 Network Fundamemtals" },
                    new Models.Requirement{RequirementId =460,Requirements ="OOP",RequirementName="44-542 OOP with Java" },
                    new Models.Requirement{RequirementId =460,Requirements ="Web apps",RequirementName="44-563 Web apps" },
                    new Models.Requirement{RequirementId =460,Requirements ="ADB",RequirementName="44-560 ADB" },
                    new Models.Requirement{RequirementId =460,Requirements ="NS",RequirementName="44-555 Network Security" },
                    new Models.Requirement{RequirementId =460,Requirements ="PM",RequirementName="44-618 PM" },
                    new Models.Requirement{RequirementId =460,Requirements ="Mobile",RequirementName="44-643 or 44-644" },
                    new Models.Requirement{RequirementId =460,Requirements ="UX",RequirementName="44-664 UX" },
                    new Models.Requirement{RequirementId =460,Requirements ="E1",RequirementName="Elective 1" },
                    new Models.Requirement{RequirementId =460,Requirements ="E2",RequirementName="Elective 2" },
                    new Models.Requirement{RequirementId =460,Requirements ="GDP1",RequirementName="GDP1" },
                    new Models.Requirement{RequirementId =460,Requirements ="GDP2",RequirementName="GDP2" },
                };
                Console.WriteLine($"Inserted{requirement.Length} new requirement.");
                foreach (Models.Requirement s in requirement)
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
                var degreerequirement = new Models.DegreeRequirement[] {
                    new Models.DegreeRequirement{DegreeRequirementId =1,DegreeId =1,RequirementId=460 },
                    new Models.DegreeRequirement{DegreeRequirementId =2,DegreeId =1,RequirementId=356 },
                    new Models.DegreeRequirement{DegreeRequirementId =3,DegreeId =1,RequirementId=542 },
                    new Models.DegreeRequirement{DegreeRequirementId =4,DegreeId =1,RequirementId=563 },
                    new Models.DegreeRequirement{DegreeRequirementId =5,DegreeId =1,RequirementId=560 },
                    new Models.DegreeRequirement{DegreeRequirementId =6,DegreeId =1,RequirementId=555 },
                    new Models.DegreeRequirement{DegreeRequirementId =7,DegreeId =1,RequirementId=618 },
                    new Models.DegreeRequirement{DegreeRequirementId =8,DegreeId =1,RequirementId=1},
                    new Models.DegreeRequirement{DegreeRequirementId =9,DegreeId =1,RequirementId=664 },
                    new Models.DegreeRequirement{DegreeRequirementId =10,DegreeId =1,RequirementId=10 },
                    new Models.DegreeRequirement{DegreeRequirementId =11,DegreeId =1,RequirementId=20 },
                    new Models.DegreeRequirement{DegreeRequirementId =12,DegreeId =1,RequirementId=691 },
                    new Models.DegreeRequirement{DegreeRequirementId =13,DegreeId =1,RequirementId=692 },
                    new Models.DegreeRequirement{DegreeRequirementId =14,DegreeId =2,RequirementId=460 },
                    new Models.DegreeRequirement{DegreeRequirementId =15,DegreeId =2,RequirementId=542 },
                    new Models.DegreeRequirement{DegreeRequirementId =16,DegreeId =2,RequirementId=563 },
                    new Models.DegreeRequirement{DegreeRequirementId =17,DegreeId =2,RequirementId=560 },
                    new Models.DegreeRequirement{DegreeRequirementId =18,DegreeId =2,RequirementId=555 },
                    new Models.DegreeRequirement{DegreeRequirementId =19,DegreeId =2,RequirementId=618 },
                    new Models.DegreeRequirement{DegreeRequirementId =20,DegreeId =2,RequirementId=1 },
                    new Models.DegreeRequirement{DegreeRequirementId =21,DegreeId =2,RequirementId=664 },
                    new Models.DegreeRequirement{DegreeRequirementId =22,DegreeId =2,RequirementId=10 },
                    new Models.DegreeRequirement{DegreeRequirementId =23,DegreeId =2,RequirementId=20 },
                    new Models.DegreeRequirement{DegreeRequirementId =24,DegreeId =2,RequirementId=691 },
                    new Models.DegreeRequirement{DegreeRequirementId =25,DegreeId =2,RequirementId=692 },
                    new Models.DegreeRequirement{DegreeRequirementId =26,DegreeId =3,RequirementId=356 },
                    new Models.DegreeRequirement{DegreeRequirementId =27,DegreeId =3,RequirementId=542 },
                    new Models.DegreeRequirement{DegreeRequirementId =28,DegreeId =3,RequirementId=563 },
                    new Models.DegreeRequirement{DegreeRequirementId =29,DegreeId =3,RequirementId=560 },
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
                Console.WriteLine($"Inserted{degreerequirement.Length} new degreerequirement.");
                foreach (Models.DegreeRequirement s in degreerequirement)
                {
                    context.DegreeRequirements.Add(s);
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
                    new Models.DegreePlan{DegreePlanId=20,DegreeID=4,StudentId=531495,DegreePlans="NS",DegreePlanName="No summer off"},
                    new Models.DegreePlan{DegreePlanId=21,DegreeID=4,StudentId=531502,DegreePlans="S",DegreePlanName="summer off"},
                    new Models.DegreePlan{DegreePlanId=22,DegreeID=4,StudentId=531369,DegreePlans="S",DegreePlanName="No summer off"},
                    new Models.DegreePlan{DegreePlanId=23,DegreeID=4,StudentId=525956,DegreePlans="s",DegreePlanName="summer off"},
                    new Models.DegreePlan{DegreePlanId=24,DegreeID=4,StudentId=531495,DegreePlans="s",DegreePlanName="No summer off"},
                    new Models.DegreePlan{DegreePlanId=25,DegreeID=4,StudentId=531502,DegreePlans="NS",DegreePlanName="summer off"},
                    new Models.DegreePlan{DegreePlanId=26,DegreeID=4,StudentId=531369,DegreePlans="NS",DegreePlanName="No summer off"},
                    new Models.DegreePlan{DegreePlanId=27,DegreeID=4,StudentId=525956,DegreePlans="NO",DegreePlanName="summer off"}
                 };
                Console.WriteLine($"Inserted {DegreePlans.Length} new DegreePlans");

                foreach (Models.DegreePlan degreePlan in DegreePlans)
                {
                    context.DegreePlans.Add(degreePlan);
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
                    new Models.Student{StudentID =531495,FirstName = "Chaithanya", LastName ="Cherukuru" },
                    new Models.Student{StudentID =531502,FirstName = "Midhun", LastName ="Kurapati" },
                     new Models.Student{StudentID =531495,FirstName = "Girish", LastName ="Guntuku" },
                      new Models.Student{StudentID =531495,FirstName = "Pappu", LastName ="sha" },
                   };
                Console.WriteLine($"Inserted{student.Length} new studenttable.");
                foreach (Models.Student s in student)
                {
                    context.Students.Add(s);
                }
                context.SaveChanges();
            }




            if (context.DegreePlanTermRequirements.Any())
            {
                Console.WriteLine("DegreePlanTermRequirements already exist");
            }
            else
            {
                var degreePlanTermRequirements = new Models.DegreePlanTermRequirement[]
                {
                  new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=1,DegreePlanID=22,TermID=1,RequirementID=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=2,DegreePlanID=22,TermID=1,RequirementID=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=3,DegreePlanID=22,TermID=1,RequirementID=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=4,DegreePlanID=22,TermID=2,RequirementID=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=5,DegreePlanID=22,TermID=2,RequirementID=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=6,DegreePlanID=22,TermID=2,RequirementID=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=7,DegreePlanID=22,TermID=3,RequirementID=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=8,DegreePlanID=22,TermID=3,RequirementID=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=9,DegreePlanID=22,TermID=4,RequirementID=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=10,DegreePlanID=22,TermID=4,RequirementID=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=11,DegreePlanID=22,TermID=4,RequirementID=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=12,DegreePlanID=23,TermID=1,RequirementID=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=13,DegreePlanID=23,TermID=1,RequirementID=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=14,DegreePlanID=23,TermID=1,RequirementID=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=15,DegreePlanID=23,TermID=3,RequirementID=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=16,DegreePlanID=23,TermID=3,RequirementID=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=17,DegreePlanID=23,TermID=4,RequirementID=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=18,DegreePlanID=23,TermID=4,RequirementID=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=19,DegreePlanID=23,TermID=4,RequirementID=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=20,DegreePlanID=23,TermID=5,RequirementID=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=21,DegreePlanID=23,TermID=5,RequirementID=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=22,DegreePlanID=23,TermID=5,RequirementID=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=23,DegreePlanID=24,TermID=1,RequirementID=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=24,DegreePlanID=24,TermID=1,RequirementID=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=25,DegreePlanID=24,TermID=1,RequirementID=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=26,DegreePlanID=24,TermID=2,RequirementID=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=27,DegreePlanID=24,TermID=2,RequirementID=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=28,DegreePlanID=24,TermID=2,RequirementID=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=29,DegreePlanID=24,TermID=3,RequirementID=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=30,DegreePlanID=24,TermID=3,RequirementID=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=31,DegreePlanID=24,TermID=4,RequirementID=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=32,DegreePlanID=24,TermID=4,RequirementID=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=33,DegreePlanID=24,TermID=5,RequirementID=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=34,DegreePlanID=25,TermID=1,RequirementID=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=35,DegreePlanID=25,TermID=1,RequirementID=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=36,DegreePlanID=25,TermID=1,RequirementID=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=37,DegreePlanID=25,TermID=2,RequirementID=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=38,DegreePlanID=25,TermID=2,RequirementID=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=39,DegreePlanID=25,TermID=2,RequirementID=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=40,DegreePlanID=25,TermID=3,RequirementID=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=41,DegreePlanID=25,TermID=4,RequirementID=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=42,DegreePlanID=25,TermID=4,RequirementID=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=43,DegreePlanID=25,TermID=4,RequirementID=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=44,DegreePlanID=25,TermID=5,RequirementID=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=45,DegreePlanID=26,TermID=1,RequirementID=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=46,DegreePlanID=26,TermID=1,RequirementID=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=47,DegreePlanID=26,TermID=1,RequirementID=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=48,DegreePlanID=26,TermID=2,RequirementID=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=49,DegreePlanID=26,TermID=2,RequirementID=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=50,DegreePlanID=26,TermID=2,RequirementID=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=51,DegreePlanID=26,TermID=4,RequirementID=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=52,DegreePlanID=26,TermID=4,RequirementID=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=53,DegreePlanID=26,TermID=4,RequirementID=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=54,DegreePlanID=26,TermID=5,RequirementID=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=55,DegreePlanID=26,TermID=5,RequirementID=692},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=56,DegreePlanID=27,TermID=1,RequirementID=542},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=57,DegreePlanID=27,TermID=1,RequirementID=563},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=58,DegreePlanID=27,TermID=1,RequirementID=560},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=59,DegreePlanID=27,TermID=3,RequirementID=555},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=60,DegreePlanID=27,TermID=3,RequirementID=618},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=61,DegreePlanID=27,TermID=3,RequirementID=1},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=62,DegreePlanID=27,TermID=4,RequirementID=664},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=63,DegreePlanID=27,TermID=4,RequirementID=691},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=64,DegreePlanID=27,TermID=4,RequirementID=10},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=65,DegreePlanID=27,TermID=5,RequirementID=20},
new Models.DegreePlanTermRequirement {DegreePlanTermRequirementID=66,DegreePlanID=27,TermID=5,RequirementID=692},
  };
                Console.WriteLine($"Inserted {degreePlanTermRequirements.Length} new DegreePlanTermRequirement");

                foreach (Models.DegreePlanTermRequirement degreePlanReq in degreePlanTermRequirements)
                {
                    context.DegreePlanTermRequirements.Add(degreePlanReq);
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
new Models.StudentTerm{StudentTermID=1,StudentId=531495,Term=1,TermAbbrev="Sp19",TermLabel="Spring2019"},
new Models.StudentTerm{StudentTermID=2,StudentId=531495,Term=2,TermAbbrev="Su19",TermLabel="Summer2019"},
new Models.StudentTerm{StudentTermID=3,StudentId=531495,Term=3,TermAbbrev="Fa19",TermLabel="Fall2019"},
new Models.StudentTerm{StudentTermID=4,StudentId=531495,Term=4,TermAbbrev="Sp20",TermLabel="Spring2020"},
new Models.StudentTerm{StudentTermID=5,StudentId=531495,Term=5,TermAbbrev="Su20",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermID=6,StudentId=531502,Term=1,TermAbbrev="Fa19",TermLabel="Fall2019"},
new Models.StudentTerm{StudentTermID=7,StudentId=531502,Term=2,TermAbbrev="Sp20",TermLabel="Spring2020"},
new Models.StudentTerm{StudentTermID=8,StudentId=531502,Term=3,TermAbbrev="Su20",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermID=9,StudentId=531502,Term=4,TermAbbrev="Fa20",TermLabel="Fall2020"},
new Models.StudentTerm{StudentTermID=10,StudentId=531502,Term=5,TermAbbrev="Fa22",TermLabel="Fall2022"},
new Models.StudentTerm{StudentTermID=11,StudentId=531502,Term=1,TermAbbrev="Sp21",TermLabel="Spring2021"},
new Models.StudentTerm{StudentTermID=12,StudentId=531369,Term=1,TermAbbrev="Sp21",TermLabel="Spring2021"},
new Models.StudentTerm{StudentTermID=13,StudentId=531369,Term=2,TermAbbrev="Su21",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermID=14,StudentId=531369,Term=3,TermAbbrev="Fa21",TermLabel="Fall2021"},
new Models.StudentTerm{StudentTermID=15,StudentId=531369,Term=4,TermAbbrev="Sp22",TermLabel="Spring2022"},
new Models.StudentTerm{StudentTermID=16,StudentId=525956,Term=1,TermAbbrev="Fa22",TermLabel="Fall2019"},
new Models.StudentTerm{StudentTermID=17,StudentId=525956,Term=2,TermAbbrev="Sp23",TermLabel="Spring2023"},
new Models.StudentTerm{StudentTermID=18,StudentId=525956,Term=3,TermAbbrev="Su23",TermLabel="Summer2020"},
new Models.StudentTerm{StudentTermID=19,StudentId=525956,Term=4,TermAbbrev="Fa23",TermLabel="Fall2023"},
new Models.StudentTerm{StudentTermID=20,StudentId=525956,Term=5,TermAbbrev="Sp24",TermLabel="Spring2024"},

                };
                Console.WriteLine($"Inserted{studentterms.Length} new students.");
                foreach (Models.StudentTerm s in studentterms)
                {
                    context.StudentTerms.Add(s);
                }
                context.SaveChanges();
            }



          
        }

    }
}




















