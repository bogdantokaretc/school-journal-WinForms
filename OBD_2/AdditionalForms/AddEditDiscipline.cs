using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace OBD_2
{
    public partial class AddEditDiscipline : Form
    {
        SqlConnection connection;
        string ID = "";
        string ID_Teacher = "";
        public AddEditDiscipline(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        public AddEditDiscipline()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;User ID=sa;Password=123456789");
            InitializeComponent();
        }

        private void AddEditDiscipline_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "disciplineDataSet.Discipline". При необходимости она может быть перемещена или удалена.
                //this.disciplineTableAdapter.Fill(this.disciplineDataSet.Discipline);
                if (addEditButton.Text == "Зберегти дані дисципліни")
                {
                    this.disciplineTableAdapter.Fill(this.disciplineDataSet.Discipline);
                    //this.teacherProcedureTableAdapter.Fill(this.teacherDataSet.TeacherProcedure);
                }
                // TODO: данная строка кода позволяет загрузить данные в таблицу "teacherDataSet.TeacherProcedure". При необходимости она может быть перемещена или удалена.
                //this.teacherProcedureTableAdapter.Fill(this.teacherDataSet.TeacherProcedure);
                if (addEditButton.Text == "Змінити дані дисципліни")
                {
                    connection.Open();
                    //string query = $"SELECT ID_Discipline FROM Discipline WHERE Discipline_Name='{nameBox.SelectedItem}'";
                    //SqlCommand command = new SqlCommand(query, connection);
                    ID = nameBox.SelectedValue.ToString();

                    var (surname, name, patronymic) = SplitNames(teacherBox.SelectedValue.ToString());
                    string query = $"SELECT ID_Teacher FROM Teacher WHERE Teacher_Surname = '{surname}' AND Teacher_Name = '{name}' AND Teacher_Patronymic='{patronymic}'";
                    SqlCommand command = new SqlCommand(query, connection);
                    ID_Teacher = command.ExecuteScalar().ToString();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Update()
        {

            try
            {
                connection.Open();
                //string query = $"UPDATE Discipline SET Discipline_Name = '{nameBox.Text}', Amount_of_time = '{EducationTimeUpDown.Value}' WHERE ID_Discipline = '{ID}'";
                //var command = new SqlCommand(query, connection);
                //command.ExecuteNonQuery();
                var (surname, name, patronymic) = SplitNames(teacherBox.SelectedValue.ToString());
                string query = $"UPDATE Teacher_Subject SET ID_Teacher = (SELECT ID_Teacher FROM Teacher WHERE Teacher_Surname = '{surname}' AND Teacher_Name = '{name}' AND Teacher_Patronymic='{patronymic}'), ID_Discipline = '{nameBox.SelectedValue}' WHERE ID_Discipline = '{ID}' AND ID_Teacher='{ID_Teacher}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно оновлені!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //private void Max()
        //{

        //    string query = "SELECT MAX(ID_Discipline) FROM Discipline";
        //    SqlCommand command = new SqlCommand(query, connection);
        //    ID = command.ExecuteScalar().ToString();

        //    ID = ID.Remove(0, 1);
        //    int ID_Discipline = Convert.ToInt32(ID);
        //    ID_Discipline++;
        //    ID = "0" + ID_Discipline.ToString();

        //}
        static (string surname, string name, string patronymic) SplitNames(string FullName)
        {
            var partsName = FullName.Split(' ');
            return (partsName[0], partsName[1], partsName[2]);
        }
        private void Add()
        {

            try
            {
                connection.Open();

               //string query = $"SELECT ID_Discipline FROM Discipline WHERE ID_Discipline = '{nameBox.SelectedValue}'";
               //SqlCommand command = new SqlCommand(query, connection);
               ID = nameBox.SelectedValue.ToString();
                //SqlDataReader reader = command.ExecuteReader();
                //if (!reader.HasRows)
                //{
                //    reader.Close();
                //    Max();
                //    query = $"INSERT INTO Discipline VALUES ('{ID}','{nameBox.Text}','{EducationTimeUpDown.Value}')";
                //    command = new SqlCommand(query, connection);
                //    command.ExecuteNonQuery();

                //}
                //if (reader.HasRows)
                //{
                //    reader.Close();
                //    query = $"SELECT ID_Discipline FROM Discipline WHERE Discipline_Name='{nameBox.Text}'";
                //    SqlCommand command2 = new SqlCommand(query, connection);
                //    ID = command2.ExecuteScalar().ToString();

                //}

                var (surname, name, patronymic) = SplitNames(teacherBox.SelectedValue.ToString());
                string query = $"INSERT INTO Teacher_Subject VALUES ('{ID}',(SELECT ID_Teacher FROM Teacher WHERE Teacher_Surname = '{surname}' AND Teacher_Name = '{name}' AND Teacher_Patronymic='{patronymic}'))";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            if (addEditButton.Text == "Змінити дані дисципліни")
            {
                Update();
                Close();
            }
            if (addEditButton.Text == "Зберегти дані дисципліни")
            {
                if (nameBox.Text == string.Empty || teacherBox.Text == string.Empty)
                    MessageBox.Show("Введіть всі дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        Add();
                        Close();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Поле заповнено не правильно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
