using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
   public  class CheckUsers
    {
        public class User
        {
            public string uuid { get; set; }
            public string password { get; set; }
        }

        public class Root
        {
            public List<User> users { get; set; }
        }
    }
}
