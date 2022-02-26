using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using ApprovedMedicalSurvey.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }
        private UI.Users mainForm = null;
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            GetVillages();
            GetRoles();
            GetUserStatus();

        }

        private void GetUserStatus()

        {
            var dt = UserServices.GetUserStatuses();
            dt.Insert(0, new Models.UserStatus
            {
                StatusArabic = "حالة المستخدم..."
                

            });
            comboBox4.DataSource = dt;
            comboBox4.DisplayMember = "StatusArabic";
            comboBox4.ValueMember = "StatusEnglish";

            
        }

        private void GetVillages()

        {

            var dt = VillageServices.GetAllVIllages("villages");
            dt.Insert(0, new Models.Village
            {
                name_ar = "اختر القرية..."
                
            });
            comboBox3.DataSource = dt;
            comboBox3.DisplayMember = "name_ar";
            comboBox3.ValueMember = "tncode";
        }

        private void GetRoles()
        {
            var dt = UserServices.GetUserPrivliges();
            dt.Insert(0, new Models.UserPrivileges
            {
                UserPrivilegesArabic = "الصلاحيات..."
                
            });
            comboBox2.DataSource = dt;
            comboBox2.DisplayMember = "UserPrivilegesArabic";
            comboBox2.ValueMember = "UserPrivilegesEnglish";

            
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)

        {

            var dt = UserServices.GetAllUserswithoutProvlage("users", comboBox2.SelectedValue.ToString());
            dt.Insert(0, new Models.Users
            {
                username = "نقطة التواصل..."
            });
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "username";
            comboBox1.ValueMember = "uuid";
           

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //    string postData ="{'users' : { 'username': '88888888', 'pin': '8888', 'email': 'eight@domain.com','role': 'central_level','status': 'active' }   }";
            //WebRequsets webRequsets = new WebRequsets();
            //    webRequsets.webPostMethod(postData, "https://gql.formon.io/api/rest/create/user/");
         
         
            GlobalVariables.isNewUser = true;           
        }
    }
}
