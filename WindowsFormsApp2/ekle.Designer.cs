namespace WindowsFormsApp2
{
    partial class ekle
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
            this.urun_kaydet = new System.Windows.Forms.Button();
            this.kategori = new System.Windows.Forms.ComboBox();
            this.urun_fiyat = new System.Windows.Forms.TextBox();
            this.urun_adi = new System.Windows.Forms.TextBox();
            this.urun_kodu = new System.Windows.Forms.TextBox();
            this.urun_no = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Button();
            this.urun_sil = new System.Windows.Forms.Button();
            this.urun_gunc = new System.Windows.Forms.Button();
            this.urunler = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urun_kaydet);
            this.groupBox1.Controls.Add(this.kategori);
            this.groupBox1.Controls.Add(this.urun_fiyat);
            this.groupBox1.Controls.Add(this.urun_adi);
            this.groupBox1.Controls.Add(this.urun_kodu);
            this.groupBox1.Controls.Add(this.urun_no);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 401);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İşlemler";
            // 
            // urun_kaydet
            // 
            this.urun_kaydet.Location = new System.Drawing.Point(91, 250);
            this.urun_kaydet.Name = "urun_kaydet";
            this.urun_kaydet.Size = new System.Drawing.Size(75, 23);
            this.urun_kaydet.TabIndex = 12;
            this.urun_kaydet.Text = "Ürün Kaydet";
            this.urun_kaydet.UseVisualStyleBackColor = true;
            this.urun_kaydet.Click += new System.EventHandler(this.urun_kaydet_Click);
            // 
            // kategori
            // 
            this.kategori.FormattingEnabled = true;
            this.kategori.Location = new System.Drawing.Point(91, 109);
            this.kategori.Name = "kategori";
            this.kategori.Size = new System.Drawing.Size(121, 21);
            this.kategori.TabIndex = 10;
            // 
            // urun_fiyat
            // 
            this.urun_fiyat.Location = new System.Drawing.Point(91, 209);
            this.urun_fiyat.Name = "urun_fiyat";
            this.urun_fiyat.Size = new System.Drawing.Size(100, 20);
            this.urun_fiyat.TabIndex = 9;
            // 
            // urun_adi
            // 
            this.urun_adi.Location = new System.Drawing.Point(91, 159);
            this.urun_adi.Name = "urun_adi";
            this.urun_adi.Size = new System.Drawing.Size(100, 20);
            this.urun_adi.TabIndex = 8;
            // 
            // urun_kodu
            // 
            this.urun_kodu.Location = new System.Drawing.Point(91, 67);
            this.urun_kodu.Name = "urun_kodu";
            this.urun_kodu.Size = new System.Drawing.Size(100, 20);
            this.urun_kodu.TabIndex = 7;
            // 
            // urun_no
            // 
            this.urun_no.Location = new System.Drawing.Point(91, 29);
            this.urun_no.Name = "urun_no";
            this.urun_no.Size = new System.Drawing.Size(100, 20);
            this.urun_no.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ürün Fiyatı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ürün Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Kodu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün No:";
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(29, 415);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(75, 23);
            this.index.TabIndex = 13;
            this.index.Text = "Ana Sayfa";
            this.index.UseVisualStyleBackColor = true;
            this.index.Click += new System.EventHandler(this.index_Click);
            // 
            // urun_sil
            // 
            this.urun_sil.Location = new System.Drawing.Point(244, 415);
            this.urun_sil.Name = "urun_sil";
            this.urun_sil.Size = new System.Drawing.Size(75, 23);
            this.urun_sil.TabIndex = 14;
            this.urun_sil.Text = "Sil";
            this.urun_sil.UseVisualStyleBackColor = true;
            this.urun_sil.Click += new System.EventHandler(this.urun_sil_Click);
            // 
            // urun_gunc
            // 
            this.urun_gunc.Location = new System.Drawing.Point(338, 415);
            this.urun_gunc.Name = "urun_gunc";
            this.urun_gunc.Size = new System.Drawing.Size(75, 23);
            this.urun_gunc.TabIndex = 15;
            this.urun_gunc.Text = "Güncelle";
            this.urun_gunc.UseVisualStyleBackColor = true;
            this.urun_gunc.Click += new System.EventHandler(this.urun_gunc_Click);
            // 
            // urunler
            // 
            this.urunler.Location = new System.Drawing.Point(434, 415);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(75, 23);
            this.urunler.TabIndex = 16;
            this.urunler.Text = "Ürünler";
            this.urunler.UseVisualStyleBackColor = true;
            this.urunler.Click += new System.EventHandler(this.urunler_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(701, 415);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 23);
            this.cikis.TabIndex = 17;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(553, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Temizle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.index);
            this.Controls.Add(this.urun_sil);
            this.Controls.Add(this.urun_gunc);
            this.Controls.Add(this.urunler);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.groupBox1);
            this.Name = "ekle";
            this.Text = "Ürün Ekle";
            this.Load += new System.EventHandler(this.ekle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button urun_kaydet;
        private System.Windows.Forms.ComboBox kategori;
        private System.Windows.Forms.TextBox urun_fiyat;
        private System.Windows.Forms.TextBox urun_adi;
        private System.Windows.Forms.TextBox urun_kodu;
        private System.Windows.Forms.TextBox urun_no;
        private System.Windows.Forms.Button index;
        private System.Windows.Forms.Button urun_sil;
        private System.Windows.Forms.Button urun_gunc;
        private System.Windows.Forms.Button urunler;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.Button button1;
    }
}