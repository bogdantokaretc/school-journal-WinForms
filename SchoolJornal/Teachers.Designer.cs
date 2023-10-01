
namespace SchoolJornal
{
    partial class Teachers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Teachers));
            this.findBox = new System.Windows.Forms.TextBox();
            this.findButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.editTeacherButton = new System.Windows.Forms.Button();
            this.deleteTeacherButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.прізвищеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.імяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поБатьковіDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типТелефонуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонуDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teacherListDataSet = new SchoolJornal.ListDataSets.TeacherListDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teacher_InfoTableAdapter = new SchoolJornal.ListDataSets.TeacherListDataSetTableAdapters.Teacher_InfoTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // findBox
            // 
            this.findBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.findBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.findBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findBox.Location = new System.Drawing.Point(12, 96);
            this.findBox.MaximumSize = new System.Drawing.Size(500, 35);
            this.findBox.MinimumSize = new System.Drawing.Size(300, 35);
            this.findBox.Name = "findBox";
            this.findBox.Size = new System.Drawing.Size(461, 35);
            this.findBox.TabIndex = 1;
            this.toolTip1.SetToolTip(this.findBox, "Введіть дані для пошуку вчителя");
            this.findBox.TextChanged += new System.EventHandler(this.findBox_TextChanged);
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.White;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findButton.Image = ((System.Drawing.Image)(resources.GetObject("findButton.Image")));
            this.findButton.Location = new System.Drawing.Point(479, 96);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(70, 35);
            this.findButton.TabIndex = 2;
            this.toolTip1.SetToolTip(this.findButton, "Пошук");
            this.findButton.UseVisualStyleBackColor = false;
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Список вчителів школи";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.BackColor = System.Drawing.Color.White;
            this.addTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("addTeacherButton.Image")));
            this.addTeacherButton.Location = new System.Drawing.Point(479, 137);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(70, 35);
            this.addTeacherButton.TabIndex = 4;
            this.toolTip1.SetToolTip(this.addTeacherButton, "Додати новий запис");
            this.addTeacherButton.UseVisualStyleBackColor = false;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // editTeacherButton
            // 
            this.editTeacherButton.BackColor = System.Drawing.Color.White;
            this.editTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("editTeacherButton.Image")));
            this.editTeacherButton.Location = new System.Drawing.Point(479, 178);
            this.editTeacherButton.Name = "editTeacherButton";
            this.editTeacherButton.Size = new System.Drawing.Size(70, 35);
            this.editTeacherButton.TabIndex = 5;
            this.toolTip1.SetToolTip(this.editTeacherButton, "Редагувати вибраний запис");
            this.editTeacherButton.UseVisualStyleBackColor = false;
            this.editTeacherButton.Click += new System.EventHandler(this.editTeacherButton_Click);
            // 
            // deleteTeacherButton
            // 
            this.deleteTeacherButton.BackColor = System.Drawing.Color.White;
            this.deleteTeacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteTeacherButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteTeacherButton.Image")));
            this.deleteTeacherButton.Location = new System.Drawing.Point(479, 219);
            this.deleteTeacherButton.Name = "deleteTeacherButton";
            this.deleteTeacherButton.Size = new System.Drawing.Size(70, 35);
            this.deleteTeacherButton.TabIndex = 6;
            this.toolTip1.SetToolTip(this.deleteTeacherButton, "Видалити вибраний запис");
            this.deleteTeacherButton.UseVisualStyleBackColor = false;
            this.deleteTeacherButton.Click += new System.EventHandler(this.deleteTeacherButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.BackColor = System.Drawing.Color.White;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.Location = new System.Drawing.Point(479, 260);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(70, 35);
            this.homeButton.TabIndex = 25;
            this.toolTip1.SetToolTip(this.homeButton, "Головна сторінка");
            this.homeButton.UseVisualStyleBackColor = false;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(461, 382);
            this.panel1.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.прізвищеDataGridViewTextBoxColumn,
            this.імяDataGridViewTextBoxColumn,
            this.поБатьковіDataGridViewTextBoxColumn,
            this.типТелефонуDataGridViewTextBoxColumn,
            this.номерТелефонуDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.teacherInfoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(461, 382);
            this.dataGridView1.TabIndex = 0;
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
            // типТелефонуDataGridViewTextBoxColumn
            // 
            this.типТелефонуDataGridViewTextBoxColumn.DataPropertyName = "Тип телефону";
            this.типТелефонуDataGridViewTextBoxColumn.HeaderText = "Тип телефону";
            this.типТелефонуDataGridViewTextBoxColumn.Name = "типТелефонуDataGridViewTextBoxColumn";
            this.типТелефонуDataGridViewTextBoxColumn.ReadOnly = true;
            this.типТелефонуDataGridViewTextBoxColumn.Width = 94;
            // 
            // номерТелефонуDataGridViewTextBoxColumn
            // 
            this.номерТелефонуDataGridViewTextBoxColumn.DataPropertyName = "Номер телефону";
            this.номерТелефонуDataGridViewTextBoxColumn.HeaderText = "Номер телефону";
            this.номерТелефонуDataGridViewTextBoxColumn.Name = "номерТелефонуDataGridViewTextBoxColumn";
            this.номерТелефонуDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерТелефонуDataGridViewTextBoxColumn.Width = 107;
            // 
            // teacherInfoBindingSource
            // 
            this.teacherInfoBindingSource.DataMember = "Teacher_Info";
            this.teacherInfoBindingSource.DataSource = this.teacherListDataSet;
            // 
            // teacherListDataSet
            // 
            this.teacherListDataSet.DataSetName = "TeacherListDataSet";
            this.teacherListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Cambria", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 51);
            this.label1.TabIndex = 8;
            this.label1.Text = "Список вчителів школи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(8, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(272, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Прізвище, ім\'я, по батькові вчителя";
            // 
            // teacher_InfoTableAdapter
            // 
            this.teacher_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // Teachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 528);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.homeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteTeacherButton);
            this.Controls.Add(this.editTeacherButton);
            this.Controls.Add(this.addTeacherButton);
            this.Controls.Add(this.findButton);
            this.Controls.Add(this.findBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Teachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Вчителі школи";
            this.Load += new System.EventHandler(this.Teachers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherListDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.Button editTeacherButton;
        private System.Windows.Forms.Button deleteTeacherButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label label2;
        private ListDataSets.TeacherListDataSet teacherListDataSet;
        private System.Windows.Forms.BindingSource teacherInfoBindingSource;
        private ListDataSets.TeacherListDataSetTableAdapters.Teacher_InfoTableAdapter teacher_InfoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn прізвищеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn імяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn поБатьковіDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типТелефонуDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонуDataGridViewTextBoxColumn;
        internal System.Windows.Forms.TextBox findBox;
    }
}