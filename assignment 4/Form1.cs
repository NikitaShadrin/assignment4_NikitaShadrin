using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double numberInt = double.Parse(textBox1.Text);
            double result = numberInt;

            for (double i = 1; i < numberInt; i++)
            {
                result = result * i;
            }

            MessageBox.Show(result.ToString());
        }
    }
}
