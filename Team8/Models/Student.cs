using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team8.Models {
  public class Student {
    [DatabaseGenerated (DatabaseGeneratedOption.None)]
    public int StudentId { get; set; }

    [Required]
    [Display (Name = "Given Name")]
    [StringLength (50, ErrorMessage = "Given name cannot be longer than 50 characters.")]
    public string GivenName { get; set; }

    [Display (Name = "Family Name")]
    [StringLength (50, ErrorMessage = "Family name cannot be longer than 50 characters.")]
    public string FamilyName { get; set; }

    [Display (Name = "Full Name")]
    public string FullName {
      get {
        return GivenName + " " + FamilyName;
      }
    }

    // Add navigation property for each related entity

    // each student has many plans... 
    public ICollection<StudentDegreePlan> StudentDegreePlans { get; set; }

    public override string ToString () {
      return base.ToString () + ": " +
        "StudentId = " + StudentId +
        "GivenName = " + GivenName +
        ", FamilyName = " + FamilyName +
        ", FullName = " + FullName +
        "";
    }
  }
}