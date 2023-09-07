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
using Microsoft.Reporting.WinForms;

namespace SchoolJornal
{
    public partial class ReportForm : Form
    {
        SqlConnection connection;
        public ReportForm(SqlConnection con)
        {
            connection = con;
            InitializeComponent();
        }
        public ReportForm()
        {
            connection = new SqlConnection(@"Data Source=DESKTOP-M3Q63QC\SQLEXPRESS;Initial Catalog=SchoolRegister;Integrated Security=True;User ID=sa;Password=123456789");
            InitializeComponent();
        }
        private void ReportForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "reportOneDataSet.Student". При необходимости она может быть перемещена или удалена.
            this.StudentTableAdapter.Fill(this.reportOneDataSet.Student);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "classDataSet.ClassProcedure". При необходимости она может быть перемещена или удалена.
            this.classProcedureTableAdapter.Fill(this.classDataSet.ClassProcedure);


            //this.reportViewer1.RefreshReport();
            //this.reportViewer2.RefreshReport();
        }

        private void firstReportButton_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand($"SELECT * FROM Student WHERE ID_Class='{ClassBox.SelectedValue}' ORDER BY Student_Surname", connection);
                SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource source = new ReportDataSource("FirstDataSet", dataTable);
                reportViewer1.LocalReport.ReportEmbeddedResource = "SchoolJornal.firstReport.rdlc";
                reportViewer1.LocalReport.DataSources.Add(source);

                ReportParameter reportParameter = new ReportParameter("ClassParametr", ClassBox.Text.TrimEnd());
                reportViewer1.LocalReport.SetParameters(reportParameter);
                connection.Close();

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //command.ExecuteNonQuery().ToString());
            // reportViewer1.LocalReport.SetParameters(reportParameter4);


        }

        private void secondReportButton_Click(object sender, EventArgs e)
        {
            connection.Open();
            reportViewer2.LocalReport.ReportEmbeddedResource = "SchoolJornal.secondReport.rdlc";
            SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM Student", connection);
            ReportParameter reportParameter = new ReportParameter("StudentSum", command.ExecuteScalar().ToString());
            reportViewer2.LocalReport.SetParameters(reportParameter);

            command = new SqlCommand($"SELECT COUNT(*) FROM Teacher", connection);
            reportParameter = new ReportParameter("TeacherSum", command.ExecuteScalar().ToString());
            reportViewer2.LocalReport.SetParameters(reportParameter);

            command = new SqlCommand($"SELECT COUNT(*) FROM Discipline", connection);
            reportParameter = new ReportParameter("DisciplineSum", command.ExecuteScalar().ToString());
            reportViewer2.LocalReport.SetParameters(reportParameter);

            command = new SqlCommand($"SELECT COUNT(*) FROM Class", connection);
            reportParameter = new ReportParameter("ClassSum", command.ExecuteScalar().ToString());
            reportViewer2.LocalReport.SetParameters(reportParameter);

            connection.Close();

            this.reportViewer2.RefreshReport();
        }
    }
}
