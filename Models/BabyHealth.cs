using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
  public  class BabyHealth
    {
        public string vaccinated { get; set; }
        public string suffer_from_stunted_growth { get; set; }
        public string six_months_kind_of_breastfeeding { get; set; }
        public string is_child_underweight { get; set; }
        public string health_center_reviewed { get; set; }
        public string has_diarrhea { get; set; }
        public string hae_respiratory_infection { get; set; }
        public string diagnosed_with_malnutrition { get; set; }
        public string complementary_foods_child_age { get; set; }
        public string anemia_diagnosed { get; set; }
        public string question_uuid { get; set; }
        public string order_uuid { get; set; }
        public string form_uuid { get; set; }
        public string form_key { get; set; }
    }
}
