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
            Yenile();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            Kitap.x = dataGridView1;       
            frm.Show();
        }
        public void Yenile()
        {
            dataGridView1.Rows.Clear();
            for (int i = 0; i < Kitap.kitapAdi.Count; i++)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = Kitap.kitapAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = Kitaplik.yazarAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = Kitaplik.KategoriAdi[i];
            }
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

        private void button4_Click(object sender, EventArgs e)
        {
            Yenile();
        }
        

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu m = new ContextMenu();
                m.MenuItems.Add(new MenuItem("Sil", new EventHandler(sil_click)));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[currentMouseOverRow].Selected = true;

                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }
        private void sil_click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                if (item.Selected == true)
                {
                    dataGridView1.Rows.Remove(item);
                }
            }
        }
        // Arama - END
    }
}
