using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace school_reg
{
    public partial class frmFacultyMainmenu : Form
    {
        public frmFacultyMainmenu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmAddCourse frmopenCourse = new frmAddCourse();
            frmopenCourse.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddStudent frmOpenStudent = new frmAddStudent();
            frmOpenStudent.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmInstructorOperations frmInstructorOperations = new frmInstructorOperations();
            frmInstructorOperations.Show();
            this.Hide();
        }

        private void Mainmenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 openLoginMenu = new Form1();
            openLoginMenu.Show();
        }
    }
}
