using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
   public class ElderHealth
    {
        public string who_is_helping_him { get; set; }
        public string is_doing_productive_job { get; set; }
        public object family_member_over_60 { get; set; }
        public string does_physical_activity { get; set; }
        public string does_need_help { get; set; }
        public string form_uuid { get; set; }
        public string form_key { get; set; }
        public string question_uuid { get; set; }
        public string order_uuid { get; set; }
    }
}
