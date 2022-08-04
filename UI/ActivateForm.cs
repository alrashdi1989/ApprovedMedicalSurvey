using ApprovedMedicalSurvey.Shared;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
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
            var login =    await Services.UserLogIn.LogIn(Shared.GlobalVariables.Mobile.ToString(), Shared.GlobalVariables.Password);
            var handler = new JwtSecurityTokenHandler();
            var jsonToken = handler.ReadToken(login);
            var tokenS = jsonToken as JwtSecurityToken;
            string  jti = tokenS.Claims.First(claim => claim.Type == "https://hasura.io/jwt/claims").Value;
            var data = (JObject)JsonConvert.DeserializeObject(jti);//convert to JObject
            GlobalVariables.UserRole = data["x-hasura-default-role"].ToString();  //get the property value...
            GlobalVariables.Uuid = data["X-Hasura-User-Uuid"].ToString();  //get the property value...

            if (login != null     )
            {
              
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
