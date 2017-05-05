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
        public ArrayList yazarAdi = new ArrayList();
        public ArrayList kategori = new ArrayList();
        Kitaplik lib = new Kitaplik();
        public Kitap()
        {
            SetKitapAdi();
        }
        void SetKitapAdi()
        {
            ArrayList dir = new ArrayList();
            ArrayList dirname = new ArrayList();
            for (int i = 0; i < lib.kategori.Length; i++)
            {
                string[] tempdir = Directory.GetFiles(@"..\DB\Library\" + lib.kategori[i] + @"\");
                foreach (string item in tempdir)
                {
                    dir.Add(item);
                }
            }
            for (int i = 0; i < dir.Count; i++)
            {
                string[] kitap = File.ReadLines(dir[i].ToString()).Take(2).ToArray(); // ilk satırı oku ve çık
                kitapAdi.Add(kitap[0].Trim());               
                yazarAdi.Add(kitap[1].Trim());
                kategori.Add(Path.GetDirectoryName(dir[i].ToString()).Substring(Path.GetDirectoryName(dir[i].ToString()).LastIndexOf('\\') + 1));
            }
        }
    }
}
