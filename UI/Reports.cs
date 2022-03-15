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
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }


        string tCode;
        string sCode;
        string gCode;
        string reportCode;
        private void button2_Click(object sender, EventArgs e)
        {
           
        }
        private void copyAlltoClipboard()
        {
            dgReports.SelectAll();
            DataObject dataObj = dgReports.GetClipboardContent();
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
            for (int j = 0; j < dgReports.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dgReports.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dgReports.Rows.Count; i++)
            {
                for (int j = 0; j < dgReports.Columns.Count; j++)
                {

                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dgReports[j, i].Value == null ? "" : dgReports[j, i].Value;
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
                reportName = "اختر نوع التقرير..."
            });
            cmReportType.DataSource = dt;
            cmReportType.DisplayMember = "ReportName";
            cmReportType.ValueMember = "reportID";
        }

        private void Villages()
        {
            if (cmTown.Text != "اختر الولاية...")


            {

                var dt = VillageServices.GetAllVIllages("villages");
                dt.Insert(0, new Village
                {
                    name_ar = "اختر القرية..."
                });
                cmTown.DataSource = dt;
                cmTown.DisplayMember = "name_ar";
                cmTown.ValueMember = "tncode";

            }




        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            resultBindingSource.DataSource= ReportServices.GetAllReports("report/"+tCode+"/"+sCode+"/"+gCode+"/"+reportCode+"");
            Cursor.Current = Cursors.Default;

        }

        private void cmTown_SelectedIndexChanged(object sender, EventArgs e)
        {
            tCode = cmTown.SelectedValue.ToString();
            sCode= tCode.Substring(0, 4);
           gCode= tCode.Substring(0, 2);
        }

        private void cmReportType_SelectedIndexChanged(object sender, EventArgs e)
        {
            reportCode = cmReportType.SelectedValue.ToString();
        }
    }
}
