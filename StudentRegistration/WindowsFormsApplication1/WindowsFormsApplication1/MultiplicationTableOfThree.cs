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
    public partial class MultiplicationTableOfThree : Form
    {
        public MultiplicationTableOfThree()
        {
            InitializeComponent();
        }
                                                     
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5 ; i++)
            {
                lblDisplay.Text += "3 * " + i + " = " + (3 * i) + "\n";
            }
        }
    }
}
