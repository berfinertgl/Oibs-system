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

namespace school_reg
{
    public partial class frmAddInstructor : Form
    {
        public frmAddInstructor()
        {
            InitializeComponent();
        }

        public string conString = "Data Source=DESKTOP-ENAHJTF;Initial Catalog=project;Integrated Security=True";

        private void frmAddInstructor_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmInstructorOperations openFrm = new frmInstructorOperations();
            openFrm.Show();
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
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
                    SqlCommand cmd = new SqlCommand("insert into instructor(name,dept_name,salary) values (@name,@dept_name,@salary) ", conn);
                        // Create and set the parameters values 
                        cmd.Parameters.AddWithValue("@name", txtName.Text);
                        cmd.Parameters.AddWithValue("@dept_name", cmbDepartment.Text);
                        cmd.Parameters.AddWithValue("@salary",txtSalary.Text);

                        // Let's ask the db to execute the query
                        int rowsAdded = cmd.ExecuteNonQuery();
                        if (rowsAdded > 0)
                            MessageBox.Show("Instructor Added!");
                        else
                            // Well this should never really happen
                            MessageBox.Show("Instructor did not Added!");

                    
                }
                catch (Exception ex)
                {
                    // We should log the error somewhere, 
                    // for this example let's just show a message
                    MessageBox.Show("ERROR: " + ex.Message);
                }
            }

        }

        private void frmAddInstructor_Load(object sender, EventArgs e)
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
                    cmbDepartment.DisplayMember = "dept_name";
                   
                    cmbDepartment.DataSource = ds.Tables["Departments"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Error occured!");
                }
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}