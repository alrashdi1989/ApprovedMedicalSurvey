
namespace ApprovedMedicalSurvey.UI
{
    partial class Scans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scans));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lookUpEdit2 = new DevExpress.XtraEditors.LookUpEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lookUpEdit3 = new DevExpress.XtraEditors.LookUpEdit();
            this.btnShowResults = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vIllagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.govenanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vIllagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.govenanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.lookUpEdit1);
            this.panel1.Location = new System.Drawing.Point(1639, 41);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 81);
            this.panel1.TabIndex = 0;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit1.Location = new System.Drawing.Point(0, 0);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lookUpEdit1.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit1.Properties.AppearanceDropDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lookUpEdit1.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEdit1.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit1.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.lookUpEdit1.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit1.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 41, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 59, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit1.Properties.DataSource = this.govenanceBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "Name";
            this.lookUpEdit1.Properties.NullText = "اختر المحافظة...";
            this.lookUpEdit1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit1.Properties.ShowFooter = false;
            this.lookUpEdit1.Properties.ShowHeader = false;
            this.lookUpEdit1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit1.Properties.ValueMember = "Id";
            this.lookUpEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lookUpEdit1.Size = new System.Drawing.Size(186, 30);
            this.lookUpEdit1.TabIndex = 0;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.lookUpEdit2);
            this.panel2.Location = new System.Drawing.Point(1431, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 81);
            this.panel2.TabIndex = 1;
            // 
            // lookUpEdit2
            // 
            this.lookUpEdit2.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit2.Location = new System.Drawing.Point(0, 0);
            this.lookUpEdit2.Name = "lookUpEdit2";
            this.lookUpEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lookUpEdit2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit2.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit2.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit2.Properties.AppearanceDropDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lookUpEdit2.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEdit2.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit2.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.lookUpEdit2.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit2.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.lookUpEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("govenanceID", "govenance ID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit2.Properties.DataSource = this.statesBindingSource;
            this.lookUpEdit2.Properties.DisplayMember = "name";
            this.lookUpEdit2.Properties.NullText = "اختر الولاية...";
            this.lookUpEdit2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit2.Properties.ShowFooter = false;
            this.lookUpEdit2.Properties.ShowHeader = false;
            this.lookUpEdit2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit2.Properties.ValueMember = "id";
            this.lookUpEdit2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lookUpEdit2.Size = new System.Drawing.Size(196, 30);
            this.lookUpEdit2.TabIndex = 0;
            this.lookUpEdit2.EditValueChanged += new System.EventHandler(this.lookUpEdit2_EditValueChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.lookUpEdit3);
            this.panel3.Location = new System.Drawing.Point(1182, 40);
            this.panel3.Margin = new System.Windows.Forms.Padding(6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 81);
            this.panel3.TabIndex = 2;
            // 
            // lookUpEdit3
            // 
            this.lookUpEdit3.Dock = System.Windows.Forms.DockStyle.Top;
            this.lookUpEdit3.Location = new System.Drawing.Point(0, 0);
            this.lookUpEdit3.Name = "lookUpEdit3";
            this.lookUpEdit3.Properties.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.lookUpEdit3.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit3.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpEdit3.Properties.Appearance.Options.UseFont = true;
            this.lookUpEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.lookUpEdit3.Properties.AppearanceDropDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lookUpEdit3.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 14F);
            this.lookUpEdit3.Properties.AppearanceDropDown.ForeColor = System.Drawing.Color.White;
            this.lookUpEdit3.Properties.AppearanceDropDown.Options.UseBackColor = true;
            this.lookUpEdit3.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lookUpEdit3.Properties.AppearanceDropDown.Options.UseForeColor = true;
            this.lookUpEdit3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", "id", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", "name", 5, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("StateID", "State ID", 5, DevExpress.Utils.FormatType.Numeric, "", false, DevExpress.Utils.HorzAlignment.Far, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default)});
            this.lookUpEdit3.Properties.DataSource = this.vIllagesBindingSource;
            this.lookUpEdit3.Properties.DisplayMember = "name";
            this.lookUpEdit3.Properties.NullText = "اختر القرية...";
            this.lookUpEdit3.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoComplete;
            this.lookUpEdit3.Properties.ShowFooter = false;
            this.lookUpEdit3.Properties.ShowHeader = false;
            this.lookUpEdit3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lookUpEdit3.Properties.ValueMember = "id";
            this.lookUpEdit3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lookUpEdit3.Size = new System.Drawing.Size(237, 30);
            this.lookUpEdit3.TabIndex = 0;
            this.lookUpEdit3.EditValueChanged += new System.EventHandler(this.lookUpEdit3_EditValueChanged);
            // 
            // btnShowResults
            // 
            this.btnShowResults.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShowResults.FlatAppearance.BorderSize = 0;
            this.btnShowResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowResults.Image = ((System.Drawing.Image)(resources.GetObject("btnShowResults.Image")));
            this.btnShowResults.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowResults.Location = new System.Drawing.Point(1050, 58);
            this.btnShowResults.Margin = new System.Windows.Forms.Padding(6);
            this.btnShowResults.Name = "btnShowResults";
            this.btnShowResults.Size = new System.Drawing.Size(120, 52);
            this.btnShowResults.TabIndex = 3;
            this.btnShowResults.Text = "بحث";
            this.btnShowResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowResults.UseVisualStyleBackColor = true;
            this.btnShowResults.Click += new System.EventHandler(this.btnShowResults_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.gridControl1);
            this.panel4.Location = new System.Drawing.Point(22, 133);
            this.panel4.Margin = new System.Windows.Forms.Padding(6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1802, 720);
            this.panel4.TabIndex = 4;
            // 
            // vIllagesBindingSource
            // 
            // 
            // statesBindingSource
            // 
            // 
            // govenanceBindingSource
            // 
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1802, 720);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // Scans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1846, 875);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnShowResults);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Scans";
            this.Text = "قائمة المسوحات";
            this.Load += new System.EventHandler(this.Scans_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit2.Properties)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit3.Properties)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vIllagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.govenanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnShowResults;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private System.Windows.Forms.BindingSource govenanceBindingSource;
        private System.Windows.Forms.BindingSource statesBindingSource;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit3;
        private System.Windows.Forms.BindingSource vIllagesBindingSource;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}