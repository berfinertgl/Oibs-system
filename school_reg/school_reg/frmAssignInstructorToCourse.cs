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
    public partial class frmAssignInstructorToCourse : Form
    {
        public frmAssignInstructorToCourse()
        {
            InitializeComponent();
        }

        private void frmAssignInstructorToCourse_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmInstructorOperations frmOpen = new frmInstructorOperations();
            frmOpen.Show();
        }
    }
}
