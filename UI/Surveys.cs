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
    public partial class Surveys : Form
    {
        public Surveys()
        {
            InitializeComponent();
        }

        private void FillingTheGridWithData()
        {
            //dataGridView1.Rows.Add("مهنا حمدان خليفة المعولي", "ذكر", "55", "الأب", "متزوج","ابتدائي","يعمل");
            //dataGridView1.Rows.Add("مهنا حمدان خليفة المعولي", "ذكر", "55", "الأب", "متزوج", "ابتدائي", "يعمل");
            //dataGridView1.Rows.Add("مهنا حمدان خليفة المعولي", "ذكر", "55", "الأب", "متزوج", "ابتدائي", "يعمل");
            //dataGridView1.Rows.Add("مهنا حمدان خليفة المعولي", "ذكر", "55", "الأب", "متزوج", "ابتدائي", "يعمل");
            //dataGridView1.Rows.Add("مهنا حمدان خليفة المعولي", "ذكر", "55", "الأب", "متزوج", "ابتدائي", "يعمل");
            //dataGridView1.Rows.Add("مهنا حمدان خليفة المعولي", "ذكر", "55", "الأب", "متزوج", "ابتدائي", "يعمل");
            //dataGridView1.Rows.Add("مهنا حمدان خليفة المعولي", "ذكر", "55", "الأب", "متزوج", "ابتدائي", "يعمل");

            //dataGridView1.ClearSelection();
        }

        private void Surveys_Load(object sender, EventArgs e)
        {
            FillingTheGridWithData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Scans f = new Scans();
            f.MdiParent = this.ParentForm ;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

      
    }
}
