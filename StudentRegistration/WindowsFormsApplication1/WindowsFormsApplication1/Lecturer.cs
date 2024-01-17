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
    public partial class frmLecturer : Form
    {
        public frmLecturer()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtLecturerID.Text == "")
            {
                MessageBox.Show("Please enter your LecturerID: ", "Lecturer Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtLecturerID.Focus();
            }
            else if (txtLecturerName.Text == "")
            {
                MessageBox.Show("Please enter your LecturerName: ", "Lecturer Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtLecturerName.Focus();
            }
            else if (txtQualification.Text == "")
            {
                MessageBox.Show("Please enter your txtQualification: ", "Lecturer Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtQualification.Focus();
            }
            else if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Please enter your EmailAddress: ", "Lecturer Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter your PhoneNumber: ", "Lecturer Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
            }
            else
            {
                MessageBox.Show("Lecturer Form Save Successful", "Lecturer Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
