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
            FillingComboBoXWithData();

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

        private void FillingComboBoXWithData()
        {
            comboBox1.Items.Insert(0, "مسقط");
            comboBox1.Items.Insert(1, "جنوب الباطنة");
            comboBox1.Items.Insert(2, "شمال الباطنة");
            comboBox1.Items.Insert(3, "الوسطى");
            comboBox1.Items.Insert(4, "ظفار");
            comboBox1.Items.Insert(5, "مسندم");
            comboBox1.Items.Insert(6, "الشرقية شمال");
            comboBox1.Items.Insert(7, "الشرقية جنوب");
            comboBox1.Items.Insert(8, "البريمي");
            comboBox1.Items.Insert(9, "الظاهرة");
            comboBox1.Items.Insert(10, "ظفار");
            comboBox1.Items.Insert(11, "الداخلية");
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
