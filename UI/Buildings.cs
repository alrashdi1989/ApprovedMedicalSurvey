using ApprovedMedicalSurvey.Shared;
using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class Buildings : Form
    {
        public Buildings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
         {
            var url = GlobalVariables.BaseUrl+ "insert HTTP/1.2";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";

            var data = @"{""objects"": [  {
        ""district"": ""111111الحي الأول"",
        ""govcode"": ""122220"",
        ""buildingco"": ""513031"",
        ""bldtype"": ""رئيسي"",
        ""objectid"": 382222,
        ""ogc_fid"": 92229,
        ""villageid"": ""100110255"",
        ""willcode"": ""1001"",
        ""wkb_geometry"": {
        ""type"": ""MultiPoint"",
      ""crs"": {
               ""type"": ""name"",
            ""properties"": {
                            ""name"": ""urn:ogc:def:crs:EPSG::4326""
            }
                    },
          ""coordinates"": [
            [
              56.7270696756487,
              23.2725623342119
            ]
          ]
        },
        ""xcoord"": 56.7270696756,
        ""ycoord"": 23.2725623342
      }
    ]

}";

            using (var streamWriter = new StreamWriter(httpRequest.GetRequestStream()))
            {
                streamWriter.Write(data);
            }

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 |
                SecurityProtocolType.Tls11| 
                SecurityProtocolType.Tls 
                | SecurityProtocolType.Ssl3;
          



            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();
            }

        }

        private void Buildings_Load(object sender, EventArgs e)
        {
            textBox1.Text = GlobalVariables.jwt;
        }
    }
}
