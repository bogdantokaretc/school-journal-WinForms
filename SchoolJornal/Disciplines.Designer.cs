

namespace SchoolJornal
{
    partial class Disciplines
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disciplines));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teacherCheck = new System.Windows.Forms.CheckBox();
            this.disciplineCheck = new System.Windows.Forms.CheckBox();
            this.teacherBox = new System.Windows.Forms.ComboBox();
            this.teacherProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherProcedureDataSet = new SchoolJornal.GeneralDataSets.TeacherProcedureDataSet();
            this.disciplineBox = new System.Windows.Forms.ComboBox();
            this.disciplineProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineProcedureDataSet = new SchoolJornal.disciplineProcedureDataSet();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.disciplineGridView = new System.Windows.Forms.DataGridView();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поБатьковіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.назваДисципліниDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кількістьГодинDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disciplineInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineListDataSet = new SchoolJornal.ListDataSets.DisciplineListDataSet();
            this.disciplineFindBox = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.deleteDisciplineButton = new System.Windows.Forms.Button();
            this.editDisciplineButton = new System.Windows.Forms.Button();
            this.addDisciplineButton = new System.Windows.Forms.Button();
            this.discipline_InfoTableAdapter = new SchoolJornal.ListDataSets.DisciplineListDataSetTableAdapters.Discipline_InfoTableAdapter();
            this.disciplineProcedureTableAdapter = new SchoolJornal.disciplineProcedureDataSetTableAdapters.DisciplineProcedureTableAdapter();
            this.teacherProcedureTableAdapter = new SchoolJornal.GeneralDataSets.TeacherProcedureDataSetTableAdapters.TeacherProcedureTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherProcedureDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teacherCheck);
            this.groupBox1.Controls.Add(this.disciplineCheck);
            this.groupBox1.Controls.Add(this.teacherBox);
            this.groupBox1.Controls.Add(this.disciplineBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 172);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пошук інформації про дисципліну";
            // 
            // teacherCheck
            // 
            this.teacherCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.teacherCheck.BackColor = System.Drawing.Color.Red;
            this.teacherCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.teacherCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherCheck.Location = new System.Drawing.Point(445, 134);
            this.teacherCheck.Name = "teacherCheck";
            this.teacherCheck.Size = new System.Drawing.Size(12, 12);
            this.teacherCheck.TabIndex = 35;
            this.teacherCheck.UseVisualStyleBackColor = false;
            this.teacherCheck.CheckedChanged += new System.EventHandler(this.teacherCheck_CheckedChanged);
            // 
            // disciplineCheck
            // 
            this.disciplineCheck.Appearance = System.Windows.Forms.Appearance.Button;
            this.disciplineCheck.BackColor = System.Drawing.Color.Red;
            this.disciplineCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disciplineCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplineCheck.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineCheck.Location = new System.Drawing.Point(445, 68);
            this.disciplineCheck.Name = "disciplineCheck";
            this.disciplineCheck.Size = new System.Drawing.Size(12, 12);
            this.disciplineCheck.TabIndex = 34;
            this.disciplineCheck.UseVisualStyleBackColor = false;
            this.disciplineCheck.CheckedChanged += new System.EventHandler(this.disciplineCheck_CheckedChanged);
            // 
            // teacherBox
            // 
            this.teacherBox.DataSource = this.teacherProcedureBindingSource;
            this.teacherBox.DisplayMember = "ПІБ";
            this.teacherBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherBox.Enabled = false;
            this.teacherBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherBox.FormattingEnabled = true;
            this.teacherBox.Location = new System.Drawing.Point(13, 124);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(426, 35);
            this.teacherBox.TabIndex = 33;
            this.teacherBox.ValueMember = "ПІБ";
            // 
            // teacherProcedureBindingSource
            // 
            this.teacherProcedureBindingSource.DataMember = "TeacherProcedure";
            this.teacherProcedureBindingSource.DataSource = this.teacherProcedureDataSet;
            // 
            // teacherProcedureDataSet
            // 
            this.teacherProcedureDataSet.DataSetName = "TeacherProcedureDataSet";
            this.teacherProcedureDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplineBox
            // 
            this.disciplineBox.DataSource = this.disciplineProcedureBindingSource;
            this.disciplineBox.DisplayMember = "Назва дисципліни";
            this.disciplineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineBox.Enabled = false;
            this.disciplineBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineBox.FormattingEnabled = true;
            this.disciplineBox.Location = new System.Drawing.Point(13, 58);
            this.disciplineBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.disciplineBox.Name = "disciplineBox";
            this.disciplineBox.Size = new System.Drawing.Size(426, 35);
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
            this.label4.Location = new System.Drawing.Point(9, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Вчитель";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Дисципліна";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(556, 34);
            this.label1.TabIndex = 31;
            this.label1.Text = "Список дисциплін школи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.disciplineGridView);
            this.panel1.Location = new System.Drawing.Point(12, 241);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 379);
            this.panel1.TabIndex = 33;
            // 
            // disciplineGridView
            // 
            this.disciplineGridView.AllowUserToAddRows = false;
            this.disciplineGridView.AllowUserToDeleteRows = false;
            this.disciplineGridView.AutoGenerateColumns = false;
            this.disciplineGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.disciplineGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.disciplineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.disciplineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.поБатьковіDataGridViewTextBoxColumn,
            this.назваДисципліниDataGridViewTextBoxColumn,
            this.кількістьГодинDataGridViewTextBoxColumn});
            this.disciplineGridView.DataSource = this.disciplineInfoBindingSource;
            this.disciplineGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.disciplineGridView.Location = new System.Drawing.Point(0, 0);
            this.disciplineGridView.Name = "disciplineGridView";
            this.disciplineGridView.ReadOnly = true;
            this.disciplineGridView.Size = new System.Drawing.Size(474, 379);
            this.disciplineGridView.TabIndex = 0;
            // 
            // прізвищеDataGridViewTextBoxColumn
            // 
            this.прізвищеDataGridViewTextBoxColumn.DataPropertyName = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.HeaderText = "Прізвище";
            this.прізвищеDataGridViewTextBoxColumn.Name = "прізвищеDataGridViewTextBoxColumn";
            this.прізвищеDataGridViewTextBoxColumn.ReadOnly = true;
            this.прізвищеDataGridViewTextBoxColumn.Width = 81;
            // 
            // імяDataGridViewTextBoxColumn
            // 
            this.імяDataGridViewTextBoxColumn.DataPropertyName = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.HeaderText = "Ім\'я";
            this.імяDataGridViewTextBoxColumn.Name = "імяDataGridViewTextBoxColumn";
            this.імяDataGridViewTextBoxColumn.ReadOnly = true;
            this.імяDataGridViewTextBoxColumn.Width = 51;
            // 
            // поБатьковіDataGridViewTextBoxColumn
            // 
            this.поБатьковіDataGridViewTextBoxColumn.DataPropertyName = "По батькові";
            this.поБатьковіDataGridViewTextBoxColumn.HeaderText = "По батькові";
            this.поБатьковіDataGridViewTextBoxColumn.Name = "поБатьковіDataGridViewTextBoxColumn";
            this.поБатьковіDataGridViewTextBoxColumn.ReadOnly = true;
            this.поБатьковіDataGridViewTextBoxColumn.Width = 85;
            // 
            // назваДисципліниDataGridViewTextBoxColumn
            // 
            this.назваДисципліниDataGridViewTextBoxColumn.DataPropertyName = "Назва дисципліни";
            this.назваДисципліниDataGridViewTextBoxColumn.HeaderText = "Назва дисципліни";
            this.назваДисципліниDataGridViewTextBoxColumn.Name = "назваДисципліниDataGridViewTextBoxColumn";
            this.назваДисципліниDataGridViewTextBoxColumn.ReadOnly = true;
            this.назваДисципліниDataGridViewTextBoxColumn.Width = 113;
            // 
            // кількістьГодинDataGridViewTextBoxColumn
            // 
            this.кількістьГодинDataGridViewTextBoxColumn.DataPropertyName = "Кількість годин";
            this.кількістьГодинDataGridViewTextBoxColumn.HeaderText = "Кількість годин";
            this.кількістьГодинDataGridViewTextBoxColumn.Name = "кількістьГодинDataGridViewTextBoxColumn";
            this.кількістьГодинDataGridViewTextBoxColumn.ReadOnly = true;
            this.кількістьГодинDataGridViewTextBoxColumn.Width = 101;
            // 
            // disciplineInfoBindingSource
            // 
            this.disciplineInfoBindingSource.DataMember = "Discipline_Info";
            this.disciplineInfoBindingSource.DataSource = this.disciplineListDataSet;
            // 
            // disciplineListDataSet
            // 
            this.disciplineListDataSet.DataSetName = "DisciplineListDataSet";
            this.disciplineListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // disciplineFindBox
            // 
            this.disciplineFindBox.BackColor = System.Drawing.Color.White;
            this.disciplineFindBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplineFindBox.Image = ((System.Drawing.Image)(resources.GetObject("disciplineFindBox.Image")));
            this.disciplineFindBox.Location = new System.Drawing.Point(492, 73);
            this.disciplineFindBox.Name = "disciplineFindBox";
            this.disciplineFindBox.Size = new System.Drawing.Size(70, 162);
            this.disciplineFindBox.TabIndex = 34;
            this.disciplineFindBox.UseVisualStyleBackColor = false;
            this.disciplineFindBox.Click += new System.EventHandler(this.disciplineFindBox_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(492, 364);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(70, 35);
            this.homeButton.TabIndex = 38;
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // deleteDisciplineButton
            // 
            this.deleteDisciplineButton.BackColor = System.Drawing.Color.White;
            this.deleteDisciplineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteDisciplineButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteDisciplineButton.Image")));
            this.deleteDisciplineButton.Location = new System.Drawing.Point(492, 323);
            this.deleteDisciplineButton.Name = "deleteDisciplineButton";
            this.deleteDisciplineButton.Size = new System.Drawing.Size(70, 35);
            this.deleteDisciplineButton.TabIndex = 37;
            this.deleteDisciplineButton.UseVisualStyleBackColor = false;
            this.deleteDisciplineButton.Click += new System.EventHandler(this.deleteDisciplineButton_Click);
            // 
            // editDisciplineButton
            // 
            this.editDisciplineButton.BackColor = System.Drawing.Color.White;
            this.editDisciplineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editDisciplineButton.Image = ((System.Drawing.Image)(resources.GetObject("editDisciplineButton.Image")));
            this.editDisciplineButton.Location = new System.Drawing.Point(492, 282);
            this.editDisciplineButton.Name = "editDisciplineButton";
            this.editDisciplineButton.Size = new System.Drawing.Size(70, 35);
            this.editDisciplineButton.TabIndex = 36;
            this.editDisciplineButton.UseVisualStyleBackColor = false;
            this.editDisciplineButton.Click += new System.EventHandler(this.editDisciplineButton_Click);
            // 
            // addDisciplineButton
            // 
            this.addDisciplineButton.BackColor = System.Drawing.Color.White;
            this.addDisciplineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDisciplineButton.Image = ((System.Drawing.Image)(resources.GetObject("addDisciplineButton.Image")));
            this.addDisciplineButton.Location = new System.Drawing.Point(492, 241);
            this.addDisciplineButton.Name = "addDisciplineButton";
            this.addDisciplineButton.Size = new System.Drawing.Size(70, 35);
            this.addDisciplineButton.TabIndex = 35;
            this.addDisciplineButton.UseVisualStyleBackColor = false;
            this.addDisciplineButton.Click += new System.EventHandler(this.addDisciplineButton_Click);
            // 
            // discipline_InfoTableAdapter
            // 
            this.discipline_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineProcedureTableAdapter
            // 
            this.disciplineProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // teacherProcedureTableAdapter
            // 
            this.teacherProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // Disciplines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 630);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.deleteDisciplineButton);
            this.Controls.Add(this.editDisciplineButton);
            this.Controls.Add(this.addDisciplineButton);
            this.Controls.Add(this.disciplineFindBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Disciplines";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Шкільні дисципліни";
            this.Load += new System.EventHandler(this.Disciplines_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherProcedureDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineProcedureDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.disciplineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineListDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView disciplineGridView;
        private System.Windows.Forms.Button disciplineFindBox;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Button deleteDisciplineButton;
        private System.Windows.Forms.Button editDisciplineButton;
        private System.Windows.Forms.Button addDisciplineButton;
        private ListDataSets.DisciplineListDataSet disciplineListDataSet;
        private System.Windows.Forms.BindingSource disciplineInfoBindingSource;
        private ListDataSets.DisciplineListDataSetTableAdapters.Discipline_InfoTableAdapter discipline_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поБатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn назваДисципліниDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кількістьГодинDataGridViewTextBoxColumn;
        private System.Windows.Forms.CheckBox teacherCheck;
        private System.Windows.Forms.CheckBox disciplineCheck;
        private disciplineProcedureDataSet disciplineProcedureDataSet;
        private System.Windows.Forms.BindingSource disciplineProcedureBindingSource;
        private disciplineProcedureDataSetTableAdapters.DisciplineProcedureTableAdapter disciplineProcedureTableAdapter;
        internal System.Windows.Forms.ComboBox disciplineBox;
        private GeneralDataSets.TeacherProcedureDataSet teacherProcedureDataSet;
        private System.Windows.Forms.BindingSource teacherProcedureBindingSource;
        private GeneralDataSets.TeacherProcedureDataSetTableAdapters.TeacherProcedureTableAdapter teacherProcedureTableAdapter;
        internal System.Windows.Forms.ComboBox teacherBox;
    }
}