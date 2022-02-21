using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Shared
{
   public static  class GlobalVariables
    {
        public static string BaseUrl { get; set; } = "https://gql.formon.io/api/rest/";
        public static  string FormName { get; set; }
    }
}
