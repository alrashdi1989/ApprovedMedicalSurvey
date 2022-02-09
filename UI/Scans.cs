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
    public partial class Scans : Form
    {
        public Scans()
        {
            InitializeComponent();
        }

        private void Scans_Load(object sender, EventArgs e)
        {
                dataGridView1.Rows.Add("1457","دغمر","11457","حمدان بن محمد الخروصي","28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.Rows.Add("1457", "دغمر", "11457", "حمدان بن محمد الخروصي", "28-01-2022");
            dataGridView1.ClearSelection();
        }

        private void btnShowResults_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Surveys f = new Surveys();
            f.MdiParent = this.ParentForm;
            f.Show();
            f.Dock = DockStyle.Fill;
        }
    }
}
