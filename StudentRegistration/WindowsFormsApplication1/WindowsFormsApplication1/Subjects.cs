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
    public partial class frmSubjects : Form
    {
        public frmSubjects()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSubjectName.Text == "")
            {
                MessageBox.Show("Please enter your SubjectName:", "Subjects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSubjectName.Focus();
            }
            else if (txtDuration.Text == "")
            {
                MessageBox.Show("Please enter your Duration:", "Subjects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDuration.Focus();
            }
            else if (txtTopics.Text == "")
            {
                MessageBox.Show("Please enter your Topics:", "Subjects", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTopics.Focus();
            }
            else
            {
                MessageBox.Show("Subjects Save Successful!", "Subjects", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSubjectName.Text = "";
                txtDuration.Text = "";
                txtTopics.Text = "";
                txtSubjectName.Focus();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSubjectName.Text = "";
            txtDuration.Text = "";
            txtTopics.Text = "";
            txtSubjectName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
