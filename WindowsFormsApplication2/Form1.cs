using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(sender.ToString());
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                MessageBox.Show("the left one was");
            }
            else if (e.Button==MouseButtons.Right)
            {
                MessageBox.Show("the right one was");
            }

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyData == Keys.A)
           {
               MessageBox.Show("letter A pressed");
           }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("you cant leave this box blank");

                textBox2.Focus();

            }
            else
            {
                textBox2.Text = textBox2.Text.ToUpper();
            }
        }
    }
}
