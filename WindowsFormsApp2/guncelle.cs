using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp2
{
    public partial class guncelle : Form
    {
        public guncelle()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLG0ND9;Initial Catalog=urunler;Integrated Security=True");

        private void cikis_Click(object sender, EventArgs e)
        {
            DialogResult s = MessageBox.Show("Çıkış yapmak istediğinize emin misiniz?", "ÇIKIŞ", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (s == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }
        }

        private void index_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Sayfa", "ANA SAYFA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            index index = new index();
            index.Show();
            this.Hide();
        }

        private void urun_ekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Ekleme Ekranı", "ÜRÜN EKLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ekle ekle = new ekle();
            ekle.Show();
            this.Hide();
        }

        private void urun_sil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Silme Ekranı", "ÜRÜN SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sil sil = new sil();
            sil.Show();
            this.Hide();
        }

        private void urunler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Listeleme Ekranı", "ÜRÜNLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunlist urunlist = new urunlist();
            urunlist.Show();
            this.Hide();
        }

        void urungetir()
            
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from urun_bilgi where urun_kod='" + textBox1.Text + "'", conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                textBox2.Text = reader["urun_no"].ToString();
                textBox3.Text = reader["urun_kod"].ToString();
                comboBox1.Text = reader["kategori"].ToString();                
                textBox4.Text = reader["urun_ad"].ToString();
                textBox5.Text = reader["urun_fiyat"].ToString();
            }
            conn.Close();

        }
        private void urun_ara_Click(object sender, EventArgs e)
        {
            urungetir();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("update urun_bilgi set urun_kod='" + textBox3.Text.ToString() + "',kategori='" + comboBox1.Text.ToString() + "',urun_ad='" + textBox4.Text.ToString() + "',urun_fiyat='" + textBox5.Text.ToString() + "'where urun_no=" + textBox2.Text + "", conn);
            comm.ExecuteNonQuery();
            MessageBox.Show("Ürün başarıyla güncellendi!","Başarılı",MessageBoxButtons.OK,MessageBoxIcon.Information);
            conn.Close();

        }

        private void ClearAll(Control ctl)
        {
            foreach (Control c in ctl.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }
                if (c.Controls.Count > 0)
                {
                    ClearAll(c);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearAll(this);
            comboBox1.Text = "";
        }

        private void guncelle_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from kategoriler", conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader["kategori"].ToString());
            }
            conn.Close();

        }
    }
}
