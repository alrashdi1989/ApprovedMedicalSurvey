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
        string status_desc;
        string status_code;

        //Call the method once phone number is valid
      
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
            Cursor.Current = Cursors.WaitCursor;

            //if (Services.UserServices.CheckIfUserISRegisterd("user/check/",txtmobile.Text).Count == 0)
            //{
            //    MessageBox.Show("الرقم المطلوب غير مسجل الرجاء التسجيل اولا....");
            //    txtmobile.Text = string.Empty;

            //    return;
            //}
            
            //OTPServiceRef.BulkPushSoapClient otpsrv = new OTPServiceRef.BulkPushSoapClient();
            //OTPServiceRef.SendStatus sendStatus = new OTPServiceRef.SendStatus();
            //sendStatus = otpsrv.SendSMS("", "", "message", 1, "", "", "", "", "55555555");

            //otpsrv.SendSMS("username", "password", "message", 1, "schedualedate","sender", "AppID", "sourceRef","MSISDN");


            //status_desc = sendStatus.StatusDesc;
            //status_code = sendStatus.StatusCode;
            //if (Services.UserServices.CheckIfUserISRegisterd("user/check/", txtmobile.Text).Count > 0)/*status_code == "00"*/
            //{
                if (txtmobile.Text.Length == 8)
                {
                    //send the number to REST API getUserbyID
                    //Get Response success "uuid" 
                    //Open OTP Server Form
                    Shared.GlobalVariables.UserName = txtmobile.Text;
                    ActivateForm actfrm = new ActivateForm();
                    actfrm.Show();
                    lblvalidate.Visible = false;
                    this.Hide();


                }
                else
                {
                    lblvalidate.Visible = true;
                }

                Cursor.Current = Cursors.Default;

            //}

        }

        private void txtmobile_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode==Keys.Enter )
            {
                btncard.PerformClick();
            }
        }
    }
}
