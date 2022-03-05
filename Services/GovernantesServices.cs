using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Services
{
    public static class GovernantesServices
    {
        //gettin the Governance info from the api 

        public static List<Governorate> GetAllGovernorate(string baseurl)
        {
            var response = Shared.HttpResponse.responseMessage(baseurl);

            List<Governorate> res = new List<Governorate>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Roots result = JsonConvert.DeserializeObject<Roots>(data);
                res = result.governorates;

            }
            return res;

        }

    }
}
