using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GradeCheckerGUI1._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable Student;
        DataTable Class;
        DataTable Gpa;
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable Student = new DataTable();
            {
                {

                    SqlCommand command = new SqlCommand();
                    SqlConnection Connection = new SqlConnection();
                    Connection.ConnectionString = @"Data Source=DESKTOP-AGRJKOJ\SQLEXPRESS;Initial Catalog=GradeChecker2;Integrated Security=True";
                    Connection.Open();

                    command.Connection = Connection;
                    command.CommandText = "select * from Student";


                    SqlDataAdapter da = new SqlDataAdapter(command);

                    da.Fill(Student);



                    dataGridView1.DataSource = Student;

                    Connection.Close();


                }
                DataTable Class = new DataTable();
                {



                    SqlCommand command = new SqlCommand();
                    SqlConnection Connection = new SqlConnection();
                    Connection.ConnectionString = @"Data Source=DESKTOP-AGRJKOJ\SQLEXPRESS;Initial Catalog=GradeChecker2;Integrated Security=True";
                    Connection.Open();

                    command.Connection = Connection;

                    command.CommandText = "select * from Class";


                    SqlDataAdapter da = new SqlDataAdapter(command);

                    da.Fill(Class);




                    dataGridView2.DataSource = Class;

                    Connection.Close();

                }
                DataTable Gpa = new DataTable();
                {
                    SqlCommand command = new SqlCommand();
                    SqlConnection Connection = new SqlConnection();
                    Connection.ConnectionString = @"Data Source=DESKTOP-AGRJKOJ\SQLEXPRESS;Initial Catalog=GradeChecker2;Integrated Security=True";
                    Connection.Open();

                    command.Connection = Connection;

                    command.CommandText = "select * from GPA";


                    SqlDataAdapter da = new SqlDataAdapter(command);

                    da.Fill(Gpa);




                    dataGridView3.DataSource = Gpa;

                    Connection.Close();

                }
            }
        }
        private void checkconnectionlabel_Click(object sender, EventArgs e)
        {

        }

        private void searchbutton_Click(object sender, EventArgs e)
        {

            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = String.Format("FirstLastName like '%" + studentfirstnametextbox.Text + "%'");



           
        }

        private void searchbutton2_Click(object sender, EventArgs e)
        {


            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = String.Format("Course like '%" + classtextbox.Text + "%'");



        }

        private void findoutgpabutton_Click(object sender, EventArgs e)
        {
            (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = "Convert(StudentID, 'System.String') LIKE '" + studentidtextbox.Text + "%'";

           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentfirstnametextbox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void studentlastnametextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void studentgradetextbox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
    }

