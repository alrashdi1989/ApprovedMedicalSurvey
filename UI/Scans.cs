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
        Boolean flag ;
        private FlatLightTheme mainForm = null;
        string jwt;
        private void Scans_Load(object sender, EventArgs e)
        {
            //binding data to combo boxes 
            Governance();
        }

        private void Governance()
        {
            var dt = GovernantesServices.GetAllGovernorate("governorates");
            dt.Insert(0, new Governorate {
            name_ar="اختر المحافظة..."});
            cbGovernance.DataSource = dt;
            cbGovernance.DisplayMember = "name_ar";
            cbGovernance.ValueMember = "rncode";
           

        }
        private void States()
        {
           //filtering states by governance 
            var dt = WillayatServices.GetAllWillayatbyId("willayat", cbGovernance.SelectedValue.ToString());
            dt.Insert(0, new Willayat
            {
                name_ar = "اختر الولاية..."
            });
            cbState.DataSource = dt;
            cbState.DisplayMember = "name_ar";
            cbState.ValueMember = "wncode";
        }

        private void Villages()
        {
            if (cbState.Text != "اختر الولاية...")

              
            {
                //filtering villiges by states 
                var dt = VillageServices.GetAllVIllagesbyStateID("villages", cbState.SelectedValue.ToString());
                dt.Insert(0, new Village
                {
                    name_ar = "اختر القرية..."
                });
                cbVillage.DataSource = dt;
                cbVillage.DisplayMember = "name_ar";
                cbVillage.ValueMember = "tncode";

            }




        }






        private void btnShowResults_Click(object sender, EventArgs e)
        {


            try
            {
                //filling data grid with data 
                this.Cursor = Cursors.WaitCursor;
                string postData = "";
                string URL = GlobalVariables.BaseUrl+"surveys/";
                WebRequsets webRequests = new WebRequsets();
                var data = webRequests.webPostMethod(postData, URL, jwt);

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

                foreach (var ques in orders.operation_orders.Where(c => c.village_name_ar == cbVillage.Text && c.status == "completed"))
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

                dgScans.Columns.Clear();
                dgScans.DataSource = dt_survey;
                dgScans.Columns[0].Visible = false;
                dgScans.Columns[1].HeaderText = "رقم المسح";
                dgScans.Columns[2].HeaderText = "رقم المبنى";
                dgScans.Columns[3].HeaderText = "حالة المسح";
                dgScans.Columns[4].HeaderText = "جامع البيان";
                dgScans.Columns[5].HeaderText = "القرية";
                dgScans.Columns[6].HeaderText = "تاريخ المسح";
                DataGridViewImageColumn img = new DataGridViewImageColumn();
                Image image = Properties.Resources.search;

                img.Image = image;
                dgScans.Columns.Add(img);
                img.HeaderText = "التفاصيل";
                img.Name = "img";
                img.Width = 60;
                this.Cursor = Cursors.Default;
                lblScanNumbers.Text = "عدد المسوحات = " + dt_survey.Rows.Count;

                flag = false;



                dgScans.ClearSelection();

                txtUser.Visible = true;
                dtScanDate.Visible = true;
                txtScanNumbers.Visible = true;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            Cursor.Current = Cursors.Default;

        }






        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //getting data from clicking on the search button in the grid 
            Cursor.Current = Cursors.WaitCursor;

            if (dgScans.CurrentCell.ColumnIndex.Equals(7) && e.RowIndex != -1)
            {
                if (dgScans.CurrentCell != null && dgScans.CurrentCell.Value != null)
                {
                    int selectedrowindex = dgScans.CurrentCell.RowIndex;
                    DataGridViewRow selectedRow = dgScans.Rows[selectedrowindex];
                    string cellValue = Convert.ToString(selectedRow.Cells["Surveyuuid"].Value);
                    GlobalVariables.SurveyID = cellValue;
                    Surveys f = new Surveys();
                    f.MdiParent = this.ParentForm;
                    f.Tag = cellValue;
                    f.Show();
                    f.Dock = DockStyle.Fill;

                    Cursor.Current = Cursors.Default;

                }
            }
        }


        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //filtering data after showing in the  grid by user name
            (dgScans.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("user LIKE '%{0}%'", txtUser.Text);

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {
            //filtering data after showing in the  grid by scan number

            (dgScans.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("Surveyid LIKE '%{0}%'", txtScanNumbers.Text);

        }

        
        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            txtUser.Text = string.Empty;

        }

        private void textBox2_MouseDown(object sender, MouseEventArgs e)
        {
            txtScanNumbers.Text = string.Empty;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            States();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Villages();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //filtering data after showing in the  grid date

            (dgScans.DataSource as System.Data.DataTable).DefaultView.RowFilter = string.Format("surveydate = '{0}'", dtScanDate.Text);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
