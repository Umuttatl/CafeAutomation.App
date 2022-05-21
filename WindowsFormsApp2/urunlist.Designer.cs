namespace WindowsFormsApp2
{
    partial class urunlist
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
            this.urun_gunc = new System.Windows.Forms.Button();
            this.urun_sil = new System.Windows.Forms.Button();
            this.urun_ekle = new System.Windows.Forms.Button();
            this.index = new System.Windows.Forms.Button();
            this.cikis = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // urun_gunc
            // 
            this.urun_gunc.Location = new System.Drawing.Point(16, 477);
            this.urun_gunc.Name = "urun_gunc";
            this.urun_gunc.Size = new System.Drawing.Size(101, 23);
            this.urun_gunc.TabIndex = 4;
            this.urun_gunc.Text = "Ürün Güncelle";
            this.urun_gunc.UseVisualStyleBackColor = true;
            this.urun_gunc.Click += new System.EventHandler(this.urun_gunc_Click);
            // 
            // urun_sil
            // 
            this.urun_sil.Location = new System.Drawing.Point(154, 477);
            this.urun_sil.Name = "urun_sil";
            this.urun_sil.Size = new System.Drawing.Size(107, 23);
            this.urun_sil.TabIndex = 5;
            this.urun_sil.Text = "Ürün Sil";
            this.urun_sil.UseVisualStyleBackColor = true;
            this.urun_sil.Click += new System.EventHandler(this.urun_sil_Click);
            // 
            // urun_ekle
            // 
            this.urun_ekle.Location = new System.Drawing.Point(154, 424);
            this.urun_ekle.Name = "urun_ekle";
            this.urun_ekle.Size = new System.Drawing.Size(107, 23);
            this.urun_ekle.TabIndex = 6;
            this.urun_ekle.Text = "Ürün Ekle";
            this.urun_ekle.UseVisualStyleBackColor = true;
            this.urun_ekle.Click += new System.EventHandler(this.urun_ekle_Click);
            // 
            // index
            // 
            this.index.Location = new System.Drawing.Point(16, 424);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(101, 23);
            this.index.TabIndex = 7;
            this.index.Text = "Ana Sayfa";
            this.index.UseVisualStyleBackColor = true;
            this.index.Click += new System.EventHandler(this.index_Click);
            // 
            // cikis
            // 
            this.cikis.Location = new System.Drawing.Point(186, 557);
            this.cikis.Name = "cikis";
            this.cikis.Size = new System.Drawing.Size(75, 23);
            this.cikis.TabIndex = 8;
            this.cikis.Text = "Çıkış";
            this.cikis.UseVisualStyleBackColor = true;
            this.cikis.Click += new System.EventHandler(this.cikis_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(313, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1124, 558);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Numarası";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Kodu";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ürün Adı";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Kategori";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birim Fiyat";
            // 
            // urunlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1449, 589);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cikis);
            this.Controls.Add(this.index);
            this.Controls.Add(this.urun_ekle);
            this.Controls.Add(this.urun_sil);
            this.Controls.Add(this.urun_gunc);
            this.Name = "urunlist";
            this.Text = "Ürün Listesi";
            this.Load += new System.EventHandler(this.urunlist_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button urun_gunc;
        private System.Windows.Forms.Button urun_sil;
        private System.Windows.Forms.Button urun_ekle;
        private System.Windows.Forms.Button index;
        private System.Windows.Forms.Button cikis;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}