using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teacher_Toolkit
{
    public partial class Form6 : Form
    {
        float timer = 5;
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer = float.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer -= timer1.Interval * 0.001f;
            textBox1.Text = timer.ToString("00.00");
            if (timer < 0)
            {
                timer1.Enabled = false;
                textBox1.Text = "0.00";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
