using ApprovedMedicalSurvey.Services;
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            villageBindingSource.DataSource = VillageServices.GetAllVIllages("villages");
            userPrivilegesBindingSource.DataSource = UserServices.GetUserPrivliges();
            userStatusBindingSource.DataSource = UserServices.GetUserStatuses();


        }
    }
}
