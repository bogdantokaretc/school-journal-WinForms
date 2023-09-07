
namespace SchoolJornal
{
    partial class AddEditMark
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
            this.mainLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.disciplineBox = new System.Windows.Forms.ComboBox();
            this.disciplineBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.disciplineDataSet = new SchoolJornal.GeneralDataSets.DisciplineDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.markBox = new System.Windows.Forms.ComboBox();
            this.markTypeBox = new System.Windows.Forms.ComboBox();
            this.markEncryptionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.markEncryptionDataSet = new SchoolJornal.GeneralDataSets.MarkEncryptionDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboNameBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.educationClassBox = new System.Windows.Forms.ComboBox();
            this.classProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDataSet = new SchoolJornal.GeneralDataSets.ClassDataSet();
            this.addEditButton = new System.Windows.Forms.Button();
            this.PersonalInfo = new System.Windows.Forms.ToolTip(this.components);
            this.MarkInfo = new System.Windows.Forms.ToolTip(this.components);
            this.classProcedureTableAdapter = new SchoolJornal.GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter();
            this.mark_EncryptionTableAdapter = new SchoolJornal.GeneralDataSets.MarkEncryptionDataSetTableAdapters.Mark_EncryptionTableAdapter();
            this.disciplineTableAdapter = new SchoolJornal.GeneralDataSets.DisciplineDataSetTableAdapters.DisciplineTableAdapter();
            this.markListDataSet = new SchoolJornal.ListDataSets.MarkListDataSet();
            this.markInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mark_InfoTableAdapter = new SchoolJornal.ListDataSets.MarkListDataSetTableAdapters.Mark_InfoTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markEncryptionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markEncryptionDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markListDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.markInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainLabel
            // 
            this.mainLabel.CausesValidation = false;
            this.mainLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(12, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(409, 68);
            this.mainLabel.TabIndex = 19;
            this.mainLabel.Text = "Форма для внесення оцінки учня";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.disciplineBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.markBox);
            this.groupBox2.Controls.Add(this.markTypeBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 181);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Інформація про оцінку";
            // 
            // disciplineBox
            // 
            this.disciplineBox.DataSource = this.disciplineBindingSource;
            this.disciplineBox.DisplayMember = "Discipline_Name";
            this.disciplineBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.disciplineBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineBox.FormattingEnabled = true;
            this.disciplineBox.Location = new System.Drawing.Point(18, 131);
            this.disciplineBox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.disciplineBox.Name = "disciplineBox";
            this.disciplineBox.Size = new System.Drawing.Size(373, 35);
            this.disciplineBox.TabIndex = 28;
            this.PersonalInfo.SetToolTip(this.disciplineBox, "Вибір учня з вибраної групи");
            this.disciplineBox.ValueMember = "ID_Discipline";
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
            this.label3.Location = new System.Drawing.Point(14, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 27;
            this.label3.Text = "Дисципліна";
            // 
            // markBox
            // 
            this.markBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.markBox.Location = new System.Drawing.Point(286, 55);
            this.markBox.Name = "markBox";
            this.markBox.Size = new System.Drawing.Size(105, 35);
            this.markBox.TabIndex = 8;
            this.MarkInfo.SetToolTip(this.markBox, "Вибір оцінки");
            // 
            // markTypeBox
            // 
            this.markTypeBox.DataSource = this.markEncryptionBindingSource;
            this.markTypeBox.DisplayMember = "Mark_Cryption";
            this.markTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.markTypeBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markTypeBox.FormattingEnabled = true;
            this.markTypeBox.Location = new System.Drawing.Point(18, 55);
            this.markTypeBox.Name = "markTypeBox";
            this.markTypeBox.Size = new System.Drawing.Size(243, 35);
            this.markTypeBox.TabIndex = 7;
            this.MarkInfo.SetToolTip(this.markTypeBox, "Вибір типу оцінки");
            this.markTypeBox.ValueMember = "ID_Mark";
            // 
            // markEncryptionBindingSource
            // 
            this.markEncryptionBindingSource.DataMember = "Mark_Encryption";
            this.markEncryptionBindingSource.DataSource = this.markEncryptionDataSet;
            // 
            // markEncryptionDataSet
            // 
            this.markEncryptionDataSet.DataSetName = "MarkEncryptionDataSet";
            this.markEncryptionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип оцінки";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(282, 33);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Оцінка";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboNameBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.educationClassBox);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 189);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Дані студента";
            // 
            // comboNameBox
            // 
            this.comboNameBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboNameBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboNameBox.FormattingEnabled = true;
            this.comboNameBox.Location = new System.Drawing.Point(18, 134);
            this.comboNameBox.Margin = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.comboNameBox.Name = "comboNameBox";
            this.comboNameBox.Size = new System.Drawing.Size(373, 35);
            this.comboNameBox.TabIndex = 26;
            this.PersonalInfo.SetToolTip(this.comboNameBox, "Вибір учня з вибраної групи");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(247, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Прізвище, ім\'я, по батькові учня";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Клас";
            // 
            // educationClassBox
            // 
            this.educationClassBox.DataSource = this.classProcedureBindingSource;
            this.educationClassBox.DisplayMember = "Клас";
            this.educationClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationClassBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationClassBox.FormattingEnabled = true;
            this.educationClassBox.Location = new System.Drawing.Point(18, 55);
            this.educationClassBox.Name = "educationClassBox";
            this.educationClassBox.Size = new System.Drawing.Size(373, 35);
            this.educationClassBox.TabIndex = 21;
            this.PersonalInfo.SetToolTip(this.educationClassBox, "Вибір групи навчання учня");
            this.educationClassBox.ValueMember = "Клас";
            this.educationClassBox.SelectedValueChanged += new System.EventHandler(this.educationClassBox_SelectedValueChanged);
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
            // addEditButton
            // 
            this.addEditButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEditButton.Location = new System.Drawing.Point(30, 477);
            this.addEditButton.Margin = new System.Windows.Forms.Padding(10);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(373, 37);
            this.addEditButton.TabIndex = 16;
            this.addEditButton.Text = "Зберегти дані оцінки учня";
            this.addEditButton.UseVisualStyleBackColor = false;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.AutomaticDelay = 50;
            this.PersonalInfo.AutoPopDelay = 10000;
            this.PersonalInfo.InitialDelay = 50;
            this.PersonalInfo.ReshowDelay = 10;
            this.PersonalInfo.ShowAlways = true;
            this.PersonalInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.PersonalInfo.ToolTipTitle = "Дані студента";
            // 
            // MarkInfo
            // 
            this.MarkInfo.AutomaticDelay = 50;
            this.MarkInfo.AutoPopDelay = 10000;
            this.MarkInfo.InitialDelay = 50;
            this.MarkInfo.ReshowDelay = 10;
            this.MarkInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MarkInfo.ToolTipTitle = "Інформація про оцінку";
            // 
            // classProcedureTableAdapter
            // 
            this.classProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // mark_EncryptionTableAdapter
            // 
            this.mark_EncryptionTableAdapter.ClearBeforeFill = true;
            // 
            // disciplineTableAdapter
            // 
            this.disciplineTableAdapter.ClearBeforeFill = true;
            // 
            // markListDataSet
            // 
            this.markListDataSet.DataSetName = "MarkListDataSet";
            this.markListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // markInfoBindingSource
            // 
            this.markInfoBindingSource.DataMember = "Mark_Info";
            this.markInfoBindingSource.DataSource = this.markListDataSet;
            // 
            // mark_InfoTableAdapter
            // 
            this.mark_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditMark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 533);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addEditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditMark";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внесення даних про оцінку в АРМ ";
            this.Load += new System.EventHandler(this.AddEditMark_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.disciplineDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markEncryptionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markEncryptionDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markListDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.markInfoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Label mainLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        internal System.Windows.Forms.ComboBox markBox;
        internal System.Windows.Forms.ComboBox markTypeBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button addEditButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.ToolTip MarkInfo;
        internal System.Windows.Forms.ToolTip PersonalInfo;
        internal System.Windows.Forms.ComboBox educationClassBox;
        internal System.Windows.Forms.ComboBox comboNameBox;
        internal System.Windows.Forms.ComboBox disciplineBox;
        private System.Windows.Forms.Label label3;
        internal GeneralDataSets.ClassDataSet classDataSet;
        internal System.Windows.Forms.BindingSource classProcedureBindingSource;
        internal GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter classProcedureTableAdapter;
        internal GeneralDataSets.MarkEncryptionDataSet markEncryptionDataSet;
        internal System.Windows.Forms.BindingSource markEncryptionBindingSource;
        internal GeneralDataSets.MarkEncryptionDataSetTableAdapters.Mark_EncryptionTableAdapter mark_EncryptionTableAdapter;
        internal GeneralDataSets.DisciplineDataSet disciplineDataSet;
        internal System.Windows.Forms.BindingSource disciplineBindingSource;
        internal GeneralDataSets.DisciplineDataSetTableAdapters.DisciplineTableAdapter disciplineTableAdapter;
        internal ListDataSets.MarkListDataSet markListDataSet;
        internal System.Windows.Forms.BindingSource markInfoBindingSource;
        internal ListDataSets.MarkListDataSetTableAdapters.Mark_InfoTableAdapter mark_InfoTableAdapter;
    }
}