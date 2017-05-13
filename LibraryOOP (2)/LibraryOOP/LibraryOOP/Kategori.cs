using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace LibraryOOP
{
    class Kategori : Dir
    {
        public List<string> kategori = new List<string>();
        public Kategori()
        {
            SetKategori();
        }
        void SetKategori()
        {
            foreach (string item in dirs)
            {
                string temp = item.Substring(item.LastIndexOf('\\') + 1);
                if (!kategori.Contains(temp)) kategori.Add(item.Substring(item.LastIndexOf('\\') + 1));
            }
        }
        public void KategoriEkle(string ad)
        {
            if (!kategori.Contains(ad))
            {
                kategori.Add(ad);
                Directory.CreateDirectory(@"..\Database\Kitaplar\" + ad);
            }
            else
            {
                MessageBox.Show("Eklemek istediğiniz kategori zaten var.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
