﻿
namespace ApprovedMedicalSurvey.UI
{
    partial class AllBuildings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbGovernance = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtScanDate = new System.Windows.Forms.DateTimePicker();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbVillage = new System.Windows.Forms.ComboBox();
            this.txtScanNumbers = new System.Windows.Forms.TextBox();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgScans = new System.Windows.Forms.DataGridView();
            this.allBuildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cbUsers = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.addBuilding = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.multiusers = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.uuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcoardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ycoardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.govcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bldtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.willcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgScans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBuildingsBindingSource)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbGovernance);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Location = new System.Drawing.Point(1484, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(341, 81);
            this.panel1.TabIndex = 0;
            // 
            // cbGovernance
            // 
            this.cbGovernance.BackColor = System.Drawing.Color.Gainsboro;
            this.cbGovernance.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbGovernance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGovernance.FormattingEnabled = true;
            this.cbGovernance.Location = new System.Drawing.Point(0, 0);
            this.cbGovernance.Name = "cbGovernance";
            this.cbGovernance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbGovernance.Size = new System.Drawing.Size(341, 29);
            this.cbGovernance.TabIndex = 1000002;
            this.cbGovernance.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtUser
            // 
            this.txtUser.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(0, 52);
            this.txtUser.Name = "txtUser";
            this.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUser.Size = new System.Drawing.Size(341, 29);
            this.txtUser.TabIndex = 1000001;
            this.txtUser.Text = "جامع البيانات...";
            this.txtUser.Visible = false;
            this.txtUser.TextChanged += new System.EventHandler(this.textEdit1_EditValueChanged);
            this.txtUser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.dtScanDate);
            this.panel2.Controls.Add(this.cbState);
            this.panel2.Location = new System.Drawing.Point(1222, 41);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 81);
            this.panel2.TabIndex = 1;
            // 
            // dtScanDate
            // 
            this.dtScanDate.CalendarFont = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtScanDate.CalendarMonthBackground = System.Drawing.Color.Gainsboro;
            this.dtScanDate.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.dtScanDate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtScanDate.Location = new System.Drawing.Point(0, 52);
            this.dtScanDate.Name = "dtScanDate";
            this.dtScanDate.Size = new System.Drawing.Size(250, 29);
            this.dtScanDate.TabIndex = 1000004;
            this.dtScanDate.Visible = false;
            this.dtScanDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbState
            // 
            this.cbState.BackColor = System.Drawing.Color.Gainsboro;
            this.cbState.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbState.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbState.FormattingEnabled = true;
            this.cbState.Location = new System.Drawing.Point(0, 0);
            this.cbState.Name = "cbState";
            this.cbState.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbState.Size = new System.Drawing.Size(250, 29);
            this.cbState.TabIndex = 1000003;
            this.cbState.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.cbVillage);
            this.panel3.Controls.Add(this.txtScanNumbers);
            this.panel3.Location = new System.Drawing.Point(988, 41);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 81);
            this.panel3.TabIndex = 2;
            // 
            // cbVillage
            // 
            this.cbVillage.BackColor = System.Drawing.Color.Gainsboro;
            this.cbVillage.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbVillage.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVillage.FormattingEnabled = true;
            this.cbVillage.Location = new System.Drawing.Point(0, 0);
            this.cbVillage.Name = "cbVillage";
            this.cbVillage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbVillage.Size = new System.Drawing.Size(222, 29);
            this.cbVillage.TabIndex = 1000004;
            // 
            // txtScanNumbers
            // 
            this.txtScanNumbers.BackColor = System.Drawing.Color.Gainsboro;
            this.txtScanNumbers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScanNumbers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtScanNumbers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScanNumbers.Location = new System.Drawing.Point(0, 52);
            this.txtScanNumbers.Name = "txtScanNumbers";
            this.txtScanNumbers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtScanNumbers.Size = new System.Drawing.Size(222, 29);
            this.txtScanNumbers.TabIndex = 1000002;
            this.txtScanNumbers.Text = "رقم المسح...";
            this.txtScanNumbers.Visible = false;
            this.txtScanNumbers.TextChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            this.txtScanNumbers.MouseDown += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseDown);
            // 
            // btnShowResults
            // 
            this.btnShowResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResults.BackColor = System.Drawing.Color.Maroon;
            this.btnShowResults.FlatAppearance.BorderSize = 0;
            this.btnShowResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowResults.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowResults.Location = new System.Drawing.Point(8, 11);
            this.btnShowResults.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(109, 31);
            this.btnShowResults.TabIndex = 3;
            this.btnShowResults.Text = "بحث";
            this.btnShowResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowResults.UseVisualStyleBackColor = false;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.dgScans);
            this.panel4.Location = new System.Drawing.Point(22, 133);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1802, 720);
            this.panel4.TabIndex = 4;
            // 
            // dgScans
            // 
            this.dgScans.AllowUserToAddRows = false;
            this.dgScans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgScans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgScans.AutoGenerateColumns = false;
            this.dgScans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgScans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgScans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.multiusers,
            this.uuidDataGridViewTextBoxColumn,
            this.xcoardDataGridViewTextBoxColumn,
            this.ycoardDataGridViewTextBoxColumn,
            this.buildingcoDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.govcodeDataGridViewTextBoxColumn,
            this.bldtypeDataGridViewTextBoxColumn,
            this.willcodeDataGridViewTextBoxColumn,
            this.villageidDataGridViewTextBoxColumn});
            this.dgScans.DataSource = this.allBuildingsBindingSource;
            this.dgScans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgScans.Location = new System.Drawing.Point(0, 0);
            this.dgScans.Name = "dgScans";
            this.dgScans.ReadOnly = true;
            this.dgScans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgScans.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgScans.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgScans.RowTemplate.Height = 32;
            this.dgScans.Size = new System.Drawing.Size(1802, 720);
            this.dgScans.TabIndex = 0;
            this.dgScans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // allBuildingsBindingSource
            // 
            this.allBuildingsBindingSource.DataSource = typeof(ApprovedMedicalSurvey.Models.Buildings);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.button1);
            this.panel5.Controls.Add(this.cbUsers);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(458, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(521, 89);
            this.panel5.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(319, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 1000006;
            this.label1.Text = "المستخدمين";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(6, 58);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 31);
            this.button1.TabIndex = 5;
            this.button1.Text = "اسناد المبنى";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbUsers
            // 
            this.cbUsers.BackColor = System.Drawing.Color.Gainsboro;
            this.cbUsers.DataSource = this.usersBindingSource;
            this.cbUsers.DisplayMember = "username";
            this.cbUsers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbUsers.FormattingEnabled = true;
            this.cbUsers.Location = new System.Drawing.Point(0, 22);
            this.cbUsers.Name = "cbUsers";
            this.cbUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cbUsers.Size = new System.Drawing.Size(313, 29);
            this.cbUsers.TabIndex = 1000005;
            this.cbUsers.ValueMember = "uuid";
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataSource = typeof(ApprovedMedicalSurvey.Models.Users);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.addBuilding);
            this.panel6.Controls.Add(this.btnShowResults);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(398, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(123, 89);
            this.panel6.TabIndex = 7;
            // 
            // addBuilding
            // 
            this.addBuilding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addBuilding.BackColor = System.Drawing.Color.Green;
            this.addBuilding.FlatAppearance.BorderSize = 0;
            this.addBuilding.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBuilding.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBuilding.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addBuilding.Location = new System.Drawing.Point(6, 52);
            this.addBuilding.Margin = new System.Windows.Forms.Padding(6);
            this.addBuilding.Name = "addBuilding";
            this.addBuilding.Size = new System.Drawing.Size(109, 31);
            this.addBuilding.TabIndex = 4;
            this.addBuilding.Text = "اضافة مبنى";
            this.addBuilding.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.addBuilding.UseVisualStyleBackColor = false;
            this.addBuilding.Click += new System.EventHandler(this.addBuilding_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // multiusers
            // 
            this.multiusers.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.multiusers.HeaderText = "";
            this.multiusers.Name = "multiusers";
            this.multiusers.ReadOnly = true;
            this.multiusers.Width = 5;
            // 
            // uuidDataGridViewTextBoxColumn
            // 
            this.uuidDataGridViewTextBoxColumn.DataPropertyName = "uuid";
            this.uuidDataGridViewTextBoxColumn.HeaderText = "uuid";
            this.uuidDataGridViewTextBoxColumn.Name = "uuidDataGridViewTextBoxColumn";
            this.uuidDataGridViewTextBoxColumn.ReadOnly = true;
            this.uuidDataGridViewTextBoxColumn.Visible = false;
            // 
            // xcoardDataGridViewTextBoxColumn
            // 
            this.xcoardDataGridViewTextBoxColumn.DataPropertyName = "xcoard";
            this.xcoardDataGridViewTextBoxColumn.HeaderText = "xcoard";
            this.xcoardDataGridViewTextBoxColumn.Name = "xcoardDataGridViewTextBoxColumn";
            this.xcoardDataGridViewTextBoxColumn.ReadOnly = true;
            this.xcoardDataGridViewTextBoxColumn.Visible = false;
            // 
            // ycoardDataGridViewTextBoxColumn
            // 
            this.ycoardDataGridViewTextBoxColumn.DataPropertyName = "ycoard";
            this.ycoardDataGridViewTextBoxColumn.HeaderText = "ycoard";
            this.ycoardDataGridViewTextBoxColumn.Name = "ycoardDataGridViewTextBoxColumn";
            this.ycoardDataGridViewTextBoxColumn.ReadOnly = true;
            this.ycoardDataGridViewTextBoxColumn.Visible = false;
            // 
            // buildingcoDataGridViewTextBoxColumn
            // 
            this.buildingcoDataGridViewTextBoxColumn.DataPropertyName = "buildingco";
            this.buildingcoDataGridViewTextBoxColumn.HeaderText = "رقم المبنى";
            this.buildingcoDataGridViewTextBoxColumn.Name = "buildingcoDataGridViewTextBoxColumn";
            this.buildingcoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "district";
            this.districtDataGridViewTextBoxColumn.HeaderText = "المحافظة";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // govcodeDataGridViewTextBoxColumn
            // 
            this.govcodeDataGridViewTextBoxColumn.DataPropertyName = "govcode";
            this.govcodeDataGridViewTextBoxColumn.HeaderText = "رمز المحافظة";
            this.govcodeDataGridViewTextBoxColumn.Name = "govcodeDataGridViewTextBoxColumn";
            this.govcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bldtypeDataGridViewTextBoxColumn
            // 
            this.bldtypeDataGridViewTextBoxColumn.DataPropertyName = "bldtype";
            this.bldtypeDataGridViewTextBoxColumn.HeaderText = "نوع البلدة";
            this.bldtypeDataGridViewTextBoxColumn.Name = "bldtypeDataGridViewTextBoxColumn";
            this.bldtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // willcodeDataGridViewTextBoxColumn
            // 
            this.willcodeDataGridViewTextBoxColumn.DataPropertyName = "willcode";
            this.willcodeDataGridViewTextBoxColumn.HeaderText = "رمز الولاية";
            this.willcodeDataGridViewTextBoxColumn.Name = "willcodeDataGridViewTextBoxColumn";
            this.willcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villageidDataGridViewTextBoxColumn
            // 
            this.villageidDataGridViewTextBoxColumn.DataPropertyName = "villageid";
            this.villageidDataGridViewTextBoxColumn.HeaderText = "رمز القرية";
            this.villageidDataGridViewTextBoxColumn.Name = "villageidDataGridViewTextBoxColumn";
            this.villageidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AllBuildings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1846, 875);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AllBuildings";
            this.Text = "اسناد المباني";
            this.Load += new System.EventHandler(this.Scans_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgScans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allBuildingsBindingSource)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowResults;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgScans;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtScanNumbers;
        private System.Windows.Forms.ComboBox cbGovernance;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.ComboBox cbVillage;
        private System.Windows.Forms.DateTimePicker dtScanDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.BindingSource allBuildingsBindingSource;
        private System.Windows.Forms.Button addBuilding;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbUsers;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridViewCheckBoxColumn multiusers;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcoardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ycoardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn govcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bldtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn willcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villageidDataGridViewTextBoxColumn;
    }
}