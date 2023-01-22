using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_x_10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lblShow.Text = "";
            for(int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    lblShow.Text += (i * j).ToString();
                    if (i * j <= 9)
                        lblShow.Text += "      ";
                    else
                        lblShow.Text += "    ";

                }
                lblShow.Text += "\n";
            }
        }
    }
}
