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
    public partial class OTPForm : Form
    {
        public OTPForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void OTPForm_Load(object sender, EventArgs e)
        {
            txtmobile.Focus();
            txtmobile.MaxLength = 8;
        }

        private void txtmobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btncard_Click(object sender, EventArgs e)
        {
            if(txtmobile.Text.Length == 8)
            {
                //send the number to REST API getUserbyID
                //Get Response success "uuid" 
                //Open OTP Server Form
                ActivateForm actfrm = new ActivateForm();
                actfrm.Show();
                lblvalidate.Visible = false;
                this.Hide();
                

            }
            else
            {
                lblvalidate.Visible = true;
            }
        }
    }
}
