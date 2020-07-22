using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace io_file
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = openFileDialog1.FileName;

            this.folderBrowserDialog1.ShowDialog();
            string folder;
            folder = folderBrowserDialog1.SelectedPath;

            System.IO.File.Copy(fn, folder);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = openFileDialog1.FileName;

            this.folderBrowserDialog1.ShowDialog();
            string folder;
            folder = folderBrowserDialog1.SelectedPath;

            System.IO.File.Move(fn, folder);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
            string fn;
            fn = openFileDialog1.FileName;

            System.IO.File.Delete(fn);
        }
    }
}
