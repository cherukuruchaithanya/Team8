using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team8.Models
{
    public class Student 
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentId { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Family")]
        public string LastName { get; set; }

        [Required]
        [StringLength(40, MinimumLength = 3)]
        [Display(Name = "Given")]
        public string FirstName { get; set; }
  

        // navigation properties provide more information for related entities
        public ICollection<DegreePlan> DegreePlans { get; set; }
        public ICollection<StudentTerm> StudentTerms { get; set; }
    }
}