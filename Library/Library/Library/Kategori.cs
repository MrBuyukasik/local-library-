using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Kategori
    {
        ArrayList kategoriAdi = new ArrayList();
        public Kategori()
        {
            SetKategoriAdi();
        }
        void SetKategoriAdi()
        {
            string path = @"..\DB\Library\"; //Dogan baba boynumuza dola
            string[] dir = Directory.GetDirectories(path);
            foreach (string item in dir)
            {
                kategoriAdi.Add(item.Substring(item.LastIndexOf('\\') + 1));
            }
        }
    }
}
