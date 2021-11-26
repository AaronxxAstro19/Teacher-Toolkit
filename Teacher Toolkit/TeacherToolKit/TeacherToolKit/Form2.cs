using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeacherToolKit
{
    public partial class Form2 : Form
    {
        float timer = 0;
        float timerB = 10;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer += timer1.Interval * 0.001f;
            textBox1.Text = " Time Elapsed: " + timer.ToString("0.0");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer = 0;
            textBox1.Text = " Time Elapsed:  ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timerB = float.Parse(textBox2.Text);
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timerB -= timer2.Interval * 0.001f;
            textBox2.Text = timerB.ToString("00.00");
            if (timerB < 0) 
            {
                timer2.Enabled = false;
                textBox2.Text = "0.00";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            timer2.Enabled = false;
        }
    }
}
