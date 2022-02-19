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
        public string Role { get; set; }

        [DisplayName("تاريخ التسجيل")]
        public DateTime CreatedAt { get; set; }

        [DisplayName("الحالة")]
        public string Status { get; set; }

        [DisplayName("اسم المستخدم")]
        public string Username { get; set; }

        [DisplayName("رقم المستخدم")]
        public string Uuid { get; set; }
        [DisplayName("البريد الالكتروني")]
        public string Email { get; set; }
    }

   
    
}

