using System.Collections;
using System.IO;

namespace Library
{
    class Kategori
    {
        public static ArrayList kategoriAdi = new ArrayList();
        public Kategori()
        {
            SetKategoriAdi();
        }
        void SetKategoriAdi()
        {
            foreach (string item in Program.dir)
            {
                kategoriAdi.Add(item.Substring(item.LastIndexOf('\\') + 1));
            }
        }
    }
}
