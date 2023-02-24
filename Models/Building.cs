namespace ApprovedMedicalSurvey.Models
{
    public class Building
    {
        public int id { get; set; }
        public string uuid { get; set; }
        public string name_ar { get; set; }
        public Geometry geometry { get; set; }
    }
    public class Buildings
    {
        public string uuid { get; set; }
        public float xcoard { get; set; }
        public float ycoard { get; set; }
        public string govcode { get; set; }
        public string villageid { get; set; }
        public string willcode { get; set; }
        public string bldtype { get; set; }
        public string district { get; set; }
        public string buildingco { get; set; }
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