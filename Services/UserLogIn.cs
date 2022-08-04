using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Services
{
    public class UserLogIn
    {
        
        

       public static async  Task<string> LogIn(string username,string password)
        {
            var httpClient = new HttpClient();
            var parameters = new Dictionary<string, string>();
            parameters["username"] = username;
            parameters["password"] = password;
            var response = await httpClient.PostAsync(Shared.GlobalVariables.BaseUrl+"login"
            ,new FormUrlEncodedContent(parameters));
            var contents = await response.Content.ReadAsStringAsync();
            Models.jwt.Root result = JsonConvert.DeserializeObject<Models.jwt.Root>(contents);
             return result.login.jwt;

            

        }

    }
}
