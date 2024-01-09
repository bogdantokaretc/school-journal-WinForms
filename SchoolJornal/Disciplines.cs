using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SchoolJornal
{
    public partial class Disciplines : Form
    {
        SqlConnection connection;
        //Main constructor for the final version of program
        public Disciplines()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=true;User studentID=sa;Password=123456789");
            InitializeComponent();
        }

        //Constructor for debugging
        public Disciplines(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        //Reloading Discipline form into default state
        private void Default()
        {
           
            disciplineCheck.CheckState = CheckState.Unchecked;
            teacherCheck.CheckState = CheckState.Unchecked;
            disciplineGridView.DataSource = disciplineListDataSet.Discipline_Info;
            this.discipline_InfoTableAdapter.Fill(this.disciplineListDataSet.Discipline_Info);
        }

        //Open AddDiscipline form
        private void addDisciplineButton_Click(object sender, EventArgs e)
        {
            AddEditDiscipline addDiscipline = new AddEditDiscipline();
            addDiscipline.ShowDialog();
            Default();
        }

        //Converting selected data from DataGrid for EditDiscipline form
        private void Edit(AddEditDiscipline EditDiscipline)
        {
            try
            {
                connection.Open();
                int index = disciplineGridView.CurrentCell.RowIndex;
                var Surname = Convert.ToString(disciplineGridView.Rows[index].Cells[0].Value);
                var Name = Convert.ToString(disciplineGridView.Rows[index].Cells[1].Value);
                var Patronymic = Convert.ToString(disciplineGridView.Rows[index].Cells[2].Value);
                var Discipline = Convert.ToString(disciplineGridView.Rows[index].Cells[3].Value);
                var AmountTime = Convert.ToString(disciplineGridView.Rows[index].Cells[4].Value);
                EditDiscipline.disciplineTableAdapter.Fill(EditDiscipline.disciplineDataSet.Discipline);
                EditDiscipline.teacherProcedureTableAdapter.Fill(EditDiscipline.teacherProcedureDataSet.TeacherProcedure);

                EditDiscipline.teacherBox.SelectedValue = Surname + " " + Name + " " + Patronymic;
                string query = $"SELECT ID_Discipline FROM Discipline WHERE Discipline_Name = '{Discipline}'";
                SqlCommand command = new SqlCommand(query, connection);
                EditDiscipline.nameBox.SelectedValue = command.ExecuteScalar().ToString();
                connection.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка оновлення даних!", "Помилка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Open EditDiscipline form
        private void editDisciplineButton_Click(object sender, EventArgs e)
        {
            AddEditDiscipline editDiscipline = new AddEditDiscipline();
            editDiscipline.addEditButton.Text = "Змінити дані дисципліни";
            editDiscipline.mainLabel.Text = "Форма для зміни даних дисципліни";
            editDiscipline.DisciplineTip.SetToolTip(editDiscipline.nameBox, "Поле для зміни назви дисципліни");
            Edit(editDiscipline);
            editDiscipline.ShowDialog();
            Default();
        }

        // Filling data from main DataGrid
        private void Disciplines_Load(object sender, EventArgs e)
        {
            this.discipline_InfoTableAdapter.Fill(this.disciplineListDataSet.Discipline_Info);
        }

        //Delete record from Teacher_Subject table in SchoolRegistry database
        private void Delete()
        {

            try
            {

                connection.Open();
                int index = disciplineGridView.CurrentCell.RowIndex;             
                var Surname = Convert.ToString(disciplineGridView.Rows[index].Cells[0].Value);
                var Name = Convert.ToString(disciplineGridView.Rows[index].Cells[1].Value);
                var Patronymic = Convert.ToString(disciplineGridView.Rows[index].Cells[2].Value);
                var Discipline = Convert.ToString(disciplineGridView.Rows[index].Cells[3].Value);
                string query = $"DELETE FROM Teacher_Subject WHERE ID_Discipline=(SELECT ID_Discipline FROM Discipline WHERE Discipline_Name = '{Discipline}') AND ID_Teacher=(SELECT ID_Teacher FROM Teacher WHERE Teacher_Name='{Name}' AND Teacher_Surname='{Surname}' AND Teacher_Patronymic='{Patronymic}')";
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
        //Delete Button click event handler 
        private void deleteDisciplineButton_Click(object sender, EventArgs e)
        {
            if (disciplineGridView.SelectedRows == null)
            {
                MessageBox.Show("Виберіть вчителя якого хочете видалити!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DialogResult.Yes == MessageBox.Show("Ви впевнені що хочете видалити цей запис ? ", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Delete();
                Default();
            }
        }
        //Find Button click event handler
        private void disciplineFindBox_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = $"SELECT * FROM Discipline_Info WHERE CONCAT_WS (' ',[Прізвище], [Ім'я], [По батькові]) LIKE '%{teacherBox.SelectedValue}%' AND [Назва дисципліни] LIKE '%{disciplineBox.SelectedValue}%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                disciplineGridView.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Home Button click event handler
        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Discipline check changing event handler
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
        //Teacher check changing event handler
        private void teacherCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (teacherCheck.Checked)
            {
                teacherCheck.BackColor = System.Drawing.Color.Green;
                teacherBox.Enabled = true;
                teacherBox.DataSource = teacherProcedureDataSet.TeacherProcedure;
                teacherBox.DisplayMember = "ПІБ";
                this.teacherProcedureTableAdapter.Fill(this.teacherProcedureDataSet.TeacherProcedure);
            }
            if (!teacherCheck.Checked)
            {
                teacherCheck.BackColor = System.Drawing.Color.Red;
                teacherBox.Enabled = false;
                teacherBox.DataSource = null;
                this.teacherProcedureTableAdapter.Dispose();
            }
        }
    }
}
