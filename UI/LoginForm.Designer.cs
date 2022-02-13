namespace ApprovedMedicalSurvey.UI
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlleft = new System.Windows.Forms.Panel();
            this.pctlogo = new System.Windows.Forms.PictureBox();
            this.btnuser = new System.Windows.Forms.Button();
            this.btncard = new System.Windows.Forms.Button();
            this.btnmobile = new System.Windows.Forms.Button();
            this.lblclose = new System.Windows.Forms.Label();
            this.pnluser = new System.Windows.Forms.Panel();
            this.lnkforget = new System.Windows.Forms.LinkLabel();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.pnlpassword = new System.Windows.Forms.Panel();
            this.pnlusername = new System.Windows.Forms.Panel();
            this.btnlogin = new System.Windows.Forms.Button();
            this.pnlcard = new System.Windows.Forms.Panel();
            this.pctcard = new System.Windows.Forms.PictureBox();
            this.lblcaption = new System.Windows.Forms.Label();
            this.btnlogincard = new System.Windows.Forms.Button();
            this.pnlmobile = new System.Windows.Forms.Panel();
            this.pnlmobilenum = new System.Windows.Forms.Panel();
            this.pctmobile = new System.Windows.Forms.PictureBox();
            this.txtmobile = new System.Windows.Forms.TextBox();
            this.btnloginmobile = new System.Windows.Forms.Button();
            this.pnlleft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).BeginInit();
            this.pnluser.SuspendLayout();
            this.pnlcard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctcard)).BeginInit();
            this.pnlmobile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctmobile)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlleft
            // 
            this.pnlleft.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlleft.Controls.Add(this.pctlogo);
            this.pnlleft.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlleft.Location = new System.Drawing.Point(519, 0);
            this.pnlleft.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlleft.Name = "pnlleft";
            this.pnlleft.Size = new System.Drawing.Size(274, 398);
            this.pnlleft.TabIndex = 0;
            // 
            // pctlogo
            // 
            this.pctlogo.Image = global::ApprovedMedicalSurvey.Properties.Resources.MOH_Logo;
            this.pctlogo.Location = new System.Drawing.Point(79, 24);
            this.pctlogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctlogo.Name = "pctlogo";
            this.pctlogo.Size = new System.Drawing.Size(135, 199);
            this.pctlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctlogo.TabIndex = 0;
            this.pctlogo.TabStop = false;
            // 
            // btnuser
            // 
            this.btnuser.BackColor = System.Drawing.Color.IndianRed;
            this.btnuser.FlatAppearance.BorderSize = 0;
            this.btnuser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnuser.ForeColor = System.Drawing.Color.White;
            this.btnuser.Location = new System.Drawing.Point(335, 66);
            this.btnuser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnuser.Name = "btnuser";
            this.btnuser.Size = new System.Drawing.Size(162, 37);
            this.btnuser.TabIndex = 1;
            this.btnuser.Text = "اسم المستخدم";
            this.btnuser.UseVisualStyleBackColor = false;
            this.btnuser.Click += new System.EventHandler(this.btnuser_Click);
            // 
            // btncard
            // 
            this.btncard.BackColor = System.Drawing.Color.Firebrick;
            this.btncard.FlatAppearance.BorderSize = 0;
            this.btncard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncard.ForeColor = System.Drawing.Color.White;
            this.btncard.Location = new System.Drawing.Point(171, 66);
            this.btncard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncard.Name = "btncard";
            this.btncard.Size = new System.Drawing.Size(162, 37);
            this.btncard.TabIndex = 1;
            this.btncard.Text = "البطاقة الذكية";
            this.btncard.UseVisualStyleBackColor = false;
            this.btncard.Click += new System.EventHandler(this.btncard_Click);
            // 
            // btnmobile
            // 
            this.btnmobile.BackColor = System.Drawing.Color.Firebrick;
            this.btnmobile.FlatAppearance.BorderSize = 0;
            this.btnmobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmobile.ForeColor = System.Drawing.Color.White;
            this.btnmobile.Location = new System.Drawing.Point(8, 66);
            this.btnmobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnmobile.Name = "btnmobile";
            this.btnmobile.Size = new System.Drawing.Size(162, 37);
            this.btnmobile.TabIndex = 1;
            this.btnmobile.Text = "رقم الموبايل";
            this.btnmobile.UseVisualStyleBackColor = false;
            this.btnmobile.Click += new System.EventHandler(this.btnmobile_Click);
            // 
            // lblclose
            // 
            this.lblclose.AutoSize = true;
            this.lblclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclose.ForeColor = System.Drawing.Color.Firebrick;
            this.lblclose.Location = new System.Drawing.Point(9, 7);
            this.lblclose.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(28, 26);
            this.lblclose.TabIndex = 2;
            this.lblclose.Text = "X";
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // pnluser
            // 
            this.pnluser.Controls.Add(this.lnkforget);
            this.pnluser.Controls.Add(this.txtpassword);
            this.pnluser.Controls.Add(this.txtusername);
            this.pnluser.Controls.Add(this.pnlpassword);
            this.pnluser.Controls.Add(this.pnlusername);
            this.pnluser.Controls.Add(this.btnlogin);
            this.pnluser.Location = new System.Drawing.Point(8, 107);
            this.pnluser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnluser.Name = "pnluser";
            this.pnluser.Size = new System.Drawing.Size(490, 216);
            this.pnluser.TabIndex = 3;
            // 
            // lnkforget
            // 
            this.lnkforget.AutoSize = true;
            this.lnkforget.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkforget.LinkColor = System.Drawing.Color.Firebrick;
            this.lnkforget.Location = new System.Drawing.Point(94, 150);
            this.lnkforget.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lnkforget.Name = "lnkforget";
            this.lnkforget.Size = new System.Drawing.Size(101, 20);
            this.lnkforget.TabIndex = 2;
            this.lnkforget.TabStop = true;
            this.lnkforget.Text = "نسيت كلمة المرور";
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.White;
            this.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.Black;
            this.txtpassword.Location = new System.Drawing.Point(98, 91);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtpassword.Size = new System.Drawing.Size(262, 25);
            this.txtpassword.TabIndex = 1;
            // 
            // txtusername
            // 
            this.txtusername.BackColor = System.Drawing.Color.White;
            this.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.Black;
            this.txtusername.Location = new System.Drawing.Point(98, 24);
            this.txtusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtusername.Name = "txtusername";
            this.txtusername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtusername.Size = new System.Drawing.Size(262, 25);
            this.txtusername.TabIndex = 1;
            // 
            // pnlpassword
            // 
            this.pnlpassword.BackColor = System.Drawing.Color.Firebrick;
            this.pnlpassword.Location = new System.Drawing.Point(98, 121);
            this.pnlpassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlpassword.Name = "pnlpassword";
            this.pnlpassword.Size = new System.Drawing.Size(262, 2);
            this.pnlpassword.TabIndex = 0;
            // 
            // pnlusername
            // 
            this.pnlusername.BackColor = System.Drawing.Color.Firebrick;
            this.pnlusername.Location = new System.Drawing.Point(98, 55);
            this.pnlusername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlusername.Name = "pnlusername";
            this.pnlusername.Size = new System.Drawing.Size(262, 2);
            this.pnlusername.TabIndex = 0;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Firebrick;
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(263, 133);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(97, 37);
            this.btnlogin.TabIndex = 1;
            this.btnlogin.Text = "دخول";
            this.btnlogin.UseVisualStyleBackColor = false;
            // 
            // pnlcard
            // 
            this.pnlcard.Controls.Add(this.pctcard);
            this.pnlcard.Controls.Add(this.lblcaption);
            this.pnlcard.Controls.Add(this.btnlogincard);
            this.pnlcard.Location = new System.Drawing.Point(8, 107);
            this.pnlcard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlcard.Name = "pnlcard";
            this.pnlcard.Size = new System.Drawing.Size(490, 216);
            this.pnlcard.TabIndex = 4;
            this.pnlcard.Visible = false;
            // 
            // pctcard
            // 
            this.pctcard.Image = global::ApprovedMedicalSurvey.Properties.Resources.card1;
            this.pctcard.Location = new System.Drawing.Point(326, 43);
            this.pctcard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctcard.Name = "pctcard";
            this.pctcard.Size = new System.Drawing.Size(147, 126);
            this.pctcard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctcard.TabIndex = 2;
            this.pctcard.TabStop = false;
            // 
            // lblcaption
            // 
            this.lblcaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaption.ForeColor = System.Drawing.Color.Firebrick;
            this.lblcaption.Location = new System.Drawing.Point(30, 43);
            this.lblcaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcaption.Name = "lblcaption";
            this.lblcaption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcaption.Size = new System.Drawing.Size(255, 72);
            this.lblcaption.TabIndex = 1;
            this.lblcaption.Text = "لاستخدام طريقة تسجيل الدخول هذه  تحتاج إلى البطاقة المدنية وقارئ البطاقة";
            // 
            // btnlogincard
            // 
            this.btnlogincard.BackColor = System.Drawing.Color.Firebrick;
            this.btnlogincard.FlatAppearance.BorderSize = 0;
            this.btnlogincard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogincard.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogincard.ForeColor = System.Drawing.Color.White;
            this.btnlogincard.Location = new System.Drawing.Point(108, 117);
            this.btnlogincard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnlogincard.Name = "btnlogincard";
            this.btnlogincard.Size = new System.Drawing.Size(104, 39);
            this.btnlogincard.TabIndex = 1;
            this.btnlogincard.Text = "إدخال";
            this.btnlogincard.UseVisualStyleBackColor = false;
            // 
            // pnlmobile
            // 
            this.pnlmobile.Controls.Add(this.pnlmobilenum);
            this.pnlmobile.Controls.Add(this.pctmobile);
            this.pnlmobile.Controls.Add(this.txtmobile);
            this.pnlmobile.Controls.Add(this.btnloginmobile);
            this.pnlmobile.Location = new System.Drawing.Point(8, 107);
            this.pnlmobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlmobile.Name = "pnlmobile";
            this.pnlmobile.Size = new System.Drawing.Size(490, 216);
            this.pnlmobile.TabIndex = 5;
            this.pnlmobile.Visible = false;
            // 
            // pnlmobilenum
            // 
            this.pnlmobilenum.BackColor = System.Drawing.Color.Firebrick;
            this.pnlmobilenum.Location = new System.Drawing.Point(67, 93);
            this.pnlmobilenum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlmobilenum.Name = "pnlmobilenum";
            this.pnlmobilenum.Size = new System.Drawing.Size(259, 2);
            this.pnlmobilenum.TabIndex = 2;
            // 
            // pctmobile
            // 
            this.pctmobile.Image = global::ApprovedMedicalSurvey.Properties.Resources.mobile;
            this.pctmobile.Location = new System.Drawing.Point(352, 35);
            this.pctmobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pctmobile.Name = "pctmobile";
            this.pctmobile.Size = new System.Drawing.Size(92, 121);
            this.pctmobile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctmobile.TabIndex = 1;
            this.pctmobile.TabStop = false;
            // 
            // txtmobile
            // 
            this.txtmobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmobile.Location = new System.Drawing.Point(67, 62);
            this.txtmobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmobile.Name = "txtmobile";
            this.txtmobile.Size = new System.Drawing.Size(259, 25);
            this.txtmobile.TabIndex = 0;
            // 
            // btnloginmobile
            // 
            this.btnloginmobile.BackColor = System.Drawing.Color.Firebrick;
            this.btnloginmobile.FlatAppearance.BorderSize = 0;
            this.btnloginmobile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloginmobile.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnloginmobile.ForeColor = System.Drawing.Color.White;
            this.btnloginmobile.Location = new System.Drawing.Point(142, 109);
            this.btnloginmobile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnloginmobile.Name = "btnloginmobile";
            this.btnloginmobile.Size = new System.Drawing.Size(104, 39);
            this.btnloginmobile.TabIndex = 1;
            this.btnloginmobile.Text = "إدخال";
            this.btnloginmobile.UseVisualStyleBackColor = false;
            this.btnloginmobile.Click += new System.EventHandler(this.btnloginmobile_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(793, 398);
            this.Controls.Add(this.pnlmobile);
            this.Controls.Add(this.pnlcard);
            this.Controls.Add(this.pnluser);
            this.Controls.Add(this.lblclose);
            this.Controls.Add(this.btnmobile);
            this.Controls.Add(this.btncard);
            this.Controls.Add(this.btnuser);
            this.Controls.Add(this.pnlleft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm2";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.pnlleft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctlogo)).EndInit();
            this.pnluser.ResumeLayout(false);
            this.pnluser.PerformLayout();
            this.pnlcard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctcard)).EndInit();
            this.pnlmobile.ResumeLayout(false);
            this.pnlmobile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctmobile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlleft;
        private System.Windows.Forms.Button btnuser;
        private System.Windows.Forms.Button btncard;
        private System.Windows.Forms.Button btnmobile;
        private System.Windows.Forms.Label lblclose;
        private System.Windows.Forms.Panel pnluser;
        private System.Windows.Forms.PictureBox pctlogo;
        private System.Windows.Forms.Panel pnlusername;
        private System.Windows.Forms.Panel pnlpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.LinkLabel lnkforget;
        private System.Windows.Forms.Panel pnlcard;
        private System.Windows.Forms.Label lblcaption;
        private System.Windows.Forms.Panel pnlmobile;
        private System.Windows.Forms.PictureBox pctmobile;
        private System.Windows.Forms.TextBox txtmobile;
        private System.Windows.Forms.Button btnloginmobile;
        private System.Windows.Forms.Panel pnlmobilenum;
        private System.Windows.Forms.PictureBox pctcard;
        private System.Windows.Forms.Button btnlogincard;
    }
}