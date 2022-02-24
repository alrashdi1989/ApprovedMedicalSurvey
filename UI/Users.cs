using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
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
        public Users()
        {
            InitializeComponent();
        }

       
        private void Users_Load(object sender, EventArgs e)
        {
            FillingTheGridWithData();

        }

      
        private void FillingTheGridWithData()
        {
          usersBindingSource.DataSource=  UserServices.GetAllUsers("users");
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

    }
}
