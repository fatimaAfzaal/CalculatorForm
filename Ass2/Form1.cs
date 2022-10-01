using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ass2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            try
            {
                label5.Text = (double.Parse(textBox1.Text) + double.Parse(textBox2.Text)).ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Please enter a valid number","Invalid Input", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = (double.Parse(textBox1.Text) - double.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = (double.Parse(textBox1.Text) * double.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                label5.Text = (double.Parse(textBox1.Text) / double.Parse(textBox2.Text)).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
