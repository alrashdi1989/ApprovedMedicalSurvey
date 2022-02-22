﻿using ApprovedMedicalSurvey.Models;
using DevExpress.XtraEditors;
using Nancy.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ApprovedMedicalSurvey.Models.ResponseData;

namespace ApprovedMedicalSurvey.UI
{
    public partial class Surveys : Form
    {
        public Surveys()
        {
            InitializeComponent();
        }
        int quest_id;
        string ans_val = "";
        string question = "";
        object[] answers = new object[20];
        int ques_count = 0;
        private void FillingTheGridWithData()
        {
           
        }

        private void Surveys_Load(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string postData = Tag.ToString();
            
            string URL = "https://gql.formon.io/api/rest/surevy/" + postData;
            var data = webPostMethod(postData, URL);

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            var orders = serializer.Deserialize<Rootobject>(data);
          
            foreach (var ques in orders.operation_orders[0].response)
            {
                ans_val = "";
                quest_id = ques.question.id;
                question = ques.question.name;
                answers = ques.response;
                foreach (var item in answers)
                {
                    ans_val += item.ToString() + " , ";
                }
                if (ans_val.Length > 0)
                {
                    
                    findControlName("txt_" + quest_id, ans_val.Substring(0, ans_val.Length - 2));

                }

            }
            this.Cursor = Cursors.Default;
            tabControl1.Visible = true;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Scans f = new Scans();
            f.MdiParent = this.ParentForm ;
            f.Show();
            f.Dock = DockStyle.Fill;
        }
        public string webPostMethod(string postData, string URL)
        {
            string responseFromServer = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "POST";
            request.Credentials = CredentialCache.DefaultCredentials;
            request.Accept = "/";
            request.UseDefaultCredentials = true;
            request.Proxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();
            try
            {
                WebResponse response = request.GetResponse();
                dataStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(dataStream);
                responseFromServer = reader.ReadToEnd();
                reader.Close();
                dataStream.Close();
                response.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return responseFromServer;

        }

        public string webGetMethod(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;


        }
        private void findControlName(string control_name, string val)
        {
            try
            {

                ques_count += 1;
                string name = control_name;
                LabelControl tbx = this.Controls.Find(name, true).FirstOrDefault() as LabelControl;
                TextEdit txt = this.Controls.Find(name, true).FirstOrDefault() as TextEdit;
                if (tbx != null )
                {
                    tbx.Text = val;
                   
                }
                if (txt != null)
                {
                    txt.Text = val;
                } 
                


            }
            catch (System.Exception ex)
            {

            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string getData = this.Tag.ToString() + "/accepted";

            string URL = "https://gql.formon.io/api/rest/survey/status/" + getData;
            var data = webGetMethod(URL);
            MessageBox.Show("تم قبول الاستبيان");
            this.Close();

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            RejectionNote f = new RejectionNote();
            f.Show();
        }
    }
}
