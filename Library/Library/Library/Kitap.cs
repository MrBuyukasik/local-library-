using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Library
{
    class Kitap
    {
        public ArrayList kitapAdi = new ArrayList();
        public ArrayList yazarNo = new ArrayList();
        public ArrayList kategoriNo = new ArrayList();
        public static DataGridView x;
        Yazar yaz = new Yazar();
        public Kitap()
        {
            Set();
        }
        public void Set()
        {
            for (int i = 0; i < Program.bookDir.Count; i++)
            {
                // Kitap
                string temp = File.ReadLines(Program.bookDir[i].ToString()).First();
                kitapAdi.Add(temp);
                // Yazar NO
                string tempYazar = File.ReadLines(Program.bookDir[i].ToString()).Skip(1).Take(1).First();
                for (int j = 0; j < yaz.yazarAdi.Count; j++)
                {
                    if (tempYazar == yaz.yazarAdi[j].ToString())
                    {
                        yazarNo.Add(j);
                    }
                }
                // Kategori no
                string tempPath = Path.GetDirectoryName(Program.bookDir[i].ToString());
                string tempKategori = tempPath.Substring(tempPath.LastIndexOf('\\') + 1);
                for (int j = 0; j < Kategori.kategoriAdi.Count; j++)
                {
                    if (tempKategori == Kategori.kategoriAdi[j].ToString())
                    {
                        kategoriNo.Add(j);
                    }
                }
            }
        }
        public void KitapEkle(string kategori)
        {
            OpenFileDialog of = new OpenFileDialog();
            of.InitialDirectory = "C:\\";
            of.Filter = "Text Dosyası (*.txt)|*.txt";
            if (of.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int index = of.FileName.LastIndexOf('\\');
                    string fileName = of.FileName.Substring(index + 1);
                    string source = of.FileName;
                    string target = @"..\DB\Library\" + kategori + "\\" + fileName;
                    File.Copy(source, target);
                    string[] temp = File.ReadAllLines(target).Take(2).ToArray();
                    kitapAdi.Add(temp[0]);
                    bool flag = true;
                    foreach (string item in yaz.yazarAdi)
                        if (item == temp[1])
                            flag = false;
                    if (flag)
                        yaz.yazarAdi.Add(temp[1]);
                    for (int j = 0; j < yaz.yazarAdi.Count; j++)
                    {
                        if (temp[1] == yaz.yazarAdi[j].ToString())
                        {
                            yazarNo.Add(j);
                        }
                    }
                    string tempPath = Path.GetDirectoryName(target);
                    string tempKategori = tempPath.Substring(tempPath.LastIndexOf('\\') + 1);
                    for (int j = 0; j < Kategori.kategoriAdi.Count; j++) // KAtegori
                    {
                        if (tempKategori == Kategori.kategoriAdi[j].ToString())
                        {
                            kategoriNo.Add(j);
                        }
                    }
                    Kitaplik k = new Kitaplik();
                    Program.bookDir.Add(target);
                    k.yazarAdi.Add(yaz.yazarAdi[Convert.ToInt32(yazarNo[yazarNo.Count - 1])]);
                    k.KategoriAdi.Add(Kategori.kategoriAdi[Convert.ToInt32(kategoriNo[kategoriNo.Count -1])]);
                    x.Rows.Add(1);
                    x.Rows[x.Rows.Count - 2].Cells[0].Value = kitapAdi[kitapAdi.Count -1];
                    x.Rows[x.Rows.Count - 2].Cells[1].Value = k.yazarAdi[k.yazarAdi.Count - 1];
                    x.Rows[x.Rows.Count - 2].Cells[2].Value = k.KategoriAdi[k.KategoriAdi.Count -1];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Bir Hatayla Karşılaşıldı.", MessageBoxButtons.OK);
                }
            }
        }
    }
}
