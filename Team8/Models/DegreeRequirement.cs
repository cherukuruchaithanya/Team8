using System;
using System.Collections.Generic;
namespace Team8.Models
{
    public class DegreeRequirement
    {
        public int DegreeRequirementId { get; set; }
        public int DegreeId { get; set; }
        public int RequirementId { get; set; }
    }
}