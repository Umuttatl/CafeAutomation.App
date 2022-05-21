namespace WindowsFormsApp2
{
    partial class salon1
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
            this.ms_kaydet = new System.Windows.Forms.Button();
            this.ms_tasi = new System.Windows.Forms.Button();
            this.ms_kapat = new System.Windows.Forms.Button();
            this.ms_cikis = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fis_tut_tb = new System.Windows.Forms.TextBox();
            this.adet_tb = new System.Windows.Forms.TextBox();
            this.br_fyt_tb = new System.Windows.Forms.TextBox();
            this.tp_tut_tb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_hsp = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_masa_no = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ms_kaydet
            // 
            this.ms_kaydet.Location = new System.Drawing.Point(28, 478);
            this.ms_kaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ms_kaydet.Name = "ms_kaydet";
            this.ms_kaydet.Size = new System.Drawing.Size(100, 28);
            this.ms_kaydet.TabIndex = 0;
            this.ms_kaydet.Text = "Kaydet";
            this.ms_kaydet.UseVisualStyleBackColor = true;
            // 
            // ms_tasi
            // 
            this.ms_tasi.Location = new System.Drawing.Point(224, 478);
            this.ms_tasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ms_tasi.Name = "ms_tasi";
            this.ms_tasi.Size = new System.Drawing.Size(100, 28);
            this.ms_tasi.TabIndex = 1;
            this.ms_tasi.Text = "Taşı";
            this.ms_tasi.UseVisualStyleBackColor = true;
            // 
            // ms_kapat
            // 
            this.ms_kapat.Location = new System.Drawing.Point(483, 478);
            this.ms_kapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ms_kapat.Name = "ms_kapat";
            this.ms_kapat.Size = new System.Drawing.Size(100, 28);
            this.ms_kapat.TabIndex = 2;
            this.ms_kapat.Text = "Masa Kapat";
            this.ms_kapat.UseVisualStyleBackColor = true;
            // 
            // ms_cikis
            // 
            this.ms_cikis.Location = new System.Drawing.Point(636, 478);
            this.ms_cikis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ms_cikis.Name = "ms_cikis";
            this.ms_cikis.Size = new System.Drawing.Size(100, 28);
            this.ms_cikis.TabIndex = 3;
            this.ms_cikis.Text = "Çıkış";
            this.ms_cikis.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Birim Fiyat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Toplam Tutar";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(125, 130);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(436, 15);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(363, 378);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Masa ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ürün Adı";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Toplam Tutar";
            // 
            // fis_tut_tb
            // 
            this.fis_tut_tb.Location = new System.Drawing.Point(603, 401);
            this.fis_tut_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fis_tut_tb.Name = "fis_tut_tb";
            this.fis_tut_tb.Size = new System.Drawing.Size(132, 22);
            this.fis_tut_tb.TabIndex = 10;
            // 
            // adet_tb
            // 
            this.adet_tb.Location = new System.Drawing.Point(125, 226);
            this.adet_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adet_tb.Name = "adet_tb";
            this.adet_tb.Size = new System.Drawing.Size(160, 22);
            this.adet_tb.TabIndex = 11;
            // 
            // br_fyt_tb
            // 
            this.br_fyt_tb.Location = new System.Drawing.Point(125, 176);
            this.br_fyt_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.br_fyt_tb.Name = "br_fyt_tb";
            this.br_fyt_tb.Size = new System.Drawing.Size(160, 22);
            this.br_fyt_tb.TabIndex = 12;
            // 
            // tp_tut_tb
            // 
            this.tp_tut_tb.Location = new System.Drawing.Point(153, 369);
            this.tp_tut_tb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tp_tut_tb.Name = "tp_tut_tb";
            this.tp_tut_tb.Size = new System.Drawing.Size(132, 22);
            this.tp_tut_tb.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(493, 405);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Toplam Adisyon";
            // 
            // btn_hsp
            // 
            this.btn_hsp.Location = new System.Drawing.Point(125, 270);
            this.btn_hsp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_hsp.Name = "btn_hsp";
            this.btn_hsp.Size = new System.Drawing.Size(161, 28);
            this.btn_hsp.TabIndex = 15;
            this.btn_hsp.Text = "Hesapla";
            this.btn_hsp.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Masa No";
            // 
            // tb_masa_no
            // 
            this.tb_masa_no.Location = new System.Drawing.Point(125, 15);
            this.tb_masa_no.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_masa_no.Name = "tb_masa_no";
            this.tb_masa_no.Size = new System.Drawing.Size(160, 22);
            this.tb_masa_no.TabIndex = 17;
            // 
            // salon1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 532);
            this.Controls.Add(this.tb_masa_no);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_hsp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tp_tut_tb);
            this.Controls.Add(this.br_fyt_tb);
            this.Controls.Add(this.adet_tb);
            this.Controls.Add(this.fis_tut_tb);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ms_cikis);
            this.Controls.Add(this.ms_kapat);
            this.Controls.Add(this.ms_tasi);
            this.Controls.Add(this.ms_kaydet);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "salon1";
            this.Text = "S-01";
            this.Load += new System.EventHandler(this.salon1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ms_kaydet;
        private System.Windows.Forms.Button ms_tasi;
        private System.Windows.Forms.Button ms_kapat;
        private System.Windows.Forms.Button ms_cikis;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox fis_tut_tb;
        private System.Windows.Forms.TextBox adet_tb;
        private System.Windows.Forms.TextBox br_fyt_tb;
        private System.Windows.Forms.TextBox tp_tut_tb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_hsp;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_masa_no;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}