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
        
        

       public static async  Task<string>  LogIn(string username,string password)
        {

            var httpClient = new HttpClient();

            var parameters = new Dictionary<string, string>();
            parameters["username"] = "55555555";
            parameters["password"] = "5555";
            var response = await httpClient.PostAsync("https://gql.formon.io/api/rest/login", new FormUrlEncodedContent(parameters));
            var contents = await response.Content.ReadAsStringAsync();

            return contents;
            //using (var client = new HttpClient())
            //{

            //    client.BaseAddress = new Uri("https://gql.formon.io/api/rest/login");
            //    client.DefaultRequestHeaders.Accept.Clear();
            //    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));


            //    Models.UserLogIn login = new Models.UserLogIn();
            //    login.usename = "55555555";
            //    login.password = "5555";




            //    HttpResponseMessage response = await client.PostAsJsonAsync<Models.UserLogIn>("https://gql.formon.io/api/rest/login", login);
            //    var result = response;

            //    return  result.ToString();
            //}
        }

    }
}
