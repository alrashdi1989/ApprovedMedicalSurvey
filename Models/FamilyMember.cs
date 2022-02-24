using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
    public class FamilyMember
    {
        [DisplayName("الاسم")]
        public string name { get; set; }

        [DisplayName("العمر ")]
        public string age { get; set; }

        [DisplayName("الجنس")]
        public string gender { get; set; }

        [DisplayName("يعاني من السنة")]
        public string is_overweight { get; set; }

        [DisplayName("النشاط البدني")]
        public string physical_activity { get; set; }

        [DisplayName("مدة النشاط البدني")]
        public string physical_activity_period { get; set; }

        [DisplayName("ترتيبك في العائلة ")]
        public string position { get; set; }

        [DisplayName("مدخن/غير مدخن")]
        public string smoking { get; set; }

        [DisplayName("الحالة الاجتماعية")]
        public string status { get; set; }

        [DisplayName("يعمل/لايعمل")]
        public string work { get; set; }

        [DisplayName("المستوى التعليمي")]
        public string education_level { get; set; }

        [DisplayName("الامراض المزمنة")]
        public string chronic_diseases { get; set; }

        [DisplayName("إعاقة")]
        public string has_disabilities { get; set; }
        public string form_key { get; set; }
        public string form_uuid { get; set; }
        public string order_uuid { get; set; }
        public string question_uuid { get; set; }
    }
}
