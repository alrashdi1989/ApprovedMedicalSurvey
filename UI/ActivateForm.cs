﻿using System;
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

        private void btncard_Click(object sender, EventArgs e)
        {
            // Check OTP code
            // load Main Form
            //MessageBox.Show("مستخدم صحسيحّ");

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
    }
}
