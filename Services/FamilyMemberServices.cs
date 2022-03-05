using ApprovedMedicalSurvey.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Services
{
   public class FamilyMemberServices
    {
        public static List<FamilyMember> GetAllFamiyMembersBySurveyID(string baseurl)
        {
            //gettin the family members info from the api 
            var response = Shared.HttpResponse.responseMessage(baseurl);

            List<FamilyMember> res = new List<FamilyMember>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Roots result = JsonConvert.DeserializeObject<Roots>(data.ToString());
                res = result.family_members;

            }
            return res;

        }

    }
}
