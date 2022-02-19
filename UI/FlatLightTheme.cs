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

        private void FlatDarkTheme_Load(object sender, EventArgs e)
        {
            Scans f = new Scans();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
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


      

        private void SingingOut()
        {
            DialogResult dr = MessageBox.Show("هل تود تسجيل الخروج من النظام؟", "تسجيل الخروج", MessageBoxButtons.YesNo,
      MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                this.Close();
            }
        }
        

       


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Scans f = new Scans();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            DisposeAllButThis(f);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Reports f = new Reports();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            DisposeAllButThis(f);
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Users f = new Users();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            DisposeAllButThis(f);
        }

        private void SingingOut(object sender, EventArgs e)
        {
            SingingOut();

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            SingingOut();
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}