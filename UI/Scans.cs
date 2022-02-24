using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using ApprovedMedicalSurvey.Shared;
using Microsoft.Office.Interop.Excel;
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
        private FlatLightTheme mainForm = null;

        private void Scans_Load(object sender, EventArgs e)
        {
            Governance();
        }

        private void Governance()
        {
            var dt = GovernantesServices.GetAllGovernorate("governorates");
            dt.Insert(0, new Governorate {
            name_ar="اختر المحافظة..."});
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "name_ar";
            comboBox1.ValueMember = "rncode";
           

        }
        private void States()
        {

            var dt = WillayatServices.GetAllWillayatbyId("willayat", comboBox1.SelectedValue.ToString());
            dt.Insert(0, new Willayat
            {
                name_ar = "اختر الولاية..."
            });
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "name_ar";
            comboBox2.ValueMember = "wncode";
        }

        private void Villages()
        {
            if (comboBox2.Text != "اختر الولاية...")

              
            {

                var dt = VillageServices.GetAllVIllagesbyStateID("villages", comboBox2.SelectedValue.ToString());
                dt.Insert(0, new Village
                {
                    name_ar = "اختر القرية..."
                });
                comboBox3.DataSource = dt;
                comboBox3.DisplayMember = "name_ar";
                comboBox3.ValueMember = "tncode";

            }




        }






        private void btnShowResults_Click(object sender, EventArgs e)
        {


            try
            {
                this.Cursor = Cursors.WaitCursor;
                string postData = "";
                string URL = "https://gql.formon.io/api/rest/surveys/";
                WebRequsets webRequests = new WebRequsets();
                var data = webRequests.webPostMethod(postData, URL);

                JavaScriptSerializer serializer = new JavaScriptSerializer();
                var orders = serializer.Deserialize<Models.Surveys>(data);





                System.Data.DataTable dt_survey = new System.Data.DataTable();
                dt_survey.Columns.Add("Surveyuuid", typeof(string));
                dt_survey.Columns.Add("Surveyid", typeof(string));
                dt_survey.Columns.Add("bncode", typeof(string));
                dt_survey.Columns.Add("status", typeof(string));
                dt_survey.Columns.Add("user", typeof(string));
                dt_survey.Columns.Add("village", typeof(string));
                dt_survey.Columns.Add("surveydate", typeof(string));


                DataRow dr;

                foreach (var ques in orders.operation_orders.Where(c => c.village_name_ar == comboBox3.Text && c.status == "completed"))
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
                label1.Text = "عدد المسوحات = " + dt_survey.Rows.Count;

                flag = false;



                dataGridView1.ClearSelection();

                textBox1.Visible = true;
                dateEdit1.Visible = true;
                textBox2.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


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


        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("user LIKE '%{0}%'", textBox1.Text);

        }

        private void dateEdit1_EditValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("surveydate = '{0}'", dateEdit1.Text);

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("Surveyid LIKE '%{0}%'", textBox2.Text);

        }

     

       


        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            textBox1.Text = string.Empty;

        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            textBox2.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            States();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Villages();
        }
    }
}
