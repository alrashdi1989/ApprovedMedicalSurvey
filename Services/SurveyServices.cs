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
        //gettin the surveys info from the api 

        public static List<OperationOrder> GetAllSurveys(string baseurl)
        {
          var response=  Shared.HttpResponse.responseMessage(baseurl);
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
