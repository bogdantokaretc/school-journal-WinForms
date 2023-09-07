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
    public partial class AddEditMark : Form
    {
        SqlConnection connection;
        public AddEditMark(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        public AddEditMark()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=True;User ID=sa;Password=123456789");
            InitializeComponent();
        }

        private void AddEditMark_Load(object sender, EventArgs e)
        {
            if (addEditButton.Text == "Зберегти дані оцінки учня")
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "markListDataSet.Mark_Info". При необходимости она может быть перемещена или удалена.
                this.mark_InfoTableAdapter.Fill(this.markListDataSet.Mark_Info);
                //// TODO: данная строка кода позволяет загрузить данные в таблицу "disciplineDataSet.Discipline". При необходимости она может быть перемещена или удалена.
                this.disciplineTableAdapter.Fill(this.disciplineDataSet.Discipline);
                //// TODO: данная строка кода позволяет загрузить данные в таблицу "markEncryptionDataSet.Mark_Encryption". При необходимости она может быть перемещена или удалена.
                this.mark_EncryptionTableAdapter.Fill(this.markEncryptionDataSet.Mark_Encryption);
                //// TODO: данная строка кода позволяет загрузить данные в таблицу "classDataSet.ClassProcedure". При необходимости она может быть перемещена или удалена.
                this.classProcedureTableAdapter.Fill(this.classDataSet.ClassProcedure);

                try
                {
                    connection.Open();
                    string query = $"SELECT CONCAT_WS(' ',Student_Surname, Student_Name, Student_Patronymic) AS FullName FROM Student WHERE ID_Class='{educationClassBox.SelectedValue}'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataSet ds = new DataSet();
                    sda.Fill(ds);
                    comboNameBox.DataSource = ds.Tables[0];
                    comboNameBox.DisplayMember = "FullName";
                    comboNameBox.ValueMember = "FullName";
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
        
        private void Update()
        {

            try
            {
                connection.Open();
                var (surname, name, patronymic) = SplitNames(comboNameBox.SelectedValue.ToString());
                string query = $"UPDATE Mark SET ID_Student = (SELECT ID_Student FROM Student WHERE Student_Surname='{surname}' AND Student_Name='{name}' AND Student_Patronymic = '{patronymic}'), ID_Discipline='{disciplineBox.SelectedValue}', ID_Mark='{markTypeBox.SelectedValue}', Mark='{markBox.SelectedItem}' WHERE Mark_Date = '{markBox.Tag}'";
                var command = new SqlCommand(query, connection);
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

                var (surname, name, patronymic) = SplitNames(comboNameBox.SelectedValue.ToString());

                DateTime dateTime = DateTime.Now;
                dateTime.ToString("dd.MM.yyyy HH:mm");

                string query = $"INSERT INTO Mark VALUES ('{dateTime}',(SELECT ID_Student FROM Student WHERE Student_Surname='{surname}' AND Student_Name='{name}' AND Student_Patronymic = '{patronymic}')," +
                    $"'{disciplineBox.SelectedValue}','{markTypeBox.SelectedValue}','{markBox.SelectedItem}')";
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
        private void educationClassBox_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = $"SELECT CONCAT_WS(' ',Student_Surname, Student_Name, Student_Patronymic) AS FullName FROM Student WHERE ID_Class='{educationClassBox.SelectedValue}'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                comboNameBox.DataSource = ds.Tables[0];
                comboNameBox.DisplayMember = "FullName";
                comboNameBox.ValueMember = "FullName";
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void addEditButton_Click(object sender, EventArgs e)
        {
            if (addEditButton.Text == "Зберегти дані оцінки учня")
            {
                if (markBox.Text == string.Empty || markTypeBox.Text == string.Empty || comboNameBox.Text == string.Empty || educationClassBox.Text == string.Empty || disciplineBox.Text == string.Empty)
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
            if (addEditButton.Text == "Змінити оцінку учня")
            {
                Update();
                Close();
            }
        }
    }
}
