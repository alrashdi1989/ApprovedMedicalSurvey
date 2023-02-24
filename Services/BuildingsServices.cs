using ApprovedMedicalSurvey.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Services
{
    public  static class BuildingsServices
    {
        public static List<Buildings> GetAllBuildings(string baseurl, int villageid)
        {
            //gettin the Villages by state info from the api with filter using lambda 

            var response = Shared.HttpResponse.responseMessage(baseurl);
            List<Buildings> res = new List<Buildings>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;


                Roots result = JsonConvert.DeserializeObject<Roots>(data);

                res = result.Buildings.Where(c => c.villageid == villageid.ToString()).ToList();

            }
            return res;

        }

    }
}
