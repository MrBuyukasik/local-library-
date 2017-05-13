using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryOOP
{
    public partial class Main : Form
    {
        Kitaplik kitaplik;
        public Main()
        {
            InitializeComponent();
            kitaplik = new Kitaplik();
            SubKategori();
            Doldur();
            toolStripComboBox1.SelectedIndex = 3;
        }
        void SetStatus(int gelen)
        {
            toolStripStatusLabel1.Text = gelen.ToString() + " satır getirildi.";
        }
        //SubKAtegori Start
        void SubKategori()
        {
            kitapEkleToolStripMenuItem.DropDownItems.Clear();
            kitaplik.kategori.Sort();
            foreach (string kategori in kitaplik.kategori)
            {
                ToolStripItem subItem = new ToolStripMenuItem(kategori);
                subItem.Click += new EventHandler(MenuClicked);
                kitapEkleToolStripMenuItem.DropDownItems.Add(subItem);
            }
        }
        private void MenuClicked(object sender, EventArgs e)
        {
            string ad = ((ToolStripMenuItem)sender).Text;
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = @"..\Database\Kitaplar\";
            ofd.Filter = "Text Dosyası (*.txt)|*.txt";
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int index = ofd.FileName.LastIndexOf('\\') + 1;
                    string dosyaAdi = ofd.FileName.Substring(index,ofd.FileName.Length-4-index);
                    string kaynak = ofd.FileName;
                    string hedef = @"..\Database\Kitaplar\" + ad + "\\" + dosyaAdi + ".txt";
                    File.Copy(kaynak,hedef);
                    kitaplik.KitapEkle(ad,dosyaAdi,hedef);
                    Doldur();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hata: "+ex.ToString(),"Bir Şeyler Ters Gitti!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }
        //SubKAtegori END
        void Doldur()
        {
            dataGridView1.Rows.Clear();
            foreach(var item in kitaplik.kitapListe)
            {
                foreach (var item2 in item.detayListe)
                {
                    dataGridView1.Rows.Add(1);
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = item2.KitapAdi;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = item2.YazarAdi;
                    dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = item2.KategoriAdi;
                }
            }
            SetStatus(dataGridView1.Rows.Count - 1);
        }

        private void toolStripTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int tercih = toolStripComboBox1.SelectedIndex;
            string ara = toolStripTextBox1.Text;
            Doldur();
            if (e.KeyCode == Keys.Enter)
            {
                switch (tercih)
                {
                    case 0:
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[2].Value.ToString() != ara)
                            {
                                dataGridView1.Rows.RemoveAt(i);
                                i--;
                            }                            
                        }
                        SetStatus(dataGridView1.Rows.Count-1);
                        break;
                    case 1:
                        for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[1].Value.ToString() != ara)
                            {
                                dataGridView1.Rows.RemoveAt(i);
                                i--;
                            }
                        }
                        SetStatus(dataGridView1.Rows.Count - 1);
                        break;
                    case 2:
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            if (dataGridView1.Rows[i].Cells[0].Value.ToString() != ara)
                            {
                                dataGridView1.Rows.RemoveAt(i);
                                i--;
                            }
                        }
                        SetStatus(dataGridView1.Rows.Count - 1);
                        break;
                    case 3:
                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            bool flag = false;
                            for (int j = 0; j < dataGridView1.ColumnCount; j++)
                            {
                                if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(ara))
                                {
                                    flag = true;
                                }
                            }
                            if (!flag)
                            {
                                dataGridView1.Rows.RemoveAt(i);
                                i--;
                            }
                        }
                        SetStatus(dataGridView1.Rows.Count - 1);
                        break;
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Selected = true;

        }

        // Sağ Click Başlangıç
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu menu = new ContextMenu();
                menu.MenuItems.Add("Aç", new EventHandler(ac_click));
                menu.MenuItems.Add("Yeniden Adlandır", new EventHandler(yad_click));
                menu.MenuItems.Add("Sil", new EventHandler(sil_click));

                int currentMouseOverRow = dataGridView1.HitTest(e.X, e.Y).RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[currentMouseOverRow].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[currentMouseOverRow].Cells[0];

                menu.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }

        private void ac_click(object sender, EventArgs e)
        {
            try
            {
                string tempkitadi = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                string tempkatadi = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                string temppath = @"..\Database\Kitaplar\" + tempkatadi + @"\" + tempkitadi + ".txt";
                Process.Start(temppath);
            }
            catch (Exception)
            {
                MessageBox.Show("Bir hatayla karşılaşıldı.","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void yad_click(object sender, EventArgs e)
        {
            PopupTB re = new PopupTB();
            re.ShowDialog();
            string ad = re.Ad;
            try
            {
                string tempkitadi = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                string tempkatadi = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                string temppath = @"..\Database\Kitaplar\" + tempkatadi + @"\" + tempkitadi + ".txt";
                string newPath = @"..\Database\Kitaplar\" + tempkatadi + @"\" + ad + ".txt";
                File.Move(temppath,newPath); // dosya adını değiştirdik

                for (int i = 0; i < kitaplik.kitapListe.Count; i++)
                {
                    for (int j = 0; j < kitaplik.kitapListe[i].detayListe.Count; j++)
                    {
                        if (tempkitadi == kitaplik.kitapListe[i].detayListe[j].KitapAdi && tempkatadi == kitaplik.kitapListe[i].detayListe[j].KategoriAdi)
                        {
                            kitaplik.kitapListe[i].dir = @"..\Database\Kitaplar\" + tempkatadi + @"\" + ad + ".txt";
                            Kitap.Detay detay = new Kitap.Detay();
                            detay = kitaplik.kitapListe[i].detayListe[j];
                            detay.KitapAdi = ad;
                            kitaplik.kitapListe[i].detayListe[j] = detay;
                        }
                    }
                }
                dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value = ad;
                string[] lines = File.ReadAllLines(newPath);
                lines[0] = ad;
                File.WriteAllLines(newPath, lines);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString(), "Bir Şeyler Ters Gitti!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void sil_click(object sender, EventArgs e)
        {            
            try
            {
                string kitadi = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString();
                string yazadi = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[1].Value.ToString();
                string katadi = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value.ToString();
                for (int i = 0; i < kitaplik.kitapListe.Count; i++)
                {
                    for (int j = 0; j < kitaplik.kitapListe[i].detayListe.Count; j++)
                    {
                        if (kitaplik.kitapListe[i].detayListe[j].KitapAdi == kitadi && kitaplik.kitapListe[i].detayListe[j].YazarAdi == yazadi && kitaplik.kitapListe[i].detayListe[j].KategoriAdi == katadi)
                        {
                            File.Delete(kitaplik.kitapListe[i].dir);
                            kitaplik.kitapListe.Remove(kitaplik.kitapListe[i]);
                            break;
                        }
                    }
                }
                Doldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: "+ex.ToString(), "Bir Şeyler Ters Gitti!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
        // Sağ Click Bitiş
        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PopupTB tb = new PopupTB();
            tb.ShowDialog();
            kitaplik.KategoriEkle(tb.Ad);
            SubKategori();
        }
    }
}
