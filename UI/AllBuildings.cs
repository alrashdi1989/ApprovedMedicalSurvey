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
    public partial class AllBuildings : Form
    {

        public AllBuildings()
        {
            InitializeComponent();
        }
        Boolean flag ;
        private FlatLightTheme mainForm = null;
        string jwt;
        private void Scans_Load(object sender, EventArgs e)
        {
            //binding data to combo boxes 
            var user = UserServices.GetAllUsers("users");

            usersBindingSource.DataSource = user.OrderByDescending(c => c.created_at);
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
                cbVillage.DataSource = dt;//.Where(c=>c.uuid == GlobalVariables.Uuid);
                cbVillage.DisplayMember = "name_ar";
                cbVillage.ValueMember = "tncode";

            }




        }






        private void btnShowResults_Click(object sender, EventArgs e)
        {
            var buildings = BuildingsServices.
            GetAllBuildings("building",Convert.ToInt32( cbVillage.SelectedValue));

            allBuildingsBindingSource.DataSource = buildings;




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

        private void addBuilding_Click(object sender, EventArgs e)
        {
            Buildings f = new Buildings();
            f.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            int num = 0;
            foreach (DataGridViewRow row in dgScans.Rows)
            {



                bool isSelected = Convert.ToBoolean(row.Cells["checklist"].Value);

                if (isSelected)
                {
                    num = +1;
                    //message += Environment.NewLine;
                    //message += row.Cells["uuidDataGridViewTextBoxColumn"].Value.ToString();
                    string URL = GlobalVariables.BaseUrl + "survey/status/" + row.Cells["uuidDataGridViewTextBoxColumn"].Value.ToString() + "/active";
                    WebRequsets webRequsets = new WebRequsets();
                    var data = webRequsets.webGetMethod(URL);
                }
            }

            if (num == 0)
            {
                MessageBox.Show("الرجاء اختيار مستخدم اولا ");
            }
        }
    }
}
