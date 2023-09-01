


namespace OBD_2
{
    partial class AddEditDiscipline
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.mainLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.teacherBox = new System.Windows.Forms.ComboBox();
            this.teacherProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            //this.teacherDataSet = new OBD_2.GeneralDataSets.teacherDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameBox = new System.Windows.Forms.ComboBox();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineDataSet = new OBD_2.GeneralDataSets.DisciplineDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.addEditButton = new System.Windows.Forms.Button();
            this.DisciplineTip = new System.Windows.Forms.ToolTip(this.components);
            this.TeacherTip = new System.Windows.Forms.ToolTip(this.components);
            this.teacherProcedureTableAdapter = new OBD_2.GeneralDataSets.teacherDataSetTableAdapters.TeacherProcedureTableAdapter();
            this.disciplineTableAdapter = new OBD_2.GeneralDataSets.DisciplineDataSetTableAdapters.DisciplineTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherProcedureBindingSource)).BeginInit();
            //((System.ComponentModel.ISupportInitialize)(this.teacherDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.mainLabel);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.addEditButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 351);
            this.panel1.TabIndex = 5;
            // 
            // mainLabel
            // 
            this.mainLabel.CausesValidation = false;
            this.mainLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(14, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(350, 68);
            this.mainLabel.TabIndex = 12;
            this.mainLabel.Text = "Форма для внесення даних про дисципліну";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teacherBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(14, 189);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 98);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Інформація про вчителя";
            // 
            // teacherBox
            // 
            this.teacherBox.DataSource = this.teacherProcedureBindingSource;
            this.teacherBox.DisplayMember = "Column1";
            this.teacherBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherBox.FormattingEnabled = true;
            this.teacherBox.Location = new System.Drawing.Point(25, 55);
            this.teacherBox.Name = "teacherBox";
            this.teacherBox.Size = new System.Drawing.Size(299, 29);
            this.teacherBox.TabIndex = 7;
            this.TeacherTip.SetToolTip(this.teacherBox, "Вибір ПІБ вчителя");
            this.teacherBox.ValueMember = "Column1";
            // 
            // teacherProcedureBindingSource
            // 
            //this.teacherProcedureBindingSource.DataMember = "TeacherProcedure";
            //this.teacherProcedureBindingSource.DataSource = this.teacherDataSet;
            // 
            // teacherDataSet
            // 
            //this.teacherDataSet.DataSetName = "teacherDataSet";
            //this.teacherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(208, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Прізвище, ім\'я, по батькові";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 97);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Інформація про дисципліну";
            // 
            // nameBox
            // 
            this.nameBox.DataSource = this.disciplineBindingSource;
            this.nameBox.DisplayMember = "Discipline_Name";
            this.nameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.FormattingEnabled = true;
            this.nameBox.Location = new System.Drawing.Point(24, 55);
            this.nameBox.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 29);
            this.nameBox.TabIndex = 17;
            this.nameBox.ValueMember = "ID_Discipline";
            // 
            // disciplineBindingSource
            // 
            this.disciplineBindingSource.DataMember = "Discipline";
            this.disciplineBindingSource.DataSource = this.disciplineDataSet;
            // 
            // disciplineDataSet
            // 
            this.disciplineDataSet.DataSetName = "DisciplineDataSet";
            this.disciplineDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Назва";
            // 
            // addEditButton
            // 
            this.addEditButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEditButton.Location = new System.Drawing.Point(38, 302);
            this.addEditButton.Margin = new System.Windows.Forms.Padding(10);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(299, 35);
            this.addEditButton.TabIndex = 8;
            this.addEditButton.Text = "Зберегти дані дисципліни";
            this.addEditButton.UseVisualStyleBackColor = false;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // DisciplineTip
            // 
            this.DisciplineTip.AutomaticDelay = 50;
            this.DisciplineTip.AutoPopDelay = 1000;
            this.DisciplineTip.InitialDelay = 50;
            this.DisciplineTip.ReshowDelay = 10;
            this.DisciplineTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.DisciplineTip.ToolTipTitle = "Інформація про дисципліну";
            // 
            // TeacherTip
            // 
            this.TeacherTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.TeacherTip.ToolTipTitle = "Інформація про вчителя";
            // 
            // teacherProcedureTableAdapter
            // 
            this.teacherProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditDiscipline
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 351);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditDiscipline";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внесення дисципліни в АРМ";
            this.Load += new System.EventHandler(this.AddEditDiscipline_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teacherProcedureBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.teacherDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox teacherBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.ToolTip TeacherTip;
        internal System.Windows.Forms.ToolTip DisciplineTip;
        internal GeneralDataSets.teacherDataSet teacherDataSet;
        internal System.Windows.Forms.BindingSource teacherProcedureBindingSource;
        internal GeneralDataSets.teacherDataSetTableAdapters.TeacherProcedureTableAdapter teacherProcedureTableAdapter;
        internal System.Windows.Forms.ComboBox nameBox;
        internal GeneralDataSets.DisciplineDataSet disciplineDataSet;
        internal System.Windows.Forms.BindingSource disciplineBindingSource;
        internal GeneralDataSets.DisciplineDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
    }
}