using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
    public class Users
    {
        [DisplayName("الصلاحيات")]
        public string role { get; set; }
       
        [DisplayName("تارخ التسجيل")]
        public DateTime created_at { get; set; }
        [DisplayName("الحاله")]
        public string status { get; set; }
        [DisplayName("اسم المستخدم")]
        public string username { get; set; }
        public string uuid { get; set; }
        [DisplayName("البريد الالكتروني")]
        public string email { get; set; }
    }

   
    
}

