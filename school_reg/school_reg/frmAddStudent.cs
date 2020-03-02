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
    public partial class frmAddStudent : Form
    {
        public frmAddStudent()
        {
            InitializeComponent();
        }
        public string conString = "Data Source=DESKTOP-ENAHJTF;Initial Catalog=project;Integrated Security=True";

        private void frmAddStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmFacultyMainmenu openMainMenu = new frmFacultyMainmenu();
            openMainMenu.Show();
        }

        private void btnAddInstructor_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into student(ID,name,dept_name,tot_cred) values (@ID,@name,@dept_name,@tot_cred)", conn);
                    cmd.Parameters.AddWithValue("@ID", txtIDs.Text);
                    cmd.Parameters.AddWithValue("@name", txtNames.Text);
                    cmd.Parameters.AddWithValue("@dept_name", cmbDepartment.Text);
                    cmd.Parameters.AddWithValue("@tot_cred", txtTot.Text);

                    int rowsAdded = cmd.ExecuteNonQuery();
                    if (rowsAdded > 0)
                        MessageBox.Show("Student Added!");
                    else
                        MessageBox.Show("Student did not Added!");
                }

                catch(Exception ex)
                {
                    MessageBox.Show("ERROR" + ex.Message);
                }
            }



        }

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmAddStudent_Load(object sender, EventArgs e)
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
                    
                    MessageBox.Show("Error occured!");
                }
            }
        }
    }
}
