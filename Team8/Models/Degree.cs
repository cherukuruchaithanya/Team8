using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team8.Models {
  public class Degree {
    [DatabaseGenerated (DatabaseGeneratedOption.None)]
    public int DegreeId { get; set; }

    [Required]
    [Display (Name = "Degree Abbreviation")]
    [StringLength (10, ErrorMessage = "Abbreviation cannot be longer than 10 characters.")]
    public string DegreeAbbrev { get; set; }

    [Required]
    [Display (Name = "Degree Name")]
    [StringLength (50, ErrorMessage = "Name cannot be longer than 50 characters.")]
    public string DegreeName { get; set; }

    public ICollection<DegreeRequirement> DegreeRequirements { get; set; }

    public override string ToString () {
      return base.ToString () + ": " +
        "DegreeId = " + DegreeId +
        ", DegreeAbbrev = " + DegreeAbbrev +
        ", DegreeName = " + DegreeName +
        "";
    }

  }
}