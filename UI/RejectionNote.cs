using ApprovedMedicalSurvey.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class RejectionNote : Form
    {
        public RejectionNote()
        {
            InitializeComponent();
        }

        private void btnRejected_Click(object sender, EventArgs e)
        {
            string getData = GlobalVariables.SurveyID + "/rejected";

            string URL = "https://gql.formon.io/api/rest/survey/status/" + getData;
            var data = webGetMethod(URL);
            MessageBox.Show("تم رفض  الاستبيان");
            this.Close();
        }

        public string webGetMethod(string URL)
        {
            string jsonString = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "GET";

            WebResponse response = request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());
            jsonString = sr.ReadToEnd();
            sr.Close();
            return jsonString;


        }

    }
}
