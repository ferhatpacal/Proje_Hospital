namespace Proje_Hastane
{
    partial class FrmGirisler
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.BtnhastaGirisi = new System.Windows.Forms.Button();
            this.BtnDoktorGirisi = new System.Windows.Forms.Button();
            this.BtnSekreterGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnhastaGirisi
            // 
            this.BtnhastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnhastaGirisi.BackgroundImage")));
            this.BtnhastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnhastaGirisi.Location = new System.Drawing.Point(23, 264);
            this.BtnhastaGirisi.Name = "BtnhastaGirisi";
            this.BtnhastaGirisi.Size = new System.Drawing.Size(262, 190);
            this.BtnhastaGirisi.TabIndex = 0;
            this.BtnhastaGirisi.UseVisualStyleBackColor = true;
            this.BtnhastaGirisi.Click += new System.EventHandler(this.button1_Click);
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.BtnDoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirisi.BackgroundImage")));
            this.BtnDoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(307, 264);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(262, 190);
            this.BtnDoktorGirisi.TabIndex = 1;
            this.BtnDoktorGirisi.UseVisualStyleBackColor = false;
            this.BtnDoktorGirisi.Click += new System.EventHandler(this.BtnDoktorGirisi_Click);
            // 
            // BtnSekreterGirisi
            // 
            this.BtnSekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirisi.BackgroundImage")));
            this.BtnSekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(598, 264);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(262, 190);
            this.BtnSekreterGirisi.TabIndex = 1;
            this.BtnSekreterGirisi.UseVisualStyleBackColor = true;
            this.BtnSekreterGirisi.Click += new System.EventHandler(this.BtnSekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 457);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 457);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Doktor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(685, 457);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(453, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(407, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Impact", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(399, 64);
            this.label4.TabIndex = 6;
            this.label4.Text = "develop Hospital";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(897, 513);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnhastaGirisi);
            this.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Develop Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnhastaGirisi;
        private System.Windows.Forms.Button BtnDoktorGirisi;
        private System.Windows.Forms.Button BtnSekreterGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
    }
}

