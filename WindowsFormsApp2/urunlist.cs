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
    public partial class urunlist : Form
    {
        public urunlist()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-SLG0ND9;Initial Catalog=urunler;Integrated Security=True");
        
        void verigoster()
        {
            
            conn.Open();
            SqlCommand comm = new SqlCommand("select * from urun_bilgi", conn);
            SqlDataReader reader = comm.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = reader["urun_no"].ToString();
                ekle.SubItems.Add(reader["urun_kod"].ToString());
                ekle.SubItems.Add(reader["urun_ad"].ToString());
                ekle.SubItems.Add(reader["kategori"].ToString());
                ekle.SubItems.Add(reader["urun_fiyat"].ToString());
                listView1.Items.Add(ekle);
            }
            conn.Close();
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

        private void urun_ekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Ekleme Ekranı", "ÜRÜN EKLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ekle ekle = new ekle();
            ekle.Show();
            this.Hide();
        }

        private void urun_gunc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Güncelleme Ekranı", "ÜRÜN GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guncelle guncelle = new guncelle();
            guncelle.Show();
            this.Hide();
        }

        private void urun_sil_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Silme Ekranı", "ÜRÜN SİL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sil sil = new sil();
            sil.Show();
            this.Hide();
        }

        private void urunlist_Load(object sender, EventArgs e)
        {
            verigoster();
        }
    }
}
