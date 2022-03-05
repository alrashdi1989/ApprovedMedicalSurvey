using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using ApprovedMedicalSurvey.Shared;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class Users : Form
    {
        public static Users users;
        public DataGridView dg;
        public Users()
        {
            users = this;
            InitializeComponent();
            dg = dgUsers;
        }

       
        private void Users_Load(object sender, EventArgs e)
        {
            FillingTheGridWithData();

        }

      
        public void FillingTheGridWithData()
        {
            //filling data grid with all users info 
           var user = UserServices.GetAllUsers("users");
            if (GlobalVariables.isNewUser==true)
            {
                user.Add(new Models.Users
                {
                    username = "سامح محمد"
    ,
                    role = "volunteer",
                    created_at = DateTime.Today,
                    status = "active",
                    uuid = "97845",
                    email = "sameh@gmai.com"
                });

            }
            usersBindingSource.DataSource = user;

           villageBindingSource.DataSource = VillageServices.GetAllVIllages("villages");
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddUser f = new AddUser();
            f.Show();
        }

      

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            //string filterValue = textEdit1.Text;
            //string filterString = "[village] like %" + filterValue+"%";
            //gridView1.Columns["village"].FilterInfo = new ColumnFilterInfo(filterString);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GlobalVariables.isNewUser==true)
            {
                FillingTheGridWithData();
                GlobalVariables.isNewUser = false;
            }
        }
    }
}
