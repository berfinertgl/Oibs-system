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

namespace school_reg
{
    public partial class frmAddCourse : Form
    {
        public frmAddCourse()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-ENAHJTF;Initial Catalog=project;Integrated Security=True";


        private void frmAddCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFacultyMainmenu openMainMenu = new frmFacultyMainmenu();
            openMainMenu.Show();
        }

        private void frmAddCourse_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-ENAHJTF;Initial Catalog=project;Integrated Security=True"))
            {
                try
                {
                    string query = "select dept_name from dbo.department";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Departments");
                    cmdDeptName.DisplayMember = "dept_name";

                    cmdDeptName.DataSource = ds.Tables["Departments"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    // Open the connection to the database. 
                    // This is the first critical step in the process.
                    // If we cannot reach the db then we have connectivity problems
                    conn.Open();
                    //SELECT max(ID) FROM login
                    // Prepare the command to be executed on the db
                    SqlCommand cmd = new SqlCommand("insert into course(course_id,title,dept_name,credits) values (@course_id,@title,@dept_name,@credits) ", conn);
                    // Create and set the parameters values 
                    cmd.Parameters.AddWithValue("@course_id", txtCId.Text);
                    cmd.Parameters.AddWithValue("@title", txtTitleName.Text);
                    cmd.Parameters.AddWithValue("@dept_name", cmdDeptName.Text);
                    cmd.Parameters.AddWithValue("@credits", txtCredit.Text);

                    // Let's ask the db to execute the query
                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                        MessageBox.Show("Course Added!");
                    else
                        // Well this should never really happen
                        MessageBox.Show("Course could not be Added!");


                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }

        }
    }
}
