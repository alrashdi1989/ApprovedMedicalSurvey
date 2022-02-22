using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using System.Windows.Forms;


namespace ApprovedMedicalSurvey.UI
{
    public partial class Scans : Form
    {

        public Scans()
        {
            InitializeComponent();
        }
        Boolean flag;


        private void Scans_Load(object sender, EventArgs e)
        {
            Governance();
            lookUpEdit1.Text = "اختر المحافظة....";
        }

        private void Governance()
        {
            governorateBindingSource.DataSource = GovernantesServices.GetAllGovernorate("governorates");
        }
        private void States()
        {
            willayatBindingSource.DataSource = WillayatServices.GetAllWillayatbyId("willayat", lookUpEdit1.EditValue.ToString());


        }

        private void Villages()
        {

            villageBindingSource.DataSource = VillageServices.GetAllVIllagesbyStateID("villages", lookUpEdit2.EditValue.ToString());


        }






        private void btnShowResults_Click(object sender, EventArgs e)
        {
          
            try
            {
                this.Cursor = Cursors.WaitCursor;
                string postData = "";
                string URL = "https://gql.formon.io/api/rest/surveys/";
                var data = webPostMethod(postData, URL);

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var orders = serializer.Deserialize<Models.Surveys>(data);





                DataTable dt_survey = new DataTable();
                dt_survey.Columns.Add("Surveyuuid", typeof(string));
                dt_survey.Columns.Add("Surveyid", typeof(string));
                dt_survey.Columns.Add("bncode", typeof(string));
                dt_survey.Columns.Add("status", typeof(string));
                dt_survey.Columns.Add("user", typeof(string));
                dt_survey.Columns.Add("village", typeof(string));
                dt_survey.Columns.Add("surveydate", typeof(string));


                DataRow dr;

                foreach (var ques in orders.operation_orders.Where(c=> c.village_name_ar == lookUpEdit3.Text && c.status=="completed"))
                {
                    dr = dt_survey.NewRow();
                    dr["Surveyuuid"] = ques.uuid;
                    dr["Surveyid"] = ques.bncode;
                    dr["bncode"] = ques.bncode;
                    dr["status"] = ques.status;
                    dr["user"] = ques.user.username;
                    dr["village"] = ques.village_name_ar;
                    string survey_create_date = ques.created_at.Date.Day.ToString() + "/" + ques.created_at.Date.Month.ToString() + "/" + ques.created_at.Date.Year.ToString();
                    dr["surveydate"] = survey_create_date;
                    dt_survey.Rows.Add(dr);
                }

                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt_survey;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].HeaderText = "رقم المسح";
                dataGridView1.Columns[2].HeaderText = "رقم المبنى";
                dataGridView1.Columns[3].HeaderText = "حالة المسح";
                dataGridView1.Columns[4].HeaderText = "جامع البيان";
                dataGridView1.Columns[5].HeaderText = "القرية";
                dataGridView1.Columns[6].HeaderText = "تاريخ المسح";
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = Properties.Resources.search;
                
                img.Image = image;
                dataGridView1.Columns.Add(img);
                img.HeaderText = "التفاصيل";
                img.Name = "img";
                img.Width = 60;
                this.Cursor = Cursors.Default;
                lblsurveycount.Text = "عدد المسوحات = " + dt_survey.Rows.Count;

                flag = false;



                dataGridView1.ClearSelection();

                 surveysBindingSource.DataSource = SurveyServices.GetAllSurveys("surveys");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


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

            }

            return responseFromServer;

        }
        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            States();
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            Villages();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    int selectedrowindex = dataGridView1.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["Surveyuuid"].Value);

                    Surveys f = new Surveys();
                    f.MdiParent = this.ParentForm;
                    f.Tag = cellValue;
                    f.Show();
                    f.Dock = DockStyle.Fill;

                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lookUpEdit1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
