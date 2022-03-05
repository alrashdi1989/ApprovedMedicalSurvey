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
  public static  class VillageServices
    {
        public static List<Village> GetAllVIllagesbyStateID(string baseurl,string wiuid)
        {
            //gettin the Villages by state info from the api with filter using lambda 

            var response = Shared.HttpResponse.responseMessage(baseurl);
            List<Village> res = new List<Village>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
               

                Roots result = JsonConvert.DeserializeObject<Roots>(data);

                res = result.villages.Where(c=> c.wncode == wiuid).ToList();

            }
            return res;

        }


        public static List<Village> GetAllVIllages(string baseurl)
        {

            //gettin all Villages  info from the api with filter using lambda 

            var response = Shared.HttpResponse.responseMessage(baseurl);
            List<Village> res = new List<Village>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;


                Roots result = JsonConvert.DeserializeObject<Roots>(data);

                res = result.villages.ToList();

            }
            return res;

        }


    }
}
