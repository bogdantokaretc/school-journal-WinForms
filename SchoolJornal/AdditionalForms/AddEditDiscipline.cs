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



namespace SchoolJornal
{
    public partial class AddEditDiscipline : Form
    {
        SqlConnection connection;
        string ID = "";
        string ID_Teacher = "";
        //Main constructor for the final version of program
        public AddEditDiscipline(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        //Constructor for debugging
        public AddEditDiscipline()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;User ID=sa;Password=123456789");
            InitializeComponent();
        }
        // Filling data from main DataGrid
        private void AddEditDiscipline_Load(object sender, EventArgs e)
        {
            try
            {
                if (addEditButton.Text == "Зберегти дані дисципліни")
                {
                    this.disciplineTableAdapter.Fill(this.disciplineDataSet.Discipline);
                    this.teacherProcedureTableAdapter.Fill(this.teacherProcedureDataSet.TeacherProcedure);
                }
                if (addEditButton.Text == "Змінити дані дисципліни")
                {
                    connection.Open();
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
        // Update discipline record in Teacher_Subject table in SchoolRegistry database
        private void Update()
        {

            try
            {
                connection.Open();
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
        //Spliting teacher full name into 3 parts
        static (string surname, string name, string patronymic) SplitNames(string FullName)
        {
            var partsName = FullName.Split(' ');
            return (partsName[0], partsName[1], partsName[2]);
        }
        // Add discipline record into Teacher_Subject table in SchoolRegister database
        private void Add()
        {

            try
            {
                connection.Open();
                ID = nameBox.SelectedValue.ToString();

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

        //Add and Edit Button click event handler 
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
                    catch (Exception)
                    {
                        MessageBox.Show("Поле заповнено не правильно!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
