using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApprovedMedicalSurvey.UI
{
    public partial class FlatLightTheme : Form
    {
        public FlatLightTheme()
        {
            InitializeComponent();
        }

        private void close(object sender, EventArgs e)
        {
            Close();

        }

        private void FlatDarkTheme_Load(object sender, EventArgs e)
        {
            Scans f = new Scans();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
        }

        private void lookUpEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DisposeAllButThis(Form form)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == form.GetType()
                    && frm != form)
                {
                    frm.Dispose();
                    frm.Close();
                }
            }
        }

        private void btnScans_Click(object sender, EventArgs e)
        {
            Scans f = new Scans();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            label2.Text = f.Text;
            DisposeAllButThis(f);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            Reports f = new Reports();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            label2.Text = f.Text;

            DisposeAllButThis(f);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            Users f = new Users();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            label2.Text = f.Text;

            DisposeAllButThis(f);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            SingingOut();
        }

        private void SingingOut()
        {
            DialogResult dr = MessageBox.Show("هل تود تسجيل الخروج من النظام؟", "تسجيل الخروج", MessageBoxButtons.YesNo,
      MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SingingOut();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState== FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}