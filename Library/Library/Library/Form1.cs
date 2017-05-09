using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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
            for (int i = 0; i < kit.kitapAdi.Count; i++)
            {
                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = kit.kitapAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = kitp.yazarAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = kitp.KategoriAdi[i];
            }
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
            for (int i = 0; i < kit.kitapAdi.Count; i++)
            {

                dataGridView1.Rows.Add(1);
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[0].Value = kit.kitapAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[1].Value = kitp.yazarAdi[i];
                dataGridView1.Rows[dataGridView1.Rows.Count - 2].Cells[2].Value = kitp.KategoriAdi[i];
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
            string search = textBox7.Text;
            List<int> indis = new List<int>();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                bool flag = false;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value.ToString().Contains(search))
                        flag = true;
                }
                if (!flag)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                    i--;
                }
            }
        }


        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            string[] tempKat = textBox4.Text.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            ArrayList tempi = new ArrayList();
            for (int i = 0; i < tempKat.Length; i++)
                for (int j = 0; j < dataGridView1.Rows.Count - 1; j++)
                    if (i == 0)
                    {
                        if (dataGridView1.Rows[j].Cells[2].Value.ToString() != tempKat[i].Trim())
                        {
                            tempi.Add(dataGridView1.Rows[j].Index);
                        }
                    }
                    else
                    {
                        if (dataGridView1.Rows[j].Cells[2].Value.ToString() == tempKat[i].Trim())
                        {
                            for (int k = 0; k < tempi.Count; k++)
                            {
                                if (Convert.ToInt32(tempi[k]) != dataGridView1.Rows[j].Index)
                                {
                                    tempi.Remove(dataGridView1.Rows[j].Index);
                                }
                            }
                        }
                    }
            for (int i = 0; i < tempi.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(Convert.ToInt32(tempi[i]) - i);
            }
        }

        private void btnYazar_Click(object sender, EventArgs e)
        {
            string searchValue = textBox2.Text;
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if ((String)dataGridView1.Rows[i].Cells[1].Value != String.Empty)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() != searchValue)
                    {

                        dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                        if (i != -1)
                        {
                            i--;
                        }
                    }

                }
            }           
        }

        private void btnKitap_Click(object sender, EventArgs e)
        {
            string search = textBox6.Text;
            List<int> indis = new List<int>();
            for (int i = 0; i < dataGridView1.Rows.Count-1; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() != search)
                {
                    indis.Add(dataGridView1.Rows[i].Index);
                }
            }
            for (int i = 0; i < indis.Count; i++)
            {
                dataGridView1.Rows.RemoveAt(indis[i] - i);
            }
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
                dataGridView1.CurrentCell = dataGridView1.Rows[currentMouseOverRow].Cells[0]; // şu kod

                m.Show(dataGridView1, new Point(e.X, e.Y));
            }
        }
        private void sil_click(object sender, EventArgs e)
        {          
            try
            {
                File.Delete(Program.path+dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value+'\\'+ dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value+".txt");
                int index = kit.kitapAdi.IndexOf(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                kit.kategoriNo.RemoveAt(index);
                kit.yazarNo.RemoveAt(index);
                kitp.kitapAdi.RemoveAt(index);
                kitp.kategoriNo.RemoveAt(index);
                kitp.yazarNo.RemoveAt(index);
                kitp.KategoriAdi.RemoveAt(index);
                kitp.yazarAdi.RemoveAt(index);
                kit.kitapAdi.Remove(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value);
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentCell.RowIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Bir Hatayla Karşılaşıldı!!!",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }            
        }
        
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
          
        }
        
        // Arama - END
    }
}
