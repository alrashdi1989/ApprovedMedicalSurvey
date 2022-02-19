using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
   public class Surveys
    {

        public string status { get; set; }
        public string uuid { get; set; }
        public string assigned_to_user_uuid { get; set; }
        public DateTime created_at { get; set; }
        public Data data { get; set; }

        public DateTime updated_at { get; set; }
    }


    }
