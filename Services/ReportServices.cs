using ApprovedMedicalSurvey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Services
{
   public class ReportServices
    {
        public static List<Reports> GetReports()
        {

            List<Reports> reports = new List<Reports>() {
            new Reports {ReportName ="الخصائص السكانية"},
            new Reports {ReportName ="الحالة التعليمة"},
            new Reports {ReportName ="صفة حيازة المنزل"},
            new Reports {ReportName ="مصادر الشرب"},
            new Reports {ReportName ="نوع الخزانات المستخدمة لحفظ مياه الشرب"},
            new Reports {ReportName ="التخلص من النفايات"},
            new Reports {ReportName ="نظام الصرف الصحي"},
            new Reports {ReportName ="طريقة مكافحة نواقل الامراض"},
            new Reports {ReportName ="مصادر دخل الأسرة"},
            new Reports {ReportName ="جهة تلقى الخدمة الصحية"},
            new Reports {ReportName ="عدد المصابين بالامراض المزمنة"},
             new Reports {ReportName ="الإعاقات حسب نوعها"},


            };

            return reports;
        }
    }
}
