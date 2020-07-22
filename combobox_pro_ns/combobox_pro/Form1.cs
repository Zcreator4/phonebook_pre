using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox_pro
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
            if(textBox1.Text == "")
            {
                MessageBox.Show("You have to enter your name.");
                return;
            }

            comboBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int si;
            si = comboBox1.SelectedIndex;

            comboBox1.Items.RemoveAt(si);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label3.Text = comboBox1.Items.Count.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int fi;
            fi = comboBox2.FindStringExact(textBox2.Text);
            this.Text = fi.ToString();
            comboBox2.SelectedIndex = fi;

            if(fi == -1)
            {
                MessageBox.Show("Not Found.");
            }
            else
            {
                this.Text = fi.ToString();
                comboBox2.SelectedIndex = fi;
            }
        }
    }
}
