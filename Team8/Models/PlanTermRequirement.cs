using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Team8.Models
{
    public class PlanTermRequirement
    {
        public PlanTermRequirement()
        {
            RequirementStatusId = 1;
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlanTermRequirementId { get; internal set; }

        public int PlanTermId { get; internal set; }

        public int DegreeRequirementId { get; set; }

        public int RequirementStatusId { get; internal set; }

        // Add navigation property for each related entity

        // each plan term requirement points to exactly one plan term
        public PlanTerm PlanTerm { get; set; }

        // each plan term requirement points to exactly one degree requirement
        public DegreeRequirement DegreeRequirement { get; set; }

        // each plan term requirement points to exactly one requirement status - have we earned credit in this term or not?
        public RequirementStatus RequirementStatus { get; set; }

        public override string ToString()
        {
            return base.ToString() + ": " +
              "PlanTermRequirementId = " + PlanTermRequirementId +
              "PlanTermId = " + PlanTermId +
              ", DegreeRequirementId = " + DegreeRequirementId +
              ", RequirementStatusId = " + RequirementStatusId +
              ", RequirementStatus: {" + RequirementStatus.ToString() +
                            "}, PlanTerm = {" + PlanTerm.ToString() +
                               "}, DegreeRequirement = {" + DegreeRequirement.ToString() +
                           "}";
        }
    }
}