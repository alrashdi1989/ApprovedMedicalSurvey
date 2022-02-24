using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Shared;
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

            string URL = GlobalVariables.BaseUrl+"surevy/" + postData;
            WebRequsets webRequsets = new WebRequsets();
            var data = webRequsets.webPostMethod(postData, URL);

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
            FlatLightTheme.flatLightTheme.lbl.Text = this.Text;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Scans f = new Scans();
            f.MdiParent = this.ParentForm ;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        private void findControlName(string control_name, string val)
        {
            try
            {

                ques_count += 1;
                string name = control_name;
                Label tbx = this.Controls.Find(name, true).FirstOrDefault() as Label;
                if (tbx != null )
                {
                    tbx.Text = val;
                   
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

            string URL = GlobalVariables.BaseUrl+"survey/status/" + getData;
            WebRequsets webRequsets = new WebRequsets();
            var data = webRequsets.webGetMethod(URL);
            MessageBox.Show("تم قبول الاستبيان");
            this.Close();

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GlobalVariables.SurveyID = this.Tag.ToString();

            RejectionNote f = new RejectionNote();
            f.Show();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }
    }
}
