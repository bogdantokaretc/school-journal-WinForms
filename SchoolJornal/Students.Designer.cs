
namespace SchoolJornal
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentGridView = new System.Windows.Forms.DataGridView();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поБатьковіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.класDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.формаНавчанняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentListDataSet = new SchoolJornal.ListDataSets.StudentListDataSet();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.studentFindButton = new System.Windows.Forms.Button();
            this.studentFindBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.educationFormBox = new System.Windows.Forms.ComboBox();
            this.educationFormProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.educationFormDataSet = new SchoolJornal.GeneralDataSets.EducationFormDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.classCheck = new System.Windows.Forms.CheckBox();
            this.educationFormCheck = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.classProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDataSet = new SchoolJornal.GeneralDataSets.ClassDataSet();
            this.homeButton = new System.Windows.Forms.Button();
            this.StudentTip = new System.Windows.Forms.ToolTip(this.components);
            this.StudentButtonsTip = new System.Windows.Forms.ToolTip(this.components);
            this.student_InfoTableAdapter = new SchoolJornal.ListDataSets.StudentListDataSetTableAdapters.Student_InfoTableAdapter();
            this.classProcedureTableAdapter = new SchoolJornal.GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter();
            this.educationFormProcedureTableAdapter = new SchoolJornal.GeneralDataSets.EducationFormDataSetTableAdapters.EducationFormProcedureTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationFormProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationFormDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 51);
            this.label1.TabIndex = 15;
            this.label1.Text = "Список учнів школи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.studentGridView);
            this.panel1.Location = new System.Drawing.Point(12, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 291);
            this.panel1.TabIndex = 14;
            // 
            // studentGridView
            // 
            this.studentGridView.AllowUserToAddRows = false;
            this.studentGridView.AllowUserToDeleteRows = false;
            this.studentGridView.AllowUserToResizeColumns = false;
            this.studentGridView.AllowUserToResizeRows = false;
            this.studentGridView.AutoGenerateColumns = false;
            this.studentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.studentGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.studentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.поБатьковіDataGridViewTextBoxColumn,
            this.класDataGridViewTextBoxColumn,
            this.формаНавчанняDataGridViewTextBoxColumn});
            this.studentGridView.DataSource = this.studentInfoBindingSource;
            this.studentGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.studentGridView.Location = new System.Drawing.Point(0, 0);
            this.studentGridView.Name = "studentGridView";
            this.studentGridView.ReadOnly = true;
            this.studentGridView.Size = new System.Drawing.Size(420, 291);
            this.studentGridView.TabIndex = 0;
            // 
            // прізвищеDataGridViewTextBoxColumn
            // 
            this.прізвищеDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.прізвищеDataGridViewTextBoxColumn.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.Name = "прізвищеDataGridViewTextBoxColumn";
            this.прізвищеDataGridViewTextBoxColumn.ReadOnly = true;
            this.прізвищеDataGridViewTextBoxColumn.Width = 81;
            // 
            // імяDataGridViewTextBoxColumn
            // 
            this.імяDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.імяDataGridViewTextBoxColumn.DataPropertyName = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.Name = "імяDataGridViewTextBoxColumn";
            this.імяDataGridViewTextBoxColumn.ReadOnly = true;
            this.імяDataGridViewTextBoxColumn.Width = 51;
            // 
            // поБатьковіDataGridViewTextBoxColumn
            // 
            this.поБатьковіDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.поБатьковіDataGridViewTextBoxColumn.DataPropertyName = "По батькові";
            this.поБатьковіDataGridViewTextBoxColumn.HeaderText = "По батькові";
            this.поБатьковіDataGridViewTextBoxColumn.Name = "поБатьковіDataGridViewTextBoxColumn";
            this.поБатьковіDataGridViewTextBoxColumn.ReadOnly = true;
            this.поБатьковіDataGridViewTextBoxColumn.Width = 85;
            // 
            // класDataGridViewTextBoxColumn
            // 
            this.класDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.класDataGridViewTextBoxColumn.DataPropertyName = "Клас";
            this.класDataGridViewTextBoxColumn.HeaderText = "Клас";
            this.класDataGridViewTextBoxColumn.Name = "класDataGridViewTextBoxColumn";
            this.класDataGridViewTextBoxColumn.ReadOnly = true;
            this.класDataGridViewTextBoxColumn.Width = 57;
            // 
            // формаНавчанняDataGridViewTextBoxColumn
            // 
            this.формаНавчанняDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.формаНавчанняDataGridViewTextBoxColumn.DataPropertyName = "Форма навчання";
            this.формаНавчанняDataGridViewTextBoxColumn.HeaderText = "Форма навчання";
            this.формаНавчанняDataGridViewTextBoxColumn.Name = "формаНавчанняDataGridViewTextBoxColumn";
            this.формаНавчанняDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentInfoBindingSource
            // 
            this.studentInfoBindingSource.DataMember = "Student_Info";
            this.studentInfoBindingSource.DataSource = this.studentListDataSet;
            // 
            // studentListDataSet
            // 
            this.studentListDataSet.DataSetName = "StudentListDataSet";
            this.studentListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.BackColor = System.Drawing.Color.White;
            this.deleteStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStudentButton.Image")));
            this.deleteStudentButton.Location = new System.Drawing.Point(438, 323);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(70, 35);
            this.deleteStudentButton.TabIndex = 13;
            this.StudentButtonsTip.SetToolTip(this.deleteStudentButton, "Видалити вибраний запис");
            this.deleteStudentButton.UseVisualStyleBackColor = false;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // editStudentButton
            // 
            this.editStudentButton.BackColor = System.Drawing.Color.White;
            this.editStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("editStudentButton.Image")));
            this.editStudentButton.Location = new System.Drawing.Point(438, 282);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(70, 35);
            this.editStudentButton.TabIndex = 12;
            this.StudentButtonsTip.SetToolTip(this.editStudentButton, "Редагувати вибраний запис");
            this.editStudentButton.UseVisualStyleBackColor = false;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.White;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("addStudentButton.Image")));
            this.addStudentButton.Location = new System.Drawing.Point(438, 241);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(70, 35);
            this.addStudentButton.TabIndex = 11;
            this.StudentButtonsTip.SetToolTip(this.addStudentButton, "Додати новий запис");
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // studentFindButton
            // 
            this.studentFindButton.BackColor = System.Drawing.Color.White;
            this.studentFindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentFindButton.Image = ((System.Drawing.Image)(resources.GetObject("studentFindButton.Image")));
            this.studentFindButton.Location = new System.Drawing.Point(438, 73);
            this.studentFindButton.Name = "studentFindButton";
            this.studentFindButton.Size = new System.Drawing.Size(70, 162);
            this.studentFindButton.TabIndex = 10;
            this.StudentButtonsTip.SetToolTip(this.studentFindButton, "Пошук");
            this.studentFindButton.UseVisualStyleBackColor = false;
            this.studentFindButton.Click += new System.EventHandler(this.searchStudentButton_Click);
            // 
            // studentFindBox
            // 
            this.studentFindBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.studentFindBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentFindBox.Location = new System.Drawing.Point(10, 116);
            this.studentFindBox.MaximumSize = new System.Drawing.Size(400, 35);
            this.studentFindBox.MinimumSize = new System.Drawing.Size(200, 35);
            this.studentFindBox.Name = "studentFindBox";
            this.studentFindBox.Size = new System.Drawing.Size(400, 35);
            this.studentFindBox.TabIndex = 9;
            this.StudentTip.SetToolTip(this.studentFindBox, "Поле для вводу ПІБ учня");
            this.studentFindBox.TextChanged += new System.EventHandler(this.studentFindBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Прізвище, ім\'я, по батькові учня";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(216, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Форма навчання";
            // 
            // educationFormBox
            // 
            this.educationFormBox.DataSource = this.educationFormProcedureBindingSource;
            this.educationFormBox.DisplayMember = "Форма навчання";
            this.educationFormBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationFormBox.Enabled = false;
            this.educationFormBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.educationFormBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationFormBox.FormattingEnabled = true;
            this.educationFormBox.Location = new System.Drawing.Point(220, 45);
            this.educationFormBox.Name = "educationFormBox";
            this.educationFormBox.Size = new System.Drawing.Size(170, 35);
            this.educationFormBox.TabIndex = 21;
            this.StudentTip.SetToolTip(this.educationFormBox, "Вибір форми навчання");
            this.educationFormBox.ValueMember = "Форма навчання";
            // 
            // educationFormProcedureBindingSource
            // 
            this.educationFormProcedureBindingSource.DataMember = "EducationFormProcedure";
            this.educationFormProcedureBindingSource.DataSource = this.educationFormDataSet;
            // 
            // educationFormDataSet
            // 
            this.educationFormDataSet.DataSetName = "EducationFormDataSet";
            this.educationFormDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.classCheck);
            this.groupBox1.Controls.Add(this.educationFormCheck);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.classBox);
            this.groupBox1.Controls.Add(this.educationFormBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.studentFindBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 162);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук учня";
            // 
            // classCheck
            // 
            this.classCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.classCheck.BackColor = System.Drawing.Color.Red;
            this.classCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.classCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.classCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classCheck.Location = new System.Drawing.Point(186, 58);
            this.classCheck.Name = "classCheck";
            this.classCheck.Size = new System.Drawing.Size(12, 12);
            this.classCheck.TabIndex = 26;
            this.classCheck.UseVisualStyleBackColor = false;
            this.classCheck.CheckedChanged += new System.EventHandler(this.classCheck_Click);
            this.classCheck.Click += new System.EventHandler(this.classCheck_Click);
            // 
            // educationFormCheck
            // 
            this.educationFormCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.educationFormCheck.BackColor = System.Drawing.Color.Red;
            this.educationFormCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.educationFormCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.educationFormCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationFormCheck.Location = new System.Drawing.Point(396, 58);
            this.educationFormCheck.Name = "educationFormCheck";
            this.educationFormCheck.Size = new System.Drawing.Size(12, 12);
            this.educationFormCheck.TabIndex = 25;
            this.educationFormCheck.UseVisualStyleBackColor = false;
            this.educationFormCheck.CheckedChanged += new System.EventHandler(this.educationFormCheck_Click);
            this.educationFormCheck.Click += new System.EventHandler(this.educationFormCheck_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 19);
            this.label6.TabIndex = 24;
            this.label6.Text = "Клас";
            // 
            // classBox
            // 
            this.classBox.DataSource = this.classProcedureBindingSource;
            this.classBox.DisplayMember = "ID_Class";
            this.classBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classBox.Enabled = false;
            this.classBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.classBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.classBox.Location = new System.Drawing.Point(10, 45);
            this.classBox.MaxDropDownItems = 5;
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(170, 35);
            this.classBox.TabIndex = 23;
            this.StudentTip.SetToolTip(this.classBox, "Вибір класу навчання");
            this.classBox.ValueMember = "ID_Class";
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
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(438, 364);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(70, 35);
            this.homeButton.TabIndex = 24;
            this.StudentButtonsTip.SetToolTip(this.homeButton, "Головна сторінка");
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // StudentTip
            // 
            this.StudentTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StudentTip.ToolTipTitle = "Пошук учня";
            // 
            // StudentButtonsTip
            // 
            this.StudentButtonsTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.StudentButtonsTip.ToolTipTitle = "Список учнів";
            // 
            // student_InfoTableAdapter
            // 
            this.student_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // classProcedureTableAdapter
            // 
            this.classProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // educationFormProcedureTableAdapter
            // 
            this.educationFormProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 543);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.editStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.studentFindButton);
            this.MaximizeBox = false;
            this.Name = "Students";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Учні школи";
            this.Load += new System.EventHandler(this.Students_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationFormProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.educationFormDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button studentFindButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.ToolTip StudentTip;
        private System.Windows.Forms.ToolTip StudentButtonsTip;
        private System.Windows.Forms.Label label6;
        internal System.Windows.Forms.TextBox studentFindBox;
        internal System.Windows.Forms.ComboBox educationFormBox;
        private ListDataSets.StudentListDataSet studentListDataSet;
        private System.Windows.Forms.BindingSource studentInfoBindingSource;
        private ListDataSets.StudentListDataSetTableAdapters.Student_InfoTableAdapter student_InfoTableAdapter;
        private GeneralDataSets.ClassDataSet classDataSet;
        private System.Windows.Forms.BindingSource classProcedureBindingSource;
        private GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter classProcedureTableAdapter;
        private GeneralDataSets.EducationFormDataSet educationFormDataSet;
        private System.Windows.Forms.BindingSource educationFormProcedureBindingSource;
        private GeneralDataSets.EducationFormDataSetTableAdapters.EducationFormProcedureTableAdapter educationFormProcedureTableAdapter;
        internal System.Windows.Forms.DataGridView studentGridView;
        internal System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.CheckBox educationFormCheck;
        private System.Windows.Forms.CheckBox classCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поБатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn класDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn формаНавчанняDataGridViewTextBoxColumn;
    }
}