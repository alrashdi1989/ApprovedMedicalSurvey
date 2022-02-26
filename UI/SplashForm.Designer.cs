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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.lblcaption = new System.Windows.Forms.Label();
            this.lblloading = new System.Windows.Forms.Label();
            this.tmrloading = new System.Windows.Forms.Timer(this.components);
            this.prgbarloading = new CircularProgressBar.CircularProgressBar();
            this.pctmohlogo = new System.Windows.Forms.PictureBox();
            this.pctwhologo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctmohlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctwhologo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblcaption
            // 
            this.lblcaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcaption.ForeColor = System.Drawing.Color.Firebrick;
            this.lblcaption.Location = new System.Drawing.Point(48, 7);
            this.lblcaption.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblcaption.Name = "lblcaption";
            this.lblcaption.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcaption.Size = new System.Drawing.Size(213, 67);
            this.lblcaption.TabIndex = 0;
            this.lblcaption.Text = "تطبيق المسح الصحي الشامل متعدد المؤشرات";
            // 
            // lblloading
            // 
            this.lblloading.AutoSize = true;
            this.lblloading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloading.ForeColor = System.Drawing.Color.Firebrick;
            this.lblloading.Location = new System.Drawing.Point(80, 471);
            this.lblloading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblloading.Name = "lblloading";
            this.lblloading.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblloading.Size = new System.Drawing.Size(197, 29);
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
            this.prgbarloading.Location = new System.Drawing.Point(98, 318);
            this.prgbarloading.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.prgbarloading.MarqueeAnimationSpeed = 2000;
            this.prgbarloading.Name = "prgbarloading";
            this.prgbarloading.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.prgbarloading.OuterMargin = -25;
            this.prgbarloading.OuterWidth = 26;
            this.prgbarloading.ProgressColor = System.Drawing.Color.Firebrick;
            this.prgbarloading.ProgressWidth = 7;
            this.prgbarloading.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.prgbarloading.Size = new System.Drawing.Size(152, 144);
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
            // pctmohlogo
            // 
            this.pctmohlogo.Image = global::ApprovedMedicalSurvey.Properties.Resources.MOH_Logo;
            this.pctmohlogo.Location = new System.Drawing.Point(198, 102);
            this.pctmohlogo.Margin = new System.Windows.Forms.Padding(2);
            this.pctmohlogo.Name = "pctmohlogo";
            this.pctmohlogo.Size = new System.Drawing.Size(129, 194);
            this.pctmohlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctmohlogo.TabIndex = 3;
            this.pctmohlogo.TabStop = false;
            // 
            // pctwhologo
            // 
            this.pctwhologo.Image = ((System.Drawing.Image)(resources.GetObject("pctwhologo.Image")));
            this.pctwhologo.Location = new System.Drawing.Point(23, 102);
            this.pctwhologo.Margin = new System.Windows.Forms.Padding(2);
            this.pctwhologo.Name = "pctwhologo";
            this.pctwhologo.Size = new System.Drawing.Size(129, 194);
            this.pctwhologo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctwhologo.TabIndex = 2;
            this.pctwhologo.TabStop = false;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(357, 517);
            this.Controls.Add(this.prgbarloading);
            this.Controls.Add(this.lblloading);
            this.Controls.Add(this.pctmohlogo);
            this.Controls.Add(this.pctwhologo);
            this.Controls.Add(this.lblcaption);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSplash";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm2";
            ((System.ComponentModel.ISupportInitialize)(this.pctmohlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctwhologo)).EndInit();
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