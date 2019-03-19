using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team8.Models
{
    public class StudentTerm
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StudentTermId { get; set; }

        [ForeignKey("StudentId")]
        public String StudentId { get; set; }

        public int Term { get; set; }

        [Required]
        [StringLength(6, MinimumLength = 3)]
        [Display(Name = "Abbreviation")]
        public string Abbrev { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 3)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        // navigation properties provide more information for related entities
        public Student Student { get; set; }
    }
}
