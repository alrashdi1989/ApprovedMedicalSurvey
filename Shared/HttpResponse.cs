using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Shared
{
   public static class HttpResponse
    {
        public static HttpResponseMessage responseMessage(string basurl) {


            var client = new HttpClient();
            client.BaseAddress = new Uri(GlobalVariables.BaseUrl + basurl);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync(client.BaseAddress).Result;

            return response;
        }
    }
}
