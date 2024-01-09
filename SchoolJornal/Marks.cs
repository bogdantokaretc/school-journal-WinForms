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

namespace SchoolJornal
{
    public partial class Marks : Form
    {
        SqlConnection connection;
        public Marks()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=true;User studentID=sa;Password=123456789");
            InitializeComponent();
        }

        public Marks(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        private void Default() //Default view settings
        {
            markFindBox.Clear();
            markCheck.CheckState = CheckState.Unchecked;
            disciplineCheck.CheckState = CheckState.Unchecked;
            markGridView.DataSource = markListDataSet.Mark_Info;
            this.mark_InfoTableAdapter.Fill(this.markListDataSet.Mark_Info);
        }
        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addStudentButton_Click(object sender, EventArgs e)
        {
            AddEditMark addEditMark = new AddEditMark();
            addEditMark.ShowDialog();
            Default();
        }
        private void Edit(AddEditMark EditMark)
        {
            try
            {

                int index = markGridView.CurrentCell.RowIndex;
                var Surname = Convert.ToString(markGridView.Rows[index].Cells[0].Value);
                var Name = Convert.ToString(markGridView.Rows[index].Cells[1].Value);
                var Patronymic = Convert.ToString(markGridView.Rows[index].Cells[2].Value);
                var Discipline = Convert.ToString(markGridView.Rows[index].Cells[3].Value);
                var Mark = Convert.ToString(markGridView.Rows[index].Cells[4].Value);
                var Date = Convert.ToString(markGridView.Rows[index].Cells[5].Value);

                EditMark.classProcedureTableAdapter.Fill(EditMark.classDataSet.ClassProcedure);
                EditMark.mark_InfoTableAdapter.Fill(EditMark.markListDataSet.Mark_Info);
                EditMark.disciplineTableAdapter.Fill(EditMark.disciplineDataSet.Discipline);
                EditMark.mark_EncryptionTableAdapter.Fill(EditMark.markEncryptionDataSet.Mark_Encryption);

                connection.Open();
                string query = $"SELECT ID_Class FROM Student WHERE Student_Surname = '{Surname}' AND Student_Name = '{Name}' AND Student_Patronymic = '{Patronymic}'";
                SqlCommand command = new SqlCommand(query, connection);
                EditMark.educationClassBox.SelectedValue = command.ExecuteScalar().ToString();

                query = $"SELECT ID_Mark FROM Mark WHERE ID_Student=(SELECT ID_Student FROM Student WHERE Student_Surname = '{Surname}' AND Student_Name = '{Name}' AND Student_Patronymic = '{Patronymic}') AND Mark='{Mark}' AND ID_Discipline=(SELECT ID_Discipline FROM Discipline WHERE Discipline_Name = '{Discipline}')";
                command = new SqlCommand(query, connection);
                EditMark.markTypeBox.SelectedValue = command.ExecuteScalar().ToString();

                query = $"SELECT ID_Discipline FROM Discipline WHERE Discipline_Name = '{Discipline}'";
                command = new SqlCommand(query, connection);
                EditMark.disciplineBox.SelectedValue = command.ExecuteScalar().ToString();

                EditMark.comboNameBox.SelectedValue = Surname + " " + Name + " " + Patronymic;
                EditMark.markBox.SelectedItem = Mark;
                EditMark.markBox.Tag = Date;
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editStudentButton_Click(object sender, EventArgs e)
        {
            AddEditMark editMark = new AddEditMark();
            editMark.addEditButton.Text = "Змінити оцінку учня";
            editMark.mainLabel.Text = "Форма для зміни оцінки учня";
            Edit(editMark);
            editMark.ShowDialog();
            Default();
        }
        private void Delete()
        {
            try
            { 
                connection.Open();
                int index = markGridView.CurrentCell.RowIndex;
                var Date = Convert.ToString(markGridView.Rows[index].Cells[5].Value);

                string query = $"DELETE FROM Mark WHERE Mark_Date='{Date}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Дані успішно видалені!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
           
        }
        private void Marks_Load(object sender, EventArgs e)
        {
            this.mark_InfoTableAdapter.Fill(this.markListDataSet.Mark_Info);
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            if (markGridView.SelectedRows == null)
            {
                MessageBox.Show("Виберіть вчителя якого хочете видалити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DialogResult.Yes == MessageBox.Show("Ви впевнені що хочете видалити цей запис ? ", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Delete();
                Default();
            }
        }

        private void searchMarkButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                if (markBox.SelectedItem == null)
                {
                    string query = $"SELECT * FROM Mark_Info WHERE CONCAT ([Прізвище], [Ім'я], [По батькові]) LIKE '%{markFindBox.Text}%' " +
                    $"AND [Дисципліна] LIKE '%{disciplineBox.SelectedValue}%'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    markGridView.DataSource = ds.Tables[0];
                    connection.Close();
                }
                else
                {
                    string query = $"SELECT * FROM Mark_Info WHERE CONCAT ([Прізвище], [Ім'я], [По батькові]) LIKE '%{markFindBox.Text}%' " +
                    $"AND [Дисципліна] LIKE '%{disciplineBox.SelectedValue}%' AND [Оцінка] LIKE '{markBox.SelectedItem}'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    markGridView.DataSource = ds.Tables[0];
                    connection.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void findMarkBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(markFindBox.Text))
            {
                markGridView.DataSource = this.markListDataSet.Mark_Info;
                this.mark_InfoTableAdapter.Fill(this.markListDataSet.Mark_Info);
            }
        }

        private void disciplineCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (disciplineCheck.Checked)
            {
                disciplineCheck.BackColor = System.Drawing.Color.Green;
                disciplineBox.Enabled = true;
                disciplineBox.DataSource = disciplineProcedureDataSet.DisciplineProcedure;
                disciplineBox.DisplayMember = "Назва дисципліни";
                this.disciplineProcedureTableAdapter.Fill(this.disciplineProcedureDataSet.DisciplineProcedure);
            }
            if (!disciplineCheck.Checked)
            {
                disciplineCheck.BackColor = System.Drawing.Color.Red;
                disciplineBox.Enabled = false;
                disciplineBox.DataSource = null;
                this.disciplineProcedureTableAdapter.Dispose();
            }
        }

        

        private void markCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (markCheck.Checked)
            {
                markCheck.BackColor = System.Drawing.Color.Green;
                markBox.Enabled = true;
                markBox.SelectedIndex = 0;
            }
            if (!markCheck.Checked)
            {
                markCheck.BackColor = System.Drawing.Color.Red;
                markBox.Enabled = false;
                markBox.SelectedItem = null;
            }
        }
    }
}
