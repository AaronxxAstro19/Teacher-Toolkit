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
    public partial class Form7 : Form
    {
        int[] classList = new int[10];
        public Form7()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
            textBox2.AppendText(textBox2.Text);
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* {
                 Random rnd = new Random();
                 if (listBox1.Items.Count > 0)
                 {
                     int studentNum = rnd.Next(0, listBox1.Items.Count);
                     listBox1.Items[studentNum].ToString();

                     listBox1.Items.RemoveAt(studentNum);
                 }
                 else
                 {
                     MessageBox.Show("Please add students!");
                 }
             }*/
            // file name

            string filename = @"\\sutcfps2.sutc.internal\studentpersonal$\18wilsona\Documents\Year 10 IT\Teacher Toolkit\Student Names.txt";
            listBox1.Items.Clear();
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
            catch
            {

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // file name
            string filename = @"\\sutcfps2.sutc.internal\studentpersonal$\18wilsona\Documents\Year 10 IT\Teacher Toolkit\Student Names.txt";
            listBox1.Items.Clear();
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
            catch
            {

            }


            //shuffle 
            Random rnd = new Random();
            for (int i =0;i<listBox1.Items.Count;i++)
            {
                string temp = listBox1.Items[i].ToString();
                int rnum = rnd.Next(0, listBox1.Items.Count);
                listBox1.Items[i] = listBox1.Items[rnum];
                listBox1.Items[rnum] = temp;
            }


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

            
    }
}
        