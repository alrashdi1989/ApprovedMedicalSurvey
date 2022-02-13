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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnuser_Click(object sender, EventArgs e)
        {
            try
            {
                pnlpassword.Visible = true;
                btnuser.BackColor = Color.IndianRed;
                btnmobile.BackColor = Color.Firebrick;
                btncard.BackColor = Color.Firebrick;

                pnlcard.Visible = false;
                pnlmobile.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
          
        }

        private void btncard_Click(object sender, EventArgs e)
        {
            try
            {
                pnlcard.Visible = true;
                btncard.BackColor = Color.IndianRed;
                btnuser.BackColor = Color.Firebrick;
                btnmobile.BackColor = Color.Firebrick;

                pnlmobile.Visible = false;
                pnlpassword.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnmobile_Click(object sender, EventArgs e)
        {
            try
            {
                pnlmobile.Visible = true;
                btnmobile.BackColor = Color.IndianRed;
                btnuser.BackColor = Color.Firebrick;
                btncard.BackColor = Color.Firebrick;

                pnlcard.Visible = false;
                pnlpassword.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnloginmobile_Click(object sender, EventArgs e)
        {
            FlatLightTheme form = new FlatLightTheme();
            form.Show();
        }
    }
}
