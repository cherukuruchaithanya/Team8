﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team8.Models {
  public class DegreeStatus {
    [DatabaseGenerated (DatabaseGeneratedOption.None)]
    public int DegreeStatusId { get; internal set; }

    [Required]
    [StringLength (15, ErrorMessage = "Status cannot be longer than 15 characters.")]
    public string Status { get; internal set; }

    public override string ToString () {
      return base.ToString () + ": " +
        "DegreeStatusId = " + DegreeStatusId +
        ", Status = " + Status +
        "";
    }

  }
}