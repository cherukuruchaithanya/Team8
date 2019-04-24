using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team8.Models {
  public class PlanTerm {
    [DatabaseGenerated (DatabaseGeneratedOption.None)]
    public int PlanTermId { get; set; }

    public int StudentDegreePlanId { get; set; }

    [Display (Name = "Term Number (used for sorting)")]
    public int TermNumber { get; set; }

    [Display (Name = "Term Abbreviation, e.g. Fall 2017")]
    [StringLength (20, ErrorMessage = "Abbreviation cannot be longer than 20 characters.")]
    public string TermAbbrev { get; set; }

    // Add navigation property for each related entity

    // each planterm points to exactly one student degree plan
    public StudentDegreePlan StudentDegreePlan { get; set; }

    // each term has zero, one, or many requirements... 
    public ICollection<PlanTermRequirement> PlanTermRequirements { get; set; }

    public override string ToString () {
      return base.ToString () + ": " +
        "PlanTermId = " + PlanTermId +
        "StudentDegreePlanId = " + StudentDegreePlanId +
        ", TermNumber = " + TermNumber +
        ", TermAbbrev = " + TermAbbrev +
        ", StudentDegreePlan = {" + StudentDegreePlan.ToString () +
                     "}";
    }

  }
}