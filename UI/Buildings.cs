using ApprovedMedicalSurvey.Shared;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
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
            var url = GlobalVariables.BaseUrl+ "buildings/insert";

            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            httpRequest.Method = "POST";

            httpRequest.Accept = "application/json";
            httpRequest.ContentType = "application/json";

            var data = @"{""objects"": [  {
        ""district"": ""111111الحي الأول"",
        ""govcode"": ""122220"",
        ""buildingco"": ""513031"",
        ""bldtype"": ""رئيسي"",
        ""objectid"": 382220,
        ""ogc_fid"": 92220,
        ""villageid"": ""100110250"",
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

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var csv = new List<string[]>();
            var lines = System.IO.File.ReadAllLines(@"C:\Users\abdul\source\repos\ApprovedMedicalSurvey\bin\Building_BAAT.csv"); // csv file location

            // loop through all lines and add it in list as string
            foreach (string line in lines)
                csv.Add(line.Split(','));

            //split string to get first line, header line as JSON properties
            var properties = lines[0].Split(',');

            var listObjResult = new List<Dictionary<string, string>>();

            //loop all remaining lines, except header so starting it from 1
            // instead of 0
            for (int i = 1; i < lines.Length; i++)
            {
                var objResult = new Dictionary<string, string>();
                for (int j = 0; j < properties.Length; j++)
                    objResult.Add(properties[j], csv[i][j]);

                listObjResult.Add(objResult);
                var json = JsonConvert.SerializeObject(listObjResult);
                MessageBox.Show(json.ToString());
                    
            }
        }
    }
}
