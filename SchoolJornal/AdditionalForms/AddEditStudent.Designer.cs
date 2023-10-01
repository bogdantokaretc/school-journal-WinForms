
namespace SchoolJornal
{
    partial class AddEditStudent
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.educationClassBox = new System.Windows.Forms.ComboBox();
            this.classDataSet = new SchoolJornal.GeneralDataSets.ClassDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.educationFormBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addEditButton = new System.Windows.Forms.Button();
            this.mainLabel = new System.Windows.Forms.Label();
            this.PersonalInfo = new System.Windows.Forms.ToolTip(this.components);
            this.EducationInfo = new System.Windows.Forms.ToolTip(this.components);
            this.classProcedureBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classProcedureTableAdapter = new SchoolJornal.GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.educationClassBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.educationFormBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(14, 324);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 165);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дані про навчання";
            // 
            // educationClassBox
            // 
            this.educationClassBox.DataSource = this.classProcedureBindingSource;
            this.educationClassBox.DisplayMember = "ID_Class";
            this.educationClassBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationClassBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationClassBox.FormattingEnabled = true;
            this.educationClassBox.Location = new System.Drawing.Point(26, 54);
            this.educationClassBox.Name = "educationClassBox";
            this.educationClassBox.Size = new System.Drawing.Size(299, 29);
            this.educationClassBox.TabIndex = 21;
            this.educationClassBox.ValueMember = "ID_Class";
            // 
            // classDataSet
            // 
            this.classDataSet.DataSetName = "ClassDataSet";
            this.classDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Клас";
            // 
            // educationFormBox
            // 
            this.educationFormBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.educationFormBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationFormBox.FormattingEnabled = true;
            this.educationFormBox.Items.AddRange(new object[] {
            "денна",
            "заочна"});
            this.educationFormBox.Location = new System.Drawing.Point(26, 119);
            this.educationFormBox.Name = "educationFormBox";
            this.educationFormBox.Size = new System.Drawing.Size(299, 29);
            this.educationFormBox.TabIndex = 8;
            this.EducationInfo.SetToolTip(this.educationFormBox, "Вибар форми навчання учня");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Форма навчання";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.surnameBox);
            this.groupBox1.Controls.Add(this.nameBox);
            this.groupBox1.Controls.Add(this.patronymicBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(14, 82);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 232);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональні дані";
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(23, 55);
            this.surnameBox.MaximumSize = new System.Drawing.Size(400, 30);
            this.surnameBox.MinimumSize = new System.Drawing.Size(300, 30);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(300, 29);
            this.surnameBox.TabIndex = 2;
            this.PersonalInfo.SetToolTip(this.surnameBox, "Поле для вводу прізвища учня");
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameBox.Location = new System.Drawing.Point(24, 120);
            this.nameBox.MaximumSize = new System.Drawing.Size(400, 30);
            this.nameBox.MinimumSize = new System.Drawing.Size(300, 30);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(300, 29);
            this.nameBox.TabIndex = 3;
            this.PersonalInfo.SetToolTip(this.nameBox, "Поле для вводу ім\'я учня");
            // 
            // patronymicBox
            // 
            this.patronymicBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.patronymicBox.Location = new System.Drawing.Point(24, 185);
            this.patronymicBox.MaximumSize = new System.Drawing.Size(400, 30);
            this.patronymicBox.MinimumSize = new System.Drawing.Size(300, 30);
            this.patronymicBox.Name = "patronymicBox";
            this.patronymicBox.Size = new System.Drawing.Size(300, 29);
            this.patronymicBox.TabIndex = 4;
            this.PersonalInfo.SetToolTip(this.patronymicBox, "Поле для вводупо батькові учня");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(20, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "По батькові";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Прізвище";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ім\'я";
            // 
            // addEditButton
            // 
            this.addEditButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.addEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addEditButton.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addEditButton.Location = new System.Drawing.Point(40, 504);
            this.addEditButton.Margin = new System.Windows.Forms.Padding(10);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(299, 35);
            this.addEditButton.TabIndex = 12;
            this.addEditButton.Text = "Зберегти дані учня";
            this.addEditButton.UseVisualStyleBackColor = false;
            this.addEditButton.Click += new System.EventHandler(this.addEditButton_Click);
            // 
            // mainLabel
            // 
            this.mainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLabel.CausesValidation = false;
            this.mainLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(14, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(350, 59);
            this.mainLabel.TabIndex = 15;
            this.mainLabel.Text = "Форма для внесення даних учня";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.AutomaticDelay = 50;
            this.PersonalInfo.AutoPopDelay = 10000;
            this.PersonalInfo.InitialDelay = 50;
            this.PersonalInfo.ReshowDelay = 10;
            this.PersonalInfo.ShowAlways = true;
            this.PersonalInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.PersonalInfo.ToolTipTitle = "Персональні дані";
            // 
            // EducationInfo
            // 
            this.EducationInfo.AutomaticDelay = 50;
            this.EducationInfo.AutoPopDelay = 10000;
            this.EducationInfo.InitialDelay = 50;
            this.EducationInfo.ReshowDelay = 10;
            this.EducationInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.EducationInfo.ToolTipTitle = "Дані про навчання";
            // 
            // classProcedureBindingSource
            // 
            this.classProcedureBindingSource.DataMember = "ClassProcedure";
            this.classProcedureBindingSource.DataSource = this.classDataSet;
            // 
            // classProcedureTableAdapter
            // 
            this.classProcedureTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 558);
            this.Controls.Add(this.mainLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addEditButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddEditStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внесення учня в АРМ";
            this.Load += new System.EventHandler(this.AddEditStudent_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classProcedureBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.TextBox surnameBox;
        internal System.Windows.Forms.TextBox nameBox;
        internal System.Windows.Forms.TextBox patronymicBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button addEditButton;
        internal System.Windows.Forms.ComboBox educationFormBox;
        internal System.Windows.Forms.Label mainLabel;
        internal System.Windows.Forms.ToolTip PersonalInfo;
        internal System.Windows.Forms.ToolTip EducationInfo;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.ComboBox educationClassBox;
        internal GeneralDataSets.ClassDataSet classDataSet;
        private System.Windows.Forms.BindingSource classProcedureBindingSource;
        internal GeneralDataSets.ClassDataSetTableAdapters.ClassProcedureTableAdapter classProcedureTableAdapter;
    }
}