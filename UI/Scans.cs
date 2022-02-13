using ApprovedMedicalSurvey.Shared;
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
            FillingTheGridWithData();
            Governance();
        }

        private void Governance()
        {
            List<Govenance> govenance = new List<Govenance>();
            govenance.Add(new Govenance { Id = 1, Name = "محافظة الداخلية" });
            govenance.Add(new Govenance { Id = 2, Name = "محافظة الظاهرة" });
            govenance.Add(new Govenance { Id = 3, Name = "محافظة شمال الباطنة" });
            govenance.Add(new Govenance { Id = 4, Name = "محافظة جنوب الباطنة" });
            govenance.Add(new Govenance { Id = 5, Name = "محافظة البريمي" });
            govenance.Add(new Govenance { Id = 6, Name = "محافظة الوسطى" });
            govenance.Add(new Govenance { Id = 7, Name = "محافظة شمال الشرقية" });
            govenance.Add(new Govenance { Id = 8, Name = "محافظة جنوب الشرقية" });
            govenance.Add(new Govenance { Id = 9, Name = "محافظة ظفار" });
            govenance.Add(new Govenance { Id = 10, Name = "محافظة مسقط" });
            govenance.Add(new Govenance { Id = 11, Name = "محافظة مسندم" });
            govenanceBindingSource.DataSource = govenance;
        }
        private void States()
        {
            List<States> States = new List<States>();
            States.Add(new States { id = 1, name = "مسقط", govenanceID=10});
            States.Add(new States { id = 2, name = "ولاية بوشر", govenanceID = 10 });
            States.Add(new States { id = 3, name = "ولاية السيب", govenanceID = 10 });
            States.Add(new States { id = 4, name = "ولاية العامرات", govenanceID = 10 });
            States.Add(new States { id = 5, name = "ولاية قريات", govenanceID = 10 });

            statesBindingSource.DataSource = States.Where(c=> c.govenanceID == Convert.ToInt32( lookUpEdit1.EditValue));
        }

        private void Villages()
        {
            List<VIllages> villages = new List<VIllages>();
            villages.Add(new VIllages { id = 1, name = "بلدة السيفة", StateID = 1 });
            villages.Add(new VIllages { id = 2, name = "قرية حرامل", StateID = 1 });
            villages.Add(new VIllages { id = 3, name = "حلة التكية", StateID = 1 });
            villages.Add(new VIllages { id = 4, name = "حلة المدبغة", StateID = 1 });
            villages.Add(new VIllages { id = 5, name = "قرية سداب", StateID = 1 });
            villages.Add(new VIllages { id = 6, name = "حلة النعم", StateID = 1 });
            villages.Add(new VIllages { id = 6, name = "حلتي الدلاليل والبصرة", StateID = 1 });
            vIllagesBindingSource.DataSource = villages.Where(c => c.StateID == Convert.ToInt32(lookUpEdit2.EditValue));
            }


        private void FillingTheGridWithData()
        {
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
    }
}
