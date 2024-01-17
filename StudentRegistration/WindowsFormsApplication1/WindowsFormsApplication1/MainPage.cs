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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void mnuStudent_Click(object sender, EventArgs e)
        {
            frmStudent s = new frmStudent();
            s.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuLecturer_Click(object sender, EventArgs e)
        {
            frmLecturer l = new frmLecturer();
            l.Show();
        }

        private void subjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubjects sub = new frmSubjects();
            sub.Show();
        }

        private void mnuCourse_Click(object sender, EventArgs e)
        {
            frmCourse c = new frmCourse();
            c.Show();
        }
    }
}
