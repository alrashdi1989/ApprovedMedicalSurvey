using ApprovedMedicalSurvey.Models;
using Newtonsoft.Json;
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
            //filling the reports class with data 

            List<Reports> reports = new List<Reports>() {
            new Reports {reportName ="الحالة الإجتماعية",reportID="4e4259cc-3299-4b07-a2f4-7d55d604d2df"},
            new Reports {reportName ="المستوى التعليمي",reportID="2aee3805-828a-40e3-a63b-ddab8dfd3fa5"},
            new Reports {reportName ="سبب الوفاه",reportID="1603961d-217b-4380-8cec-4f70edaf256a"},
            new Reports {reportName ="مصادر الدخل",reportID="4fe4d99d-960c-439e-81ca-e73043d0926b"},
            new Reports {reportName ="متوسط أجمالي دخل الأسرة",reportID="716240e7-dee2-40e3-8fc1-e24a5f810d93"},
            new Reports {reportName ="نظام الصرف الصحي",reportID="210229c0-5a26-4ca4-ad2b-5abb5b3622dc"},
            new Reports {reportName ="نوع المحاصيل",reportID="790ea967-3e99-4f73-af71-5c9e8a855eac"},
            new Reports {reportName ="طرق مكافحة الحشرات",reportID="994b103e-3a9c-4756-add4-83de7820c8dd"},
            new Reports {reportName ="استغلال الأراضي الزراعية",reportID="13416b92-a369-4d7a-a20a-790e8c120058"},
            new Reports {reportName ="التخلص من القمامة",reportID="bec6067c-39f9-4b6c-983e-72ba8336491d"},
            new Reports {reportName ="لأمراض المزمنة",reportID="d49b555b-1c62-44b4-9a48-2ce32bc5ce3c"},
            new Reports {reportName ="الإعاقة",reportID="93b768b4-1cf8-4a64-8e1a-6314c02d0c5c"},
            new Reports {reportName ="مصادر شرب المياه",reportID="10f3038f-3be5-4cea-a584-e755e850c7e7"},
            new Reports {reportName ="معدل انتشار وسائل المباعدة بين الحمل",reportID="a16cc3b2-9d7e-4034-a759-1b88488f9889"},
            new Reports {reportName ="معدل انتشار النشاط البدني",reportID="daf64e46-7ce7-42cb-85d6-a2063aeb3824"},
            new Reports {reportName ="معدل انتشار سوء التغذية",reportID="c40f1b8d-aa0f-4f5e-9d3d-0696b7385a9a"},
            new Reports {reportName ="الخصائص السكانية",reportID="6f1d0881-5800-4cac-a387-fbeace663595"},
            new Reports {reportName ="حيازة المنزل",reportID="82898509-b7ea-42ca-b3ab-e43b9c8d3f79"},
            new Reports {reportName ="نوع الخزانات المستخدمة",reportID="10f3038f-3be5-4cea-a584-e755e850c7e7"},
            new Reports {reportName ="تلقى الخدمة الصحية",reportID="62d20b20-d2bb-4499-8843-3ca4fcd1eb9e"},


            };

            return reports;
        }


        public static List<AllReports.Result> GetAllReports(string baseurl)
        {

            //gettin all Villages  info from the api with filter using lambda 

            var response = Shared.HttpResponse.responseMessage(baseurl);
            List<AllReports.Result> res = new List<AllReports.Result>();
            if (response.IsSuccessStatusCode)
            {
                var data = response.Content.ReadAsStringAsync().Result;

                if (data != null)
                {
                    AllReports.Root result = JsonConvert.DeserializeObject<AllReports.Root>(data);
                    res = result.results.ToList();
                }


                

            }
            return res;

        }

    }
}
