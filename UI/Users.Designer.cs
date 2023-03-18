
namespace ApprovedMedicalSurvey.UI
{
    partial class Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Users));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.checklist = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnNewUser = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cbUserRoles = new System.Windows.Forms.ComboBox();
            this.txtnumber = new System.Windows.Forms.TextBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.cbVillage = new System.Windows.Forms.ComboBox();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.cbVocalPoint = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.villageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgUsers);
            this.panel1.Location = new System.Drawing.Point(1, 158);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 388);
            this.panel1.TabIndex = 0;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgUsers.AutoGenerateColumns = false;
            this.dgUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checklist,
            this.usernameDataGridViewTextBoxColumn,
            this.roleDataGridViewTextBoxColumn,
            this.createdatDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.uuidDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgUsers.DataSource = this.usersBindingSource;
            this.dgUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgUsers.Location = new System.Drawing.Point(0, 0);
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgUsers.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgUsers.RowTemplate.Height = 32;
            this.dgUsers.Size = new System.Drawing.Size(1227, 388);
            this.dgUsers.TabIndex = 1;
            // 
            // checklist
            // 
            this.checklist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.checklist.FillWeight = 45.68528F;
            this.checklist.HeaderText = "";
            this.checklist.Name = "checklist";
            this.checklist.Width = 5;
            // 
            // btnNewUser
            // 
            this.btnNewUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNewUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnNewUser.ForeColor = System.Drawing.Color.Black;
            this.btnNewUser.Image = ((System.Drawing.Image)(resources.GetObject("btnNewUser.Image")));
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.Location = new System.Drawing.Point(1026, 9);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Size = new System.Drawing.Size(192, 54);
            this.btnNewUser.TabIndex = 1;
            this.btnNewUser.Text = "اضافة مستخدم جديد";
            this.btnNewUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNewUser.UseVisualStyleBackColor = true;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbUserRoles);
            this.panel2.Controls.Add(this.txtnumber);
            this.panel2.Controls.Add(this.cbStatus);
            this.panel2.Controls.Add(this.btnNewUser);
            this.panel2.Controls.Add(this.cbVillage);
            this.panel2.Controls.Add(this.btnUpdateUser);
            this.panel2.Controls.Add(this.cbVocalPoint);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 151);
            this.panel2.TabIndex = 2;
            // 
            // cbUserRoles
            // 
            this.cbUserRoles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUserRoles.BackColor = System.Drawing.Color.Gainsboro;
            this.cbUserRoles.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUserRoles.FormattingEnabled = true;
            this.cbUserRoles.Location = new System.Drawing.Point(708, 43);
            this.cbUserRoles.Name = "cbUserRoles";
            this.cbUserRoles.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbUserRoles.Size = new System.Drawing.Size(312, 29);
            this.cbUserRoles.TabIndex = 22;
            this.cbUserRoles.SelectedIndexChanged += new System.EventHandler(this.cbUserRoles_SelectedIndexChanged);
            // 
            // txtnumber
            // 
            this.txtnumber.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnumber.Location = new System.Drawing.Point(708, 11);
            this.txtnumber.Name = "txtnumber";
            this.txtnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnumber.Size = new System.Drawing.Size(312, 26);
            this.txtnumber.TabIndex = 21;
            this.txtnumber.Text = "رقم المستخدم...";
            this.txtnumber.TextChanged += new System.EventHandler(this.txtnumber_TextChanged);
            this.txtnumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtnumber_MouseDown);
            // 
            // cbStatus
            // 
            this.cbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbStatus.AutoSize = true;
            this.cbStatus.Checked = true;
            this.cbStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbStatus.Enabled = false;
            this.cbStatus.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStatus.ForeColor = System.Drawing.Color.Black;
            this.cbStatus.Location = new System.Drawing.Point(647, 13);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(55, 25);
            this.cbStatus.TabIndex = 20;
            this.cbStatus.Text = "فعال";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // cbVillage
            // 
            this.cbVillage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVillage.BackColor = System.Drawing.Color.Gainsboro;
            this.cbVillage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVillage.FormattingEnabled = true;
            this.cbVillage.Location = new System.Drawing.Point(20, 108);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbVillage.Size = new System.Drawing.Size(312, 29);
            this.cbVillage.TabIndex = 19;
            this.cbVillage.Visible = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateUser.Enabled = false;
            this.btnUpdateUser.FlatAppearance.BorderSize = 0;
            this.btnUpdateUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnUpdateUser.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateUser.Image")));
            this.btnUpdateUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateUser.Location = new System.Drawing.Point(424, 3);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(217, 54);
            this.btnUpdateUser.TabIndex = 2;
            this.btnUpdateUser.Text = "تحديث بيانات المستخدم";
            this.btnUpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // cbVocalPoint
            // 
            this.cbVocalPoint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbVocalPoint.BackColor = System.Drawing.Color.Gainsboro;
            this.cbVocalPoint.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVocalPoint.FormattingEnabled = true;
            this.cbVocalPoint.Location = new System.Drawing.Point(338, 108);
            this.cbVocalPoint.Name = "cbVocalPoint";
            this.cbVocalPoint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbVocalPoint.Size = new System.Drawing.Size(312, 29);
            this.cbVocalPoint.TabIndex = 17;
            this.cbVocalPoint.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1227, 151);
            this.panel3.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.usernameDataGridViewTextBoxColumn.HeaderText = "اسم المستخدم";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // roleDataGridViewTextBoxColumn
            // 
            this.roleDataGridViewTextBoxColumn.DataPropertyName = "role";
            this.roleDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.roleDataGridViewTextBoxColumn.HeaderText = "الصلاحيات";
            this.roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            // 
            // createdatDataGridViewTextBoxColumn
            // 
            this.createdatDataGridViewTextBoxColumn.DataPropertyName = "created_at";
            this.createdatDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.createdatDataGridViewTextBoxColumn.HeaderText = "تارخ التسجيل";
            this.createdatDataGridViewTextBoxColumn.Name = "createdatDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.statusDataGridViewTextBoxColumn.HeaderText = "الحاله";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // uuidDataGridViewTextBoxColumn
            // 
            this.uuidDataGridViewTextBoxColumn.DataPropertyName = "uuid";
            this.uuidDataGridViewTextBoxColumn.HeaderText = "uuid";
            this.uuidDataGridViewTextBoxColumn.Name = "uuidDataGridViewTextBoxColumn";
            this.uuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.FillWeight = 110.8629F;
            this.emailDataGridViewTextBoxColumn.HeaderText = "البريد الالكتروني";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(ApprovedMedicalSurvey.Models.Users);
            // 
            // villageBindingSource
            // 
            this.villageBindingSource.DataSource = typeof(ApprovedMedicalSurvey.Models.Village);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1228, 546);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Users";
            this.Text = "شاشة المستخدمين";
            this.Load += new System.EventHandler(this.Users_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.villageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewUser;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource villageBindingSource;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cbVillage;
        private System.Windows.Forms.ComboBox cbVocalPoint;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checklist;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtnumber;
        private System.Windows.Forms.ComboBox cbUserRoles;
    }
}