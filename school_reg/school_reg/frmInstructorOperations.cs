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
    public partial class frmInstructorOperations : Form
    {
        public frmInstructorOperations()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-ENAHJTF;Initial Catalog=project;Integrated Security=True";
        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            frmAddInstructor frmOpenInstructor = new frmAddInstructor();
            frmOpenInstructor.Show();
            this.Hide();
        }

        private void frmInstructorOperations_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFacultyMainmenu frmOpen = new frmFacultyMainmenu();
            frmOpen.Show();
        }

        private void frmInstructorOperations_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(conString);
                conn.Open();
                string query = "select * from dbo.instructor";
                SqlDataAdapter da = new SqlDataAdapter(query,conn);
                DataSet ds = new DataSet();
                da.Fill(ds,"Instructors");
                dataGridView1.DataSource = ds;
                dataGridView1.DataMember = "Instructors";
                dataGridView1.Columns["ID"].HeaderText = "Instructor ID";
                dataGridView1.Columns["name"].HeaderText = "Instructor Name";
                dataGridView1.Columns["dept_name"].HeaderText = "Department";
                dataGridView1.Columns["salary"].HeaderText = "Salary";
            }
            catch (Exception ex)
            {
                // write exception info to log or anything else
                MessageBox.Show("Error occured!");
            }
        }

        private void btnAddTeaches_Click(object sender, EventArgs e)
        {
            frmAssignInstructorToCourse frmOpen = new frmAssignInstructorToCourse();
            frmOpen.Show();
            this.Hide();
        }
    }
}