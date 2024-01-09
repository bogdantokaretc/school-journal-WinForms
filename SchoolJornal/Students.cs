using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Data.SqlClient;
using static SchoolJornal.GeneralDataSets.DisciplineDataSet;

namespace SchoolJornal
{
    public partial class Students : Form
    {
        SqlConnection connection;
        public Students()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=true;User studentID=sa;Password=123456789");
            InitializeComponent();
        }

        public Students(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        private void Default() //Default view settings 
        {
            studentFindBox.Clear();
            classCheck.CheckState = CheckState.Unchecked;
            educationFormCheck.CheckState= CheckState.Unchecked;
            studentGridView.DataSource = studentListDataSet.Student_Info;
            this.student_InfoTableAdapter.Fill(this.studentListDataSet.Student_Info);
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddEditStudent addStudent = new AddEditStudent();
            addStudent.ShowDialog();
            Default();
        }
        private void Edit(AddEditStudent EditStudent)
        {
            try
            {

                int index = studentGridView.CurrentCell.RowIndex;
                var Surname = Convert.ToString(studentGridView.Rows[index].Cells[0].Value);
                var Name = Convert.ToString(studentGridView.Rows[index].Cells[1].Value);
                var Patronymic = Convert.ToString(studentGridView.Rows[index].Cells[2].Value);
                var Class = Convert.ToString(studentGridView.Rows[index].Cells[3].Value);
                var EducationForm = Convert.ToString(studentGridView.Rows[index].Cells[4].Value);
                EditStudent.classProcedureTableAdapter.Fill(EditStudent.classDataSet.ClassProcedure);
                EditStudent.surnameBox.Text = Surname;
                EditStudent.nameBox.Text = Name;
                EditStudent.patronymicBox.Text = Patronymic;
                EditStudent.educationClassBox.SelectedValue = Class;
                EditStudent.educationFormBox.SelectedItem = EducationForm;

            }
            catch
            {
                MessageBox.Show("Помилка оновлення даних!", "Помилка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editStudentButton_Click(object sender, EventArgs e)
        {
            AddEditStudent editStudent = new AddEditStudent();
            editStudent.addEditButton.Text = "Змінити дані учня";
            editStudent.mainLabel.Text = "Форма для зміни даних учня";
            editStudent.PersonalInfo.SetToolTip(editStudent.surnameBox, "Поле для зміни прізвища учня");
            editStudent.PersonalInfo.SetToolTip(editStudent.nameBox, "Поле для зміни ім'я учня");
            editStudent.PersonalInfo.SetToolTip(editStudent.patronymicBox, "Поле для зміни по батькові учня");
            editStudent.EducationInfo.SetToolTip(editStudent.educationClassBox, "Поле для зміни групи навчання учня");
            editStudent.EducationInfo.SetToolTip(editStudent.educationFormBox, "Поле для зміни форми навчання учня");
            Edit(editStudent);
            editStudent.ShowDialog();
            Default();
        }
        private void Delete()
        {

            try
            {

                connection.Open();
                int index = studentGridView.CurrentCell.RowIndex;
                var Surname = Convert.ToString(studentGridView.Rows[index].Cells[0].Value);
                var Name = Convert.ToString(studentGridView.Rows[index].Cells[1].Value);
                var Patronymic = Convert.ToString(studentGridView.Rows[index].Cells[2].Value);

                string query = $"DELETE FROM Student WHERE Student_Surname='{Surname}' AND Student_Name='{Name}' AND Student_Patronymic='{Patronymic}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Дані успішно видалені!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            connection.Close();
        }
        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (studentGridView.SelectedRows == null)
            {
                MessageBox.Show("Виберіть вчителя якого хочете видалити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DialogResult.Yes == MessageBox.Show("Ви впевнені що хочете видалити цей запис ? ", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Delete();
                Default();
            }
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Students_Load(object sender, EventArgs e)
        { 

            this.student_InfoTableAdapter.Fill(this.studentListDataSet.Student_Info);

        }

        private void searchStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM Student_Info WHERE CONCAT ([Прізвище], [Ім'я], [По батькові]) LIKE '%{studentFindBox.Text}%' " +
                    $"AND [Клас] LIKE '%{classBox.SelectedValue}%' AND [Форма навчання] LIKE '%{educationFormBox.SelectedValue}%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                studentGridView.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void studentFindBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(studentFindBox.Text))
            {
                studentGridView.DataSource = this.studentListDataSet.Student_Info;
                this.student_InfoTableAdapter.Fill(this.studentListDataSet.Student_Info);
            }
        }


        private void classCheck_Click(object sender, EventArgs e)
        {
            if (classCheck.Checked)
            {
                classCheck.BackColor = System.Drawing.Color.Green;
                classBox.Enabled = true;
                classBox.DataSource = classDataSet.ClassProcedure;
                classBox.DisplayMember = "ID_Class";
                this.classProcedureTableAdapter.Fill(this.classDataSet.ClassProcedure);
            }
            if (!classCheck.Checked)
            {
                classCheck.BackColor = System.Drawing.Color.Red;
                classBox.Enabled = false;
                classBox.DataSource = null;
                this.classProcedureTableAdapter.Dispose();
            }
        }

        private void educationFormCheck_Click(object sender, EventArgs e)
        {
            if (educationFormCheck.Checked)
            {
                educationFormCheck.BackColor = System.Drawing.Color.Green;
                educationFormBox.Enabled = true;
                educationFormBox.DataSource = educationFormDataSet.EducationFormProcedure;
                educationFormBox.DisplayMember = "Форма навчання";
                this.educationFormProcedureTableAdapter.Fill(this.educationFormDataSet.EducationFormProcedure);
            }
            if (!educationFormCheck.Checked)
            {
                educationFormCheck.BackColor = System.Drawing.Color.Red;
                educationFormBox.Enabled = false;
                educationFormBox.DataSource = null;
                this.educationFormProcedureTableAdapter.Dispose();
            }
        }
    }
}
