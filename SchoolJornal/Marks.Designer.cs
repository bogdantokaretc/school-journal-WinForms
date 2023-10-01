
namespace SchoolJornal
{
    partial class Marks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marks));
            this.homeButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.disciplineCheck = new System.Windows.Forms.CheckBox();
            this.markCheck = new System.Windows.Forms.CheckBox();
            this.markBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.markFindBox = new System.Windows.Forms.TextBox();
            this.disciplineBox = new System.Windows.Forms.ComboBox();
            this.disciplineProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineProcedureDataSet = new SchoolJornal.disciplineProcedureDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.markGridView = new System.Windows.Forms.DataGridView();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поБатьковіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплінаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.оцінкаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаОтриманняDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markListDataSet = new SchoolJornal.ListDataSets.MarkListDataSet();
            this.deleteStudentButton = new System.Windows.Forms.Button();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.searchMarkButton = new System.Windows.Forms.Button();
            this.MarkTip = new System.Windows.Forms.ToolTip(this.components);
            this.mark_InfoTableAdapter = new SchoolJornal.ListDataSets.MarkListDataSetTableAdapters.Mark_InfoTableAdapter();
            this.disciplineProcedureTableAdapter = new SchoolJornal.disciplineProcedureDataSetTableAdapters.DisciplineProcedureTableAdapter();
            this.disciplineProcedureDataSet1 = new SchoolJornal.disciplineProcedureDataSet();
            this.disciplineProcedureTableAdapter1 = new SchoolJornal.disciplineProcedureDataSetTableAdapters.DisciplineProcedureTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.markGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(572, 364);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(70, 35);
            this.homeButton.TabIndex = 32;
            this.MarkTip.SetToolTip(this.homeButton, "Головна сторінка");
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.disciplineCheck);
            this.groupBox1.Controls.Add(this.markCheck);
            this.groupBox1.Controls.Add(this.markBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.markFindBox);
            this.groupBox1.Controls.Add(this.disciplineBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(550, 172);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук оцінки";
            // 
            // disciplineCheck
            // 
            this.disciplineCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.disciplineCheck.BackColor = System.Drawing.Color.Red;
            this.disciplineCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disciplineCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplineCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineCheck.Location = new System.Drawing.Point(356, 68);
            this.disciplineCheck.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
            this.disciplineCheck.Name = "disciplineCheck";
            this.disciplineCheck.Size = new System.Drawing.Size(12, 12);
            this.disciplineCheck.TabIndex = 33;
            this.disciplineCheck.UseVisualStyleBackColor = false;
            this.disciplineCheck.CheckedChanged += new System.EventHandler(this.disciplineCheck_CheckedChanged);
            this.disciplineCheck.Click += new System.EventHandler(this.disciplineCheck_CheckedChanged);
            // 
            // markCheck
            // 
            this.markCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.markCheck.BackColor = System.Drawing.Color.Red;
            this.markCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.markCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markCheck.Location = new System.Drawing.Point(525, 68);
            this.markCheck.Name = "markCheck";
            this.markCheck.Size = new System.Drawing.Size(12, 12);
            this.markCheck.TabIndex = 27;
            this.markCheck.UseVisualStyleBackColor = false;
            this.markCheck.CheckedChanged += new System.EventHandler(this.markCheck_CheckedChanged);
            this.markCheck.Click += new System.EventHandler(this.markCheck_CheckedChanged);
            // 
            // markBox
            // 
            this.markBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markBox.Enabled = false;
            this.markBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markBox.FormattingEnabled = true;
            this.markBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.markBox.Location = new System.Drawing.Point(401, 58);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(118, 35);
            this.markBox.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(397, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 22;
            this.label5.Text = "Оцінка";
            // 
            // markFindBox
            // 
            this.markFindBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.markFindBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markFindBox.Location = new System.Drawing.Point(10, 126);
            this.markFindBox.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.markFindBox.MaximumSize = new System.Drawing.Size(600, 35);
            this.markFindBox.MinimumSize = new System.Drawing.Size(300, 35);
            this.markFindBox.Name = "markFindBox";
            this.markFindBox.Size = new System.Drawing.Size(527, 35);
            this.markFindBox.TabIndex = 9;
            this.markFindBox.TextChanged += new System.EventHandler(this.findMarkBox_TextChanged);
            // 
            // disciplineBox
            // 
            this.disciplineBox.DataSource = this.disciplineProcedureBindingSource;
            this.disciplineBox.DisplayMember = "Назва дисципліни";
            this.disciplineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineBox.Enabled = false;
            this.disciplineBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineBox.FormattingEnabled = true;
            this.disciplineBox.Location = new System.Drawing.Point(10, 58);
            this.disciplineBox.Name = "disciplineBox";
            this.disciplineBox.Size = new System.Drawing.Size(340, 35);
            this.disciplineBox.TabIndex = 16;
            this.disciplineBox.ValueMember = "Назва дисципліни";
            // 
            // disciplineProcedureBindingSource
            // 
            this.disciplineProcedureBindingSource.DataMember = "DisciplineProcedure";
            this.disciplineProcedureBindingSource.DataSource = this.disciplineProcedureDataSet;
            // 
            // disciplineProcedureDataSet
            // 
            this.disciplineProcedureDataSet.DataSetName = "disciplineProcedureDataSet";
            this.disciplineProcedureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(5, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Прізвище, ім\'я, по батькові учня";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дисципліна";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(550, 51);
            this.label1.TabIndex = 30;
            this.label1.Text = "Список оцінок учнів";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.markGridView);
            this.panel1.Location = new System.Drawing.Point(12, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 291);
            this.panel1.TabIndex = 29;
            // 
            // markGridView
            // 
            this.markGridView.AllowUserToAddRows = false;
            this.markGridView.AllowUserToDeleteRows = false;
            this.markGridView.AutoGenerateColumns = false;
            this.markGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.markGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.markGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.markGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.поБатьковіDataGridViewTextBoxColumn,
            this.дисциплінаDataGridViewTextBoxColumn,
            this.оцінкаDataGridViewTextBoxColumn,
            this.датаОтриманняDataGridViewTextBoxColumn});
            this.markGridView.DataSource = this.markInfoBindingSource;
            this.markGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.markGridView.Location = new System.Drawing.Point(0, 0);
            this.markGridView.Name = "markGridView";
            this.markGridView.ReadOnly = true;
            this.markGridView.Size = new System.Drawing.Size(550, 291);
            this.markGridView.TabIndex = 0;
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
            // дисциплінаDataGridViewTextBoxColumn
            // 
            this.дисциплінаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.дисциплінаDataGridViewTextBoxColumn.DataPropertyName = "Дисципліна";
            this.дисциплінаDataGridViewTextBoxColumn.HeaderText = "Дисципліна";
            this.дисциплінаDataGridViewTextBoxColumn.Name = "дисциплінаDataGridViewTextBoxColumn";
            this.дисциплінаDataGridViewTextBoxColumn.ReadOnly = true;
            this.дисциплінаDataGridViewTextBoxColumn.Width = 91;
            // 
            // оцінкаDataGridViewTextBoxColumn
            // 
            this.оцінкаDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.оцінкаDataGridViewTextBoxColumn.DataPropertyName = "Оцінка";
            this.оцінкаDataGridViewTextBoxColumn.HeaderText = "Оцінка";
            this.оцінкаDataGridViewTextBoxColumn.Name = "оцінкаDataGridViewTextBoxColumn";
            this.оцінкаDataGridViewTextBoxColumn.ReadOnly = true;
            this.оцінкаDataGridViewTextBoxColumn.Width = 66;
            // 
            // датаОтриманняDataGridViewTextBoxColumn
            // 
            this.датаОтриманняDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.датаОтриманняDataGridViewTextBoxColumn.DataPropertyName = "Дата отримання";
            this.датаОтриманняDataGridViewTextBoxColumn.HeaderText = "Дата отримання";
            this.датаОтриманняDataGridViewTextBoxColumn.Name = "датаОтриманняDataGridViewTextBoxColumn";
            this.датаОтриманняDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // markInfoBindingSource
            // 
            this.markInfoBindingSource.DataMember = "Mark_Info";
            this.markInfoBindingSource.DataSource = this.markListDataSet;
            // 
            // markListDataSet
            // 
            this.markListDataSet.DataSetName = "MarkListDataSet";
            this.markListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deleteStudentButton
            // 
            this.deleteStudentButton.BackColor = System.Drawing.Color.White;
            this.deleteStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteStudentButton.Image")));
            this.deleteStudentButton.Location = new System.Drawing.Point(572, 323);
            this.deleteStudentButton.Name = "deleteStudentButton";
            this.deleteStudentButton.Size = new System.Drawing.Size(70, 35);
            this.deleteStudentButton.TabIndex = 28;
            this.MarkTip.SetToolTip(this.deleteStudentButton, "Видалити вибраний запис");
            this.deleteStudentButton.UseVisualStyleBackColor = false;
            this.deleteStudentButton.Click += new System.EventHandler(this.deleteStudentButton_Click);
            // 
            // editStudentButton
            // 
            this.editStudentButton.BackColor = System.Drawing.Color.White;
            this.editStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("editStudentButton.Image")));
            this.editStudentButton.Location = new System.Drawing.Point(572, 282);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(70, 35);
            this.editStudentButton.TabIndex = 27;
            this.MarkTip.SetToolTip(this.editStudentButton, "Редагувати вибраний запис");
            this.editStudentButton.UseVisualStyleBackColor = false;
            this.editStudentButton.Click += new System.EventHandler(this.editStudentButton_Click);
            // 
            // addStudentButton
            // 
            this.addStudentButton.BackColor = System.Drawing.Color.White;
            this.addStudentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addStudentButton.Image = ((System.Drawing.Image)(resources.GetObject("addStudentButton.Image")));
            this.addStudentButton.Location = new System.Drawing.Point(572, 241);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(70, 35);
            this.addStudentButton.TabIndex = 26;
            this.MarkTip.SetToolTip(this.addStudentButton, "Додати новий запис");
            this.addStudentButton.UseVisualStyleBackColor = false;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // searchMarkButton
            // 
            this.searchMarkButton.BackColor = System.Drawing.Color.White;
            this.searchMarkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchMarkButton.Image = ((System.Drawing.Image)(resources.GetObject("searchMarkButton.Image")));
            this.searchMarkButton.Location = new System.Drawing.Point(572, 73);
            this.searchMarkButton.Name = "searchMarkButton";
            this.searchMarkButton.Size = new System.Drawing.Size(70, 162);
            this.searchMarkButton.TabIndex = 25;
            this.MarkTip.SetToolTip(this.searchMarkButton, "Пошук оцінки");
            this.searchMarkButton.UseVisualStyleBackColor = false;
            this.searchMarkButton.Click += new System.EventHandler(this.searchMarkButton_Click);
            // 
            // MarkTip
            // 
            this.MarkTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MarkTip.ToolTipTitle = "Список оцінок";
            // 
            // mark_InfoTableAdapter
            // 
            this.mark_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineProcedureTableAdapter
            // 
            this.disciplineProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineProcedureDataSet1
            // 
            this.disciplineProcedureDataSet1.DataSetName = "disciplineProcedureDataSet";
            this.disciplineProcedureDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplineProcedureTableAdapter1
            // 
            this.disciplineProcedureTableAdapter1.ClearBeforeFill = true;
            // 
            // Marks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 541);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteStudentButton);
            this.Controls.Add(this.editStudentButton);
            this.Controls.Add(this.addStudentButton);
            this.Controls.Add(this.searchMarkButton);
            this.MaximizeBox = false;
            this.Name = "Marks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Оцінки";
            this.Load += new System.EventHandler(this.Marks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.markGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox markBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox markFindBox;
        private System.Windows.Forms.ComboBox disciplineBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button deleteStudentButton;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.Button searchMarkButton;
        private System.Windows.Forms.ToolTip MarkTip;
        private System.Windows.Forms.CheckBox markCheck;
        private System.Windows.Forms.CheckBox disciplineCheck;
        private ListDataSets.MarkListDataSet markListDataSet;
        private System.Windows.Forms.BindingSource markInfoBindingSource;
        private ListDataSets.MarkListDataSetTableAdapters.Mark_InfoTableAdapter mark_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поБатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплінаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn оцінкаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаОтриманняDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView markGridView;
        private disciplineProcedureDataSet disciplineProcedureDataSet;
        private System.Windows.Forms.BindingSource disciplineProcedureBindingSource;
        private disciplineProcedureDataSetTableAdapters.DisciplineProcedureTableAdapter disciplineProcedureTableAdapter;
        private disciplineProcedureDataSet disciplineProcedureDataSet1;
        private disciplineProcedureDataSetTableAdapters.DisciplineProcedureTableAdapter disciplineProcedureTableAdapter1;
    }
}