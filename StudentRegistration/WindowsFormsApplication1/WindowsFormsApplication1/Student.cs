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
    public partial class frmStudent : Form
    {
        public frmStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 3; i++)
            {
                lblDisplay.Text += i + "\n";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Text = "";
            txtStudentName.Text = "";
            txtNRC.Text = "";
            txtQuali.Text = "";
            txtEmailAddress.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
            txtStudentID.Focus();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            txtStudentID.Select();
            this.ActiveControl = txtStudentID;
            txtStudentID.Focus();

            /* txtStudentName.Select();
            this.ActiveControl = txtStudentName;
            txtStudentName.Focus(); */
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
             if (txtStudentID.Text == "")
            {
                MessageBox.Show("Please enter StudentID: ", "Student Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtStudentID.Focus();
            }
            else if (txtStudentName.Text == "")
            {
                MessageBox.Show("Please enter your StudentName: ", "Student Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtStudentName.Focus();
            }
            else if (txtNRC.Text == "")
            {
                MessageBox.Show("Please enter your NRC Number: ", "Student Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtNRC.Focus();
            }
            else if (txtQuali.Text == "")
            {
                MessageBox.Show("Please enter your Qualifaction: ", "Student Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtQuali.Focus();
            }
            else if (txtEmailAddress.Text == "")
            {
                MessageBox.Show("Please enter your EmailAddress: ", "Student Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtEmailAddress.Focus();
            }
            else if (txtPhoneNumber.Text == "")
            {
                MessageBox.Show("Please enter your PhoneNumber: ", "Student Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                txtPhoneNumber.Focus();
            }
             else if (txtAddress.Text == "")
             {
                 MessageBox.Show("Please enter your Address: ", "Student Form", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                 txtAddress.Focus();
             }
             else
             {
                 MessageBox.Show("Student Save Successful", "Student Form", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 txtStudentID.Text = "";
                 txtStudentName.Text = "";
                 txtNRC.Text = "";
                 txtQuali.Text = "";
                 txtEmailAddress.Text = "";
                 txtPhoneNumber.Text = "";
                 txtAddress.Text = "";
                 txtStudentID.Focus();
             }
        }
    }
}
