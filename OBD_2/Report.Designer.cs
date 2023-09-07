
namespace SchoolJornal
{
    partial class ReportForm
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
            this.StudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportOneDataSet = new SchoolJornal.reportOneDataSet();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.firstReport = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.firstReportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.classProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDataSet = new SchoolJornal.GeneralDataSets.ClassDataSet();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.secondReportButton = new System.Windows.Forms.Button();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.classProcedureTableAdapter = new SchoolJornal.GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter();
            this.StudentTableAdapter = new SchoolJornal.reportOneDataSetTableAdapters.StudentTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOneDataSet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.firstReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentBindingSource
            // 
            this.StudentBindingSource.DataMember = "Student";
            this.StudentBindingSource.DataSource = this.reportOneDataSet;
            // 
            // reportOneDataSet
            // 
            this.reportOneDataSet.DataSetName = "reportOneDataSet";
            this.reportOneDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.firstReport);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // firstReport
            // 
            this.firstReport.Controls.Add(this.reportViewer1);
            this.firstReport.Controls.Add(this.firstReportButton);
            this.firstReport.Controls.Add(this.label1);
            this.firstReport.Controls.Add(this.ClassBox);
            this.firstReport.Location = new System.Drawing.Point(4, 28);
            this.firstReport.Name = "firstReport";
            this.firstReport.Padding = new System.Windows.Forms.Padding(3);
            this.firstReport.Size = new System.Drawing.Size(768, 394);
            this.firstReport.TabIndex = 0;
            this.firstReport.Text = "Список Групи";
            this.firstReport.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SchoolJornal.firstReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.ShowFindControls = false;
            this.reportViewer1.Size = new System.Drawing.Size(616, 394);
            this.reportViewer1.TabIndex = 4;
            // 
            // firstReportButton
            // 
            this.firstReportButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.firstReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstReportButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstReportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.firstReportButton.Location = new System.Drawing.Point(622, 357);
            this.firstReportButton.Name = "firstReportButton";
            this.firstReportButton.Size = new System.Drawing.Size(140, 31);
            this.firstReportButton.TabIndex = 3;
            this.firstReportButton.Text = "Створити Звіт";
            this.firstReportButton.UseVisualStyleBackColor = false;
            this.firstReportButton.Click += new System.EventHandler(this.firstReportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(618, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Клас";
            // 
            // ClassBox
            // 
            this.ClassBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClassBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.ClassBox.DataSource = this.classProcedureBindingSource;
            this.ClassBox.DisplayMember = "Клас";
            this.ClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClassBox.Location = new System.Drawing.Point(622, 26);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(140, 27);
            this.ClassBox.TabIndex = 1;
            this.ClassBox.ValueMember = "Клас";
            // 
            // classProcedureBindingSource
            // 
            this.classProcedureBindingSource.DataMember = "ClassProcedure";
            this.classProcedureBindingSource.DataSource = this.classDataSet;
            // 
            // classDataSet
            // 
            this.classDataSet.DataSetName = "ClassDataSet";
            this.classDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.secondReportButton);
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 394);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Загальний звіт";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // secondReportButton
            // 
            this.secondReportButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.secondReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondReportButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondReportButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.secondReportButton.Location = new System.Drawing.Point(622, 357);
            this.secondReportButton.Name = "secondReportButton";
            this.secondReportButton.Size = new System.Drawing.Size(140, 31);
            this.secondReportButton.TabIndex = 6;
            this.secondReportButton.Text = "Створити Звіт";
            this.secondReportButton.UseVisualStyleBackColor = false;
            this.secondReportButton.Click += new System.EventHandler(this.secondReportButton_Click);
            // 
            // reportViewer2
            // 
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "SchoolJornal.secondReport.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 0);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.ShowFindControls = false;
            this.reportViewer2.Size = new System.Drawing.Size(616, 394);
            this.reportViewer2.TabIndex = 5;
            // 
            // classProcedureTableAdapter
            // 
            this.classProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // StudentTableAdapter
            // 
            this.StudentTableAdapter.ClearBeforeFill = true;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Звіти";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reportOneDataSet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.firstReport.ResumeLayout(false);
            this.firstReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage firstReport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox ClassBox;
        private GeneralDataSets.ClassDataSet classDataSet;
        private System.Windows.Forms.BindingSource classProcedureBindingSource;
        private GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter classProcedureTableAdapter;
        private System.Windows.Forms.Button firstReportButton;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StudentBindingSource;
        private reportOneDataSet reportOneDataSet;
        private reportOneDataSetTableAdapters.StudentTableAdapter StudentTableAdapter;
        private System.Windows.Forms.Button secondReportButton;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
    }
}