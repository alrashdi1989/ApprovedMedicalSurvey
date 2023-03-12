﻿using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using ApprovedMedicalSurvey.Shared;
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
            Cursor.Current = Cursors.WaitCursor;
            if (GlobalVariables.UserRole=="super_admin")
            {
                btnNewUser.Visible = true;
            }
            GetVillages();
            vocalpoint();
            FillingTheGridWithData();
            Cursor.Current = Cursors.Default;
        }

      
        public void FillingTheGridWithData()
        {
            //filling data grid with all users info 
           var user = UserServices.GetAllUsers("users");
           
            usersBindingSource.DataSource = user.OrderByDescending(c=>c.created_at);

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

        private void GetVillages()

        {

            var dt = VillageServices.GetAllVIllages("villages");
            dt.Insert(0, new Models.Village
            {
                name_ar = "اختر القرية..."

            });
            cbVillage.DataSource = dt;
            cbVillage.DisplayMember = "name_ar";
            cbVillage.ValueMember = "tncode";
        }
         private void vocalpoint() {
            //addig data binding to the vocal point after choosing the user role 
            var dt = UserServices.GetAllUsers("users");
            dt.Insert(0, new Models.Users
            {
                username = "نقطة التواصل..."
            });
            cbVocalPoint.DataSource = dt;
            cbVocalPoint.DisplayMember = "username";
            cbVocalPoint.ValueMember = "uuid";
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            string message = string.Empty;
            int num = 0;
            foreach (DataGridViewRow row in dgUsers.Rows)
            {



                bool isSelected = Convert.ToBoolean(row.Cells["checklist"].Value);
               
                if (isSelected)
                {
                    num = +1;
                  
                    string URL = GlobalVariables.BaseUrl + "user/status/" + row.Cells["uuidDataGridViewTextBoxColumn"].Value.ToString()+"/active";
                    WebRequsets webRequsets = new WebRequsets();
                    var data = webRequsets.webPostMethod("",URL,true);
                }
            }

            if (num==0)
            {
                MessageBox.Show("الرجاء اختيار مستخدم اولا ");
            }
          

        }

        private void txtUserNumber_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void txtUserNumber_TextChanged(object sender, EventArgs e)
        {
            

        }
    }
}
