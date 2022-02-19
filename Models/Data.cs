using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
   public class Data
    {
        public int id { get; set; }
        public double lat { get; set; }
        public double lng { get; set; }
        public string name { get; set; }
        public string uuid { get; set; }
        public string bncode { get; set; }
        public string rncode { get; set; }
        public string status { get; set; }
        public string tncode { get; set; }
        public string wncode { get; set; }
        public Village village { get; set; }
        public Willayat willaya { get; set; }
        public Building building { get; set; }
        public List<object> volunteer { get; set; }
        public string admin_uuid { get; set; }
        public DateTime created_at { get; set; }
        public Governorate governorate { get; set; }
        public string willaya_uuid { get; set; }
        public string destrict_uuid { get; set; }
        public string template_uuid { get; set; }
        public string volunteer_uuid { get; set; }
        public string governorat_uuid { get; set; }
    }
}
