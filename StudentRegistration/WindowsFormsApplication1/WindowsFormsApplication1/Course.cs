using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmCourse : Form
    {
        public frmCourse()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            clsCourse c = new clsCourse();
            c.Course_ID(txtCourseID.Text);
            c.Course_Name(txtCourseName.Text);
            c.Course_Fees(txtFees.Text);
            c.Course_Duration(txtDuration.Text);

            if (txtCourseID.Text == "")
            {
                MessageBox.Show("Please enter your CourseID: ", "Course Regisrer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseID.Focus();
            }
            else if (txtCourseName.Text == "")
            {
                MessageBox.Show("Please enter your CourseName: ", "Course Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCourseName.Focus();
            }
            else if (txtFees.Text == "")
            {
                MessageBox.Show("Please enter your Fees: ", "Course Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFees.Focus();
            }
            else if (txtDuration.Text == "")
            {
                MessageBox.Show("Please enter your Duration: ", "Course Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
            }
            else
            {
                MessageBox.Show("Course Register Successful!", "Course Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCourseID.Text = "";
                txtCourseName.Text = "";
                txtFees.Text = "";
                txtDuration.Text = "";
                txtCourseID.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCourseID.Text = "";
            txtCourseName.Text = "";
            txtFees.Text = "";
            txtDuration.Text = "";
            txtCourseID.Focus();
        }
    }
}
