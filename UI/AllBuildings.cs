using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using ApprovedMedicalSurvey.Shared;
using Microsoft.Office.Interop.Excel;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web.Helpers;
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
        string Vuuid;
        string Wuuid;
        string guuid;
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
          Vuuid =dt.Select(x => x.uuid).ToString();
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
            MessageBox.Show(cbVillage.SelectedValue.ToString());
            allBuildingsBindingSource.DataSource = buildings;

            label3.Text = buildings.Count().ToString();




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
            //var dt  = GovernantesServices.GetAllGovernorate("governorates");
            //Wuuid = dt.Where(x => x.rncode == cbGovernance.SelectedValue).SingleOrDefault().uuid;
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
            var dt = WillayatServices.GetAllWillayatbyId("willayat", cbGovernance.SelectedValue.ToString());
            var state = cbState.SelectedValue.ToString();
             Wuuid = dt.Where(x=>x.wncode == state).FirstOrDefault().uuid ;


            var vdt = VillageServices.GetAllVIllagesbyStateID("villages", cbState.SelectedValue.ToString());
            var village = cbVillage.SelectedValue.ToString();
            Vuuid = vdt.Where(x => x.tncode == village).FirstOrDefault().uuid;


            var gdt = GovernantesServices.GetAllGovernorate("governorates");
            var goverment = cbGovernance.SelectedValue.ToString();
            guuid = gdt.Where(x => x.rncode == goverment).FirstOrDefault().uuid;
            string message = string.Empty;
            foreach (DataGridViewRow row in dgScans.Rows)
            {



                bool isSelected = Convert.ToBoolean(row.Cells["multiusers"].Value);

                if (isSelected)
                {

                    string wncode = row.Cells["willcodeDataGridViewTextBoxColumn"].Value.ToString();
                    string willaya_uuid = Wuuid;
                    string volunteer_uuid = cbUsers.SelectedValue.ToString();
                    string village_uuid = Vuuid;
                    string tncode = row.Cells["villageidDataGridViewTextBoxColumn"].Value.ToString();
                    string template_uuid = "fb19b96d-5a24-442e-ae7c-949bf6158f79";// row.Cells["uuidDataGridViewTextBoxColumn"].Value.ToString();
                    string status = "new";
                    string rncode = row.Cells["govcodeDataGridViewTextBoxColumn"].Value.ToString();
                    string lng = row.Cells["xcoardDataGridViewTextBoxColumn"].Value.ToString();
                    string lat = row.Cells["ycoardDataGridViewTextBoxColumn"].Value.ToString();
                    string governorat_uuid = guuid;
                    string destrict_uuid = "0f8cc492-05af-4c38-942c-0fe532aa954e";// row.Cells["districtDataGridViewTextBoxColumn"].Value.ToString();
                    string building_uuid = row.Cells["uuidDataGridViewTextBoxColumn"].Value.ToString();
                    string bncode = row.Cells["buildingcoDataGridViewTextBoxColumn"].Value.ToString();
                    string admin_uuid = "7330866a-193f-4f12-a53e-4371b308be71";



                    string str = "{\"wncode\":\"" + wncode + "\",\"willaya_uuid\":\"" + willaya_uuid + "\"," +
                        "\"volunteer_uuid\":\"" + volunteer_uuid + "\",\"village_uuid\":\"" + village_uuid + "\",\"tncode\":\"" + tncode +
                        "\",\"template_uuid\":\"" + template_uuid + "\",\"status\":\"" + status + "\",\"rncode\":\"" + rncode + "\",\"lng\":" + lng + "," +
                        "\"lat\":" + lat + ",\"governorat_uuid\":\"" + governorat_uuid + "\",\"destrict_uuid\":\"" + destrict_uuid + "\",\"building_uuid\":\"" + building_uuid + "\",\"bncode\":\"" + bncode + "\",\"admin_uuid\":\"" + admin_uuid + "\" }";
                    string URL = GlobalVariables.BaseUrl + "order/new";


                    WebRequsets webRequsets = new WebRequsets();
                    var response = webRequsets.webPostMethod(str, URL, true);

                };
            }
            MessageBox.Show("تم اسناد المباني للمستخدم ");

        }

        private void cbVillage_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
