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
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 openLoginMenu = new Form1();
            openLoginMenu.Show();
        }

        public string conString = "Data Source=DESKTOP-ENAHJTF;Initial Catalog=project;Integrated Security=True";
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                string q = "select ID,password from login where ID='" + txtID.Text.ToString() + "' and password='" + txtPassword.Text.ToString() + "'";
                SqlCommand cmd = new SqlCommand(q, con);
                cmd.ExecuteNonQuery();


            }
            SqlDataAdapter sqa = new SqlDataAdapter("Select stat From login where ID='" + txtID.Text + "' and password='" + txtPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sqa.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                switch (dt.Rows[0]["stat"] as string)
                {
                    case "F":
                        { 
                        this.Hide();
                        new frmFacultyMainmenu().Show();
                        break;
                        }
                    case "A":
                        {
                            this.Hide();
                            new frmInstructorMainMenu().Show();
                            break;
                        }
                    case "S":
                        {
                            this.Hide();
                            new frmStudentMainMenu().Show();
                            break;
                        }

                    default:
                        { 
                        MessageBox.Show("Some Error occured!");
                        break;
                        }
                }
            }
            else
            {
                MessageBox.Show("Username/Password is incorrect.Please try again!");
            }
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
            txtPassword.Text = "";
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
            }

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                txtID.Text = "ID";
            }
        }
    }
}
