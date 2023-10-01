using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Xml.Serialization;

namespace SchoolJornal
{
  
    public partial class Login : Form
    {
        string Connection;
        public Login()
        {

            InitializeComponent();
       
        }
        private void RoleCheck(SqlConnection connection, string role)
        {
            connection.Open();
            MainForm mainForm = new MainForm(connection);
            string query = $"IF IS_ROLEMEMBER ('{role}') = 1 " + $"SELECT 'Користувач з ролью {role}' AS [Результат]";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows && role == "Teacher")
            {
                MessageBox.Show($"Вітаю вчитель: {loginBox.Text}!", "АРМ вчителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm.reportButton.Hide();
                mainForm.disciplineButton.Hide();
                mainForm.Show();
            }
            else if (reader.HasRows && role == "Curator")
            {
                
                MessageBox.Show($"Вітаю куратор: {loginBox.Text}!", "АРМ вчителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                mainForm.teacherButton.Hide();
                mainForm.reportButton.Hide();
                mainForm.disciplineButton.Hide();
                mainForm.Show();
                
            }
            else if (reader.HasRows && role == "DeputyDirector")
            {
                
                MessageBox.Show($"Вітаю директор: {loginBox.Text}!", "АРМ вчителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                mainForm.reportButton.Show();
                mainForm.disciplineButton.Show();
                mainForm.teacherButton.Show();
                mainForm.Show();

            }
            reader.Close();
            connection.Close();
            
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
           
            SqlConnection con = new SqlConnection(Connection + $"User studentID={loginBox.Text};Password={passwordbox.Text}");
            try
            {
                
                RoleCheck(con, "Teacher");
                RoleCheck(con, "Curator");
                RoleCheck(con, "DeputyDirector");
                Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Введіть дані коректно!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
          

        private void Login_Load(object sender, EventArgs e)
        {
            
            try
            {
                StreamReader sr = new StreamReader("DBConnectionString");
                
                Connection = sr.ReadLine();
               
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
