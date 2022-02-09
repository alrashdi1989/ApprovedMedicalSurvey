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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void FillingTheGridWithData()
        {
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");
            dataGridView1.Rows.Add("abdul1989", "مستخدم", "المركز", "الخوض", "28-01-2022", "28-01-2022");

            dataGridView1.ClearSelection();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            FillingTheGridWithData();

        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            AddUser f = new AddUser();
            f.ShowDialog();
        }
    }
}
