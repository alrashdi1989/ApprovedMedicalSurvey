using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using ApprovedMedicalSurvey.Shared;
using DevExpress.Utils.Extensions;
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
            governorateBindingSource.DataSource = GovernantesServices.GetAllGovernorate("governorates");
        }
        private void States()
        {
            willayatBindingSource.DataSource = WillayatServices.GetAllWillayatbyId("willayat", lookUpEdit1.EditValue.ToString());


        }

        private void Villages()
        {

            villageBindingSource.DataSource = VillageServices.GetAllVIllagesbyStateID("villages", lookUpEdit2.EditValue.ToString());


        }






        private void btnShowResults_Click(object sender, EventArgs e)
        {
          
            try
            {
                dataGridView1.Rows.Clear();
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");
                dataGridView1.Rows.Add("1234", "5457", lookUpEdit3.Text, "28-09-2022", "سامح محمد", "جديد");

                dataGridView1.ClearSelection();

                 surveysBindingSource.DataSource = SurveyServices.GetAllSurveys("surveys");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }


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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                if (dataGridView1.CurrentCell != null && dataGridView1.CurrentCell.Value != null)
                {
                    Surveys f = new Surveys();
                    f.MdiParent = this.ParentForm;
                    f.Show();
                    f.Dock = DockStyle.Fill;
                }
            }
        }
    }
}
