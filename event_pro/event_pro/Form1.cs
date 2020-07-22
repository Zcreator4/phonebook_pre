using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace event_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            this.Text = e.KeyCode.ToString();

            switch(e.KeyCode)
            {
                case Keys.Escape:
                    this.Close();
                    break;

                case Keys.F5:
                    this.button2_Click(sender, e);
                    break;

                case Keys.F4:
                    this.BackColor = Color.Violet;
                    break;
            }

            //if(e.KeyCode == Keys.F5)
            //{
            //    this.button2_Click(sender,e);
            //}

            //if(e.KeyCode == Keys.F4)
            //{
            //    this.BackColor = Color.Violet;
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Aqua;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
    }
}
