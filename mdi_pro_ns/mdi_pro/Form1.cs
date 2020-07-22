using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Backup bf = new Backup();
            bf.MdiParent = this;
            bf.BackColor = Color.Turquoise;
            bf.MinimizeBox = false;
            bf.MaximizeBox = false;
            bf.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            settings sf = new settings();
            sf.MdiParent = this;
            sf.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Backup bf = new Backup();
            bf.MdiParent = this;
            bf.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            settings sf = new settings();
            sf.MdiParent = this;
            sf.Show();
        }
    }
}
