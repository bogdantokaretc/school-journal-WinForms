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
    public partial class AddEditStudent : Form
    {
        SqlConnection connection;
        string ID = "";
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "classDataSet.ClassProcedure". При необходимости она может быть перемещена или удалена.
            this.classProcedureTableAdapter.Fill(this.classDataSet.ClassProcedure);
            if (addEditButton.Text == "Змінити дані учня")
            {
                connection.Open();
                string query = $"SELECT ID_Student FROM Student WHERE Student_Surname='{surnameBox.Text}' AND Student_Name='{nameBox.Text}' AND Student_Patronymic='{patronymicBox.Text}'";
                SqlCommand command = new SqlCommand(query, connection);
                ID = command.ExecuteScalar().ToString();
                connection.Close();
            }
        }
        private void Update()
        {

            try
            {
                connection.Open();
                string query = $"UPDATE Student SET ID_Class ='{educationClassBox.SelectedValue}', Student_Surname = '{surnameBox.Text}', Student_Name = '{nameBox.Text}', Student_Patronymic = '{patronymicBox.Text}', Education_Form = '{educationFormBox.SelectedItem}' WHERE ID_Student = '{ID}'";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Дані успішно оновлені!", "Успіх", MessageBoxButtons.OK,MessageBoxIcon.Information);
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Max()
        {

            string query = "SELECT MAX(ID_Student) FROM Student";
            SqlCommand command = new SqlCommand(query, connection);
            ID = command.ExecuteScalar().ToString();

            ID=ID.Remove(0, 5);
            int ID_Student = Convert.ToInt32(ID);
            ID_Student++;
            ID = "S-000" + ID_Student.ToString();

        }
        private void Add()
        {

            try
            {
                connection.Open();
                Max();
                string query = $"INSERT INTO Student VALUES ('{ID}','{educationClassBox.SelectedValue}','{surnameBox.Text}','{nameBox.Text}','{patronymicBox.Text}','{educationFormBox.SelectedItem}')";
                var command = new SqlCommand(query, connection);
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
            if (addEditButton.Text == "Змінити дані учня")
            {
                Update();
                Close();
            }
            if (addEditButton.Text == "Зберегти дані учня")
            {
                if (surnameBox.Text == string.Empty || nameBox.Text == string.Empty || patronymicBox.Text == string.Empty || educationClassBox.Text == string.Empty || educationFormBox.Text == string.Empty)
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
