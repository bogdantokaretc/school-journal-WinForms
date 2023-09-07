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

    public partial class AddEditTeacher : Form
    {
        SqlConnection connection;
        string ID="";
        public AddEditTeacher(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        public AddEditTeacher()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=True;User ID=sa;Password=123456789");
            InitializeComponent();
        }
        private void AddEditTeacher_Load(object sender, EventArgs e)
        {
            if (addEditButton.Text == "Змінити дані вчителя")
            {
                connection.Open();
                string query = $"SELECT ID_Teacher FROM Teacher WHERE Teacher_Surname='{surnameBox.Text}' AND Teacher_Name='{nameBox.Text}' AND Teacher_Patronymic='{patronymicBox.Text}'";
                SqlCommand command = new SqlCommand(query, connection);
                ID = command.ExecuteScalar().ToString();
                connection.Close();
            }
            if (addEditButton.Text == "Зберегти дані вчителя")
            {
                
            }
        }
        private void Update()
        {
            
            try
            {
                connection.Open();
                string query = $"UPDATE Teacher SET Teacher_Surname = '{surnameBox.Text}', Teacher_Name = '{nameBox.Text}', Teacher_Patronymic = '{patronymicBox.Text}' WHERE ID_Teacher = '{ID}'";
            var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                string query2 = $"UPDATE Telephone SET Telephone_Type = '{telephoneTypeBox.SelectedItem}', Telephone_Number = '{telephoneNumberBox.Text}' WHERE ID_Teacher = '{ID}'";
                var command2 = new SqlCommand(query2, connection);
                command2.ExecuteNonQuery();
                MessageBox.Show("Дані успішно оновлені!", "Успіх", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Max()
        {
            
            string query = "SELECT MAX(ID_Teacher) FROM Teacher";
            SqlCommand command = new SqlCommand(query, connection);
            ID=command.ExecuteScalar().ToString();
            ID.Remove(0, 2);
            int ID_Teacher = 1 + Convert.ToInt32(ID);
            ID = "00" + ID_Teacher.ToString();
            
        }
        private void Add()
        {

            try
            {
                connection.Open();
                Max();
                string query = $"INSERT INTO Teacher VALUES ('{ID}','{surnameBox.Text}','{nameBox.Text}','{patronymicBox.Text}')";
                var command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
                string query2 = $"INSERT INTO Telephone (Telephone_Type, Telephone_Number, ID_Teacher) VALUES ('{telephoneTypeBox.SelectedItem}','{telephoneNumberBox.Text}','{ID}')";
                var command2 = new SqlCommand(query2, connection);
                command2.ExecuteNonQuery();
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
            if (addEditButton.Text == "Змінити дані вчителя")
            {
                Update();
                Close();
            }
            if (addEditButton.Text == "Зберегти дані вчителя")
            {
                if (surnameBox.Text == string.Empty || nameBox.Text == string.Empty || patronymicBox.Text == string.Empty || telephoneTypeBox.Text == string.Empty || telephoneNumberBox.Text == string.Empty)
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void telephoneTypeBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (telephoneTypeBox.Text=="мобільний")
             telephoneNumberBox.Mask = "+38(000)-000-00-00";
            if(telephoneTypeBox.Text == "стаціонарний")
             telephoneNumberBox.Mask = "00-00-00";
        }
    }
}
