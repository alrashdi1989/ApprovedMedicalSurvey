using ApprovedMedicalSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows.Forms;
using ApprovedMedicalSurvey.Shared;

namespace ApprovedMedicalSurvey.Services
{
    public static   class UserServices
    {            //gettin the users info from the api 

        public static List<Users> GetAllUsers(string baseurl) {

            var response = Shared.HttpResponse.responseMessage(baseurl);

            List<Models.Users> res = new List<Users>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Roots    result = JsonConvert.DeserializeObject<Roots>(data.ToString());
               
                res = result.Users;
               
            }
            return res;

        }

        public static List<Users> GetAllUserswithoutProvlage(string baseurl,string privliges)
        {
            //gettin the users info from the api with filter using lambda 

            var response = Shared.HttpResponse.responseMessage(baseurl);

            List<Models.Users> res = new List<Users>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                Roots result = JsonConvert.DeserializeObject<Roots>(data.ToString());

                res = result.Users.Where(c => c.role != privliges.ToLower()).ToList();

            }
            return res;

        }
        public static List<CheckUsers.User> CheckIfUserISRegisterd(string baseurl, string phoneNumber)
        {
            //gettin the users info from the api with filter using lambda 

            var response = Shared.HttpResponse.responseMessage(baseurl+phoneNumber);

            List<CheckUsers.User> res = new List<CheckUsers.User>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;
                CheckUsers.Root result = JsonConvert.DeserializeObject<CheckUsers.Root>(data.ToString());

                res = result.users;

            }
            return res;

        }


        public static List<UserStatus> GetUserStatuses() {
            //filling user states calss with data 

            List<UserStatus> userStatuses = new List<UserStatus>() {
            new UserStatus {StatusArabic="نشط",StatusEnglish="active"},
            new UserStatus {StatusArabic="غير نشط",StatusEnglish="inactive"}
            };

            return userStatuses;
        }

        public static List<UserPrivileges> GetUserPrivliges()
        {
            //filling UserPrivileges states calss with data 

            List<UserPrivileges> userPrivileges = new List<UserPrivileges>() {
            new UserPrivileges {UserPrivilegesArabic="جامع بيان /  متطوع",UserPrivilegesEnglish="Volunteer"},
            new UserPrivileges {UserPrivilegesArabic="مستوى المحافظة",UserPrivilegesEnglish="Government Level"},
            new UserPrivileges {UserPrivilegesArabic="مستوى الولاية",UserPrivilegesEnglish="state Level"},
            new UserPrivileges {UserPrivilegesArabic="مستوى المركزي",UserPrivilegesEnglish="Central Level"}

            };

            return userPrivileges;






        }


    }
}
