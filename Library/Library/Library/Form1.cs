using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    public partial class Form1 : Form
    {
        Kategori kat;
        Yazar yaz;
        Kitap kit;
        Kitaplik kitp;
        public Form1()
        {
            InitializeComponent();
            kat = new Kategori();
            yaz = new Yazar();
            kit = new Kitap();
            kitp = new Kitaplik();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < kit.kitapAdi.Count; i++)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = kitp.kitapAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = kitp.yazarAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = kitp.KategoriAdi[i];
            }
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
        }

        // Arama - START
        private void rb_CheckedChanged(object sender, EventArgs e)
        {
            foreach (RadioButton c in groupBox1.Controls.OfType<RadioButton>())
            {
                if (((RadioButton)c).Checked == true)
                {
                    Degistir("pnl"+((RadioButton)c).Name.Substring(2));
                }
            }

        }

        void Degistir(string gelen)
        {
            foreach (Panel p in groupBox1.Controls.OfType<Panel>())
            {
                if (((Panel)p).Name == gelen)
                {
                    ((Panel)p).Enabled = true;
                    ((Panel)p).Location = new Point(195,20);
                }
                else
                {
                    ((Panel)p).Enabled = false;
                    ((Panel)p).Location = new Point(7,132);
                }
            }
        }

        private void btnKitaplik_Click(object sender, EventArgs e)
        {

        }

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            
        }

        private void btnYazar_Click(object sender, EventArgs e)
        {

        }

        private void btnKitap_Click(object sender, EventArgs e)
        {

        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            Form3 kategoriEkle = new Form3();
            kategoriEkle.Show();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        // Arama - END
    }
}
