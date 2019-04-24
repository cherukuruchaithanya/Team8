using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team8.Models {
  public class StudentDegreePlan {
    public StudentDegreePlan () {
      DegreeStatusId = 1; // default to 1
    }

    [DatabaseGenerated (DatabaseGeneratedOption.None)]
    public int StudentDegreePlanId { get; set; }

    public int StudentId { get; set; }

    public int DegreeId { get; set; }

    [Display (Name = "Plan Number (used for sorting)")]
    public int PlanNumber { get; set; }

    [Required]
    [Display (Name = "Plan Abbreviation (20 char)")]
    [StringLength (20, ErrorMessage = "Abbreviation cannot be longer than 20 characters.")]
    public string PlanAbbrev { get; set; }

    [Required]
    [Display (Name = "Plan Name")]
    [StringLength (50, ErrorMessage = "Name cannot be longer than 50 characters.")]
    public string PlanName { get; set; }

    public int DegreeStatusId { get; set; }

    [Display (Name = "Includes Internship?")]
    public Boolean IncludesInternship { get; set; }

    // Add navigation property for each related entity

    // each plan points to exactly one student
    public Student Student { get; set; }

    // each plan points to exactly one degree
    public Degree Degree { get; set; }

    // each plan points to exactly one degree status
    public DegreeStatus DegreeStatus { get; set; }

    // each plan has many terms... 
    public ICollection<PlanTerm> PlanTerms { get; set; }

    public override string ToString () {
      return base.ToString () + ": " +
        "StudentDegreePlanId = " + StudentDegreePlanId +
        "StudentId = " + StudentId +
        ", DegreeId = " + DegreeId +
        ", PlanNumber = " + PlanNumber +
        ", PlanAbbrev = " + PlanAbbrev +
        ", PlanName = " + PlanName +
        ", DegreeStatusId = " + DegreeStatusId +
        ", IncludesInternship = " + IncludesInternship +
        ", Student ={" + Student.ToString () +
                      "}, Degree = {" + Degree.ToString () +
                     "}";
    }

  }
}