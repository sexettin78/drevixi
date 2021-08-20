using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Security.Cryptography;
using System.IO;


namespace Drevixi
{
    public partial class drevixi : Form
    {
        String videoyol, videoyazi;
        public drevixi()
        {
            InitializeComponent();
            String ayar;
            String videoyol;
            
        }
        PowerStatus ps = SystemInformation.PowerStatus;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
            if (denetim.Visible == true)
            {
                denetim.Visible = false;
            }
            else {
                denetim.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
          
            tarayici browser = new tarayici();
            browser.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }
        bool sürükle = false;
        Point konum;
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;
            konum = e.Location;

        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükle == true)
            {
               
            }
        }

        private void panel3_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongTimeString();
            label2.Text = DateTime.Now.ToLongDateString();
            label31.Text = ps.BatteryLifePercent.ToString("P");
            progressBar1.Value = (int)(ps.BatteryLifePercent * 100); 
            
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
           
          
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ayarlar.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ayarlar.Visible = false;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                denetim.BackColor = Color.Red;
            }
            
        }

        private void ayarlar_Paint(object sender, PaintEventArgs e)
        {
            if (radioButton5.Checked == true)
            {
              
               
                panel5.BackColor = Color.Red;
                panel6.BackColor = Color.Red;
                panel7.BackColor = Color.Red;
                denetim.BackColor = Color.Red;
                ayarlar.BackColor = Color.Red;
                muzık.BackColor = Color.Red;
                panel8.BackColor = Color.Red;
                panel9.BackColor = Color.Red;
                panel10.BackColor = Color.Red;
                panel11.BackColor = Color.Red;
                panel12.BackColor = Color.Red;
                panel13.BackColor = Color.Red;
            }
            if (radioButton6.Checked == true)
            {
        
                panel5.BackColor = Color.Green;
                panel6.BackColor = Color.Green;
                panel7.BackColor = Color.Green;
                denetim.BackColor = Color.Green;
                ayarlar.BackColor = Color.Green;
                muzık.BackColor = Color.Green;
                panel8.BackColor = Color.Green;
                panel9.BackColor = Color.Green;
                panel10.BackColor = Color.Green;
                panel11.BackColor = Color.Green;
                panel12.BackColor = Color.Green;
                panel13.BackColor = Color.Green;
            }
            if (radioButton7.Checked == true)
            {

                
                panel5.BackColor = Color.Yellow;
                panel6.BackColor = Color.Yellow;
                panel7.BackColor = Color.Yellow;
                denetim.BackColor = Color.Yellow;
                ayarlar.BackColor = Color.Yellow;
                muzık.BackColor = Color.Yellow;
                panel8.BackColor = Color.Yellow;
                panel9.BackColor = Color.Yellow;
                panel10.BackColor = Color.Yellow;
                panel11.BackColor = Color.Yellow;
                panel12.BackColor = Color.Yellow;
                panel13.BackColor = Color.Yellow;
            }
            if (radioButton8.Checked == true)
            {

              
                panel5.BackColor = Color.Aqua;
                panel6.BackColor = Color.Aqua;
                panel7.BackColor = Color.Aqua;
                denetim.BackColor = Color.Aqua;
                ayarlar.BackColor = Color.Aqua;
                muzık.BackColor = Color.Aqua;
                panel8.BackColor = Color.Aqua;
                panel9.BackColor = Color.Aqua;
                panel10.BackColor = Color.Aqua;
                panel11.BackColor = Color.Aqua;
                panel12.BackColor = Color.Aqua;
                panel13.BackColor = Color.Aqua;
            }
            if (radioButton1.Checked == true)
            {

                
                panel5.BackColor = Color.Pink;
                panel6.BackColor = Color.Pink;
                panel7.BackColor = Color.Pink;
                denetim.BackColor = Color.Pink;
                ayarlar.BackColor = Color.Pink;
                muzık.BackColor = Color.Pink;
                muzık.BackColor = Color.Pink;
                panel8.BackColor = Color.Pink;
                panel9.BackColor = Color.Pink;
                panel10.BackColor = Color.Pink;
                panel11.BackColor = Color.Pink;
                panel12.BackColor = Color.Pink;
                panel13.BackColor = Color.Pink;
            
            }
            if(radioButton2.Checked == true)
            {

                panel5.BackColor = Color.White;
                panel6.BackColor = Color.White;
                panel7.BackColor = Color.White;
                denetim.BackColor = Color.White;
                ayarlar.BackColor = Color.White;
                muzık.BackColor = Color.White;
                panel8.BackColor = Color.White;
                panel9.BackColor = Color.White;
                panel10.BackColor = Color.White;
                panel11.BackColor = Color.White;
                panel12.BackColor = Color.White;
                panel13.BackColor = Color.White;
            }

            if (radioButton3.Checked == true)
            {

                panel5.BackColor = Color.Orange;
                panel6.BackColor = Color.Orange;
                panel7.BackColor = Color.Orange;
                denetim.BackColor = Color.Orange;
                ayarlar.BackColor = Color.Orange;
                panel8.BackColor = Color.Orange;
                panel9.BackColor = Color.Orange;
                panel10.BackColor = Color.Orange;
                panel11.BackColor = Color.Orange;
                panel12.BackColor = Color.Orange;
                panel13.BackColor = Color.Orange;
            }

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            sohbet cet = new sohbet();
            cet.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Process[] Memory = Process.GetProcesses();
            foreach(Process prc in Memory)
            {
             
            listBox1.Items.Add(prc.ProcessName);
            }
            }

        private void button6_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            openFileDialog1.ShowDialog();
            for (int i = 0; i < openFileDialog1.SafeFileNames.Length; i++)
            {
                listBox3.Items.Add(openFileDialog1.SafeFileNames[i].ToString());
                listBox2.Items.Add(openFileDialog1.FileNames[i].ToString());
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.SelectedIndex = listBox3.SelectedIndex;
            axWindowsMediaPlayer2.URL = listBox2.SelectedItem.ToString();
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            muzık.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            muzık.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.pause();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.stop();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer2.Ctlcontrols.play();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog ac = new OpenFileDialog();
            ac.Title = "Dosya aç";
            ac.Filter = "Txt Dosyaları|*.txt";
            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                richTextBox1.LoadFile(ac.FileName,RichTextBoxStreamType.PlainText);
            }

           
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SaveFileDialog kaydet = new SaveFileDialog();
            kaydet.Title = "Dosya kaydet";
            kaydet.Filter = "Txt Dosyaları|*.txt"; 
            if (kaydet.ShowDialog() == System.Windows.Forms.DialogResult.OK) ;
            {
                richTextBox1.SaveFile(kaydet.FileName,RichTextBoxStreamType.PlainText);
            }

        }

        private void button14_Click(object sender, EventArgs e)
        {
            panel6.Visible = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (webBrowser3.CanGoForward)
            {
                webBrowser3.GoForward();
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbdv = new FolderBrowserDialog() { Description = "Dizin seçiniz" })
            {
                if (fbdv.ShowDialog() == DialogResult.OK)
                {
                    webBrowser3.Url = new Uri(fbdv.SelectedPath);
                    textBox2.Text = fbdv.SelectedPath;
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (webBrowser3.CanGoBack)
            {
                webBrowser3.GoBack();
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            panel7.Visible = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void panel7_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;
            konum = e.Location;
        }

        private void panel7_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükle == true)
            {
                panel7.Left = e.X + panel7.Left - (konum.X);
                panel7.Top = e.Y + panel7.Top - (konum.Y);
            }
        }

        private void panel7_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chat_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;
            konum = e.Location;
        }

        private void chat_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükle == true)
            {
  
            }
        }

        private void chat_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void ayarlar_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükle == true)
            {
                ayarlar.Left = e.X + ayarlar.Left - (konum.X);
                ayarlar.Top = e.Y + ayarlar.Top - (konum.Y);
            }
        }

        private void ayarlar_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void ayarlar_MouseDown(object sender, MouseEventArgs e)
        {

            sürükle = true;
            konum = e.Location;
        }

        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {

            sürükle = true;
            konum = e.Location;
        }

        private void panel5_MouseMove(object sender, MouseEventArgs e)
        {

            if (sürükle == true)
            {
                panel5.Left = e.X + panel5.Left - (konum.X);
                panel5.Top = e.Y + panel5.Top - (konum.Y);
            }

        }

        private void panel5_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void muzık_MouseMove(object sender, MouseEventArgs e)
        {

            if (sürükle == true)
            {
                muzık.Left = e.X + muzık.Left - (konum.X);
                muzık.Top = e.Y + muzık.Top - (konum.Y);
            }

        }

        private void muzık_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void muzık_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;
            konum = e.Location;
        }

        private void panel6_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;
            konum = e.Location;
        }

        private void panel6_MouseMove(object sender, MouseEventArgs e)
        {

            if (sürükle == true)
            {
                panel6.Left = e.X + panel6.Left - (konum.X);
                panel6.Top = e.Y + panel6.Top - (konum.Y);
            }
        }

        private void panel6_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void panel8_Paint_1(object sender, PaintEventArgs e)
        {
            int sayi1, sayi2;
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox3.Text);
            sayi2 = Convert.ToDouble(textBox4.Text);
            sonuc = sayi1 + sayi2;
            label18.Text = sonuc.ToString();

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox3.Text);
            sayi2 = Convert.ToDouble(textBox4.Text);
            sonuc = sayi1 - sayi2;
            label18.Text = sonuc.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox3.Text);
            sayi2 = Convert.ToDouble(textBox4.Text);
            sonuc = sayi1 * sayi2;
            label18.Text = sonuc.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double sayi1, sayi2, sonuc;
            sayi1 = Convert.ToDouble(textBox3.Text);
            sayi2 = Convert.ToDouble(textBox4.Text);
            sonuc = sayi1 / sayi2;
            label18.Text = sonuc.ToString();
        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {

            if (sürükle == true)
            {
                panel8.Left = e.X + panel8.Left - (konum.X);
                panel8.Top = e.Y + panel8.Top - (konum.Y);
            }
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;
            konum = e.Location;
        }

        private void panel8_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void button24_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            String videoyol, videoyazi;
            OpenFileDialog openFileDialog = new OpenFileDialog() { Multiselect = false,Filter="MP4 Dosyası|*.mp4|Tüm Dosyalar|*.*" };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                videoyol = openFileDialog.FileName;
                videoyazi = openFileDialog.SafeFileName;
                axWindowsMediaPlayer1.URL = videoyol;
                label19.Text = videoyazi;
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            String videoyol, videoyazi;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            panel9.Visible = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            panel9.Visible = false;
        }

        private void panel9_MouseDown(object sender, MouseEventArgs e)
        {
            sürükle = true;
            konum = e.Location;
        }

        private void panel9_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükle == true)
            {
                panel9.Left = e.X + panel9.Left - (konum.X);
                panel9.Top = e.Y + panel9.Top - (konum.Y);
            }
        }

        private void panel9_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button29_Click(object sender, EventArgs e)
        {
             timer1.Start();
            
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Tekrar:
            int mesajsayisi = 0;
            for (int i = 0; i < 30; i++)
            {
                SendKeys.Send(textBox5.Text);
                SendKeys.Send("{ENTER}");
                mesajsayisi = mesajsayisi + 1;
            }
            if (mesajsayisi == 30)
            
                timer2.Stop();
            

        }

        private void button30_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(textBox6.Text);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            timer3.Stop();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
        }

        private void button32_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
        }

        private void button33_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
        }

        private void panel11_MouseDown(object sender, MouseEventArgs e)
        {

            sürükle = true;
            konum = e.Location;
        }

        private void panel11_MouseMove(object sender, MouseEventArgs e)
        {

            if (sürükle == true)
            {
                panel11.Left = e.X + panel11.Left - (konum.X);
                panel11.Top = e.Y + panel11.Top - (konum.Y);
            }
        }

        private void panel11_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void panel10_MouseMove(object sender, MouseEventArgs e)
        {

            if (sürükle == true)
            {
                panel10.Left = e.X + panel10.Left - (konum.X);
                panel10.Top = e.Y + panel10.Top - (konum.Y);
            }
        }

        private void panel10_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void panel10_MouseDown(object sender, MouseEventArgs e)
        {

            sürükle = true;
            konum = e.Location;

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
        }

        private void button34_Click(object sender, EventArgs e)
        {
            WebClient wClient = new WebClient();
            wClient.DownloadFile(textBox7.Text,@textBox8.Text);
            wClient.DownloadFileCompleted += wClient_DownloadFileCompleted;
            wClient.DownloadProgressChanged += wClient_DownloadProgressChanged;
            
        }

        void wClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            
        }

        void wClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            label27.Text = "İndirme başarı ile tamamlandı";
        }

        private void button35_Click(object sender, EventArgs e)
        {
            panel12.Visible = false;
        }
         
        private void button36_Click(object sender, EventArgs e)
        {
            WebClient wClient = new WebClient();
            wClient.DownloadFile(textBox7.Text, @textBox8.Text);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            WebClient wClient = new WebClient();
            wClient.DownloadFile(textBox7.Text, @textBox8.Text);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            panel12.Visible = true;
        }

        private void panel12_MouseDown(object sender, MouseEventArgs e)
        {

            sürükle = true;
            konum = e.Location;

        }

        private void panel12_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükle == true)
            {
                panel12.Left = e.X + panel12.Left - (konum.X);
                panel12.Top = e.Y + panel12.Top - (konum.Y);
            }

        }

        private void panel12_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        public string GetMD5FromFile(string filenpath)
        {
            using (var md5 = MD5.Create())
        {
            using (var stream = File.OpenRead(filenpath))
            {
                return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-",string.Empty).ToLower();
            }
        }
        
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            var md5signatures = File.ReadAllLines("MD5base.txt");
            if (md5signatures.Contains(tbMD5.Text))
            {
                label28.Text = "VİRÜSLÜ";
                label28.ForeColor = Color.Red;
            }
            else
            {
                label28.Text = "Dosya Temiz";
                label28.ForeColor = Color.Green;
            }
        }

        private void açToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Txt Dosyaları| *.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
            tbMD5.Text = GetMD5FromFile(ofd.FileName);
            
            }
        }

        private void çıkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel13.Visible = false;
        }

        private void panel13_MouseDown(object sender, MouseEventArgs e)
        {

            sürükle = true;
            konum = e.Location;

        }

        private void panel13_MouseMove(object sender, MouseEventArgs e)
        {

            if (sürükle == true)
            {
                panel13.Left = e.X + panel13.Left - (konum.X);
                panel13.Top = e.Y + panel13.Top - (konum.Y);
            }

        }

        private void panel13_MouseUp(object sender, MouseEventArgs e)
        {
            sürükle = false;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            panel13.Visible = false;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            panel13.Visible = true;
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            progressBar1.Value = (int)(ps.BatteryLifePercent * 100); 
        }

        private void label31_Click(object sender, EventArgs e)
        {
            label31.Text = ps.BatteryLifePercent.ToString("P");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            
            paint paint = new paint();
            paint.Show();
        }

        private void button39_Click(object sender, EventArgs e)
        {
            
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            kus kusoyun = new kus();
            kusoyun.Show();
        }

                
       
                    
             

                
            
            
        }
    }

