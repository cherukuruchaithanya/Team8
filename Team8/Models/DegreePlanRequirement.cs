using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Team8.Models
{
    public class DegreePlanTermRequirement
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]  
        public int DegreePlanTermRequirementId { get; set; }

        [ForeignKey("DegreePlanId")]
        public int DegreePlanId { get; set; } 

        public int Term { get; set; }

        [ForeignKey("RequirementId")]
        public int RequirementId { get; set; }

        [Required]
        [StringLength(8, MinimumLength = 1)]
        [Display(Name = "Status")]
        public string Status { get; set; } = "P";  

        
        public DegreePlan DegreePlan { get; set; }
        public Requirement Requirement { get; set; }
    }
}
