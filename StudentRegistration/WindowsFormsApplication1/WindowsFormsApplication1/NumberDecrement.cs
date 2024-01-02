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
    public partial class NumberDecrement : Form
    {
        public NumberDecrement()
        {
            InitializeComponent();
        }

        private void btnDSL_Click(object sender, EventArgs e)
        {
            for (int i = 20; i >= 12; i = i-2)
            {
                lblDSL.Text += i + "\n";
            }
        }
    }
}
