
namespace SchoolJornal
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportButton = new System.Windows.Forms.Button();
            this.changeUserButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.disciplineButton = new System.Windows.Forms.Button();
            this.markButton = new System.Windows.Forms.Button();
            this.studentButton = new System.Windows.Forms.Button();
            this.teacherButton = new System.Windows.Forms.Button();
            this.MainTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.reportButton);
            this.panel1.Controls.Add(this.changeUserButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(383, 370);
            this.panel1.TabIndex = 0;
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.reportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportButton.Image = ((System.Drawing.Image)(resources.GetObject("reportButton.Image")));
            this.reportButton.Location = new System.Drawing.Point(44, 332);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(35, 35);
            this.reportButton.TabIndex = 4;
            this.MainTip.SetToolTip(this.reportButton, "Кнопка для перегляду звітів");
            this.reportButton.UseVisualStyleBackColor = false;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // changeUserButton
            // 
            this.changeUserButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.changeUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeUserButton.Image = ((System.Drawing.Image)(resources.GetObject("changeUserButton.Image")));
            this.changeUserButton.Location = new System.Drawing.Point(3, 332);
            this.changeUserButton.Name = "changeUserButton";
            this.changeUserButton.Size = new System.Drawing.Size(35, 35);
            this.changeUserButton.TabIndex = 3;
            this.MainTip.SetToolTip(this.changeUserButton, "Кнопка для зміни користувача");
            this.changeUserButton.UseVisualStyleBackColor = false;
            this.changeUserButton.Click += new System.EventHandler(this.changeUserButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(166, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Розроблено: Токарець Б.О.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(36, 191);
            this.label1.MaximumSize = new System.Drawing.Size(350, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 100);
            this.label1.TabIndex = 1;
            this.label1.Text = "АРМ контролю успішності учнів";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(102, 37);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 154);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.disciplineButton);
            this.panel2.Controls.Add(this.markButton);
            this.panel2.Controls.Add(this.studentButton);
            this.panel2.Controls.Add(this.teacherButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(383, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 370);
            this.panel2.TabIndex = 1;
            // 
            // disciplineButton
            // 
            this.disciplineButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.disciplineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.disciplineButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.disciplineButton.Location = new System.Drawing.Point(18, 268);
            this.disciplineButton.Margin = new System.Windows.Forms.Padding(5);
            this.disciplineButton.Name = "disciplineButton";
            this.disciplineButton.Padding = new System.Windows.Forms.Padding(10);
            this.disciplineButton.Size = new System.Drawing.Size(343, 67);
            this.disciplineButton.TabIndex = 4;
            this.disciplineButton.Text = "Дисципліни";
            this.disciplineButton.UseVisualStyleBackColor = false;
            this.disciplineButton.Click += new System.EventHandler(this.disciplineButton_Click);
            // 
            // markButton
            // 
            this.markButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.markButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.markButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.markButton.Location = new System.Drawing.Point(18, 191);
            this.markButton.Margin = new System.Windows.Forms.Padding(5);
            this.markButton.Name = "markButton";
            this.markButton.Padding = new System.Windows.Forms.Padding(10);
            this.markButton.Size = new System.Drawing.Size(343, 67);
            this.markButton.TabIndex = 3;
            this.markButton.Text = "Оцінки";
            this.markButton.UseVisualStyleBackColor = false;
            this.markButton.Click += new System.EventHandler(this.markButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.studentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studentButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.studentButton.Location = new System.Drawing.Point(18, 114);
            this.studentButton.Margin = new System.Windows.Forms.Padding(5);
            this.studentButton.Name = "studentButton";
            this.studentButton.Padding = new System.Windows.Forms.Padding(10);
            this.studentButton.Size = new System.Drawing.Size(343, 67);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Учні";
            this.studentButton.UseVisualStyleBackColor = false;
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // teacherButton
            // 
            this.teacherButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.teacherButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.teacherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.teacherButton.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.teacherButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teacherButton.Location = new System.Drawing.Point(18, 37);
            this.teacherButton.Margin = new System.Windows.Forms.Padding(5);
            this.teacherButton.Name = "teacherButton";
            this.teacherButton.Padding = new System.Windows.Forms.Padding(10);
            this.teacherButton.Size = new System.Drawing.Size(343, 67);
            this.teacherButton.TabIndex = 0;
            this.teacherButton.Text = "Вчителі";
            this.teacherButton.UseVisualStyleBackColor = false;
            this.teacherButton.Click += new System.EventHandler(this.teacherButton_Click);
            // 
            // MainTip
            // 
            this.MainTip.AutomaticDelay = 50;
            this.MainTip.AutoPopDelay = 10000;
            this.MainTip.InitialDelay = 50;
            this.MainTip.IsBalloon = true;
            this.MainTip.ReshowDelay = 10;
            this.MainTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.MainTip.ToolTipTitle = "Форма управління АРМ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 370);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Реєстр школи";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button changeUserButton;
        private System.Windows.Forms.ToolTip MainTip;
        internal System.Windows.Forms.Button reportButton;
        internal System.Windows.Forms.Button markButton;
        internal System.Windows.Forms.Button studentButton;
        internal System.Windows.Forms.Button teacherButton;
        internal System.Windows.Forms.Button disciplineButton;
    }
}

