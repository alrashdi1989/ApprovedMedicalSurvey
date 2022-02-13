namespace ApprovedMedicalSurvey.UI
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.lblcaption = new System.Windows.Forms.Label();
            this.pctwhologo = new System.Windows.Forms.PictureBox();
            this.pctmohlogo = new System.Windows.Forms.PictureBox();
            this.lblloading = new System.Windows.Forms.Label();
            this.tmrloading = new System.Windows.Forms.Timer(this.components);
            this.prgbarloading = new CircularProgressBar.CircularProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.pctwhologo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctmohlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcaption
            // 
            this.lblcaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaption.ForeColor = System.Drawing.Color.Firebrick;
            this.lblcaption.Location = new System.Drawing.Point(64, 9);
            this.lblcaption.Name = "lblcaption";
            this.lblcaption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcaption.Size = new System.Drawing.Size(284, 82);
            this.lblcaption.TabIndex = 0;
            this.lblcaption.Text = "تطبيق المسح الصحي الشامل متعدد المؤشرات";
            // 
            // pctwhologo
            // 
            this.pctwhologo.Image = global::ApprovedMedicalSurvey.Properties.Resources.who;
            this.pctwhologo.Location = new System.Drawing.Point(31, 126);
            this.pctwhologo.Name = "pctwhologo";
            this.pctwhologo.Size = new System.Drawing.Size(172, 239);
            this.pctwhologo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctwhologo.TabIndex = 2;
            this.pctwhologo.TabStop = false;
            // 
            // pctmohlogo
            // 
            this.pctmohlogo.Image = global::ApprovedMedicalSurvey.Properties.Resources.MOH_Logo;
            this.pctmohlogo.Location = new System.Drawing.Point(264, 126);
            this.pctmohlogo.Name = "pctmohlogo";
            this.pctmohlogo.Size = new System.Drawing.Size(172, 239);
            this.pctmohlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctmohlogo.TabIndex = 3;
            this.pctmohlogo.TabStop = false;
            // 
            // lblloading
            // 
            this.lblloading.AutoSize = true;
            this.lblloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloading.ForeColor = System.Drawing.Color.Firebrick;
            this.lblloading.Location = new System.Drawing.Point(106, 580);
            this.lblloading.Name = "lblloading";
            this.lblloading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblloading.Size = new System.Drawing.Size(245, 36);
            this.lblloading.TabIndex = 5;
            this.lblloading.Text = "جاري تحميل البرنامج...";
            // 
            // tmrloading
            // 
            this.tmrloading.Enabled = true;
            this.tmrloading.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // prgbarloading
            // 
            this.prgbarloading.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.prgbarloading.AnimationSpeed = 500;
            this.prgbarloading.BackColor = System.Drawing.Color.Transparent;
            this.prgbarloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prgbarloading.ForeColor = System.Drawing.Color.Firebrick;
            this.prgbarloading.InnerColor = System.Drawing.Color.WhiteSmoke;
            this.prgbarloading.InnerMargin = 2;
            this.prgbarloading.InnerWidth = -1;
            this.prgbarloading.Location = new System.Drawing.Point(131, 391);
            this.prgbarloading.MarqueeAnimationSpeed = 2000;
            this.prgbarloading.Name = "prgbarloading";
            this.prgbarloading.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.prgbarloading.OuterMargin = -25;
            this.prgbarloading.OuterWidth = 26;
            this.prgbarloading.ProgressColor = System.Drawing.Color.Firebrick;
            this.prgbarloading.ProgressWidth = 7;
            this.prgbarloading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.prgbarloading.Size = new System.Drawing.Size(203, 177);
            this.prgbarloading.StartAngle = 270;
            this.prgbarloading.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgbarloading.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prgbarloading.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.prgbarloading.SubscriptText = "";
            this.prgbarloading.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.prgbarloading.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.prgbarloading.SuperscriptText = "";
            this.prgbarloading.TabIndex = 6;
            this.prgbarloading.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.prgbarloading.Value = 68;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(476, 636);
            this.Controls.Add(this.prgbarloading);
            this.Controls.Add(this.lblloading);
            this.Controls.Add(this.pctmohlogo);
            this.Controls.Add(this.pctwhologo);
            this.Controls.Add(this.lblcaption);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm2";
            ((System.ComponentModel.ISupportInitialize)(this.pctwhologo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctmohlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcaption;
        private System.Windows.Forms.PictureBox pctwhologo;
        private System.Windows.Forms.PictureBox pctmohlogo;
        private System.Windows.Forms.Label lblloading;
        private System.Windows.Forms.Timer tmrloading;
        private CircularProgressBar.CircularProgressBar prgbarloading;
    }
}