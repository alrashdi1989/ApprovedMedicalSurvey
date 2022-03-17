using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
    public  class jwt
    {
        public class Login
        {
            public string jwt { get; set; }
            public string refreshToken { get; set; }
        }

        public class Root
        {
            public Login login { get; set; }
        }


    }
}
