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
    public partial class kus : Form
    {
        int pspeed = 8;
        int gravity = 15;
        int skor = 0;
        public kus()
        {
            InitializeComponent();
        }

        public void EndGame()
        {
            Timer1.Stop();
            skora.Text = "Oyun Bitti";
            skora.ForeColor = Color.Red;
        }


        private void kus_Load(object sender, EventArgs e)
        {

        }

        private void gameTimer(object sender, EventArgs e)
        {
            kuss.Top += gravity;
            tunelalt.Left -= pspeed;
            tunel2.Left -= pspeed;
            skora.Text = "SKOR: " + skor;
            if (tunelalt.Left < -150)
            {
                tunelalt.Left = 800;
                skor++;
            }
            if (tunel2.Left < -180)
            {
                tunel2.Left = 950;
                skor++;
            }
            if (kuss.Bounds.IntersectsWith(tunelalt.Bounds) ||
            kuss.Bounds.IntersectsWith(tunel2.Bounds) ||
                kuss.Bounds.IntersectsWith(yer.Bounds) || kuss.Top < -25)
            {
                EndGame();
            }
        }

        private void game_Down(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;

            }
        }

        private void game_Up(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }

        private void gameDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -15;

            }
        }

        private void kus_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 15;

            }
        }

    }
}
