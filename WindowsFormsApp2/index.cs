using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
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

        private void urun_gunc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ürün Güncelleme Ekranı", "ÜRÜN GÜNCELLE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            guncelle guncelle = new guncelle();
            guncelle.Show();
            this.Hide();
        }

        private void satis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Satış", "SATIŞ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            satis satis = new satis();
            satis.Show();
            this.Hide();
        }

        private void personel_yon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Personel Yönetimi", "PERSONEL", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personel personel = new personel();
            personel.Show();
            this.Hide();
        }

        private void index_Load(object sender, EventArgs e)
        {

        }
    }
}
