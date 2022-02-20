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
   public static  class SurveyServices
    {
        public static List<OperationOrder> GetAllSurveys(string baseurl)
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(GlobalVariables.BaseUrl + baseurl);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync(client.BaseAddress).Result;
            List<OperationOrder> res = new List<OperationOrder>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Roots result = JsonConvert.DeserializeObject<Roots>(data);
                res = result.operationOrders;

            }

            return res;

        }

    }
}
