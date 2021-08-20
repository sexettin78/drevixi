namespace Drevixi
{
    partial class kus
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kus));
            this.yer = new System.Windows.Forms.PictureBox();
            this.tunelalt = new System.Windows.Forms.PictureBox();
            this.tunel2 = new System.Windows.Forms.PictureBox();
            this.kuss = new System.Windows.Forms.PictureBox();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.skora = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.yer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunelalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuss)).BeginInit();
            this.SuspendLayout();
            // 
            // yer
            // 
            this.yer.Image = global::Drevixi.Properties.Resources._34_345857_ground_tints_and_shades;
            this.yer.Location = new System.Drawing.Point(-3, 509);
            this.yer.Name = "yer";
            this.yer.Size = new System.Drawing.Size(587, 86);
            this.yer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yer.TabIndex = 4;
            this.yer.TabStop = false;
            // 
            // tunelalt
            // 
            this.tunelalt.Image = global::Drevixi.Properties.Resources.do_what_i_waaant_transparent_warp_pipe_pngs_for_all_flappy_bird_pipe_115630532830ulyq0drvv__1_;
            this.tunelalt.Location = new System.Drawing.Point(277, 323);
            this.tunelalt.Name = "tunelalt";
            this.tunelalt.Size = new System.Drawing.Size(142, 190);
            this.tunelalt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tunelalt.TabIndex = 3;
            this.tunelalt.TabStop = false;
            // 
            // tunel2
            // 
            this.tunel2.Image = global::Drevixi.Properties.Resources.pipe_180;
            this.tunel2.Location = new System.Drawing.Point(401, 0);
            this.tunel2.Name = "tunel2";
            this.tunel2.Size = new System.Drawing.Size(100, 140);
            this.tunel2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tunel2.TabIndex = 2;
            this.tunel2.TabStop = false;
            // 
            // kuss
            // 
            this.kuss.Image = global::Drevixi.Properties.Resources.images__4___1_1;
            this.kuss.Location = new System.Drawing.Point(38, 70);
            this.kuss.Name = "kuss";
            this.kuss.Size = new System.Drawing.Size(64, 49);
            this.kuss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kuss.TabIndex = 1;
            this.kuss.TabStop = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 20;
            this.Timer1.Tick += new System.EventHandler(this.gameTimer);
            // 
            // skora
            // 
            this.skora.AutoSize = true;
            this.skora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.skora.Location = new System.Drawing.Point(2, 9);
            this.skora.Name = "skora";
            this.skora.Size = new System.Drawing.Size(78, 31);
            this.skora.TabIndex = 5;
            this.skora.Text = "Skor:";
            // 
            // kus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(578, 591);
            this.Controls.Add(this.skora);
            this.Controls.Add(this.yer);
            this.Controls.Add(this.tunelalt);
            this.Controls.Add(this.tunel2);
            this.Controls.Add(this.kuss);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "kus";
            this.Text = "Drevixi Flappy Bird";
            this.Load += new System.EventHandler(this.kus_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.kus_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.yer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunelalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tunel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kuss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox kuss;
        private System.Windows.Forms.PictureBox tunel2;
        private System.Windows.Forms.PictureBox tunelalt;
        private System.Windows.Forms.PictureBox yer;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.Label skora;
    }
}