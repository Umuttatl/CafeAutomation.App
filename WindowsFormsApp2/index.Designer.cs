namespace WindowsFormsApp2
{
    partial class index
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personel_yon = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.urun_ekle = new System.Windows.Forms.Button();
            this.urun_sil = new System.Windows.Forms.Button();
            this.urunler = new System.Windows.Forms.Button();
            this.urun_gunc = new System.Windows.Forms.Button();
            this.satis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personel_yon);
            this.groupBox1.Controls.Add(this.cikis);
            this.groupBox1.Controls.Add(this.urun_ekle);
            this.groupBox1.Controls.Add(this.urun_sil);
            this.groupBox1.Controls.Add(this.urunler);
            this.groupBox1.Controls.Add(this.urun_gunc);
            this.groupBox1.Controls.Add(this.satis);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(779, 438);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // personel_yon
            // 
            this.personel_yon.Location = new System.Drawing.Point(233, 257);
            this.personel_yon.Name = "personel_yon";
            this.personel_yon.Size = new System.Drawing.Size(241, 23);
            this.personel_yon.TabIndex = 6;
            this.personel_yon.Text = "Personel Yönetimi";
            this.personel_yon.UseVisualStyleBackColor = true;
            this.personel_yon.Click += new System.EventHandler(this.personel_yon_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(666, 379);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 23);
            this.cikis.TabIndex = 5;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // urun_ekle
            // 
            this.urun_ekle.Location = new System.Drawing.Point(209, 51);
            this.urun_ekle.Name = "urun_ekle";
            this.urun_ekle.Size = new System.Drawing.Size(107, 23);
            this.urun_ekle.TabIndex = 4;
            this.urun_ekle.Text = "Ürün Ekle";
            this.urun_ekle.UseVisualStyleBackColor = true;
            this.urun_ekle.Click += new System.EventHandler(this.urun_ekle_Click);
            // 
            // urun_sil
            // 
            this.urun_sil.Location = new System.Drawing.Point(399, 51);
            this.urun_sil.Name = "urun_sil";
            this.urun_sil.Size = new System.Drawing.Size(107, 23);
            this.urun_sil.TabIndex = 3;
            this.urun_sil.Text = "Ürün Sil";
            this.urun_sil.UseVisualStyleBackColor = true;
            this.urun_sil.Click += new System.EventHandler(this.urun_sil_Click);
            // 
            // urunler
            // 
            this.urunler.Location = new System.Drawing.Point(209, 116);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(107, 23);
            this.urunler.TabIndex = 2;
            this.urunler.Text = "Ürünler";
            this.urunler.UseVisualStyleBackColor = true;
            this.urunler.Click += new System.EventHandler(this.urunler_Click);
            // 
            // urun_gunc
            // 
            this.urun_gunc.Location = new System.Drawing.Point(399, 116);
            this.urun_gunc.Name = "urun_gunc";
            this.urun_gunc.Size = new System.Drawing.Size(107, 23);
            this.urun_gunc.TabIndex = 1;
            this.urun_gunc.Text = "Ürün Güncelle";
            this.urun_gunc.UseVisualStyleBackColor = true;
            this.urun_gunc.Click += new System.EventHandler(this.urun_gunc_Click);
            // 
            // satis
            // 
            this.satis.Location = new System.Drawing.Point(286, 160);
            this.satis.Name = "satis";
            this.satis.Size = new System.Drawing.Size(118, 23);
            this.satis.TabIndex = 0;
            this.satis.Text = "Satış";
            this.satis.UseVisualStyleBackColor = true;
            this.satis.Click += new System.EventHandler(this.satis_Click);
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "index";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.index_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button personel_yon;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button urun_ekle;
        private System.Windows.Forms.Button urun_sil;
        private System.Windows.Forms.Button urunler;
        private System.Windows.Forms.Button urun_gunc;
        private System.Windows.Forms.Button satis;
    }
}