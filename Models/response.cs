using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApprovedMedicalSurvey.Models
{
    internal class ResponseData
    {
        public class Rootobject
        {
            public Operation_Orders[] operation_orders { get; set; }
        }

        public class Operation_Orders
        {
            public Response[] response { get; set; }
            public string uuid { get; set; }
        }

        public class Response
        {
            public string key { get; set; }
            public string uuid { get; set; }
            public bool dirty { get; set; }
            public string notes { get; set; }
            public Order order { get; set; }
            public bool synced { get; set; }
            public object[] actions { get; set; }
            public string form_key { get; set; }
            public Question question { get; set; }
            public object[] response { get; set; }
            public string form_uuid { get; set; }
            public bool is_valid { get; set; }
            public string error_icon { get; set; }
            public string valid_icon { get; set; }
            public string survey_uuid { get; set; }
            public object[] answer_images { get; set; }
            public string error_message { get; set; }
            public object response_uuid { get; set; }
            public string template_uuid { get; set; }
            public string valid_message { get; set; }
        }

        public class Order
        {
            public int id { get; set; }
            public float lat { get; set; }
            public float lng { get; set; }
            public string name { get; set; }
            public string uuid { get; set; }
            public string bncode { get; set; }
            public string rncode { get; set; }
            public string status { get; set; }
            public string tncode { get; set; }
            public string wncode { get; set; }
            public Village village { get; set; }
            public Willaya willaya { get; set; }
            public Building building { get; set; }
            public object[] volunteer { get; set; }
            public string admin_uuid { get; set; }
            public DateTime created_at { get; set; }
            public Governorate governorate { get; set; }
            public string willaya_uuid { get; set; }
            public string destrict_uuid { get; set; }
            public string template_uuid { get; set; }
            public string volunteer_uuid { get; set; }
            public string governorat_uuid { get; set; }
        }

        public class Village
        {
            public int id { get; set; }
            public string uuid { get; set; }
            public string name_ar { get; set; }
        }

        public class Willaya
        {
            public int id { get; set; }
            public string uuid { get; set; }
            public string rncode { get; set; }
            public string name_ar { get; set; }
            public string name_en { get; set; }
            public int objectid { get; set; }
            public float shape_area { get; set; }
            public float shape_leng { get; set; }
        }

        public class Building
        {
            public int id { get; set; }
            public string uuid { get; set; }
            public string name_ar { get; set; }
            public Geometry geometry { get; set; }
        }

        public class Geometry
        {
            public Crs crs { get; set; }
            public string type { get; set; }
            public float[][] coordinates { get; set; }
        }

        public class Crs
        {
            public string type { get; set; }
            public Properties properties { get; set; }
        }

        public class Properties
        {
            public string name { get; set; }
        }

        public class Governorate
        {
            public int id { get; set; }
            public string uuid { get; set; }
            public string name_ar { get; set; }
        }

        public class Question
        {
            public int id { get; set; }
            public string key { get; set; }
            public string name { get; set; }
            public string uuid { get; set; }
            public int weight { get; set; }
            public string widget { get; set; }
            public bool enabled { get; set; }
            public int form_id { get; set; }
            public string options { get; set; }
            public bool required { get; set; }
            public string form_uuid { get; set; }
            public bool is_visible { get; set; }
            public string visibility { get; set; }
            public int template_id { get; set; }
            public string error_message { get; set; }
            public Responses_Set[] responses_set { get; set; }
            public string template_name { get; set; }
            public string template_uuid { get; set; }
            public int page_id { get; set; }
            public string page_uuid { get; set; }
            public int order_index { get; set; }
        }

        public class Responses_Set
        {
            public int id { get; set; }
            public string name { get; set; }
            public string uuid { get; set; }
            public string label { get; set; }
            public int score { get; set; }
            public bool enabled { get; set; }
            public int form_id { get; set; }
            public bool is_info { get; set; }
            public string form_uuid { get; set; }
            public bool is_default { get; set; }
            public int question_id { get; set; }
            public int template_id { get; set; }
            public string question_uuid { get; set; }
            public string template_uuid { get; set; }
            public string response_color { get; set; }
            public string response_value { get; set; }
        }

    }
}
