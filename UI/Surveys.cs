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
            //showing conformaation message to make the user accepet the survey 
       DialogResult dr = MessageBox.Show("هل انت متاكد من قبول الاستبيان؟", "قبول الاستبيان", MessageBoxButtons.YesNo,
      MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                string getData = this.Tag.ToString() + "/accepted";

                string URL = GlobalVariables.BaseUrl + "survey/status/" + getData;
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
            //filling the family members data after chossing one of them 
            if (dgFamilyMemebers.CurrentCell.ColumnIndex.Equals(13) && e.RowIndex != -1)
            {
                if (dgFamilyMemebers.CurrentCell != null && dgFamilyMemebers.CurrentCell.Value != null)
                {
                    ClearingLabels();

                    int selectedrowindex = dgFamilyMemebers.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dgFamilyMemebers.Rows[selectedrowindex];
                    familyMemberName = Convert.ToString(selectedRow.Cells["nameDataGridViewTextBoxColumn"].Value);
                    var memberDetails = FamilyMemberServices.GetAllFamiyMembersBySurveyID("family/members/" + GlobalVariables.SurveyID).Where(c =>
                    c.name == familyMemberName);
                    lbl_122.Text = memberDetails.SingleOrDefault().smoking;
                    lbl_124.Text = memberDetails.SingleOrDefault().chronic_diseases;
                    lbl_123.Text = memberDetails.SingleOrDefault().has_disabilities;
                    if (memberDetails.FirstOrDefault().women_health.Count != 0)
                    {
                        var womenshealth = memberDetails.FirstOrDefault().women_health.FirstOrDefault();
                        lbl_133.Text = womenshealth.marriage_period;
                        lbl_86.Text = womenshealth.has_children;
                        lbl_87.Text = womenshealth.is_pregnant_now;
                        lbl_88.Text = womenshealth.time_interval_between_pregnancy;
                        lbl_90.Text = womenshealth.birth_spacing_reson;
                        lbl_97.Text = womenshealth.visited_health_institution;
                        lbl_91.Text = womenshealth.previous_birth_spacing_methods;
                        lbl_92.Text = womenshealth.pregnancy_clinic_reviewed;
                        lbl_93.Text = womenshealth.pregnancy_clinic_reviewed_reson;
                        lbl_94.Text = womenshealth.vaccinated_against_tetanus;
                        lbl_95.Text = womenshealth.diagnosed_with_anemia;
                        lbl_96.Text = womenshealth.last_child_born_location;
                    }

                    if (memberDetails.FirstOrDefault().elder_health.Count != 0)
                    {
                        var elderhealth = memberDetails.FirstOrDefault().elder_health.FirstOrDefault();
                        lbl_112.Text = elderhealth.is_doing_productive_job;
                        lbl_113.Text = elderhealth.does_need_help;
                        lbl_114.Text = elderhealth.does_physical_activity;
                        lbl_115.Text = elderhealth.who_is_helping_him;
                    }
                    if (memberDetails.FirstOrDefault().baby_health.Count != 0)
                    {
                        var cildresnshealth = memberDetails.FirstOrDefault().baby_health.FirstOrDefault();
                        lbl_134.Text = cildresnshealth.six_months_kind_of_breastfeeding;
                        lbl_99.Text = cildresnshealth.complementary_foods_child_age;
                        lbl_100.Text = cildresnshealth.vaccinated;
                        lbl_101.Text = cildresnshealth.is_child_underweight;
                        lbl_102.Text = cildresnshealth.health_center_reviewed;
                        lbl_103.Text = cildresnshealth.has_diarrhea;
                        lbl_104.Text = cildresnshealth.hae_respiratory_infection;
                        lbl_105.Text = cildresnshealth.anemia_diagnosed;
                        lbl_106.Text = cildresnshealth.diagnosed_with_malnutrition;
                        lbl_107.Text = cildresnshealth.suffer_from_stunted_growth;
                        lbl_107.Text = memberDetails.SingleOrDefault().chronic_diseases;
                    }


                    tabControl2.Visible = true;


                }
            }
        }

        private void ClearingLabels()
        {
            lbl_122.Text = string.Empty;
            lbl_133.Text = string.Empty;
            lbl_86.Text = string.Empty;
            lbl_87.Text = string.Empty;
            lbl_88.Text = string.Empty;
            lbl_90.Text = string.Empty;
            lbl_97.Text = string.Empty;
            lbl_91.Text = string.Empty;
            lbl_92.Text = string.Empty;
            lbl_93.Text = string.Empty;
            lbl_94.Text = string.Empty;
            lbl_95.Text = string.Empty;
            lbl_96.Text = string.Empty;
            lbl_112.Text = string.Empty;
            lbl_113.Text = string.Empty;
            lbl_114.Text = string.Empty;
            lbl_115.Text = string.Empty;
            lbl_134.Text = string.Empty;
            lbl_99.Text = string.Empty;
            lbl_100.Text = string.Empty;
            lbl_101.Text = string.Empty;
            lbl_102.Text = string.Empty;
            lbl_103.Text = string.Empty;
            lbl_104.Text = string.Empty;
            lbl_105.Text = string.Empty;
            lbl_106.Text = string.Empty;
            lbl_107.Text = string.Empty;
        }
    }
}
