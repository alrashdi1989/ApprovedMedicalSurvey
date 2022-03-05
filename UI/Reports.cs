using ApprovedMedicalSurvey.Models;
using ApprovedMedicalSurvey.Services;
using ApprovedMedicalSurvey.Shared;
using Microsoft.Office.Interop.Excel;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //exporting data source to excel sheet 
            Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            //binding data to combo boxes 
            UserReports();

            Villages();
        }

        private void UserReports()
        {
            var dt = ReportServices.GetReports();
            dt.Insert(0, new Models.Reports
            {
                ReportName = "اختر نو التقرير..."
            });
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "ReportName";
            comboBox1.ValueMember = "ReportName";
        }

        private void Villages()
        {
            if (comboBox2.Text != "اختر الولاية...")


            {

                var dt = VillageServices.GetAllVIllages("villages");
                dt.Insert(0, new Village
                {
                    name_ar = "اختر القرية..."
                });
                comboBox2.DataSource = dt;
                comboBox2.DisplayMember = "name_ar";
                comboBox2.ValueMember = "tncode";

            }




        }

    }
}
