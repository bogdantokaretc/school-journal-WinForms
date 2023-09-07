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
using System.IO;

namespace SchoolJornal
{
    public partial class Teachers : Form
    {
        SqlConnection connection;
        public Teachers(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        public Teachers()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=true;User ID=sa;Password=123456789");
            InitializeComponent();
        }

        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            AddEditTeacher addTeacher = new AddEditTeacher();
            addTeacher.ShowDialog();
            findBox.Clear();
            dataGridView1.DataSource = teacherListDataSet.Teacher_Info;
            this.teacher_InfoTableAdapter.Fill(this.teacherListDataSet.Teacher_Info);
        }
        private void Edit(AddEditTeacher EditTeacher)
        {
            try
            {
                
                int index = dataGridView1.CurrentCell.RowIndex;
                var Surname = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
                var Name = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
                var Patronymic = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
                var TelephoneType = Convert.ToString(dataGridView1.Rows[index].Cells[3].Value);
                var TelephoneNumber = Convert.ToString(dataGridView1.Rows[index].Cells[4].Value);

                EditTeacher.surnameBox.Text = Surname;
                EditTeacher.nameBox.Text = Name;
                EditTeacher.patronymicBox.Text = Patronymic;
                EditTeacher.telephoneTypeBox.SelectedItem = TelephoneType;
                EditTeacher.telephoneNumberBox.Text = TelephoneNumber;

            }
            catch
            {
                MessageBox.Show("Помилка оновлення даних!", "Помилка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editTeacherButton_Click(object sender, EventArgs e)
        {
            AddEditTeacher editTeacher = new AddEditTeacher();
            editTeacher.addEditButton.Text = "Змінити дані вчителя";
            editTeacher.mainLabel.Text = "Форма для зміни даних вчителя";
            editTeacher.PersonalInfo.SetToolTip(editTeacher.surnameBox,"Поле для зміни прізвища вчителя");
            editTeacher.PersonalInfo.SetToolTip(editTeacher.nameBox,"Поле для зміни ім'я вчителя");
            editTeacher.PersonalInfo.SetToolTip(editTeacher.patronymicBox,"Поле для зміни по батькові вчителя");
            editTeacher.Contacts.SetToolTip(editTeacher.telephoneTypeBox, "Поле для зміни типу телефона");
            editTeacher.Contacts.SetToolTip(editTeacher.telephoneNumberBox, "Поле для зміни номеру телефона");
            Edit(editTeacher);
            editTeacher.ShowDialog();
            findBox.Clear();
            dataGridView1.DataSource = teacherListDataSet.Teacher_Info;
            this.teacher_InfoTableAdapter.Fill(this.teacherListDataSet.Teacher_Info);

        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "teacherListDataSet.Teacher_Info". При необходимости она может быть перемещена или удалена.
            this.teacher_InfoTableAdapter.Fill(this.teacherListDataSet.Teacher_Info);

        }
        private void Delete()
        {
           
            try 
            {

            connection.Open();
            int index = dataGridView1.CurrentCell.RowIndex;
            var Surname = Convert.ToString(dataGridView1.Rows[index].Cells[0].Value);
            var Name = Convert.ToString(dataGridView1.Rows[index].Cells[1].Value);
            var Patronymic = Convert.ToString(dataGridView1.Rows[index].Cells[2].Value);
            

            string query = $"DELETE FROM Teacher WHERE Teacher_Surname='{Surname}' AND Teacher_Name='{Name}' AND Teacher_Patronymic='{Patronymic}'";
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();

            MessageBox.Show("Дані успішно видалені!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
            }
            connection.Close();
        }
        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows==null)
            {
                MessageBox.Show("Виберіть вчителя якого хочете видалити!", "Помилка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (DialogResult.Yes == MessageBox.Show("Ви впевнені що хочете видалити цей запис ? ", "Підтвердження", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation))
            {
                Delete();
                findBox.Clear();
                dataGridView1.DataSource = teacherListDataSet.Teacher_Info;
                this.teacher_InfoTableAdapter.Fill(this.teacherListDataSet.Teacher_Info);
            }

            
        }
       
        private void findButton_Click(object sender, EventArgs e)
        {
            
            try
            {
                connection.Open();
                string query = $"SELECT * FROM Teacher_Info WHERE CONCAT ([Прізвище], [Ім'я], [По батькові]) LIKE '%{findBox.Text}%'";
                SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void findBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(findBox.Text))
            {
                dataGridView1.DataSource = this.teacherListDataSet.Teacher_Info;
                this.teacher_InfoTableAdapter.Fill(this.teacherListDataSet.Teacher_Info);
            }
        }

        
    }
}
