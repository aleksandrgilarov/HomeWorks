using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public static int i, s = 0;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button16.BackColor = Color.Black;
                button16.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button2.BackColor = Color.Black;
                button2.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
                s--;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button4.BackColor = Color.Black;
                button4.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
                s--;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button6.BackColor = Color.Black;
                button6.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
                s--;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button8.BackColor = Color.Black;
                button8.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
                s--;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button11.BackColor = Color.Black;
                button11.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
                s--;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button9.BackColor = Color.Black;
                button9.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
                s--;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
            {
                i++;
                s++;
                button14.BackColor = Color.Black;
                button14.Enabled = false;
            }
            if (i == 9)
            {
                MessageBox.Show("Game over score = " + s, "End", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
            if (i != 9)
                s--;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                MessageBox.Show("Game start", "Start", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                button16.BackColor = Color.White;
                button14.BackColor = Color.White;
                button11.BackColor = Color.White;
                button9.BackColor = Color.White;
                button8.BackColor = Color.White;
                button6.BackColor = Color.White;
                button4.BackColor = Color.White;
                button2.BackColor = Color.White;
                i++;
            }
             if (i != 9)
                s--;
        }
    }
}
