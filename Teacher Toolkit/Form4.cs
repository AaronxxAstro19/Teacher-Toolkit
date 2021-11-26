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
    public partial class Rewards : Form
    {
        public Rewards()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (listBox1.Items.Count > 0)
            {
                int studentNum = rnd.Next(0, listBox1.Items.Count);
                textBox1.Text = listBox1.Items[studentNum].ToString();

                listBox1.Items.RemoveAt(studentNum);
            }
            else
            {
                MessageBox.Show("Please add students!");
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

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void importClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getClassList();
        }
        void getClassList()
        {
            
            {
                
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}

