using System;
using System.Collections.Generic;

namespace Team8.Models
{
    public class DegreePlan
    {
        public int DegreePlanId { get; set; }
        public int DegreeID { get; set; }
        public int StudentId { get; set; }
        public string DegreePlan { get; set; }
        public string DegreePlanName { get; set; }


    }
}