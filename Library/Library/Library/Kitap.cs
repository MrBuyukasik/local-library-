using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Kitap
    {
        public ArrayList kitapAdi = new ArrayList();
        public ArrayList yazarNo = new ArrayList();
        public ArrayList kategoriNo = new ArrayList();
        public Kitap()
        {
            SET();
        }
        void SET()
        {
            for (int i = 0; i < Program.bookDir.Count; i++)
            {
                // Kitap
                string temp = File.ReadLines(Program.bookDir[i].ToString()).First();
                kitapAdi.Add(temp);
                // Yazar NO
                string tempYazar = File.ReadLines(Program.bookDir[i].ToString()).Skip(1).Take(1).First();
                for (int j = 0; j < Yazar.yazarAdi.Count; j++)
                {
                    if (tempYazar == Yazar.yazarAdi[j].ToString())
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
    }
}
