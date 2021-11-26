using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Teacher_Toolkit
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            textBox1.AppendText(textBox1.Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)//if atleast one person on the list
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count); //get a random place on the list
                textBox2.Text = listBox1.Items[studentNum].ToString(); //copy name to textbox

                listBox1.Items.RemoveAt(studentNum); //remove the chosen student
            }
            else
            {
                MessageBox.Show("Please add students!"); //no students on the list
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // file name
            string filename = @"\\sutcfps2.sutc.internal\studentpersonal$\18wilsona\Documents\Year 10 IT\Teacher Toolkit\Student Names.txt";
            try
            {
                // create a streamreader
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    //read line by line
                    while ((line = reader.ReadLine()) != null)
                    {
                        listBox1.Items.Add(line + "\r\n");
                    }
                }
            }
            catch (Exception exp)
            {
                textBox1.AppendText(exp.Message);
            }

        }
    }
}
