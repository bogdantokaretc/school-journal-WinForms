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
using System.Xml.Serialization;
using System.IO;

namespace OBD_2
{
    public partial class MainForm : Form
    {
        SqlConnection connection;
        public MainForm(SqlConnection conn)
        {
            connection = conn;
            InitializeComponent();
           
        }
        public MainForm()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=true;User ID=sa;Password=123456789");
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            connection.Close();
         
            
        }

        private void teacherButton_Click(object sender, EventArgs e)
        {
           
            Teachers teachers = new Teachers(connection);
            teachers.ShowDialog();
        }

        private void studentButton_Click(object sender, EventArgs e)
        {
            
            Students students = new Students(connection);
            students.ShowDialog();
        }

        private void markButton_Click(object sender, EventArgs e)
        {
            
            Marks marks = new Marks(connection);
            marks.ShowDialog();
        }

        private void disciplineButton_Click(object sender, EventArgs e)
        {
            Disciplines disciplines = new Disciplines(connection);
            disciplines.ShowDialog();
        }

        private void changeUserButton_Click(object sender, EventArgs e)
        {
            
            Hide();
            Login login = new Login();
            login.ShowDialog();
            
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            ReportForm reportForm = new ReportForm(connection);
            reportForm.ShowDialog();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
           
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
