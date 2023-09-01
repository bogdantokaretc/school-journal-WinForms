
namespace OBD_2
{
    partial class AddEditTeacher
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
            this.telephoneNumberBox = new System.Windows.Forms.MaskedTextBox();
            this.telephoneTypeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.patronymicBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addEditButton = new System.Windows.Forms.Button();
            this.PersonalInfo = new System.Windows.Forms.ToolTip(this.components);
            this.Contacts = new System.Windows.Forms.ToolTip(this.components);
            this.teacher_InfoTableAdapter = new OBD_2.ListDataSets.TeacherListDataSetTableAdapters.Teacher_InfoTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(380, 558);
            this.panel1.TabIndex = 4;
            // 
            // mainLabel
            // 
            this.mainLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainLabel.CausesValidation = false;
            this.mainLabel.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainLabel.Location = new System.Drawing.Point(3, 9);
            this.mainLabel.Name = "mainLabel";
            this.mainLabel.Size = new System.Drawing.Size(373, 59);
            this.mainLabel.TabIndex = 12;
            this.mainLabel.Text = "Форма для внесення данних вчителя";
            this.mainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.telephoneNumberBox);
            this.groupBox2.Controls.Add(this.telephoneTypeBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(14, 324);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(350, 165);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Контакти";
            // 
            // telephoneNumberBox
            // 
            this.telephoneNumberBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telephoneNumberBox.Location = new System.Drawing.Point(25, 119);
            this.telephoneNumberBox.Name = "telephoneNumberBox";
            this.telephoneNumberBox.Size = new System.Drawing.Size(299, 29);
            this.telephoneNumberBox.TabIndex = 8;
            this.telephoneNumberBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // telephoneTypeBox
            // 
            this.telephoneTypeBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.telephoneTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.telephoneTypeBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.telephoneTypeBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.telephoneTypeBox.Items.AddRange(new object[] {
            "мобільний",
            "стаціонарний"});
            this.telephoneTypeBox.Location = new System.Drawing.Point(25, 55);
            this.telephoneTypeBox.Name = "telephoneTypeBox";
            this.telephoneTypeBox.Size = new System.Drawing.Size(299, 29);
            this.telephoneTypeBox.Sorted = true;
            this.telephoneTypeBox.TabIndex = 7;
            this.Contacts.SetToolTip(this.telephoneTypeBox, "Вибір типу телефона");
            this.telephoneTypeBox.SelectedValueChanged += new System.EventHandler(this.telephoneTypeBox_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Тип телефону";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(21, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Номер телефону";
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
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Персональні дані";
            // 
            // surnameBox
            // 
            this.surnameBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.surnameBox.Location = new System.Drawing.Point(24, 55);
            this.surnameBox.MaximumSize = new System.Drawing.Size(400, 30);
            this.surnameBox.MinimumSize = new System.Drawing.Size(300, 30);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(300, 29);
            this.surnameBox.TabIndex = 2;
            this.PersonalInfo.SetToolTip(this.surnameBox, "Поле для вводу прізвища\r\n");
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
            this.PersonalInfo.SetToolTip(this.nameBox, "Поле для вводу ім\'я");
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
            this.PersonalInfo.SetToolTip(this.patronymicBox, "Поле для вводу по батькові");
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
            this.addEditButton.Location = new System.Drawing.Point(39, 504);
            this.addEditButton.Margin = new System.Windows.Forms.Padding(10);
            this.addEditButton.Name = "addEditButton";
            this.addEditButton.Size = new System.Drawing.Size(299, 35);
            this.addEditButton.TabIndex = 8;
            this.addEditButton.Text = "Зберегти дані вчителя";
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
            this.PersonalInfo.ToolTipTitle = "Персональні дані";
            // 
            // Contacts
            // 
            this.Contacts.AutomaticDelay = 50;
            this.Contacts.AutoPopDelay = 10000;
            this.Contacts.InitialDelay = 50;
            this.Contacts.ReshowDelay = 10;
            this.Contacts.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.Contacts.ToolTipTitle = "Контакти";
            // 
            // teacher_InfoTableAdapter
            // 
            this.teacher_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // AddEditTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 558);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "AddEditTeacher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Внесення вчителя в АРМ";
            this.Load += new System.EventHandler(this.AddEditTeacher_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button addEditButton;
        internal System.Windows.Forms.Label mainLabel;
        internal System.Windows.Forms.TextBox patronymicBox;
        internal System.Windows.Forms.TextBox nameBox;
        internal System.Windows.Forms.TextBox surnameBox;
        internal System.Windows.Forms.ComboBox telephoneTypeBox;
        internal System.Windows.Forms.ToolTip PersonalInfo;
        internal System.Windows.Forms.ToolTip Contacts;
        private ListDataSets.TeacherListDataSetTableAdapters.Teacher_InfoTableAdapter teacher_InfoTableAdapter;
        internal System.Windows.Forms.MaskedTextBox telephoneNumberBox;
    }
}