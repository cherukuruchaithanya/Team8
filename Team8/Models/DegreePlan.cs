using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team8.Models
{
    public class DegreePlan
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DegreePlanId { get; set; }

        [ForeignKey("DegreeId")]
        public int DegreeId { get; set; }

        [ForeignKey("StudentId")]
        public int StudentId { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 3)]
        [Display(Name = "Abbreviation")]
        public String DegreePlans { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Name")]
        public String DegreePlanName { get; set; }

        public int SortOrder { get; set; }

 
        public Degree Degree { get; set; }
        public Student Student { get; set; }
    }
}
