
namespace ApprovedMedicalSurvey.UI
{
    partial class Reports
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.govenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnExcelDownload = new System.Windows.Forms.Button();
            this.cmTown = new System.Windows.Forms.ComboBox();
            this.cmReportType = new System.Windows.Forms.ComboBox();
            this.dgReports = new System.Windows.Forms.DataGridView();
            this.resultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.valueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.govenanceBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgReports);
            this.panel1.Location = new System.Drawing.Point(2, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 344);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnGenerateReport);
            this.panel2.Controls.Add(this.btnExcelDownload);
            this.panel2.Controls.Add(this.cmTown);
            this.panel2.Controls.Add(this.cmReportType);
            this.panel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 93);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGenerateReport.FlatAppearance.BorderSize = 0;
            this.btnGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.btnGenerateReport.Location = new System.Drawing.Point(151, 49);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(109, 31);
            this.btnGenerateReport.TabIndex = 3;
            this.btnGenerateReport.Text = "عرض التقرير";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnExcelDownload
            // 
            this.btnExcelDownload.BackColor = System.Drawing.Color.Green;
            this.btnExcelDownload.FlatAppearance.BorderSize = 0;
            this.btnExcelDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcelDownload.ForeColor = System.Drawing.Color.White;
            this.btnExcelDownload.Location = new System.Drawing.Point(36, 49);
            this.btnExcelDownload.Name = "btnExcelDownload";
            this.btnExcelDownload.Size = new System.Drawing.Size(109, 31);
            this.btnExcelDownload.TabIndex = 2;
            this.btnExcelDownload.Text = "تصدير التقرير";
            this.btnExcelDownload.UseVisualStyleBackColor = false;
            this.btnExcelDownload.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmTown
            // 
            this.cmTown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmTown.BackColor = System.Drawing.Color.Gainsboro;
            this.cmTown.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmTown.FormattingEnabled = true;
            this.cmTown.Location = new System.Drawing.Point(529, 51);
            this.cmTown.Name = "cmTown";
            this.cmTown.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmTown.Size = new System.Drawing.Size(257, 29);
            this.cmTown.TabIndex = 1;
            this.cmTown.SelectedIndexChanged += new System.EventHandler(this.cmTown_SelectedIndexChanged);
            // 
            // cmReportType
            // 
            this.cmReportType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmReportType.BackColor = System.Drawing.Color.Gainsboro;
            this.cmReportType.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmReportType.FormattingEnabled = true;
            this.cmReportType.Location = new System.Drawing.Point(266, 51);
            this.cmReportType.Name = "cmReportType";
            this.cmReportType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmReportType.Size = new System.Drawing.Size(257, 29);
            this.cmReportType.TabIndex = 0;
            this.cmReportType.SelectedIndexChanged += new System.EventHandler(this.cmReportType_SelectedIndexChanged);
            // 
            // dgReports
            // 
            this.dgReports.AllowUserToAddRows = false;
            this.dgReports.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgReports.AutoGenerateColumns = false;
            this.dgReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReports.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.valueDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn});
            this.dgReports.DataSource = this.resultBindingSource;
            this.dgReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgReports.Location = new System.Drawing.Point(0, 0);
            this.dgReports.Margin = new System.Windows.Forms.Padding(2);
            this.dgReports.Name = "dgReports";
            this.dgReports.ReadOnly = true;
            this.dgReports.RowHeadersVisible = false;
            this.dgReports.RowHeadersWidth = 51;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgReports.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.dgReports.RowTemplate.Height = 45;
            this.dgReports.Size = new System.Drawing.Size(796, 344);
            this.dgReports.TabIndex = 1;
            // 
            // resultBindingSource
            // 
            this.resultBindingSource.DataSource = typeof(ApprovedMedicalSurvey.Models.AllReports.Result);
            // 
            // valueDataGridViewTextBoxColumn
            // 
            this.valueDataGridViewTextBoxColumn.DataPropertyName = "value";
            this.valueDataGridViewTextBoxColumn.HeaderText = "العدد";
            this.valueDataGridViewTextBoxColumn.Name = "valueDataGridViewTextBoxColumn";
            this.valueDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "الاسم ";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "--";
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reports";
            this.Text = "شاشة التقارير";
            this.Load += new System.EventHandler(this.Reports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.govenanceBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource govenanceBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnExcelDownload;
        private System.Windows.Forms.ComboBox cmTown;
        private System.Windows.Forms.ComboBox cmReportType;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgReports;
        private System.Windows.Forms.BindingSource resultBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn valueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}