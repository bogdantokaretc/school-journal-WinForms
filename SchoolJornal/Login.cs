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
using Microsoft.ReportingServices.Diagnostics.Internal;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Collections;
using System.Xml.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Runtime.Remoting.Contexts;

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
            MainForm mainForm = new MainForm(connection);

            switch (role)
            {
                case "Teacher":
                    MessageBox.Show($"Вітаю вчителя: {loginBox.Text}!", "АРМ вчителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.reportButton.Hide();
                    mainForm.disciplineButton.Hide();
                    mainForm.Show();
                    break;

                case "Curator":
                    MessageBox.Show($"Вітаю куратора: {loginBox.Text}!", "АРМ вчителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.teacherButton.Hide();
                    mainForm.reportButton.Hide();
                    mainForm.disciplineButton.Hide();
                    mainForm.Show();
                    break;

                case "DeputyDirector":
                    MessageBox.Show($"Вітаю директора: {loginBox.Text}!", "АРМ вчителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainForm.reportButton.Show();
                    mainForm.disciplineButton.Show();
                    mainForm.teacherButton.Show();
                    mainForm.Show();
                    break;

                default:
                    MessageBox.Show($"Невідома роль користувача: {loginBox.Text}! Надано мінімальний функціонал програми", "АРМ вчителя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(Connection + $"User ID={loginBox.Text};Password={passwordbox.Text}");
            try
            {
                connect.Open();
                string query = $"SELECT r.name AS RoleName FROM sys.server_principals sp " +
                    $"INNER JOIN sys.database_principals dp ON sp.sid = dp.sid " +
                    $"LEFT JOIN sys.database_role_members m ON dp.principal_id = m.member_principal_id " +
                    $"LEFT JOIN sys.database_principals r ON m.role_principal_id = r.principal_id WHERE sp.name = '{loginBox.Text}'";

                SqlCommand command = new SqlCommand(query, connect);
                SqlDataReader reader = command.ExecuteReader();
                reader.ReadAsync();

                string role = reader.GetString(0);
                RoleCheck(connect, role);
                Hide();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

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


