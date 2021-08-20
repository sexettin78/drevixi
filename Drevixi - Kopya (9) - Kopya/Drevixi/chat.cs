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
    public partial class chat : Form
    {
        public chat()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ipchat.unaux.com");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ipchat.unaux.com/drevixi");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ipchat.unaux.com/drevixi/oyun");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ipchat.unaux.com/drevixi/anonim");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://ipchat.unaux.com/drevixi/kllanici");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
