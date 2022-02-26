using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
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
        bool isfamilymember = false;
        string familyMemberName;
        private void FillingTheGridWithData()
        {
           
        }

        private void Surveys_Load(object sender, EventArgs e)
        {
            FillLabelWithData();

        }

        private void FillLabelWithData()
        {
            Cursor = Cursors.WaitCursor;
            string postData = Tag.ToString();

            string URL = GlobalVariables.BaseUrl + "surevy/" + GlobalVariables.SurveyID;
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
                    if (ans_val.Length > 0 )
                    {

                        findControlName("txt_" + quest_id, ans_val.Substring(0, ans_val.Length - 2));

                    }

                    

                }

           
           
            this.Cursor = Cursors.Default;
            tabControl1.Visible = true;
            FlatLightTheme.flatLightTheme.lbl.Text = this.Text;
            familyMemberBindingSource.DataSource = FamilyMemberServices.GetAllFamiyMembersBySurveyID("family/members/" + GlobalVariables.SurveyID);
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
            f.ShowDialog();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                     familyMemberName = Convert.ToString(selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value);
                    var memberDetails = FamilyMemberServices.GetAllFamiyMembersBySurveyID("family/members/" + GlobalVariables.SurveyID).Where(c =>
                    c.name == familyMemberName);
                    var womenshealth = memberDetails.FirstOrDefault().women_health.FirstOrDefault();
                   lbl_133.Text = womenshealth.marriage_period;
                    lbl_86.Text = womenshealth.has_children;
                    lbl_87.Text = womenshealth.is_pregnant_now;
                    lbl_88.Text = womenshealth.time_interval_between_pregnancy;
                    lbl_90.Text = womenshealth.birth_spacing_reson;
                    lbl_97.Text = womenshealth.pregnancy_clinic_reviewed;
                    lbl_91.Text = womenshealth.current_birth_spacing_methods;
                    tabControl2.Visible = true;


                }
            }
        }
    }
}
