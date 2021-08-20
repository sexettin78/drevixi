using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drevixi
{
    public partial class tarayici : Form
    {
        public tarayici()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(textBox1.Text);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://google.com");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://drevixi.rf.gd");
        }
    }
}
