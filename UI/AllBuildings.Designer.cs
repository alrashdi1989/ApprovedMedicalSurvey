
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblScanNumbers = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.allBuildingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uuidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xcoardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ycoardDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.govcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villageidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.willcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bldtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buildingcoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgScans)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.allBuildingsBindingSource)).BeginInit();
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgScans.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgScans.AutoGenerateColumns = false;
            this.dgScans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgScans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgScans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgScans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uuidDataGridViewTextBoxColumn,
            this.xcoardDataGridViewTextBoxColumn,
            this.ycoardDataGridViewTextBoxColumn,
            this.govcodeDataGridViewTextBoxColumn,
            this.villageidDataGridViewTextBoxColumn,
            this.willcodeDataGridViewTextBoxColumn,
            this.bldtypeDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.buildingcoDataGridViewTextBoxColumn});
            this.dgScans.DataSource = this.allBuildingsBindingSource;
            this.dgScans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgScans.Location = new System.Drawing.Point(0, 0);
            this.dgScans.Name = "dgScans";
            this.dgScans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgScans.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgScans.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgScans.RowTemplate.Height = 32;
            this.dgScans.Size = new System.Drawing.Size(1802, 720);
            this.dgScans.TabIndex = 0;
            this.dgScans.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.lblScanNumbers);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Location = new System.Drawing.Point(614, 24);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(365, 89);
            this.panel5.TabIndex = 6;
            // 
            // lblScanNumbers
            // 
            this.lblScanNumbers.AutoSize = true;
            this.lblScanNumbers.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScanNumbers.ForeColor = System.Drawing.Color.Black;
            this.lblScanNumbers.Location = new System.Drawing.Point(3, 21);
            this.lblScanNumbers.Name = "lblScanNumbers";
            this.lblScanNumbers.Size = new System.Drawing.Size(22, 21);
            this.lblScanNumbers.TabIndex = 8;
            this.lblScanNumbers.Text = "--";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnShowResults);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(242, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(123, 89);
            this.panel6.TabIndex = 7;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // allBuildingsBindingSource
            // 
            this.allBuildingsBindingSource.DataSource = typeof(ApprovedMedicalSurvey.Models.Buildings);
            // 
            // uuidDataGridViewTextBoxColumn
            // 
            this.uuidDataGridViewTextBoxColumn.DataPropertyName = "uuid";
            this.uuidDataGridViewTextBoxColumn.HeaderText = "uuid";
            this.uuidDataGridViewTextBoxColumn.Name = "uuidDataGridViewTextBoxColumn";
            // 
            // xcoardDataGridViewTextBoxColumn
            // 
            this.xcoardDataGridViewTextBoxColumn.DataPropertyName = "xcoard";
            this.xcoardDataGridViewTextBoxColumn.HeaderText = "xcoard";
            this.xcoardDataGridViewTextBoxColumn.Name = "xcoardDataGridViewTextBoxColumn";
            // 
            // ycoardDataGridViewTextBoxColumn
            // 
            this.ycoardDataGridViewTextBoxColumn.DataPropertyName = "ycoard";
            this.ycoardDataGridViewTextBoxColumn.HeaderText = "ycoard";
            this.ycoardDataGridViewTextBoxColumn.Name = "ycoardDataGridViewTextBoxColumn";
            // 
            // govcodeDataGridViewTextBoxColumn
            // 
            this.govcodeDataGridViewTextBoxColumn.DataPropertyName = "govcode";
            this.govcodeDataGridViewTextBoxColumn.HeaderText = "govcode";
            this.govcodeDataGridViewTextBoxColumn.Name = "govcodeDataGridViewTextBoxColumn";
            // 
            // villageidDataGridViewTextBoxColumn
            // 
            this.villageidDataGridViewTextBoxColumn.DataPropertyName = "villageid";
            this.villageidDataGridViewTextBoxColumn.HeaderText = "villageid";
            this.villageidDataGridViewTextBoxColumn.Name = "villageidDataGridViewTextBoxColumn";
            // 
            // willcodeDataGridViewTextBoxColumn
            // 
            this.willcodeDataGridViewTextBoxColumn.DataPropertyName = "willcode";
            this.willcodeDataGridViewTextBoxColumn.HeaderText = "willcode";
            this.willcodeDataGridViewTextBoxColumn.Name = "willcodeDataGridViewTextBoxColumn";
            // 
            // bldtypeDataGridViewTextBoxColumn
            // 
            this.bldtypeDataGridViewTextBoxColumn.DataPropertyName = "bldtype";
            this.bldtypeDataGridViewTextBoxColumn.HeaderText = "bldtype";
            this.bldtypeDataGridViewTextBoxColumn.Name = "bldtypeDataGridViewTextBoxColumn";
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "district";
            this.districtDataGridViewTextBoxColumn.HeaderText = "district";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            // 
            // buildingcoDataGridViewTextBoxColumn
            // 
            this.buildingcoDataGridViewTextBoxColumn.DataPropertyName = "buildingco";
            this.buildingcoDataGridViewTextBoxColumn.HeaderText = "buildingco";
            this.buildingcoDataGridViewTextBoxColumn.Name = "buildingcoDataGridViewTextBoxColumn";
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
            this.Text = "قائمة المسوحات";
            this.Load += new System.EventHandler(this.Scans_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgScans)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.allBuildingsBindingSource)).EndInit();
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
        private System.Windows.Forms.Label lblScanNumbers;
        private System.Windows.Forms.DateTimePicker dtScanDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn uuidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xcoardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ycoardDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn govcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villageidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn willcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bldtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn buildingcoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource allBuildingsBindingSource;
    }
}