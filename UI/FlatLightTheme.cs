using ApprovedMedicalSurvey.Shared;
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
        public static FlatLightTheme flatLightTheme;
        public Label lbl;
        public FlatLightTheme()
        {
            InitializeComponent();
            flatLightTheme = this;
            lbl = lblScreenName;
        }

        private void FlatDarkTheme_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Scans f = new Scans();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;

            GlobalVariables.FormName = f.Text;
            lblScreenName.Text = GlobalVariables.FormName;
            Cursor.Current = Cursors.Default;
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
                DisposeAllButThis(this);
                this.Close();
                OTPForm frm = new OTPForm();
                frm.Show();
               
            }
        }
        

       


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Scans f = new Scans();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            GlobalVariables.FormName = f.Text;
            lblScreenName.Text = GlobalVariables.FormName;

            DisposeAllButThis(f);
            Cursor.Current = Cursors.Default;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Reports f = new Reports();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            GlobalVariables.FormName = f.Text;
            lblScreenName.Text = GlobalVariables.FormName;

            DisposeAllButThis(f);
            Cursor.Current = Cursors.Default;

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Users f = new Users();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            GlobalVariables.FormName = f.Text;
            lblScreenName.Text = GlobalVariables.FormName;


            DisposeAllButThis(f);
            Cursor.Current = Cursors.Default;

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

        private void pbLogOut_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Buildings f = new Buildings();
            f.MdiParent = this;
            f.Show();
            f.Dock = DockStyle.Fill;
            GlobalVariables.FormName = f.Text;
            lblScreenName.Text = GlobalVariables.FormName;


            DisposeAllButThis(f);
            Cursor.Current = Cursors.Default;
        }
    }
}