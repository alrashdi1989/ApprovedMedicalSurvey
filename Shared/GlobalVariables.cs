using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Shared
{
   public static  class GlobalVariables
    {
        //all shared variable used on the application are declared in this class 
        public static string BaseUrl { get; set; } = "https://gql.formon.io/api/rest/";
        public static  string FormName { get; set; }
        public static string SurveyID { get; set; }
        public static bool isNewUser { get; set; } = false;
        public static string UserName { get; set; }
        public static string Password { get; set; }
    }
}
