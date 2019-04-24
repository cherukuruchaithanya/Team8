using System;
using System.Linq;
using Microsoft.Extensions.Logging;
using Team8;
using Team8.Data;
using Team8.Models;

namespace Team8.Data
{
    public class DbInitializer
    {

        private static readonly ILogger LOG = ProgramLogger.CreateLogger();

        public DbInitializer()
        {
            LOG.LogInformation("Logger available.");
        }

        public static void Initialize(ApplicationDbContext context)
        {
            if (!context.DegreeStatuses.Any())
            {
                var degreeStatuses = new DegreeStatus[] {
          new DegreeStatus { DegreeStatusId = 1, Status = "Planned" },
          new DegreeStatus { DegreeStatusId = 2, Status = "In-Progress" },
          new DegreeStatus { DegreeStatusId = 3, Status = "Completed" }
        };

                foreach (DegreeStatus item in degreeStatuses)
                {
                    try
                    {
                        context.DegreeStatuses.Add(item);
                        context.SaveChanges();
                        LOG.LogDebug("Added {}.", item);
                    }
                    catch (Exception ex)
                    {
                        LOG.LogError("Error adding {}. Inner Exception was {}.", item, ex.InnerException.Message);
                    }
                }
            }

            if (!context.RequirementStatuses.Any())
            {
                var requirementStatuses = new RequirementStatus[] {
          new RequirementStatus { RequirementStatusId = 1, Status = "Planned" },
          new RequirementStatus { RequirementStatusId = 2, Status = "In-Progress" },
          new RequirementStatus { RequirementStatusId = 3, Status = "Completed" }
        };
                foreach (RequirementStatus item in requirementStatuses)
                {
                    context.RequirementStatuses.Add(item);
                    context.SaveChanges();
                    LOG.LogDebug("Added {}", item);
                }
            }

            if (!context.Students.Any())
            {

                var students = new Student[] {
          new Student { StudentId = 1531, GivenName = "Peanut", FamilyName = "McNubbin" },
          new Student { StudentId = 1647, GivenName = "Waffles", FamilyName = "Frapenstein" },
          new Student { StudentId = 1840, GivenName = "Butters", FamilyName = "Bunnybill" },
          new Student { StudentId = 1537, GivenName = "Bella", FamilyName = "Barkley" },
          new Student { StudentId = 1675, GivenName = "Max", FamilyName = "Headroom" },
          new Student { StudentId = 1745, GivenName = "Charlie", FamilyName = "Goodchap" },
          new Student { StudentId = 1206, GivenName = "Buddy", FamilyName = "CoolJ" },
          new Student { StudentId = 1966, GivenName = "Patch", FamilyName = "Shakespaw" },
          new Student { StudentId = 1683, GivenName = "Pickles", FamilyName = "Pooch" },
          new Student { StudentId = 1333, GivenName = "Honey", FamilyName = "Dawg" },
          new Student { StudentId = 1606, GivenName = "Abbie", FamilyName = "Fangle" },
          new Student { StudentId = 1954, GivenName = "Tess", FamilyName = "Ruff" },
          new Student { StudentId = 1528, GivenName = "Denise", FamilyName = "Case" }
        };
                foreach (Student item in students)
                {
                    context.Students.Add(item);
                    context.SaveChanges();
                    LOG.LogDebug("Added {}", item);
                }
            }

            if (!context.Degrees.Any())
            {

                var degrees = new Degree[] {
          new Degree { DegreeId = 1526, DegreeAbbrev = "MSACS+2", DegreeName = "Masters of ACS (with 2 rereqs)" },
          new Degree { DegreeId = 1050, DegreeAbbrev = "MSACS+NF", DegreeName = "Masters of ACS (with NF rereq)" },
          new Degree { DegreeId = 1547, DegreeAbbrev = "MSACS+DB", DegreeName = "Masters of ACS (with DB rereq)" },
          new Degree { DegreeId = 1824, DegreeAbbrev = "MSACS", DegreeName = "Masters of Applied Computer Science" },
          new Degree { DegreeId = 1829, DegreeAbbrev = "MSIS", DegreeName = "Masters of Information Systems" },
          new Degree { DegreeId = 1850, DegreeAbbrev = "MSIT", DegreeName = "Masters of Information Technology" }
        };
                foreach (Degree item in degrees)
                {
                    context.Degrees.Add(item);
                    context.SaveChanges();
                    LOG.LogDebug("Added {}", item);
                }
            }

            if (!context.DegreeRequirements.Any())
            {

                var degreeRequirements = new DegreeRequirement[] {
          new DegreeRequirement { DegreeRequirementId = 1046, DegreeId = 1526, RequirementNumber = 1, RequirementAbbrev = "356", RequirementName = "Network Fundamentals" },
          new DegreeRequirement { DegreeRequirementId = 1523, DegreeId = 1526, RequirementNumber = 2, RequirementAbbrev = "460", RequirementName = "Database Systems" },
          new DegreeRequirement { DegreeRequirementId = 1963, DegreeId = 1526, RequirementNumber = 3, RequirementAbbrev = "542", RequirementName = "Object-Oriented Programming" },
          new DegreeRequirement { DegreeRequirementId = 1521, DegreeId = 1526, RequirementNumber = 4, RequirementAbbrev = "563", RequirementName = "Developing Web Applications and Services" },
          new DegreeRequirement { DegreeRequirementId = 1383, DegreeId = 1526, RequirementNumber = 5, RequirementAbbrev = "560", RequirementName = "Advanced Topics in Database Systems" },
          new DegreeRequirement { DegreeRequirementId = 1409, DegreeId = 1526, RequirementNumber = 6, RequirementAbbrev = "555", RequirementName = "Network Security" },
          new DegreeRequirement { DegreeRequirementId = 1738, DegreeId = 1526, RequirementNumber = 7, RequirementAbbrev = "618", RequirementName = "Project Management in Business and Technology" },
          new DegreeRequirement { DegreeRequirementId = 1890, DegreeId = 1526, RequirementNumber = 8, RequirementAbbrev = "623", RequirementName = "Information Technology Management" },
          new DegreeRequirement { DegreeRequirementId = 1380, DegreeId = 1526, RequirementNumber = 9, RequirementAbbrev = "mobile", RequirementName = "Mobile Computing" },
          new DegreeRequirement { DegreeRequirementId = 1191, DegreeId = 1526, RequirementNumber = 10, RequirementAbbrev = "664", RequirementName = "Human Computer Interaction" },
          new DegreeRequirement { DegreeRequirementId = 1921, DegreeId = 1526, RequirementNumber = 11, RequirementAbbrev = "691", RequirementName = "CS Graduate Directed Project I" },
          new DegreeRequirement { DegreeRequirementId = 1755, DegreeId = 1526, RequirementNumber = 12, RequirementAbbrev = "692", RequirementName = "CS Graduate Directed Project II" },
          new DegreeRequirement { DegreeRequirementId = 1742, DegreeId = 1526, RequirementNumber = 13, RequirementAbbrev = "elective", RequirementName = "Elective" },
          new DegreeRequirement { DegreeRequirementId = 1741, DegreeId = 1050, RequirementNumber = 1, RequirementAbbrev = "356", RequirementName = "Network Fundamentals" },
          new DegreeRequirement { DegreeRequirementId = 1640, DegreeId = 1050, RequirementNumber = 2, RequirementAbbrev = "542", RequirementName = "Object-Oriented Programming" },
          new DegreeRequirement { DegreeRequirementId = 1102, DegreeId = 1050, RequirementNumber = 3, RequirementAbbrev = "563", RequirementName = "Developing Web Applications and Services" },
          new DegreeRequirement { DegreeRequirementId = 1651, DegreeId = 1050, RequirementNumber = 4, RequirementAbbrev = "560", RequirementName = "Advanced Topics in Database Systems" },
          new DegreeRequirement { DegreeRequirementId = 1813, DegreeId = 1050, RequirementNumber = 5, RequirementAbbrev = "555", RequirementName = "Network Security" },
          new DegreeRequirement { DegreeRequirementId = 1501, DegreeId = 1050, RequirementNumber = 6, RequirementAbbrev = "618", RequirementName = "Project Management in Business and Technology" },
          new DegreeRequirement { DegreeRequirementId = 1312, DegreeId = 1050, RequirementNumber = 7, RequirementAbbrev = "623", RequirementName = "Information Technology Management" },
          new DegreeRequirement { DegreeRequirementId = 1361, DegreeId = 1050, RequirementNumber = 8, RequirementAbbrev = "mobile", RequirementName = "Mobile Computing" },
          new DegreeRequirement { DegreeRequirementId = 1111, DegreeId = 1050, RequirementNumber = 9, RequirementAbbrev = "664", RequirementName = "Human Computer Interaction" },
          new DegreeRequirement { DegreeRequirementId = 1946, DegreeId = 1050, RequirementNumber = 10, RequirementAbbrev = "691", RequirementName = "CS Graduate Directed Project I" },
          new DegreeRequirement { DegreeRequirementId = 1294, DegreeId = 1050, RequirementNumber = 11, RequirementAbbrev = "692", RequirementName = "CS Graduate Directed Project II" },
          new DegreeRequirement { DegreeRequirementId = 1058, DegreeId = 1050, RequirementNumber = 12, RequirementAbbrev = "elective", RequirementName = "Elective" },
          new DegreeRequirement { DegreeRequirementId = 1016, DegreeId = 1547, RequirementNumber = 1, RequirementAbbrev = "460", RequirementName = "Database Systems" },
          new DegreeRequirement { DegreeRequirementId = 1017, DegreeId = 1547, RequirementNumber = 2, RequirementAbbrev = "542", RequirementName = "Object-Oriented Programming" },
          new DegreeRequirement { DegreeRequirementId = 1831, DegreeId = 1547, RequirementNumber = 3, RequirementAbbrev = "563", RequirementName = "Developing Web Applications and Services" },
          new DegreeRequirement { DegreeRequirementId = 1389, DegreeId = 1547, RequirementNumber = 4, RequirementAbbrev = "560", RequirementName = "Advanced Topics in Database Systems" },
          new DegreeRequirement { DegreeRequirementId = 1486, DegreeId = 1547, RequirementNumber = 5, RequirementAbbrev = "555", RequirementName = "Network Security" },
          new DegreeRequirement { DegreeRequirementId = 1949, DegreeId = 1547, RequirementNumber = 6, RequirementAbbrev = "618", RequirementName = "Project Management in Business and Technology" },
          new DegreeRequirement { DegreeRequirementId = 1714, DegreeId = 1547, RequirementNumber = 7, RequirementAbbrev = "623", RequirementName = "Information Technology Management" },
          new DegreeRequirement { DegreeRequirementId = 1158, DegreeId = 1547, RequirementNumber = 8, RequirementAbbrev = "mobile", RequirementName = "Mobile Computing" },
          new DegreeRequirement { DegreeRequirementId = 1195, DegreeId = 1547, RequirementNumber = 9, RequirementAbbrev = "664", RequirementName = "Human Computer Interaction" },
          new DegreeRequirement { DegreeRequirementId = 1643, DegreeId = 1547, RequirementNumber = 10, RequirementAbbrev = "691", RequirementName = "CS Graduate Directed Project I" },
          new DegreeRequirement { DegreeRequirementId = 1497, DegreeId = 1547, RequirementNumber = 11, RequirementAbbrev = "692", RequirementName = "CS Graduate Directed Project II" },
          new DegreeRequirement { DegreeRequirementId = 1884, DegreeId = 1547, RequirementNumber = 12, RequirementAbbrev = "elective", RequirementName = "Elective" },
          new DegreeRequirement { DegreeRequirementId = 1797, DegreeId = 1824, RequirementNumber = 1, RequirementAbbrev = "542", RequirementName = "Object-Oriented Programming" },
          new DegreeRequirement { DegreeRequirementId = 1498, DegreeId = 1824, RequirementNumber = 2, RequirementAbbrev = "563", RequirementName = "Developing Web Applications and Services" },
          new DegreeRequirement { DegreeRequirementId = 1166, DegreeId = 1824, RequirementNumber = 3, RequirementAbbrev = "560", RequirementName = "Advanced Topics in Database Systems" },
          new DegreeRequirement { DegreeRequirementId = 1093, DegreeId = 1824, RequirementNumber = 4, RequirementAbbrev = "555", RequirementName = "Network Security" },
          new DegreeRequirement { DegreeRequirementId = 1885, DegreeId = 1824, RequirementNumber = 5, RequirementAbbrev = "618", RequirementName = "Project Management in Business and Technology" },
          new DegreeRequirement { DegreeRequirementId = 1023, DegreeId = 1824, RequirementNumber = 6, RequirementAbbrev = "623", RequirementName = "Information Technology Management" },
          new DegreeRequirement { DegreeRequirementId = 1134, DegreeId = 1824, RequirementNumber = 7, RequirementAbbrev = "mobile", RequirementName = "Mobile Computing" },
          new DegreeRequirement { DegreeRequirementId = 1006, DegreeId = 1824, RequirementNumber = 8, RequirementAbbrev = "664", RequirementName = "Human Computer Interaction" },
          new DegreeRequirement { DegreeRequirementId = 1622, DegreeId = 1824, RequirementNumber = 9, RequirementAbbrev = "691", RequirementName = "CS Graduate Directed Project I" },
          new DegreeRequirement { DegreeRequirementId = 1079, DegreeId = 1824, RequirementNumber = 10, RequirementAbbrev = "692", RequirementName = "CS Graduate Directed Project II" },
          new DegreeRequirement { DegreeRequirementId = 1918, DegreeId = 1824, RequirementNumber = 11, RequirementAbbrev = "elective", RequirementName = "Elective" },
          new DegreeRequirement { DegreeRequirementId = 1875, DegreeId = 1829, RequirementNumber = 1, RequirementAbbrev = "ITM", RequirementName = "Information Technology Management" },
          new DegreeRequirement { DegreeRequirementId = 1824, DegreeId = 1829, RequirementNumber = 2, RequirementAbbrev = "ISAD", RequirementName = "Information Systems Analysis and Design" },
          new DegreeRequirement { DegreeRequirementId = 1853, DegreeId = 1829, RequirementNumber = 3, RequirementAbbrev = "OOS", RequirementName = "Developing Object-Oriented Systems with Java" },
          new DegreeRequirement { DegreeRequirementId = 1847, DegreeId = 1829, RequirementNumber = 4, RequirementAbbrev = "DDI", RequirementName = "Database Design and Implementation" },
          new DegreeRequirement { DegreeRequirementId = 1231, DegreeId = 1829, RequirementNumber = 5, RequirementAbbrev = "ENI", RequirementName = "Enterprise Networking and Internetworking" },
          new DegreeRequirement { DegreeRequirementId = 2000, DegreeId = 1829, RequirementNumber = 6, RequirementAbbrev = "SDE", RequirementName = "User Centered System Design and Evaluation" },
          new DegreeRequirement { DegreeRequirementId = 1677, DegreeId = 1829, RequirementNumber = 7, RequirementAbbrev = "INFOSEC", RequirementName = "Cybersecurity and Information Systems Security Management" },
          new DegreeRequirement { DegreeRequirementId = 1417, DegreeId = 1829, RequirementNumber = 8, RequirementAbbrev = "PISE", RequirementName = "Professionalism in the IS Environment" },
          new DegreeRequirement { DegreeRequirementId = 1927, DegreeId = 1829, RequirementNumber = 9, RequirementAbbrev = "PMIT", RequirementName = "Project Management for Business and Technology" },
          new DegreeRequirement { DegreeRequirementId = 1575, DegreeId = 1829, RequirementNumber = 10, RequirementAbbrev = "FMIT", RequirementName = "Financial Modeling and Decision Making for IT" },
          new DegreeRequirement { DegreeRequirementId = 1909, DegreeId = 1829, RequirementNumber = 11, RequirementAbbrev = "BIA", RequirementName = "Business Intelligence and Analytics" },
          new DegreeRequirement { DegreeRequirementId = 1692, DegreeId = 1829, RequirementNumber = 12, RequirementAbbrev = "CAP", RequirementName = "IS Capstone Project" },
          new DegreeRequirement { DegreeRequirementId = 1530, DegreeId = 1850, RequirementNumber = 1, RequirementAbbrev = "44-515 ", RequirementName = "Effective Assessment " },
          new DegreeRequirement { DegreeRequirementId = 1257, DegreeId = 1850, RequirementNumber = 2, RequirementAbbrev = "44-582", RequirementName = "Technology Curriculum & Integration" },
          new DegreeRequirement { DegreeRequirementId = 1429, DegreeId = 1850, RequirementNumber = 3, RequirementAbbrev = "44-585", RequirementName = "Instructional Technology and the Learning Process" },
          new DegreeRequirement { DegreeRequirementId = 1900, DegreeId = 1850, RequirementNumber = 4, RequirementAbbrev = "44-614", RequirementName = "Introduction to Online Teaching/Learning" },
          new DegreeRequirement { DegreeRequirementId = 1453, DegreeId = 1850, RequirementNumber = 5, RequirementAbbrev = "44-626", RequirementName = "Multimedia Systems" },
          new DegreeRequirement { DegreeRequirementId = 1883, DegreeId = 1850, RequirementNumber = 6, RequirementAbbrev = "44-635", RequirementName = "Instructional Systems Design" },
          new DegreeRequirement { DegreeRequirementId = 1397, DegreeId = 1850, RequirementNumber = 7, RequirementAbbrev = "44-645", RequirementName = "Computers and Networks" },
          new DegreeRequirement { DegreeRequirementId = 1524, DegreeId = 1850, RequirementNumber = 8, RequirementAbbrev = "44-650   ", RequirementName = "Building Virtual Learning Environment" },
          new DegreeRequirement { DegreeRequirementId = 1318, DegreeId = 1850, RequirementNumber = 9, RequirementAbbrev = "44-656  ", RequirementName = "Current Issues in Instructional Technology" },
          new DegreeRequirement { DegreeRequirementId = 1381, DegreeId = 1850, RequirementNumber = 10, RequirementAbbrev = "44-696", RequirementName = "Graduate Directed Project" },
          new DegreeRequirement { DegreeRequirementId = 1697, DegreeId = 1850, RequirementNumber = 11, RequirementAbbrev = "Elective", RequirementName = "Elective" },
          new DegreeRequirement { DegreeRequirementId = 1319, DegreeId = 1850, RequirementNumber = 12, RequirementAbbrev = "comps", RequirementName = "IS Capstone Project" }
        };
                foreach (DegreeRequirement item in degreeRequirements)
                {
                    context.DegreeRequirements.Add(item);
                    context.SaveChanges();
                    LOG.LogDebug("Added {}", item);
                }
            }

            if (!context.StudentDegreePlans.Any())
            {

                var studentDegreePlans = new StudentDegreePlan[] {
          new StudentDegreePlan { StudentDegreePlanId = 1672, StudentId = 1531, DegreeId = 1526, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1617, StudentId = 1647, DegreeId = 1050, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1147, StudentId = 1840, DegreeId = 1547, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1334, StudentId = 1537, DegreeId = 1824, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1234, StudentId = 1675, DegreeId = 1829, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1076, StudentId = 1745, DegreeId = 1850, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1661, StudentId = 1206, DegreeId = 1526, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1133, StudentId = 1966, DegreeId = 1050, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1519, StudentId = 1683, DegreeId = 1547, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1277, StudentId = 1333, DegreeId = 1824, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1065, StudentId = 1333, DegreeId = 1829, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1105, StudentId = 1606, DegreeId = 1829, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1224, StudentId = 1954, DegreeId = 1850, PlanNumber = 1, PlanAbbrev = "Initial plan", PlanName = "My initial plan " },
          new StudentDegreePlan { StudentDegreePlanId = 1503, StudentId = 1531, DegreeId = 1526, PlanNumber = 2, PlanAbbrev = "internship plan", PlanName = "Plan adjusted for internship" },
          new StudentDegreePlan { StudentDegreePlanId = 1379, StudentId = 1647, DegreeId = 1050, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1653, StudentId = 1840, DegreeId = 1547, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1054, StudentId = 1537, DegreeId = 1824, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1333, StudentId = 1675, DegreeId = 1829, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1040, StudentId = 1745, DegreeId = 1850, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1227, StudentId = 1206, DegreeId = 1526, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1746, StudentId = 1966, DegreeId = 1050, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1254, StudentId = 1683, DegreeId = 1547, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1082, StudentId = 1333, DegreeId = 1824, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1341, StudentId = 1333, DegreeId = 1829, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1614, StudentId = 1606, DegreeId = 1829, PlanNumber = 2, PlanAbbrev = "Most recent plan", PlanName = "My most recently updated plan (use this)" },
          new StudentDegreePlan { StudentDegreePlanId = 1139, StudentId = 1954, DegreeId = 1850, PlanNumber = 2, PlanAbbrev = "early comps", PlanName = "early comps" }
        };
                foreach (StudentDegreePlan item in studentDegreePlans)
                {
                    context.StudentDegreePlans.Add(item);
                    context.SaveChanges();
                    LOG.LogDebug("Added {}", item);
                }
            }

            if (!context.PlanTerms.Any())
            {

                var planTerms = new PlanTerm[] {
          new PlanTerm { PlanTermId = 7712, StudentDegreePlanId = 1661, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 8039, StudentDegreePlanId = 1661, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 4734, StudentDegreePlanId = 1661, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 6087, StudentDegreePlanId = 1661, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 6088, StudentDegreePlanId = 1661, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 6089, StudentDegreePlanId = 1661, TermNumber = 6, TermAbbrev = "Summer 2018" },
          new PlanTerm { PlanTermId = 4535, StudentDegreePlanId = 1227, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 1781, StudentDegreePlanId = 1227, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 9815, StudentDegreePlanId = 1227, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 9774, StudentDegreePlanId = 1227, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 9362, StudentDegreePlanId = 1227, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 9363, StudentDegreePlanId = 1227, TermNumber = 6, TermAbbrev = "Summer 2018" },
          new PlanTerm { PlanTermId = 4466, StudentDegreePlanId = 1277, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 1453, StudentDegreePlanId = 1277, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 6105, StudentDegreePlanId = 1277, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 9309, StudentDegreePlanId = 1277, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 9310, StudentDegreePlanId = 1277, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 9311, StudentDegreePlanId = 1277, TermNumber = 6, TermAbbrev = "Summer 2018" },
          new PlanTerm { PlanTermId = 7978, StudentDegreePlanId = 1082, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 1326, StudentDegreePlanId = 1082, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 4660, StudentDegreePlanId = 1082, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 5745, StudentDegreePlanId = 1082, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 2861, StudentDegreePlanId = 1082, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 2862, StudentDegreePlanId = 1082, TermNumber = 6, TermAbbrev = "Summer 2018" },
          new PlanTerm { PlanTermId = 6307, StudentDegreePlanId = 1065, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 6549, StudentDegreePlanId = 1065, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 5389, StudentDegreePlanId = 1065, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 1298, StudentDegreePlanId = 1065, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 7140, StudentDegreePlanId = 1341, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 7316, StudentDegreePlanId = 1341, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 6388, StudentDegreePlanId = 1341, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 3589, StudentDegreePlanId = 1341, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 5641, StudentDegreePlanId = 1341, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 6372, StudentDegreePlanId = 1672, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 1873, StudentDegreePlanId = 1672, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 7067, StudentDegreePlanId = 1672, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 3624, StudentDegreePlanId = 1672, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 6908, StudentDegreePlanId = 1503, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 4703, StudentDegreePlanId = 1503, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 9519, StudentDegreePlanId = 1503, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 1429, StudentDegreePlanId = 1503, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 7838, StudentDegreePlanId = 1503, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 1702, StudentDegreePlanId = 1334, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 5916, StudentDegreePlanId = 1334, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 8121, StudentDegreePlanId = 1334, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 1677, StudentDegreePlanId = 1334, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 3807, StudentDegreePlanId = 1054, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 2089, StudentDegreePlanId = 1054, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 7154, StudentDegreePlanId = 1054, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 5034, StudentDegreePlanId = 1054, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 2505, StudentDegreePlanId = 1054, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 1086, StudentDegreePlanId = 1105, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 9970, StudentDegreePlanId = 1105, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 3563, StudentDegreePlanId = 1105, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 8923, StudentDegreePlanId = 1105, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 3620, StudentDegreePlanId = 1614, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 5820, StudentDegreePlanId = 1614, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 4957, StudentDegreePlanId = 1614, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 7837, StudentDegreePlanId = 1614, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 5333, StudentDegreePlanId = 1614, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 9356, StudentDegreePlanId = 1617, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 2488, StudentDegreePlanId = 1617, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 5167, StudentDegreePlanId = 1617, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 6847, StudentDegreePlanId = 1617, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 1179, StudentDegreePlanId = 1379, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 8934, StudentDegreePlanId = 1379, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 2448, StudentDegreePlanId = 1379, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 4136, StudentDegreePlanId = 1379, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 3630, StudentDegreePlanId = 1379, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 9449, StudentDegreePlanId = 1234, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 1146, StudentDegreePlanId = 1234, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 5763, StudentDegreePlanId = 1234, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 3687, StudentDegreePlanId = 1234, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 3583, StudentDegreePlanId = 1333, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 2040, StudentDegreePlanId = 1333, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 8967, StudentDegreePlanId = 1333, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 9153, StudentDegreePlanId = 1333, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 9758, StudentDegreePlanId = 1333, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 8251, StudentDegreePlanId = 1519, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 3115, StudentDegreePlanId = 1519, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 6570, StudentDegreePlanId = 1519, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 1821, StudentDegreePlanId = 1519, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 7998, StudentDegreePlanId = 1254, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 1588, StudentDegreePlanId = 1254, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 4074, StudentDegreePlanId = 1254, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 4545, StudentDegreePlanId = 1254, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 2576, StudentDegreePlanId = 1254, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 1965, StudentDegreePlanId = 1076, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 4722, StudentDegreePlanId = 1076, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 5963, StudentDegreePlanId = 1076, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 3347, StudentDegreePlanId = 1076, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 1693, StudentDegreePlanId = 1040, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 5366, StudentDegreePlanId = 1040, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 2520, StudentDegreePlanId = 1040, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 2655, StudentDegreePlanId = 1040, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 9306, StudentDegreePlanId = 1040, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 7789, StudentDegreePlanId = 1147, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 8271, StudentDegreePlanId = 1147, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 6706, StudentDegreePlanId = 1147, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 5024, StudentDegreePlanId = 1147, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 3781, StudentDegreePlanId = 1653, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 3780, StudentDegreePlanId = 1653, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 1467, StudentDegreePlanId = 1653, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 7431, StudentDegreePlanId = 1653, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 9674, StudentDegreePlanId = 1653, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 5933, StudentDegreePlanId = 1224, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 9423, StudentDegreePlanId = 1224, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 1935, StudentDegreePlanId = 1224, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 1317, StudentDegreePlanId = 1224, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 1691, StudentDegreePlanId = 1139, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 1173, StudentDegreePlanId = 1139, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 1767, StudentDegreePlanId = 1139, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 6234, StudentDegreePlanId = 1139, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 2970, StudentDegreePlanId = 1139, TermNumber = 5, TermAbbrev = "Spring 2018" },
          new PlanTerm { PlanTermId = 1727, StudentDegreePlanId = 1133, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 6214, StudentDegreePlanId = 1133, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 3716, StudentDegreePlanId = 1133, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 2181, StudentDegreePlanId = 1133, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 5271, StudentDegreePlanId = 1746, TermNumber = 1, TermAbbrev = "Fall 2016" },
          new PlanTerm { PlanTermId = 8145, StudentDegreePlanId = 1746, TermNumber = 2, TermAbbrev = "Spring 2017" },
          new PlanTerm { PlanTermId = 1540, StudentDegreePlanId = 1746, TermNumber = 3, TermAbbrev = "Summer 2017" },
          new PlanTerm { PlanTermId = 9036, StudentDegreePlanId = 1746, TermNumber = 4, TermAbbrev = "Fall 2017" },
          new PlanTerm { PlanTermId = 1257, StudentDegreePlanId = 1746, TermNumber = 5, TermAbbrev = "Spring 2018" }
        };
                foreach (PlanTerm item in planTerms)
                {
                    context.PlanTerms.Add(item);
                    context.SaveChanges();
                    LOG.LogDebug("Added {}", item);
                }
            }

            if (!context.PlanTermRequirements.Any())
            {

                var planTermRequirements = new PlanTermRequirement[] {
          new PlanTermRequirement { PlanTermRequirementId = 30108, PlanTermId = 7712, DegreeRequirementId = 1046},
          new PlanTermRequirement { PlanTermRequirementId = 36602, PlanTermId = 7712, DegreeRequirementId = 1523},
          new PlanTermRequirement { PlanTermRequirementId = 48088, PlanTermId = 7712, DegreeRequirementId = 1963},
          new PlanTermRequirement { PlanTermRequirementId = 26972, PlanTermId = 7712, DegreeRequirementId = 1521},
          new PlanTermRequirement { PlanTermRequirementId = 20491, PlanTermId = 8039, DegreeRequirementId = 1383},
          new PlanTermRequirement { PlanTermRequirementId = 11253, PlanTermId = 8039, DegreeRequirementId = 1409},
          new PlanTermRequirement { PlanTermRequirementId = 34145, PlanTermId = 8039, DegreeRequirementId = 1738},
          new PlanTermRequirement { PlanTermRequirementId = 38985, PlanTermId = 4734, DegreeRequirementId = 1890},
          new PlanTermRequirement { PlanTermRequirementId = 25452, PlanTermId = 4734, DegreeRequirementId = 1380},
          new PlanTermRequirement { PlanTermRequirementId = 47008, PlanTermId = 4734, DegreeRequirementId = 1191},
          new PlanTermRequirement { PlanTermRequirementId = 11209, PlanTermId = 6087, DegreeRequirementId = 1921},
          new PlanTermRequirement { PlanTermRequirementId = 17234, PlanTermId = 6087, DegreeRequirementId = 1755},
          new PlanTermRequirement { PlanTermRequirementId = 26072, PlanTermId = 4535, DegreeRequirementId = 1046},
          new PlanTermRequirement { PlanTermRequirementId = 30508, PlanTermId = 4535, DegreeRequirementId = 1523},
          new PlanTermRequirement { PlanTermRequirementId = 24092, PlanTermId = 4535, DegreeRequirementId = 1963},
          new PlanTermRequirement { PlanTermRequirementId = 13567, PlanTermId = 4535, DegreeRequirementId = 1521},
          new PlanTermRequirement { PlanTermRequirementId = 40548, PlanTermId = 1781, DegreeRequirementId = 1383},
          new PlanTermRequirement { PlanTermRequirementId = 25466, PlanTermId = 1781, DegreeRequirementId = 1409},
          new PlanTermRequirement { PlanTermRequirementId = 23894, PlanTermId = 1781, DegreeRequirementId = 1738},
          new PlanTermRequirement { PlanTermRequirementId = 26373, PlanTermId = 9774, DegreeRequirementId = 1890},
          new PlanTermRequirement { PlanTermRequirementId = 15133, PlanTermId = 9774, DegreeRequirementId = 1380},
          new PlanTermRequirement { PlanTermRequirementId = 30221, PlanTermId = 9774, DegreeRequirementId = 1191},
          new PlanTermRequirement { PlanTermRequirementId = 39020, PlanTermId = 9362, DegreeRequirementId = 1921 },
          new PlanTermRequirement { PlanTermRequirementId = 26173, PlanTermId = 9362, DegreeRequirementId = 1755 },
          new PlanTermRequirement { PlanTermRequirementId = 16903, PlanTermId = 6372, DegreeRequirementId = 1046},
          new PlanTermRequirement { PlanTermRequirementId = 34651, PlanTermId = 6372, DegreeRequirementId = 1523},
          new PlanTermRequirement { PlanTermRequirementId = 39336, PlanTermId = 6372, DegreeRequirementId = 1963},
          new PlanTermRequirement { PlanTermRequirementId = 31825, PlanTermId = 6372, DegreeRequirementId = 1521},
          new PlanTermRequirement { PlanTermRequirementId = 28169, PlanTermId = 1873, DegreeRequirementId = 1383},
          new PlanTermRequirement { PlanTermRequirementId = 46158, PlanTermId = 1873, DegreeRequirementId = 1409},
          new PlanTermRequirement { PlanTermRequirementId = 40025, PlanTermId = 1873, DegreeRequirementId = 1738},
          new PlanTermRequirement { PlanTermRequirementId = 21495, PlanTermId = 7067, DegreeRequirementId = 1890},
          new PlanTermRequirement { PlanTermRequirementId = 44181, PlanTermId = 7067, DegreeRequirementId = 1380},
          new PlanTermRequirement { PlanTermRequirementId = 37419, PlanTermId = 7067, DegreeRequirementId = 1191 },
          new PlanTermRequirement { PlanTermRequirementId = 27761, PlanTermId = 3624, DegreeRequirementId = 1921 },
          new PlanTermRequirement { PlanTermRequirementId = 16533, PlanTermId = 3624, DegreeRequirementId = 1755 },
          new PlanTermRequirement { PlanTermRequirementId = 35124, PlanTermId = 6908, DegreeRequirementId = 1046},
          new PlanTermRequirement { PlanTermRequirementId = 14326, PlanTermId = 6908, DegreeRequirementId = 1523},
          new PlanTermRequirement { PlanTermRequirementId = 46874, PlanTermId = 6908, DegreeRequirementId = 1963},
          new PlanTermRequirement { PlanTermRequirementId = 34113, PlanTermId = 6908, DegreeRequirementId = 1521},
          new PlanTermRequirement { PlanTermRequirementId = 25416, PlanTermId = 4703, DegreeRequirementId = 1383},
          new PlanTermRequirement { PlanTermRequirementId = 35556, PlanTermId = 4703, DegreeRequirementId = 1409},
          new PlanTermRequirement { PlanTermRequirementId = 36857, PlanTermId = 4703, DegreeRequirementId = 1738},
          new PlanTermRequirement { PlanTermRequirementId = 25468, PlanTermId = 9519, DegreeRequirementId = 1890},
          new PlanTermRequirement { PlanTermRequirementId = 35967, PlanTermId = 1429, DegreeRequirementId = 1380},
          new PlanTermRequirement { PlanTermRequirementId = 25331, PlanTermId = 1429, DegreeRequirementId = 1191},
          new PlanTermRequirement { PlanTermRequirementId = 37730, PlanTermId = 1429, DegreeRequirementId = 1921},
          new PlanTermRequirement { PlanTermRequirementId = 16764, PlanTermId = 7838, DegreeRequirementId = 1755 }
        };
                foreach (PlanTermRequirement item in planTermRequirements)
                {
                    context.PlanTermRequirements.Add(item);
                    context.SaveChanges();
                    LOG.LogDebug("Added {}", item);
                }
            }

        } // method
    } // class
} // namespace