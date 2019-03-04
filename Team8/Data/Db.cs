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
            if (context.Degree.Any())
            {
                Console.WriteLine("Degree Already Exist");
            }
            else
            {
                var degree = new Degree[] {
                    new Degree{DegreeID =1,Degree ="ACS+2",DegreeName="MS ACS+2" },
                    new Degree{DegreeID =2,Degree ="ACS+DB",DegreeName="MS ACS+DB" },
                    new Degree{DegreeID =3,Degree ="ACS+NF",DegreeName="MS ACS+NF" },
                    new Degree{DegreeID =4,Degree ="ACS",DegreeName="MS ACS" },
                };
                Console.WriteLine($"Inserted{degree.Length} new degree.");
                foreach ( Degree s in degree)
                {
                    context.Degree.Add(s);
                }
                context.SaveChanges();
            }


            if (context.Requirement.Any())
            {
                Console.WriteLine("Requirement Already Exist");
            }
            else
            {
                var requirement = new Requirement[] {
                    new Requirement{RequirementID =460,Requirement ="DB",RequirementName="44-460 Database" },
                    new Requirement{RequirementID =356,Requirement ="NF",RequirementName="44-356 Network Fundamemtals" },
                    new Requirement{RequirementID =460,Requirement ="OOP",RequirementName="44-542 OOP with Java" },
                    new Requirement{RequirementID =460,Requirement ="Web apps",RequirementName="44-563 Web apps" },
                    new Requirement{RequirementID =460,Requirement ="ADB",RequirementName="44-560 ADB" },
                    new Requirement{RequirementID =460,Requirement ="NS",RequirementName="44-555 Network Security" },
                    new Requirement{RequirementID =460,Requirement ="PM",RequirementName="44-618 PM" },
                    new Requirement{RequirementID =460,Requirement ="Mobile",RequirementName="44-643 or 44-644" },
                    new Requirement{RequirementID =460,Requirement ="UX",RequirementName="44-664 UX" },
                    new Requirement{RequirementID =460,Requirement ="E1",RequirementName="Elective 1" },
                    new Requirement{RequirementID =460,Requirement ="E2",RequirementName="Elective 2" },
                    new Requirement{RequirementID =460,Requirement ="GDP1",RequirementName="GDP1" },
                    new Requirement{RequirementID =460,Requirement ="GDP2",RequirementName="GDP2" },
                };
                Console.WriteLine($"Inserted{requirement.Length} new requirement.");
                foreach (Requirement s in requirement)
                {
                    context.Requirement.Add(s);
                }
                context.SaveChanges();
            }


            if (context.Requirement.Any())
            {
                Console.WriteLine("Requirement Already Exist");
            }
            else
            {
                var degreerequirement = new DegreeRequirement[] {
                    new DegreeRequirement{DegreeRequirementID =1,DegreeId =1,RequirementId=460 },
                    new DegreeRequirement{DegreeRequirementID =2,DegreeId =1,RequirementId=356 },
                    new DegreeRequirement{DegreeRequirementID =3,DegreeId =1,RequirementId=542 },
                    new DegreeRequirement{DegreeRequirementID =4,DegreeId =1,RequirementId=563 },
                    new DegreeRequirement{DegreeRequirementID =5,DegreeId =1,RequirementId=560 },
                    new DegreeRequirement{DegreeRequirementID =6,DegreeId =1,RequirementId=555 },
                    new DegreeRequirement{DegreeRequirementID =7,DegreeId =1,RequirementId=618 },
                    new DegreeRequirement{DegreeRequirementID =8,DegreeId =1,RequirementId=1},
                    new DegreeRequirement{DegreeRequirementID =9,DegreeId =1,RequirementId=664 },
                    new DegreeRequirement{DegreeRequirementID =10,DegreeId =1,RequirementId=10 },
                    new DegreeRequirement{DegreeRequirementID =11,DegreeId =1,RequirementId=20 },
                    new DegreeRequirement{DegreeRequirementID =12,DegreeId =1,RequirementId=691 },
                    new DegreeRequirement{DegreeRequirementID =13,DegreeId =1,RequirementId=692 },
                    new DegreeRequirement{DegreeRequirementID =14,DegreeId =2,RequirementId=460 },
                    new DegreeRequirement{DegreeRequirementID =15,DegreeId =2,RequirementId=542 },
                    new DegreeRequirement{DegreeRequirementID =16,DegreeId =2,RequirementId=563 },
                    new DegreeRequirement{DegreeRequirementID =17,DegreeId =2,RequirementId=560 },
                    new DegreeRequirement{DegreeRequirementID =18,DegreeId =2,RequirementId=555 },
                    new DegreeRequirement{DegreeRequirementID =19,DegreeId =2,RequirementId=618 },
                    new DegreeRequirement{DegreeRequirementID =20,DegreeId =2,RequirementId=1 },
                    new DegreeRequirement{DegreeRequirementID =21,DegreeId =2,RequirementId=664 },
                    new DegreeRequirement{DegreeRequirementID =22,DegreeId =2,RequirementId=10 },
                    new DegreeRequirement{DegreeRequirementID =23,DegreeId =2,RequirementId=20 },
                    new DegreeRequirement{DegreeRequirementID =24,DegreeId =2,RequirementId=691 },
                    new DegreeRequirement{DegreeRequirementID =25,DegreeId =2,RequirementId=692 },
                    new DegreeRequirement{DegreeRequirementID =26,DegreeId =3,RequirementId=356 },
                    new DegreeRequirement{DegreeRequirementID =27,DegreeId =3,RequirementId=542 },
                    new DegreeRequirement{DegreeRequirementID =28,DegreeId =3,RequirementId=563 },
                    new DegreeRequirement{DegreeRequirementID =29,DegreeId =3,RequirementId=560 },
                    new DegreeRequirement{DegreeRequirementID =30,DegreeId =3,RequirementId=555 },
                    new DegreeRequirement{DegreeRequirementID =31,DegreeId =3,RequirementId=618 },
                    new DegreeRequirement{DegreeRequirementID =32,DegreeId =3,RequirementId=1},
                    new DegreeRequirement{DegreeRequirementID =33,DegreeId =3,RequirementId=664 },
                    new DegreeRequirement{DegreeRequirementID =34,DegreeId =3,RequirementId=10 },
                    new DegreeRequirement{DegreeRequirementID =35,DegreeId =3,RequirementId=20 },
                    new DegreeRequirement{DegreeRequirementID =36,DegreeId =3,RequirementId=691 },
                    new DegreeRequirement{DegreeRequirementID =37,DegreeId =3,RequirementId=692 },
                    new DegreeRequirement{DegreeRequirementID =38,DegreeId =4,RequirementId=542 },
                    new DegreeRequirement{DegreeRequirementID =39,DegreeId =4,RequirementId=563 },
                    new DegreeRequirement{DegreeRequirementID =40,DegreeId =4,RequirementId=560 },
                    new DegreeRequirement{DegreeRequirementID =41,DegreeId =4,RequirementId=555 },
                    new DegreeRequirement{DegreeRequirementID =42,DegreeId =4,RequirementId=618 },
                    new DegreeRequirement{DegreeRequirementID =43,DegreeId =4,RequirementId=1 },
                    new DegreeRequirement{DegreeRequirementID =44,DegreeId =4,RequirementId=664 },
                    new DegreeRequirement{DegreeRequirementID =45,DegreeId =4,RequirementId=10 },
                    new DegreeRequirement{DegreeRequirementID =46,DegreeId =4,RequirementId=20 },
                    new DegreeRequirement{DegreeRequirementID =47,DegreeId =4,RequirementId=691 },
                    new DegreeRequirement{DegreeRequirementID =48,DegreeId =4,RequirementId=692 },
                };
                Console.WriteLine($"Inserted{degreerequirement.Length} new degreerequirement.");
                foreach (DegreeRequirement s in degreerequirement)
                {
                    context.Degreerequirement.Add(s);
                }
                context.SaveChanges();
            }

                                                         









            if (context.Studenttable.Any())
            {
                Console.WriteLine("Student already exist");
            }
            else
            {
                var studenttable = new Studenttable[] {
                    new Studenttable{StudentID =531495,FirstName = "Chaithanya", LastName ="Cherukuru" },
                    new Studenttable{StudentID =531502,FirstName = "Midhun", LastName ="Kurapati" },
                     new Studenttable{StudentID =531495,FirstName = "Girish", LastName ="Guntuku" },
                      new Studenttable{StudentID =531495,FirstName = "Pappu", LastName ="sha" },
                   };
                Console.WriteLine($"Inserted{studenttable.Length} new studenttable.");
                foreach (Studenttable s in studenttable)
                {
                    context.Studenttable.Add(s);
                }
                context.SaveChanges();
            }




 

            if (context.StudentTerms.Any())
            {
                Console.WriteLine("Degreess already exist");
            }
            else
            {
                var studentterms = new StudentTerm[] {
new StudentTerm{StudentTermID=1,StudentId=531495,Term=1,TermAbbrev="Sp19",TermLabel="Spring2019"},
new StudentTerm{StudentTermID=2,StudentId=531495,Term=2,TermAbbrev="Su19",TermLabel="Summer2019"},
new StudentTerm{StudentTermID=3,StudentId=531495,Term=3,TermAbbrev="Fa19",TermLabel="Fall2019"},
new StudentTerm{StudentTermID=4,StudentId=531495,Term=4,TermAbbrev="Sp20",TermLabel="Spring2020"},
new StudentTerm{StudentTermID=5,StudentId=531495,Term=5,TermAbbrev="Su20",TermLabel="Summer2020"},
new StudentTerm{StudentTermID=6,StudentId=531502,Term=1,TermAbbrev="Fa19",TermLabel="Fall2019"},
new StudentTerm{StudentTermID=7,StudentId=531502,Term=2,TermAbbrev="Sp20",TermLabel="Spring2020"},
new StudentTerm{StudentTermID=8,StudentId=531502,Term=3,TermAbbrev="Su20",TermLabel="Summer2020"},
new StudentTerm{StudentTermID=9,StudentId=531502,Term=4,TermAbbrev="Fa20",TermLabel="Fall2020"},
new StudentTerm{StudentTermID=10,StudentId=531502,Term=5,TermAbbrev="Fa22",TermLabel="Fall2022"},
new StudentTerm{StudentTermID=11,StudentId=531502,Term=1,TermAbbrev="Sp21",TermLabel="Spring2021"},
new StudentTerm{StudentTermID=12,StudentId=531369,Term=1,TermAbbrev="Sp21",TermLabel="Spring2021"},
new StudentTerm{StudentTermID=13,StudentId=531369,Term=2,TermAbbrev="Su21",TermLabel="Summer2020"},
new StudentTerm{StudentTermID=14,StudentId=531369,Term=3,TermAbbrev="Fa21",TermLabel="Fall2021"},
new StudentTerm{StudentTermID=15,StudentId=531369,Term=4,TermAbbrev="Sp22",TermLabel="Spring2022"},
new StudentTerm{StudentTermID=16,StudentId=525956,Term=1,TermAbbrev="Fa22",TermLabel="Fall2019"},
new StudentTerm{StudentTermID=17,StudentId=525956,Term=2,TermAbbrev="Sp23",TermLabel="Spring2023"},
new StudentTerm{StudentTermID=18,StudentId=525956,Term=3,TermAbbrev="Su23",TermLabel="Summer2020"},
new StudentTerm{StudentTermID=19,StudentId=525956,Term=4,TermAbbrev="Fa23",TermLabel="Fall2023"},
new StudentTerm{StudentTermID=20,StudentId=525956,Term=5,TermAbbrev="Sp24",TermLabel="Spring2024"},

                };
                Console.WriteLine($"Inserted{studentterms.Length} new students.");
                foreach (StudentTerm s in studentterms)
                {
                    context.Degrees.Add(s);
                }
                context.SaveChanges();
            }



          
        }

    }
}