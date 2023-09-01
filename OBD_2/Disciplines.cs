using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OBD_2
{
    public partial class Disciplines : Form
    {
        SqlConnection connection;
        public Disciplines()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=true;User ID=sa;Password=123456789");
            InitializeComponent();
        }

        public Disciplines(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }

        private void Default()
        {
           
            disciplineCheck.CheckState = CheckState.Unchecked;
            teacherCheck.CheckState = CheckState.Unchecked;
            disciplineGridView.DataSource = disciplineListDataSet.Discipline_Info;
            this.discipline_InfoTableAdapter.Fill(this.disciplineListDataSet.Discipline_Info);
        }

        private void addDisciplineButton_Click(object sender, EventArgs e)
        {
            AddEditDiscipline addDiscipline = new AddEditDiscipline();
            addDiscipline.ShowDialog();
            Default();
        }
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
                EditDiscipline.teacherProcedureTableAdapter.Fill(EditDiscipline.teacherDataSet.TeacherProcedure);
                EditDiscipline.teacherBox.SelectedValue = Surname + " " + Name + " " + Patronymic;
                string query = $"SELECT ID_Discipline FROM Discipline WHERE Discipline_Name = '{Discipline}'";
                SqlCommand command = new SqlCommand(query, connection);
                EditDiscipline.nameBox.SelectedValue = command.ExecuteScalar().ToString();
                connection.Close();
            }
            catch
            {
                MessageBox.Show("Помилка оновлення даних!", "Помилка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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

        

        private void Disciplines_Load(object sender, EventArgs e)
        {
            
            this.discipline_InfoTableAdapter.Fill(this.disciplineListDataSet.Discipline_Info);

        }
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

        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void teacherCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (teacherCheck.Checked)
            {
                this.teacherProcedureTableAdapter.Fill(this.teacherDataSet.TeacherProcedure);
                teacherCheck.BackColor = System.Drawing.Color.Green;
                teacherBox.Enabled = true;
                teacherBox.DataSource = teacherDataSet.TeacherProcedure;
                teacherBox.DisplayMember = "Column1";
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
