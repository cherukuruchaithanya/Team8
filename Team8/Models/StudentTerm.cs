using System;
using System.Collections.Generic;

namespace Team8.Models
{
    public class StudentTerm
    {
        public int StudentTermID { get; set; }
        public int StudentID { get; set; }
        public int Term { get; set; }
        public string TermAbbrev { get; set; }
        public string TermLable { get; set; }

    }
}