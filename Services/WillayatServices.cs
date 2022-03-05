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
   public static class WillayatServices
    {
        public static List<Willayat> GetAllWillayatbyId(string baseurl, string rncode)
        {
            //gettin the willayt by governance  info from the api with filter using lambda 

            var response = Shared.HttpResponse.responseMessage(baseurl);
            List<Willayat> res = new List<Willayat>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Roots result = JsonConvert.DeserializeObject<Roots>(data);
                res = result.willayat.Where(c => c.rncode == rncode).ToList();

            }
            return res;

        }
    }
}
