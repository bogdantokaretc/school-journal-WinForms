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
using SchoolJornal.ListDataSets;

namespace SchoolJornal
{
    public partial class AddEditStudent : Form
    {
        SqlConnection connection;
        string studentID;
        public AddEditStudent(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        public AddEditStudent()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=true;User ID=sa;Password=123456789");
            InitializeComponent();
        }

        private void AddEditStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classDataSet.ClassProcedure' table. You can move, or remove it, as needed.
            this.classProcedureTableAdapter.Fill(this.classDataSet.ClassProcedure);

            if (addEditButton.Text == "Змінити дані учня") GetIDStudent();
        }
        private void GetIDStudent()
        {
            connection.Open();
            string query = 
                $"SELECT ID_Student FROM Student WHERE Student_Surname='{surnameBox.Text}'" +
                $"AND Student_Name='{nameBox.Text}' AND Student_Patronymic='{patronymicBox.Text}'";
            SqlCommand command = new SqlCommand(query, connection);
            studentID = command.ExecuteScalar().ToString();
            connection.Close();
        }
        private void Update()
        {
            try
            {
                connection.Open();
                string query = 
                    $"UPDATE Student SET ID_Class ='{educationClassBox.SelectedValue}', Student_Surname = '{surnameBox.Text}'," +
                    $"Student_Name = '{nameBox.Text}', Student_Patronymic = '{patronymicBox.Text}', Education_Form = '{educationFormBox.SelectedItem}' " +
                    $"WHERE ID_Student = '{studentID}'";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("Дані успішно оновлені!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        
        private void Add()
        {
            try
            {
                connection.Open();
                string query =
                    $"INSERT INTO Student (ID_Class, Student_Surname, Student_Name, Student_Patronymic, Education_Form)" +
                    $"VALUES ('{educationClassBox.SelectedValue}','{surnameBox.Text}','{nameBox.Text}','{patronymicBox.Text}','{educationFormBox.SelectedItem}')";
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally 
            {
                MessageBox.Show("Дані успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            if (addEditButton.Text == "Змінити дані учня")
            {
                Update();
                Close();
            }
            if (addEditButton.Text == "Зберегти дані учня")
            {
                if (string.IsNullOrWhiteSpace(surnameBox.Text) || string.IsNullOrWhiteSpace(nameBox.Text) || 
                    string.IsNullOrWhiteSpace(patronymicBox.Text) || string.IsNullOrWhiteSpace(educationClassBox.Text) || 
                    string.IsNullOrWhiteSpace(educationFormBox.Text))
                {
                    MessageBox.Show("Введіть всі дані!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Add();
                    Close();
                }
            }
        }
    }
}
