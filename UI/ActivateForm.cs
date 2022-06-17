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
    public partial class ActivateForm : Form
    {
        public ActivateForm()
        {
            InitializeComponent();
        }

        private void ActivateForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox3.Focus();   
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox4.Focus();
        }

        private async void btncard_Click(object sender, EventArgs e)
        {
           GlobalVariables.Password = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text;
            if (GlobalVariables.OTP.ToString() == GlobalVariables.Password)
            {
                await Services.UserLogIn.LogIn(Shared.GlobalVariables.UserName, Shared.GlobalVariables.Password);
                FlatLightTheme mainform = new FlatLightTheme();
                mainform.Show();
            }

            else
            {
                MessageBox.Show("الرجاء التحقق من رمز ال OTP");
            }
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OTPForm otpfrm= new OTPForm();
            otpfrm.Show();
            clearOTPData(); 
            this.Hide();
        }

        private void clearOTPData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }

        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btncard.PerformClick();
            }
        }
    }
}
