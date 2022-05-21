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
    public partial class satis : Form
    {
        public satis()
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

        private void index_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ana Sayfa", "ANA SAYFA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            index index = new index();
            index.Show();
            this.Hide();
        }

        private void btn_salon1_Click(object sender, EventArgs e)
        {
            salon1 salon1 = new salon1();
            salon1.Show();
            this.Hide();
        }
    }
}
