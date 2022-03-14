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
            //Binding data sourcces to Combo Boxes
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
            cbUserStatus.DataSource = dt;
            cbUserStatus.DisplayMember = "StatusArabic";
            cbUserStatus.ValueMember = "StatusEnglish";

            
        }


        private void GetRoles()
        {
            var dt = UserServices.GetUserPrivliges();
            dt.Insert(0, new Models.UserPrivileges
            {
                UserPrivilegesArabic = "الصلاحيات..."
                
            });
            cbUserRoles.DataSource = dt;
            cbUserRoles.DisplayMember = "UserPrivilegesArabic";
            cbUserRoles.ValueMember = "UserPrivilegesEnglish";

            
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)

        {
         
           

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
