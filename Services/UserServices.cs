using ApprovedMedicalSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using DevExpress.Internal.WinApi.Windows.UI.Notifications;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using ApprovedMedicalSurvey.Shared;

namespace ApprovedMedicalSurvey.Services
{
    public static   class UserServices
    {
        public static List<Users> GetAllUsers(string basurl) {

            var client = new HttpClient();
            client.BaseAddress = new Uri(GlobalVariables.BaseUrl+basurl);
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var response = client.GetAsync(client.BaseAddress).Result;
            List<Models.Users> res = new List<Users>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
               Roots    result = JsonConvert.DeserializeObject<Roots>(data);
                res = result.Users;
               
            }
            return res;

        }
     

    }
}
