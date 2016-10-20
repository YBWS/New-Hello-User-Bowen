using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCaculate_Click(object sender, EventArgs e)
        {
            double input1 = Convert.ToDouble(txtoutput1.Text);
            double input2 = Convert.ToDouble(txtoutput2.Text);

            double total = input1 * 10 + input2;

            //computer display
            lblDisplay.Text = string.Format("{0,10}{1,15:C2}\n{2,10}{3,15:C2}\n{4,10}{5,15:C2}",
                "item1", input1, "item2", input2, "total:", total);
        }
    }
}
