using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
   public class AllReports
    {
        public class Result
        {
            public int value { get; set; }
            public string name { get; set; }
        }

        public class Sum
        {
            public int count { get; set; }
        }

        public class Aggregate
        {
            public Sum sum { get; set; }
        }

        public class All
        {
            public Aggregate aggregate { get; set; }
        }

        public class Root
        {
            public List<Result> results { get; set; }
            public All all { get; set; }
        }


    }
}
