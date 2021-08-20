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
    public partial class paint : Form
    {
        public paint()
        {
            InitializeComponent();
        }
        bool ciz;
        int baslax, baslay;
        int kalınlık = 3;
        ColorDialog renksec = new ColorDialog();
        private void paint_Load(object sender, EventArgs e)
        {
           
        }

        private void paint_MouseDown(object sender, MouseEventArgs e)
        {
            ciz = true;
            baslax = e.X;
            baslay = e.Y;
        }

        private void paint_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen p = new Pen(renksec.Color, kalınlık);

            Point point1 = new Point(baslax, baslay);
            Point point2 = new Point(e.X, e.Y);

            if (ciz == true) 
            {
                g.DrawLine(p, point1, point2);
                baslax = e.X;
                baslay = e.Y;
            }
        }

        private void paint_MouseUp(object sender, MouseEventArgs e)
        {
            ciz = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            renksec.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ciz = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            kalınlık = int.Parse(comboBox1.SelectedIndex.ToString());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ciz == false)
            {
                ciz = true;
            }
            else
            {
                ciz = false;
            }
        }
    }
}
