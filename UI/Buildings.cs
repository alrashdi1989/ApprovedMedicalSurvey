using ApprovedMedicalSurvey.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class Buildings : Form
    {
        private readonly HttpClient httpClient;

        public Buildings()
        {
            InitializeComponent();
        }

      
        private void Buildings_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)

        {   
            var url = GlobalVariables.BaseUrl + "buildings/insert";


          
            var csv = new List<string[]>();
            var lines = System.IO.File.ReadAllLines(openFileDialog1.FileName); // csv file location

            // loop through all lines and add it in list as string
           

            foreach (string line in lines) {

                if (!String.IsNullOrEmpty(lines.ToString()))
                {
                    csv.Add(line.Split(','));
                }
               

              
            }

            
            //split string to get first line, header line as JSON properties
            var properties = lines[0].Split(',');

            var listObjResult = new List<Dictionary<string, string>>();

            //loop all remaining lines, except header so starting it from 1
            // instead of 0
            for (int i = 1; i < lines.Length; i++)

            {
                progressBar1.Maximum = lines.Length;
                progressBar1.Value = i+1;
                var objResult = new Dictionary<string, string>();
                
                for (int j = 0; j < properties.Length; j++)

                objResult.Add(properties[j], csv[i][j]);
                objResult.Remove("uuid");
                objResult.Remove("wkb_geometry");
                listObjResult.Add(objResult);
              
                var json = JsonConvert.SerializeObject(listObjResult) ;


                Shared.WebRequsets webRequsets = new Shared.WebRequsets();
                json.Remove(11);
                json.Remove(10);
                var data = "{\"objects\":" + json + "}";
                webRequsets.webPostMethod(data, url,true);

            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
    }

      
}
