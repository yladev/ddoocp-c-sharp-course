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
    public partial class NumberIncrement : Form
    {
        public NumberIncrement()
        {
            InitializeComponent();
        }

        private void btnDis_Click(object sender, EventArgs e)
        {
            for (int i = 10; i <= 30; i=i+5)
            {
                lblDis.Text += i + "\n";
            }
        }
    }
}
