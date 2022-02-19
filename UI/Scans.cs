using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Shared;
using DevExpress.Utils.Extensions;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{ 
    public partial class Scans : Form
    {
        public Scans()
        {
            InitializeComponent();
        }

        private void Scans_Load(object sender, EventArgs e)
        {
            Governance();
        }

        private void Governance()
        {
          
        }
        private void States()
        {
           

        }

        private void Villages()
        {
            
            }


     

      

        private async void btnShowResults_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Surveys f = new Surveys();
            f.MdiParent = this.ParentForm;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
            States();
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {
           
        }

        private void lookUpEdit2_EditValueChanged(object sender, EventArgs e)
        {
            Villages();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
