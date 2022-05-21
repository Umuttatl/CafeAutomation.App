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
    public partial class ekle : Form
    {
        public ekle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLG0ND9;Initial Catalog=urunler;Integrated Security=True");
        private void label3_Click(object sender, EventArgs e)
        {

        }

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

        private void urun_sil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Silme Ekranı", "ÜRÜN SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sil sil = new sil();
            sil.Show();
            this.Hide();
        }

        private void urun_gunc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Güncelleme Ekranı", "ÜRÜN GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guncelle guncelle = new guncelle();
            guncelle.Show();
            this.Hide();
        }

        private void urunler_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Listeleme Ekranı", "ÜRÜNLER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            urunlist urunlist = new urunlist();
            urunlist.Show();
            this.Hide();
        }

        private void urun_kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLG0ND9;Initial Catalog=urunler;Integrated Security=True");
            SqlCommand comm = new SqlCommand("Select count(*) from urun_bilgi where urun_no='" + urun_no.Text+ "'", conn);
            conn.Open();
            int sonuc = (int)comm.ExecuteScalar(); 
            if (sonuc ==0)
            {
                //ürün ekleme
                SqlCommand komut = new SqlCommand("insert into urun_bilgi(urun_no,urun_kod,urun_ad,kategori,urun_fiyat) Values ('" + urun_no.Text.ToString() + "','" + urun_kodu.Text.ToString() + "','" + urun_adi.Text.ToString() + "','" + kategori.Text.ToString() + "','" + urun_fiyat.Text.ToString() + "')", conn);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ürün başarıyla eklendi!","Başarılı",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (sonuc>0)
            {
                MessageBox.Show("Bu ürün zaten kayıtlı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                urun_no.Focus();
            }
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
        private void button1_Click(object sender, EventArgs e)
        {
            ClearAll(this);
            kategori.Text = "";
            
        }

        private void ekle_Load(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from kategoriler", conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                kategori.Items.Add(reader["kategori"].ToString());
            }
            conn.Close();
        }
    }
}
