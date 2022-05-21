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
    public partial class giris : Form
    {
        public giris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void log_in_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="admin"&& textBox2.Text=="admin")
            {
                MessageBox.Show("Giriş Başarılı", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                index index = new index();
                index.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        private void giris_Load(object sender, EventArgs e)
        {

        }
    }
}
